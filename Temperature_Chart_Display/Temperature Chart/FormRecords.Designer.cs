namespace Temperature_Chart
{
    partial class FormRecords
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
            this.btnView = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPulse = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblGSR = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(253, 14);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(16, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(231, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblID.Location = new System.Drawing.Point(168, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Forename:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblForename.Location = new System.Drawing.Point(168, 115);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(18, 20);
            this.lblForename.TabIndex = 2;
            this.lblForename.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(19, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Surname:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSurname.Location = new System.Drawing.Point(168, 141);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(18, 20);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(19, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Age:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAge.Location = new System.Drawing.Point(168, 167);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(18, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(17, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Temperature:";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTemp.Location = new System.Drawing.Point(168, 196);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(18, 20);
            this.lblTemp.TabIndex = 2;
            this.lblTemp.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Location = new System.Drawing.Point(17, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Pulse:";
            // 
            // lblPulse
            // 
            this.lblPulse.AutoSize = true;
            this.lblPulse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPulse.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPulse.Location = new System.Drawing.Point(168, 218);
            this.lblPulse.Name = "lblPulse";
            this.lblPulse.Size = new System.Drawing.Size(18, 20);
            this.lblPulse.TabIndex = 2;
            this.lblPulse.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label13.Location = new System.Drawing.Point(17, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "GSR:";
            // 
            // lblGSR
            // 
            this.lblGSR.AutoSize = true;
            this.lblGSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGSR.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblGSR.Location = new System.Drawing.Point(168, 243);
            this.lblGSR.Name = "lblGSR";
            this.lblGSR.Size = new System.Drawing.Size(18, 20);
            this.lblGSR.TabIndex = 2;
            this.lblGSR.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label15.Location = new System.Drawing.Point(19, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDate.Location = new System.Drawing.Point(168, 93);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(18, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "0";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(172, 285);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(156, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(16, 285);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(150, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // FormRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(340, 320);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblGSR);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPulse);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnView);
            this.Name = "FormRecords";
            this.Text = "Client Records";
            this.Load += new System.EventHandler(this.FormRecords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPulse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblGSR;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
    }
}