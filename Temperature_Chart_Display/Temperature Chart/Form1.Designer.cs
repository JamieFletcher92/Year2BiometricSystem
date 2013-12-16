namespace Temperature_Chart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSwitchTemp = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTemp1 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAve1 = new System.Windows.Forms.Label();
            this.btnSwitchHR = new System.Windows.Forms.Button();
            this.btnSwitchGSR = new System.Windows.Forms.Button();
            this.HRChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GSRChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_All = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAve2 = new System.Windows.Forms.Label();
            this.lblAve3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTemp3 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GSRChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSwitchTemp
            // 
            this.btnSwitchTemp.ForeColor = System.Drawing.Color.Black;
            this.btnSwitchTemp.Location = new System.Drawing.Point(4, 74);
            this.btnSwitchTemp.Name = "btnSwitchTemp";
            this.btnSwitchTemp.Size = new System.Drawing.Size(156, 23);
            this.btnSwitchTemp.TabIndex = 0;
            this.btnSwitchTemp.Text = "Temperature";
            this.btnSwitchTemp.UseVisualStyleBackColor = true;
            this.btnSwitchTemp.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tempChart
            // 
            this.tempChart.BackColor = System.Drawing.Color.Black;
            this.tempChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tempChart.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.tempChart.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.AxisX.LineColor = System.Drawing.Color.OrangeRed;
            chartArea1.AxisY.LineColor = System.Drawing.Color.OrangeRed;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.tempChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.BackSecondaryColor = System.Drawing.Color.Transparent;
            legend1.Name = "Temperature";
            this.tempChart.Legends.Add(legend1);
            this.tempChart.Location = new System.Drawing.Point(748, 170);
            this.tempChart.Name = "tempChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Temperature";
            series1.Name = "tempSeries";
            this.tempChart.Series.Add(series1);
            this.tempChart.Size = new System.Drawing.Size(303, 166);
            this.tempChart.TabIndex = 3;
            this.tempChart.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblTemp1
            // 
            this.lblTemp1.AutoSize = true;
            this.lblTemp1.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTemp1.Location = new System.Drawing.Point(695, 245);
            this.lblTemp1.Name = "lblTemp1";
            this.lblTemp1.Size = new System.Drawing.Size(13, 13);
            this.lblTemp1.TabIndex = 4;
            this.lblTemp1.Text = "0";
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTime1.Location = new System.Drawing.Point(893, 339);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(13, 13);
            this.lblTime1.TabIndex = 5;
            this.lblTime1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(653, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Temperature (oC)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(862, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time(Seconds)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(842, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Average:";
            // 
            // lblAve1
            // 
            this.lblAve1.AutoSize = true;
            this.lblAve1.BackColor = System.Drawing.Color.Transparent;
            this.lblAve1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAve1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAve1.Location = new System.Drawing.Point(946, 137);
            this.lblAve1.Name = "lblAve1";
            this.lblAve1.Size = new System.Drawing.Size(24, 25);
            this.lblAve1.TabIndex = 9;
            this.lblAve1.Text = "0";
            // 
            // btnSwitchHR
            // 
            this.btnSwitchHR.ForeColor = System.Drawing.Color.Black;
            this.btnSwitchHR.Location = new System.Drawing.Point(4, 19);
            this.btnSwitchHR.Name = "btnSwitchHR";
            this.btnSwitchHR.Size = new System.Drawing.Size(156, 23);
            this.btnSwitchHR.TabIndex = 10;
            this.btnSwitchHR.Text = "Heart Rate";
            this.btnSwitchHR.UseVisualStyleBackColor = true;
            this.btnSwitchHR.Click += new System.EventHandler(this.btnSwitchHR_Click);
            // 
            // btnSwitchGSR
            // 
            this.btnSwitchGSR.ForeColor = System.Drawing.Color.Black;
            this.btnSwitchGSR.Location = new System.Drawing.Point(4, 45);
            this.btnSwitchGSR.Name = "btnSwitchGSR";
            this.btnSwitchGSR.Size = new System.Drawing.Size(156, 23);
            this.btnSwitchGSR.TabIndex = 11;
            this.btnSwitchGSR.Text = "GSR";
            this.btnSwitchGSR.UseVisualStyleBackColor = true;
            this.btnSwitchGSR.Click += new System.EventHandler(this.btnSwitchGSR_Click);
            // 
            // HRChart
            // 
            this.HRChart.BackColor = System.Drawing.Color.Black;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.HRChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Heart Rate";
            this.HRChart.Legends.Add(legend2);
            this.HRChart.Location = new System.Drawing.Point(1165, 170);
            this.HRChart.Name = "HRChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.LabelForeColor = System.Drawing.Color.DarkOrange;
            series2.Legend = "Heart Rate";
            series2.Name = "HRSeries";
            this.HRChart.Series.Add(series2);
            this.HRChart.Size = new System.Drawing.Size(303, 166);
            this.HRChart.TabIndex = 12;
            this.HRChart.Text = "chart1";
            // 
            // GSRChart
            // 
            this.GSRChart.BackColor = System.Drawing.Color.Black;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.GSRChart.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Name = "Legend1";
            this.GSRChart.Legends.Add(legend3);
            this.GSRChart.Location = new System.Drawing.Point(334, 170);
            this.GSRChart.Name = "GSRChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.LabelForeColor = System.Drawing.Color.LightSalmon;
            series3.Legend = "Legend1";
            series3.Name = "GSRSeries";
            this.GSRChart.Series.Add(series3);
            this.GSRChart.Size = new System.Drawing.Size(303, 166);
            this.GSRChart.TabIndex = 13;
            this.GSRChart.Text = "chart1";
            // 
            // btn_All
            // 
            this.btn_All.ForeColor = System.Drawing.Color.Black;
            this.btn_All.Location = new System.Drawing.Point(4, 104);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(156, 23);
            this.btn_All.TabIndex = 14;
            this.btn_All.Text = "ALL ";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(404, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Average:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(1238, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Average:";
            // 
            // lblAve2
            // 
            this.lblAve2.AutoSize = true;
            this.lblAve2.BackColor = System.Drawing.Color.Transparent;
            this.lblAve2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAve2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAve2.Location = new System.Drawing.Point(508, 137);
            this.lblAve2.Name = "lblAve2";
            this.lblAve2.Size = new System.Drawing.Size(24, 25);
            this.lblAve2.TabIndex = 9;
            this.lblAve2.Text = "0";
            // 
            // lblAve3
            // 
            this.lblAve3.AutoSize = true;
            this.lblAve3.BackColor = System.Drawing.Color.Transparent;
            this.lblAve3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAve3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAve3.Location = new System.Drawing.Point(1342, 137);
            this.lblAve3.Name = "lblAve3";
            this.lblAve3.Size = new System.Drawing.Size(24, 25);
            this.lblAve3.TabIndex = 9;
            this.lblAve3.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(296, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "GSR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(424, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Time(Seconds)";
            // 
            // lblTemp2
            // 
            this.lblTemp2.AutoSize = true;
            this.lblTemp2.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTemp2.Location = new System.Drawing.Point(313, 239);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(13, 13);
            this.lblTemp2.TabIndex = 4;
            this.lblTemp2.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(1100, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Heart Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(1271, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Time(Seconds)";
            // 
            // lblTemp3
            // 
            this.lblTemp3.AutoSize = true;
            this.lblTemp3.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTemp3.Location = new System.Drawing.Point(1138, 245);
            this.lblTemp3.Name = "lblTemp3";
            this.lblTemp3.Size = new System.Drawing.Size(13, 13);
            this.lblTemp3.TabIndex = 4;
            this.lblTemp3.Text = "0";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.BackColor = System.Drawing.Color.Transparent;
            this.lblTime2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTime2.Location = new System.Drawing.Point(451, 339);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(13, 13);
            this.lblTime2.TabIndex = 5;
            this.lblTime2.Text = "0";
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.BackColor = System.Drawing.Color.Transparent;
            this.lblTime3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTime3.Location = new System.Drawing.Point(1299, 342);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(13, 13);
            this.lblTime3.TabIndex = 5;
            this.lblTime3.Text = "0";
            // 
            // btnStop
            // 
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(4, 132);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(156, 24);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(754, 404);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(113, 20);
            this.txtForename.TabIndex = 16;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(931, 404);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(113, 20);
            this.txtSurname.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(574, 404);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(113, 20);
            this.txtID.TabIndex = 16;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(1084, 404);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(113, 20);
            this.txtAge.TabIndex = 16;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblForename.Location = new System.Drawing.Point(691, 407);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 17;
            this.lblForename.Text = "Forename:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSurname.Location = new System.Drawing.Point(873, 407);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 17;
            this.lblSurname.Text = "Surname:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblID.Location = new System.Drawing.Point(507, 407);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 13);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID Number:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAge.Location = new System.Drawing.Point(1050, 407);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 13);
            this.lblAge.TabIndex = 17;
            this.lblAge.Text = "Age: ";
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(1203, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 27);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.ForeColor = System.Drawing.Color.Black;
            this.btnRecords.Location = new System.Drawing.Point(1389, 400);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(163, 27);
            this.btnRecords.TabIndex = 19;
            this.btnRecords.Text = "View Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(468, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(830, 73);
            this.label10.TabIndex = 20;
            this.label10.Text = "Player Performance Monitor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1558, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "2.10";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.btn_All);
            this.groupBox1.Controls.Add(this.btnSwitchTemp);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnSwitchHR);
            this.groupBox1.Controls.Add(this.btnSwitchGSR);
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(1413, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 163);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "View Records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Temperature_Chart.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1370, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HRChart);
            this.Controls.Add(this.GSRChart);
            this.Controls.Add(this.tempChart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.lblAve3);
            this.Controls.Add(this.lblAve2);
            this.Controls.Add(this.lblAve1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime3);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.lblTemp3);
            this.Controls.Add(this.lblTemp2);
            this.Controls.Add(this.lblTemp1);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Name = "Form1";
            this.Text = "Player Performance Monitor v2.10";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GSRChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchTemp;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempChart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTemp1;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAve1;
        private System.Windows.Forms.Button btnSwitchHR;
        private System.Windows.Forms.Button btnSwitchGSR;
        private System.Windows.Forms.DataVisualization.Charting.Chart HRChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart GSRChart;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAve2;
        private System.Windows.Forms.Label lblAve3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTemp2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTemp3;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button1;
    }
}

