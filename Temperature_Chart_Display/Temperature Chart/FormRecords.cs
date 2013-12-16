//---NAMESPACES---
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Temperature_Chart
{
    public partial class FormRecords : Form
    {
        public FormRecords()
        {
            InitializeComponent();
        }

        //---VARIABLES FOR USE WITHIN THIS FORM---
        string PatientID, Surname, Forename, Age, Temperature, GSR, Pulse, dateTime, idInput;
        int counter = 0, arrayCounter = 0, clickCount = 0;

        //---DECLARING STRING ARRAYS THAT WILL BE NEEDED TO STORE DATA WITHIN THIS FORM---
        string[,] Records = new string[50000, 8];
        string[,] foundRecords = new string[50000, 8];

        //---DECLARING A STRING LIST USED TO HOLD THE ID NUMBERS OF CLIENTS FOUND LATER ON---
        List<string> idList = new List<string>();

        //---NEW XMLDOCUMENT INSTANCE, USED TO LOAD THE XML DOCUMENT INTO THE PROGRAM LATER ON---
        XmlDocument addDoc = new XmlDocument();

        //---METHOD EXECUTED WHEN THE FORM LOADS---
        private void FormRecords_Load(object sender, EventArgs e)
        {
            //---THE RECORDS XML FILE IS LOADED INTO THE PROGRAM---
            addDoc.Load("Records.xml");

            //---MOVING INSIDE OF THE ROOT NODES OF THE FILE---
            XmlNodeList nodeList = addDoc.SelectNodes("/records/Patient");

            //---FOR EACH NODE WITHIN THE ROOT NODES, EXECUTE THE FOLLOWING CODE---
            foreach (XmlNode xmlNode in nodeList)
            {
                //---ASSIGNING THE VALUE WITHIN THE "DATETIME" TAGS TO THE ARRAY WITHIN COLLUMN 0---
                dateTime = xmlNode["DateTime"].InnerText;
                Records[counter, 0] = dateTime;

                //---ASSIGNING THE VALUE WITHIN THE "ID" TAG TO THE 1ST COLLUMN OF THE ARRAY---
                PatientID = xmlNode["ID"].InnerText;
                Records[counter, 1] = PatientID;

                //---STORING THE "FORENAME" VALUE TO THE 2ND COLLUMN IN THE ARRAY---
                Forename = xmlNode["Forename"].InnerText;
                Records[counter, 2] = Forename;

                //---ASSIGNING THE VALUE OF THE "SURNAME" TAG TO COLLUMN 3 IN THE ARRAY---
                Surname = xmlNode["Surname"].InnerText;
                Records[counter, 3] = Surname;

                //---STORING THE VALUE WITHIN THE "AGE" TAG TO COLLUMN 4 OF THE ARRAY "RECORDS"---
                Age = xmlNode["Age"].InnerText;
                Records[counter, 4] = Age;

                //---STORING THE "TEMPERATURE" TAGS VALUE TO COLLUMN 5 OF THE ARRAY---
                Temperature = xmlNode["Temperature"].InnerText;
                Records[counter, 5] = Temperature;

                //---ASSIGNING THE VALUE WITHIN THE "PULSE" TAGS TO COLLUMN 6 OF THE ARRAY---
                Pulse = xmlNode["Pulse"].InnerText;
                Records[counter, 6] = Pulse;

                //---STORING THE VALUE FOUND WITHIN THE "GSR" TAGS TO COLLUMN 7 OF THE ARRAY---
                GSR = xmlNode["GSR"].InnerText;
                Records[counter, 7] = GSR;

                //---ADDING 1 TO THE VALUE OF COUNTER, THIS MEANS THAT THE CODE WITHIN THIS TAG WILL BE EXECUTED AGAIN, BUT THE NEW DATA WILL BE STORED IN THE NEXT ROW OF ARRAY---
                counter = counter + 1;
            }
            //---ASSIGNING VARIABLE "I" WITH VALUE OF 0, EXECUTING FOLLOWING CODE, AND ADDING 1 TO "I" UNTILL IT REACHES THE VALUE OF COUNTER--- 
            for (int i = 0; i < counter; i++)
            {
                //---ADDING THE VALUE IN COLLUMN 1 OF THE ARRAY TO THE LIST "IDLIST", SO ALL CLIENT ID'S ARE STORED IN THIS LIST---
                idList.Add(Records[i, 1]);
            }
        }

        //---METHOD EXECUTED WHENEVER THE USER CLICKS THE "VIEW" BUTTON---
        private void btnView_Click(object sender, EventArgs e)
        {
            //---MOVING INSIDE OF THE ROOT NODES OF THE FILE AGAIN---
            XmlNodeList nodeList = addDoc.SelectNodes("/records/Patient");

            //---ASSIGNING THE USER INPUT ID TO THE VARIABLE "IDINPUT"---
            idInput = txtID.Text;

            //---ENABLING BOTH "NEXT" AND "PREVIOUS" BUTTONS---
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;

            //---NEW VARIABLE "T" WITH VALUE OF 0, USED LATER ON---
            int t = 0;

            //---IF THE USER INPUT ID IS WITHIN THE LIST CONTAINING ALL THE CLIENT IDS RECORDED, EXECUTE THE FOLLOWING CODE---
            if (idList.Contains(idInput))
            {
                //---EXECUTE THIS CODE AND ADD 1 TO "I", WHILE "I" IS LESS THAN THE VALUE OF "COUNTER"---
                for (int i = 0; i < counter; i++)
                {
                    //---THE VALUE IN COLLUMN 1 OF THE ARRAY IS ASSIGNED TO "IDRECORDS"---
                    string idRecords = Records[i, 1];

                    //---IF THE VALUE OF "IDRECORDS" JUST ASSIGNED, MATCHES THE USER INPUT VALUE, DO THE FOLLOWING---
                    if (idRecords == idInput)
                    {
                        //---STORING ALL FOUND DATA FOR THIS CLIENT WITHIN THE "FOUNDRECORDS" ARRAY, TO BE DEALED WITH AND DISPLAYED TO THE USER LATER---
                        foundRecords[t, 0] = Records[i, 0];
                        foundRecords[t, 1] = Records[i, 1];
                        foundRecords[t, 2] = Records[i, 2];
                        foundRecords[t, 3] = Records[i, 3];
                        foundRecords[t, 4] = Records[i, 4];
                        foundRecords[t, 5] = Records[i, 5];
                        foundRecords[t, 6] = Records[i, 6];
                        foundRecords[t, 7] = Records[i, 7];

                        //---ADDING 1 TO THE VALUE OF "T" SO THAT THIS CODE WILL MOVE THROUGH THE ARRAY STORING ALL THE DATA FOR THE GIVEN CLIENT ID WITHIN THE ARRAY---
                        t = t + 1;
                    }
                }

                //---LET THE USER KNOW THAT THE RECORDS HAVE BEEN FOUND FOR THIS CLIENT---
                MessageBox.Show("Records have been found for client " + idInput);
            }

            //---IF THE USER INPUT CLIENT ID HAS NO RECORDED DATA FOR IT, LET THE USER KNOW AND ASK THEM TO TRY AGAIN WITH A NEW ID---
            else
            {
                MessageBox.Show("No readings were found for that client, please try again!");
            }
        }

        //---METHOD EXECUTED WHEN THE USER CLICKS THE "NEXT" BUTTON", THIS CODE SHOULD DISPLAY THE NEXT AVAILABLE DATA FOR THE GIVEN CLIENT---
        private void btnNext_Click(object sender, EventArgs e)
        {
            //---ADDING 1 TO THE VALUE OF CLICKCOUNT, USED TO SEARCH THE INDEX OF THE ARRAY---
            clickCount = clickCount + 1;

            //---ASSIGNING THE CERTAIN VALUES OF THE ARRAY TO VARIABLES, THIS IS USED TO CHECK IF THERE ARE ANY MORE RECORDS FOR THE GIVEN CLIENT ID---
            string searchedID = foundRecords[clickCount, 1];
            string nextID = foundRecords[clickCount + 1, 1];

            //---ASSIGNING THE USER INPUT ID TO THE VARIABLE "IDTOMATCH"---
            string idToMatch = txtID.Text;

            //---IF THE ID WITHIN THE ARRAY MATCHES THE ID THE USER HAS INPUT, THEN DO THE FOLLOWING---
            if (searchedID == idToMatch)
            {
                //---ASSIGNING ALL THE FOUND RECORDS AND DATA FOR THE GIVEN CLIENT ID TO THE LABELS, SO THAT THEY ARE DISPLAYED TO THE USER---
                lblDate.Text = foundRecords[clickCount, 0];
                lblID.Text = foundRecords[clickCount, 1];
                lblForename.Text = foundRecords[clickCount, 2];
                lblSurname.Text = foundRecords[clickCount, 3];
                lblAge.Text = foundRecords[clickCount, 4];
                lblTemp.Text = foundRecords[clickCount, 5];
                lblPulse.Text = foundRecords[clickCount, 6];
                lblGSR.Text = foundRecords[clickCount, 7];
            }

            //---IF THE NEXT ID IN THE ARRAY DOESN'T MATCH THE ID THE USER INPUT, DISABLE THE "NEXT" BUTTON AS THERE ARE NO MORE RECORDS TO VIEW---
            if (nextID != idToMatch)
            {
                btnNext.Enabled = false;
            }

            //---HOWEVER IS THERE ARE MORE RECORDS TO VEIW, KEEP THE "NEXT" BUTTON ENABLED---
            else if (nextID == idToMatch)
            {
                btnNext.Enabled = true;
            }

            //---IF THE VALUE OF "CLICKCOUNT" IS 0, DISABLE THE "PREVIOUS" BUTTON---
            if (clickCount == 0)
            {
                btnPrevious.Enabled = false;
            }
            //---HOWEVER, IF THE VALUE OF "CLICKCOUNT IS NOT 0, ENABLE THE "PREVIOUS" BUTTON---
            else
            {
                btnPrevious.Enabled = true;
            }

        }

        //---THIS CODE IS EXECUTED WHEN THE USER CLICKS THE "PREVIOUS" BUTTON---
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //---DECREASE THE VALUE OF "CLICKCOUNT" BY 1 AND ASSIGN THIS NEW VALUE TO "CLICKCOUNTDOWN"---
            int clickCountDown = clickCount - 1;

            //---ASSIGN THE VALUE FOUND IN THE 1ST COLLUMN OF THE ARRAY TO "SEARCHEDID"---
            string searchedID = foundRecords[clickCountDown, 1];

            //---ASSIGN THE VALUE OF THE USER INPUT TEXTBOX TO "IDTOMATCH"---
            string idToMatch = txtID.Text;

            //---ASSIGN THE VALUE OF THE NEXT ID IN THE ARRAY TO "NEXTID"---
            string nextID = foundRecords[clickCount + 1, 1];

            //---IF THE ID FOUND IN THE ARRAY MATCHES THE ID THAT THE USER HAS INPUT, THE EXECUTE THIS CODE---
            if (searchedID == idToMatch)
            {
                //---DISPLAYING THE FOUND RECORDS FOR THE USER SEARCHED ID TO THE USER VIA THE LABELS WITHIN THE FORM---
                lblDate.Text = foundRecords[clickCountDown, 0];
                lblID.Text = foundRecords[clickCountDown, 1];
                lblForename.Text = foundRecords[clickCountDown, 2];
                lblSurname.Text = foundRecords[clickCountDown, 3];
                lblAge.Text = foundRecords[clickCountDown, 4];
                lblTemp.Text = foundRecords[clickCountDown, 5];
                lblPulse.Text = foundRecords[clickCountDown, 6];
                lblGSR.Text = foundRecords[clickCountDown, 7];
            }

            //--DECREASING THE VALUE OF CLICKCOUNT BY 1---
            clickCount = clickCount - 1;

            //---IF CLICKCOUNT IS 0, DISABLE THE "PREVIOUS" BUTTON---
            if (clickCount == 0)
            {
                btnPrevious.Enabled = false;
            }

            //---OTHERWISE KEEP THIS BUTTON ENABLED---
            else
            {
                btnPrevious.Enabled = true;
            }

            //---IF THE NEXT ID WITHINT HE ARRAY DOESN'T MATCH THE ID THE USER HAS INPUT, THEN DISABLE THE "NEXT" BUTTON---
            if (nextID != idToMatch)
            {
                btnNext.Enabled = false;
            }

            //---OTHERWISE, ENABLE THE "NEXT" BUTTON---
            else if (nextID == idToMatch)
            {
                btnNext.Enabled = true;
            }
        }
    }
}

    
