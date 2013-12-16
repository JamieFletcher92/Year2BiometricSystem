/*---THIS IS THE CODE USED FOR THE ATHLETE PERFORMANCE MONITORING SYSTEM, THIS PROGRAM IS USED IN ORDER
TO MONITOR THE TEMPERATURE, GALVANIC SKIN RESPONSE AND PULSE OF AN ATHLETE WHILST THEY ARE EXCERSISING
AND PROVIDE REAL TIME DATA ALLOWING FOR ANY DROPS IN PERFORMANCE TO BE NOTICED---*/

//---THIS IS CODE WRITTEN BY JAMES FLETCHER (11033350)---

//---NAMESPACES FOR USE WITHIN THIS FORM---
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace Temperature_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        //---VARIABLES FOR USE WITHIN THIS FORM---
        private int pointIndex = 0;

        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int Option = 0;

        double gsrAve = 0;
        double tempAve = 0;
        double hrAve = 0;

        //---LISTS USED TO FIND AVERAGES OF TAKEN DATA LATE IN PROGRAM---
        List<double> dataList = new List<double>();
        List<double> dataList2 = new List<double>();
        List<double> dataList3 = new List<double>();

        //---NEW XMLDOCUMENT VARIABLE TO LOAD AND SAVE RECORDS FILE LATER---
        XmlDocument addDoc = new XmlDocument();

        //---METHOD EXECUTED WHEN FORM IS LOADED---
        private void Form1_Load(object sender, EventArgs e)
        {
            //---CHANGING PROPERTIES OF TEMPERATURE CHART FOR DISPLAY PURPOSES---
            tempChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            tempChart.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
            tempChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            tempChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

            //---CHANGING PROPERTIES OF HEART RATE CHART FOR DISPLAY PURPOSES---
            HRChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            HRChart.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
            HRChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            HRChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

            //---CHANGING PROPERTIES OF GSR CHART FOR DISPLAY PURPOSES---
            GSRChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            GSRChart.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
            GSRChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            GSRChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
        }

        //---METHOD EXECUTED WHEN THE USER CLICKS THE "PLOT" BUTTON, USED TO PLOT THE TEMPERATURE ALONE---
        private void btnPlot_Click(object sender, EventArgs e)
        {
            //---DISABLING AND ENABLIND APPROPIATE BUTTONS---
            btn_All.Enabled = false;
            btnSwitchGSR.Enabled = false;
            btnSwitchHR.Enabled = false;
            btnSwitchTemp.Enabled = false;
            btnStop.Enabled = true;

            //---ENABLING THE TIMER "TIMER1"---
            timer1.Enabled = true;

            //---OPENING SERIAL PORT---
            serialPort1.Open();

            //---SENDING THE VALUE "1" DOWN THE SERIAL PORT TO THE ARDUINO DEVICE---
            Option = 1;
            serialPort1.Write(Option.ToString());
        }

        //---METHOD EXECUTED WHEN THE USER WISHES TO PLOT THE GSR ALONE---
        private void btnSwitchGSR_Click(object sender, EventArgs e)
        {
            //---DISABLING AND ENABLING THE CORRECT BUTTONS THAT CAN NOW BE PRESSED BY THE USER---
            btn_All.Enabled = false;
            btnSwitchGSR.Enabled = false;
            btnSwitchHR.Enabled = false;
            btnSwitchTemp.Enabled = false;
            btnStop.Enabled = true;
            
            //---ENABLING THE TIMER "TIMER2"---
            timer2.Enabled = true;

            //---OPENING THE SERIAL PORT---
            serialPort1.Open();

            //---SENDING THE VARIABLE OPTION WHICH IS NOW "2" DOWN THE SERIAL PORT---
            Option = 2;
            serialPort1.Write(Option.ToString());
        }

        //---METHOD EXECUTED WHEN THE USER WISHES TO PLOT THE HEART RATE ALONE---
        private void btnSwitchHR_Click(object sender, EventArgs e)
        {
            //---ENABLING AND DISABLING CORRECT BUTTONS---
            btn_All.Enabled = false;
            btnSwitchGSR.Enabled = false;
            btnSwitchHR.Enabled = false;
            btnSwitchTemp.Enabled = false;
            btnStop.Enabled = true;

            //---STARTING "TIMER3"'S TICK---
            timer3.Enabled = true;

            //---SERIAL PORT BEING OPENING SO DATA CAN BE READ INTO PROGRAM---
            serialPort1.Open();

            //---SENDING OPTION "3" DOWN THE SERIAL PORT---
            Option = 3;
            serialPort1.Write(Option.ToString());
        }

        //---METHOD EXECUTED WHEN THE USER PRESSES THE "ALL" BUTTON---
        private void btn_All_Click(object sender, EventArgs e)
        {
            //---DISABLING ALL OTHER BUTTONS APART FROM "STOP" TO PREVENT ERRORS CAUSED WHEN PRESSED---
            btn_All.Enabled = false;
            btnSwitchGSR.Enabled = false;
            btnSwitchHR.Enabled = false;
            btnSwitchTemp.Enabled = false;
            btnStop.Enabled = true;

            //---STARTING TIMER1---
            timer1.Enabled = true;

            //---OPENING SERIALPORT1 IN ORDER TO RECEIVE DATA FROM ARDUINO DEVICE---
            serialPort1.Open();

            //---ASSINGING THE VARIABLE "OPTION" AS 4 AND SENDING THIS DOWN THE SERIALPORT TO THE ARDUINO---
            Option = 4;
            serialPort1.Write(Option.ToString());
        }

        //---METHOD EXECUTED WHEN THE USER PRESSES THE "STOP" BUTTON---
        private void btnStop_Click(object sender, EventArgs e)
        {
            //---DISABLING ALL 3 TIMERS---
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;

            //---ENABLING ALL OTHER BUTTONS APART FROM STOP, AS THESE CAN NOW BE PRESSED WITHOUT CAUSING ERRORS---
            btn_All.Enabled = true;
            btnSwitchGSR.Enabled = true;
            btnSwitchHR.Enabled = true;
            btnSwitchTemp.Enabled = true;
            btnStop.Enabled = false;

            //---CLEARING THE DATALISTS---
            dataList.Clear();
            dataList2.Clear();
            dataList3.Clear();

            //---SENDING "5" DOWN THE SERIAL PORT, THIS WILL TRIGGER THE ARDUINOS CODE TO STOP TAKING IN DATA---
            Option = 5;
            serialPort1.Write(Option.ToString());

            //---CLOSING THE SERIALPORT---
            serialPort1.Close();
        }

        //---CODE HERE IS EXECUTED WHEN TIMER1 TICKS, THE TIME LABEL ON THE AXIS OF THE TEMPERATURE CHART IS BEING UPDATED HERE---
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //---ADDINING 1 TO "COUNT1" AND DISPLAYING THIS VARIABLE TO THE USER WITH THE USE OF THE LABEL---
            count1 = count1 + 1;
            lblTime1.Text = count1.ToString();           
        }

        //---METHOD EXECUTED ON TIMER2 TICKS (EVERY SECOND, WHEN ENABLED)---
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            //COUNTING THE SECONDS SINCE ENABLED AND DISPLAYING TO USER UNDER THE GSR CHART---
            count2 = count2 + 1;
            lblTime2.Text = count2.ToString();
        }

        //---METHOD EXECUTED ON TIMER3 TICK---
        private void timer3_Tick_1(object sender, EventArgs e)
        {
            //---COUNTING SECONDS AND DISPLAYING TO USER UNDER THE HEART RATE CHART---
            count3 = count3 + 1;
            lblTime3.Text = count3.ToString();
        }

        //---THE CODE WITHIN THIS METHOD IS EXECUTED WHENEVER DATA IS RECEIVED FROM THE SERIAL PORT---
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //---IF THE CURRENT VALUE OF "OPTION" IS 1---
            if (Option == 1)
            {
                //---TRY AND EXECUTE THE CODE WITHIN THESE BRACKETS---
                try
                {
                    //---CONVERT THE RECEIVED DATA TO A DOUBLE AND ASSIGN TO VARIABLE "READIN"---
                    double readIn = Convert.ToDouble(serialPort1.ReadLine());

                    //---ADDING THE RECEIVED DATA TO THE TEMPERATURE CHART---
                    tempChart.Series["tempSeries"].Points.Add(readIn);

                    //---ADDING THE RECEIVED DATA TO THE LIST "DATALIST"---
                    dataList.Add(readIn);

                    //---DISPLAYING THE RECEIVED DATA TO THE USER ON THE TEMPERATURE CHART AXIS LABEL---
                    lblTemp1.Text = Math.Round(readIn, 2).ToString();

                    //USING "DATALIST" TO CALCULATE THE CURRENT AVERAGE OF TEMPERATURE DATA AND DISPLAYING THIS TO THE USER---
                    tempAve = dataList.Sum() / dataList.Count();
                    lblAve1.Text = Math.Round(tempAve, 2).ToString();
                    
                    //---IF THE SERIAL PORT IS SENDING BLANK OR NO DATA, CLOSE THE SERIAL PORT, STOPS ERRORS OCCURING---
                    if (serialPort1.ReadLine() == null)
                    {
                        serialPort1.Close();
                    }
                }

                //---IF THE PREVIOUS CODE COULDN'T BE EXECUTED, CATCH THE EXCEPTION AND CLOSE THE SERIAL PORT, STOPS THE PROGRAM CRASHING---
                catch (System.IO.IOException)
                {
                    serialPort1.Close();
                }
            }

            //---IF THE CURRENT VALUE OF "OPTION" IS 2, EXECUTE THE FOLLOWING CODE--- 
            else if (Option == 2)
            {
                //---TRY AND EXECUTE THE FOLLOWING CODE---
                try
                {
                    //---CONVERING THE DATA RECEIVED INTO A DOUBLE---
                    double readIn = Convert.ToDouble(serialPort1.ReadLine());

                    //---PLOTTING THE DATA ON THE CHART---
                    GSRChart.Series["GSRSeries"].Points.Add(readIn);

                    //---ADDING DATA TO THE DATALIST FOR THE GSR DATA---
                    dataList2.Add(readIn);

                    //---DISPLAYING THE RECEIVED DATA, TO 2 DECIMAL PLACES, TO THE USER---
                    lblTemp2.Text = Math.Round(readIn, 2).ToString();

                    //---WORKING OUT THE CURRENT AVERAGE AND DISPLAYING THIS TO THE USER---
                    gsrAve = dataList2.Sum() / dataList2.Count();
                    lblAve2.Text = Math.Round(gsrAve, 2).ToString();

                    //---IF THERE IS NO DATA BEING RECEIVED FROM THE SERIAL PORT, CLOSE THE SERIAL PORT---
                    if (serialPort1.ReadLine() == null)
                    {
                        serialPort1.Close();
                    }
                }

                //---IF THERE IS AN ERROR, CLOSE THE SERIAL PORT---
                catch (System.IO.IOException)
                {
                    serialPort1.Close();
                }
            }

            //---IF THE CURRENT VALUE OF OPTION IS 3---
            else if (Option == 3)
            {
                //---ATTEMPT TO EXECUTE THE FOLLOWING CODE---
                try
                {
                    //---CONVERT THE DATA FROM THE SERIAL PORT TO A DOUBLE---
                    double readIn = Convert.ToDouble(serialPort1.ReadLine());

                    //---PLOT THIS DATA ON THE HEART RATE CHART---
                    HRChart.Series["HRSeries"].Points.Add(readIn);

                    //---ADD THIS DATA TO THE LIST THAT HOLDS THE HEART RATE DATA---
                    dataList3.Add(readIn);

                    //---ROUND THE DATA TO 2 DECIMAL PLACES AND DISPLAY TO THE USER---
                    lblTemp3.Text = Math.Round(readIn, 2).ToString();

                    //---FIND THE AVERAGE OF THE HEART RATE DATA AND DISPLAY THIS TO THE USER---
                    hrAve = dataList3.Sum() / dataList3.Count();
                    lblAve3.Text = Math.Round(hrAve, 2).ToString();

                    //---IF THERE IS NO DATA IN THE SERIAL PORT, CLOSE THE SERIAL PORT---
                    if (serialPort1.ReadLine() == null)
                    {
                        serialPort1.Close();
                    }
                }

                //---IF THERE IS AN ERROR, CATCH THIS EXCEPTION AND CLOSE THE SERIAL PORT---
                catch (System.IO.IOException)
                {
                    serialPort1.Close();
                }

            }

            //---IF THE CURRENT VALUE OF THE OPTION VARIABLE IS 4---
            else if (Option == 4)
            {
                //---TRY AND EXECUTE THE FOLLOWING CODE---
                try
                {
                    //---CONVERT THE RECEIVED DATA TO A DOUBLE---
                    double readIn = Convert.ToDouble(serialPort1.ReadLine());

                    //---IF THE RECEIVED DATA IS LESS THAN 10000, ADDED TO DATA WITHIN ARDUINO CODE, THEN DO THE FOLLOWING---
                    if (readIn < 10000)
                    {
                        //---MINUS 1000 OFF THE RECEIVED DATA, SO THIS DATA IS NOW ITS CORRECT, ORIGIONAL, FIGURE---
                        double readIn1 = readIn - 1000;

                        //---ADD THIS TO THE TEMPERATURE CHART---
                        tempChart.Series["tempSeries"].Points.Add(readIn1);

                        //---ADD THIS TO THE TEMPERATURE DATALIST---
                        dataList.Add(readIn1);

                        //---DISPLAY THIS TO THE USER---
                        lblTemp1.Text = Convert.ToString(readIn1);

                        //---FIND THE AVERAGE AND DISPLAY THIS TO THE USER---
                        tempAve = dataList.Sum() / dataList.Count();
                        lblAve1.Text = Math.Round(tempAve, 2).ToString();
                    }

                    //---IF THE RECEIVED DATA IS BETWEEN 10000 AND 100000 (THIS IS THE GSR DATA) THEN DO THE FOLLOWING---
                    if (readIn > 10000 && readIn < 100000)
                    {
                        //---CONVERT THE DATA TO A DOUBLE---
                        double readIn2 = readIn - 10000;

                        //---PLOT THE DATA ON THE CORRECT CHART---
                        GSRChart.Series["GSRSeries"].Points.Add(readIn2);

                        //---ADD THE DATA TO THE CORRECT LIST---
                        dataList2.Add(readIn2);

                        //---SHOW THE DATA TO THE USER WITHIN THE CORRECT LABEL---
                        lblTemp2.Text = Convert.ToString(readIn2);

                        //---CALCULATE THE AVERAGE, AND DISPLAY TO THE USER---
                        gsrAve = dataList2.Sum() / dataList2.Count();
                        lblAve2.Text = Math.Round(gsrAve, 2).ToString();
                    }

                    //---IF THE DATA FROM THE SERIAL PORT IS OVER 100000 (HEART RATE DATA) THEN EXECUTE THE FOLLOWING CODE---
                    if (readIn > 100000)
                    {
                        //---CONVERT THE DATA TO A DOUBLE AND ASSIGN TO THE VARIABLE "READIN3"---
                        double readIn3 = readIn - 100000;

                        //---PLOT THE DATA ON THE HEART RATE CHART---
                        HRChart.Series["HRSeries"].Points.Add(readIn3);

                        //---ADD THE DATA TO THE HEART RATE LIST---
                        dataList3.Add(readIn3);

                        //---DISPLAY THE DATA NEXT TO THE HEART RATE CHART---
                        lblTemp3.Text = Convert.ToString(readIn3);

                        //---FIND THE AVERAGE AND DISPLAY THIS ABOVE THE HEART RATE CHART---
                        hrAve = dataList3.Sum() / dataList3.Count();
                        lblAve3.Text = Math.Round(hrAve, 2).ToString();
                    }
                }

                //---IF THERE WERE ANY EXCEPTIONS, CATCH THESE AND CLOSE THE SERIAL PORT---
                catch (System.IO.IOException)
                {
                    serialPort1.Close();
                }
            }
        }

        //---METHOD EXECUTED WHEN THE USER CLICKS THE "SAVE" BUTTON, HERE THE COLLECTED DATA IS SAVED TO THE RECORDS FILE---
        private void btnSave_Click(object sender, EventArgs e)
        {
            //---SETTING UP THE VARIABLES WITH THE DATA THE USER HAS INPUT AND COLLECTED, ALONG WITH THE CURRENT DATE AND TIME, READY TO BE SAVED INTO THE XML FILE---
            string PatientID = txtID.Text;
            string Forename = txtForename.Text;
            string Surname = txtSurname.Text;
            string Age = txtAge.Text;
            string Temperature = Math.Round(tempAve, 2).ToString();
            string Pulse = Math.Round(hrAve, 2).ToString();
            string GSResponse = Math.Round(gsrAve, 2).ToString();
            string timeNow = DateTime.Now.ToString();

            //---IF ALL OF THE USER INPUTS ARE NOT BLANK, EXECUTE THE FOLLOWING. THIS PREVENTS BLANK DATA BEING SAVED IN THE RECORDS FILE---
            if (PatientID != "" && Forename != "" && Surname != "" && Age != "")
            {
                //---LOADING THE RECORDS XML FILE INTO THE PROGRAM---
                addDoc.Load("Records.xml");

                //---SEARCHING INTO THE XML FILE INSIDE OF THE ROOT NODES---
                XmlNodeList nodeList = addDoc.SelectNodes("/records/Patient");

                //---CREATING A NEW ELEMENT CALLED "PAITENT"
                XmlElement element1 = addDoc.CreateElement("Patient");
                addDoc.DocumentElement.AppendChild(element1);

                //---CREATING A NEW NODE INSIDE HERE CALLED "DATETIME" AND SAVING THE VALUE OF "TIMENOW" INSIDE THIS NODE---
                XmlElement element2 = addDoc.CreateElement("DateTime");
                element2.InnerText = timeNow;
                element1.AppendChild(element2);

                //---CREATING A NEW TAG FOR "ID" AND SAVING THE PATIENT ID WITHIN HERE---
                element2 = addDoc.CreateElement("ID");
                element2.InnerText = PatientID;
                element1.AppendChild(element2);

                //---SAVING THE CLIENTS FORENAME WITHIN THE CORRESPONDING TAG---
                element2 = addDoc.CreateElement("Forename");
                element2.InnerText = Forename;
                element1.AppendChild(element2);

                //---SAVING THE CLIENTS SURNAME THAT THE USER HAS INPUT---
                element2 = addDoc.CreateElement("Surname");
                element2.InnerText = Surname;
                element1.AppendChild(element2);

                //---SAVING THE CLIENTS AGE WITHIN THE FILE---
                element2 = addDoc.CreateElement("Age");
                element2.InnerText = Age;
                element1.AppendChild(element2);

                //---SAVING THE AVERAGE TEMPERATURE OF THE CLIENT WITHIN THE FILE---
                element2 = addDoc.CreateElement("Temperature");
                element2.InnerText = Temperature;
                element1.AppendChild(element2);

                //---SAVING THE AVERAGE PULSE OF THE CLIENT WITHIN THE FILE---
                element2 = addDoc.CreateElement("Pulse");
                element2.InnerText = Pulse;
                element1.AppendChild(element2);

                //---SAVING THE AVERAGE GSR READING FROM THE CLIENT WITHIN THE FILE---
                element2 = addDoc.CreateElement("GSR");
                element2.InnerText = GSResponse;
                element1.AppendChild(element2);

                //---SAVING THE FILE UNDER THE NAME "RECORDS.XML"---
                addDoc.Save("Records.xml");

                //---DISPLAYING A MESSAGE BOX TELLING THE USER THAT THE CLIENTS READINGS HAVE BEEN SAVED---
                MessageBox.Show("Readings have been saved for the client " + PatientID);
            }

            //---HOWEVER, IF ANY OF THE USER INPUT TEXTBOXES WERE BLANK, ASK THE USER TO ENTER ALL THE RELEVANT DETAILS BEFORE SAVING, VIA A MESSAGEBOX---
            else
            {
                MessageBox.Show("Please enter all the client details before saving!");
            }
        }

        //---IF THE USER CLICKS THE "VIEW RECORDS" BUTTON, EXECUTE THE CODE WITHIN THIS METHOD---
        private void btnRecords_Click(object sender, EventArgs e)
        {
            //---OPENING THE RECORDS FORM VIA THE USER OF THE "THREADPROC" METHOD---
            System.Threading.Thread records = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            records.Start();
        }

        //---THIS METHOD RUNS THE "FORMRECORDS" FORM, USED TO VIEW PAST CLIENT RECORDS---
        public static void ThreadProc()
        {
            Application.Run(new FormRecords());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread records = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            records.Start();
        }
    }
}
 
    

            
        
    



