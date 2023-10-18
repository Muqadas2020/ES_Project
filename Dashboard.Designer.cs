
namespace Hospital_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.HMSlabel = new System.Windows.Forms.Label();
            this.PatientappointmentTextBox = new System.Windows.Forms.TextBox();
            this.AddPatientTextBox = new System.Windows.Forms.TextBox();
            this.Exitbtn = new System.Windows.Forms.TextBox();
            this.AddPatientpanel = new System.Windows.Forms.Panel();
            this.Savebutton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.PatientAddresstextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PatientDiseasetextBox = new System.Windows.Forms.TextBox();
            this.DoctornametextBox = new System.Windows.Forms.TextBox();
            this.BloodGroupcomboBox = new System.Windows.Forms.ComboBox();
            this.patientGendercomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.PhnotextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.PRecordLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.WardInfocomboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.WardTypeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.MedicinetextBox = new System.Windows.Forms.TextBox();
            this.AddPatientpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HMSlabel
            // 
            this.HMSlabel.AutoSize = true;
            this.HMSlabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.HMSlabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HMSlabel.Location = new System.Drawing.Point(241, 41);
            this.HMSlabel.Name = "HMSlabel";
            this.HMSlabel.Size = new System.Drawing.Size(382, 29);
            this.HMSlabel.TabIndex = 1;
            this.HMSlabel.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // PatientappointmentTextBox
            // 
            this.PatientappointmentTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PatientappointmentTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PatientappointmentTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientappointmentTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PatientappointmentTextBox.Location = new System.Drawing.Point(279, 222);
            this.PatientappointmentTextBox.Multiline = true;
            this.PatientappointmentTextBox.Name = "PatientappointmentTextBox";
            this.PatientappointmentTextBox.Size = new System.Drawing.Size(319, 41);
            this.PatientappointmentTextBox.TabIndex = 4;
            this.PatientappointmentTextBox.Text = "Appointment For The Patient";
            this.PatientappointmentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatientappointmentTextBox.Click += new System.EventHandler(this.PatientApoointment_click);
            // 
            // AddPatientTextBox
            // 
            this.AddPatientTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddPatientTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddPatientTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPatientTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.AddPatientTextBox.Location = new System.Drawing.Point(279, 156);
            this.AddPatientTextBox.Multiline = true;
            this.AddPatientTextBox.Name = "AddPatientTextBox";
            this.AddPatientTextBox.Size = new System.Drawing.Size(319, 41);
            this.AddPatientTextBox.TabIndex = 3;
            this.AddPatientTextBox.Text = "Add New Patient Record";
            this.AddPatientTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddPatientTextBox.Click += new System.EventHandler(this.AddPtient_click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.DarkGray;
            this.Exitbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Exitbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exitbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Exitbtn.Location = new System.Drawing.Point(279, 287);
            this.Exitbtn.Multiline = true;
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(319, 41);
            this.Exitbtn.TabIndex = 5;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exitbtn.Click += new System.EventHandler(this.Exit_click);
            // 
            // AddPatientpanel
            // 
            this.AddPatientpanel.Controls.Add(this.label14);
            this.AddPatientpanel.Controls.Add(this.MedicinetextBox);
            this.AddPatientpanel.Controls.Add(this.label13);
            this.AddPatientpanel.Controls.Add(this.textBox11);
            this.AddPatientpanel.Controls.Add(this.label12);
            this.AddPatientpanel.Controls.Add(this.WardTypeTextBox);
            this.AddPatientpanel.Controls.Add(this.WardInfocomboBox);
            this.AddPatientpanel.Controls.Add(this.Savebutton);
            this.AddPatientpanel.Controls.Add(this.label11);
            this.AddPatientpanel.Controls.Add(this.PatientAddresstextBox);
            this.AddPatientpanel.Controls.Add(this.label9);
            this.AddPatientpanel.Controls.Add(this.label10);
            this.AddPatientpanel.Controls.Add(this.PatientDiseasetextBox);
            this.AddPatientpanel.Controls.Add(this.DoctornametextBox);
            this.AddPatientpanel.Controls.Add(this.BloodGroupcomboBox);
            this.AddPatientpanel.Controls.Add(this.patientGendercomboBox);
            this.AddPatientpanel.Controls.Add(this.label8);
            this.AddPatientpanel.Controls.Add(this.label6);
            this.AddPatientpanel.Controls.Add(this.label5);
            this.AddPatientpanel.Controls.Add(this.label3);
            this.AddPatientpanel.Controls.Add(this.label2);
            this.AddPatientpanel.Controls.Add(this.label1);
            this.AddPatientpanel.Controls.Add(this.AgetextBox);
            this.AddPatientpanel.Controls.Add(this.PhnotextBox);
            this.AddPatientpanel.Controls.Add(this.NametextBox);
            this.AddPatientpanel.Controls.Add(this.PRecordLabel);
            this.AddPatientpanel.Location = new System.Drawing.Point(-1, 0);
            this.AddPatientpanel.Name = "AddPatientpanel";
            this.AddPatientpanel.Size = new System.Drawing.Size(885, 462);
            this.AddPatientpanel.TabIndex = 6;
            this.AddPatientpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddPatientpanel_Paint);
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Savebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Savebutton.Location = new System.Drawing.Point(324, 391);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(288, 43);
            this.Savebutton.TabIndex = 29;
            this.Savebutton.Text = "SAVE RECORDS";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.save_click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(481, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Patient Address";
            // 
            // PatientAddresstextBox
            // 
            this.PatientAddresstextBox.Location = new System.Drawing.Point(620, 290);
            this.PatientAddresstextBox.Name = "PatientAddresstextBox";
            this.PatientAddresstextBox.Size = new System.Drawing.Size(202, 23);
            this.PatientAddresstextBox.TabIndex = 25;
            this.PatientAddresstextBox.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Disease Symptoms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Patient Doctor";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // PatientDiseasetextBox
            // 
            this.PatientDiseasetextBox.Location = new System.Drawing.Point(211, 346);
            this.PatientDiseasetextBox.Name = "PatientDiseasetextBox";
            this.PatientDiseasetextBox.Size = new System.Drawing.Size(202, 23);
            this.PatientDiseasetextBox.TabIndex = 22;
            this.PatientDiseasetextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // DoctornametextBox
            // 
            this.DoctornametextBox.Location = new System.Drawing.Point(211, 243);
            this.DoctornametextBox.Name = "DoctornametextBox";
            this.DoctornametextBox.Size = new System.Drawing.Size(202, 23);
            this.DoctornametextBox.TabIndex = 21;
            this.DoctornametextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // BloodGroupcomboBox
            // 
            this.BloodGroupcomboBox.FormattingEnabled = true;
            this.BloodGroupcomboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.BloodGroupcomboBox.Location = new System.Drawing.Point(620, 132);
            this.BloodGroupcomboBox.Name = "BloodGroupcomboBox";
            this.BloodGroupcomboBox.Size = new System.Drawing.Size(202, 23);
            this.BloodGroupcomboBox.TabIndex = 20;
            this.BloodGroupcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // patientGendercomboBox
            // 
            this.patientGendercomboBox.FormattingEnabled = true;
            this.patientGendercomboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.patientGendercomboBox.Location = new System.Drawing.Point(620, 77);
            this.patientGendercomboBox.Name = "patientGendercomboBox";
            this.patientGendercomboBox.Size = new System.Drawing.Size(202, 23);
            this.patientGendercomboBox.TabIndex = 19;
            this.patientGendercomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Blood Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Patient Age";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contact Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Any Ward Allocation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Patient Gender";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(211, 132);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(202, 23);
            this.AgetextBox.TabIndex = 8;
            this.AgetextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // PhnotextBox
            // 
            this.PhnotextBox.Location = new System.Drawing.Point(211, 187);
            this.PhnotextBox.Name = "PhnotextBox";
            this.PhnotextBox.Size = new System.Drawing.Size(202, 23);
            this.PhnotextBox.TabIndex = 7;
            this.PhnotextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(211, 77);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(202, 23);
            this.NametextBox.TabIndex = 3;
            this.NametextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PRecordLabel
            // 
            this.PRecordLabel.AutoSize = true;
            this.PRecordLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PRecordLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PRecordLabel.Location = new System.Drawing.Point(279, 21);
            this.PRecordLabel.Name = "PRecordLabel";
            this.PRecordLabel.Size = new System.Drawing.Size(319, 29);
            this.PRecordLabel.TabIndex = 2;
            this.PRecordLabel.Text = "ADD NEW PATIENT RECORD";
            this.PRecordLabel.Click += new System.EventHandler(this.PRecordLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(286, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "ADD NEW PATIENT RECORD";
            // 
            // WardInfocomboBox
            // 
            this.WardInfocomboBox.FormattingEnabled = true;
            this.WardInfocomboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.WardInfocomboBox.Location = new System.Drawing.Point(620, 189);
            this.WardInfocomboBox.Name = "WardInfocomboBox";
            this.WardInfocomboBox.Size = new System.Drawing.Size(202, 23);
            this.WardInfocomboBox.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(481, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Ward Type";
            // 
            // WardTypeTextBox
            // 
            this.WardTypeTextBox.Location = new System.Drawing.Point(620, 234);
            this.WardTypeTextBox.Name = "WardTypeTextBox";
            this.WardTypeTextBox.Size = new System.Drawing.Size(202, 23);
            this.WardTypeTextBox.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(67, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "Patient Disease";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(211, 295);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(202, 23);
            this.textBox11.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(481, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 36;
            this.label14.Text = "Medicines";
            // 
            // MedicinetextBox
            // 
            this.MedicinetextBox.Location = new System.Drawing.Point(620, 343);
            this.MedicinetextBox.Name = "MedicinetextBox";
            this.MedicinetextBox.Size = new System.Drawing.Size(202, 23);
            this.MedicinetextBox.TabIndex = 35;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 461);
            this.Controls.Add(this.AddPatientpanel);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.PatientappointmentTextBox);
            this.Controls.Add(this.AddPatientTextBox);
            this.Controls.Add(this.HMSlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.AddPatientpanel.ResumeLayout(false);
            this.AddPatientpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HMSlabel;
        private System.Windows.Forms.TextBox PatientappointmentTextBox;
        private System.Windows.Forms.TextBox AddPatientTextBox;
        private System.Windows.Forms.TextBox Exitbtn;
        private System.Windows.Forms.Panel AddPatientpanel;
        private System.Windows.Forms.Label PRecordLabel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PatientAddresstextBox;
        private System.Windows.Forms.TextBox PatientDiseasetextBox;
        private System.Windows.Forms.TextBox DoctornametextBox;
        private System.Windows.Forms.ComboBox BloodGroupcomboBox;
        private System.Windows.Forms.ComboBox patientGendercomboBox;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.TextBox PhnotextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MedicinetextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox WardTypeTextBox;
        private System.Windows.Forms.ComboBox WardInfocomboBox;
        //private System.Windows.Forms.Panel NewInfopanel;
        //private System.Windows.Forms.Label newInfo;
    }
}