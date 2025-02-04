﻿
namespace Hospital_Management_System.Client.Forms.Doctor
{
    partial class ViewPatientFromDoctor
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
            this.panelDoctorPatientTop = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvDoctorsPatient = new System.Windows.Forms.DataGridView();
            this.panelDoctorPAtientData = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.txtAppointmentId = new System.Windows.Forms.TextBox();
            this.btnPreviousPrescription = new System.Windows.Forms.Button();
            this.btnAddPrescription = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAppointmentDate = new System.Windows.Forms.TextBox();
            this.panelDoctorPatientTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorsPatient)).BeginInit();
            this.panelDoctorPAtientData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDoctorPatientTop
            // 
            this.panelDoctorPatientTop.Controls.Add(this.dateTimePicker1);
            this.panelDoctorPatientTop.Controls.Add(this.dgvDoctorsPatient);
            this.panelDoctorPatientTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDoctorPatientTop.Location = new System.Drawing.Point(0, 0);
            this.panelDoctorPatientTop.Name = "panelDoctorPatientTop";
            this.panelDoctorPatientTop.Size = new System.Drawing.Size(1008, 237);
            this.panelDoctorPatientTop.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(645, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dgvDoctorsPatient
            // 
            this.dgvDoctorsPatient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDoctorsPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorsPatient.Location = new System.Drawing.Point(70, 60);
            this.dgvDoctorsPatient.Name = "dgvDoctorsPatient";
            this.dgvDoctorsPatient.RowTemplate.Height = 25;
            this.dgvDoctorsPatient.Size = new System.Drawing.Size(775, 170);
            this.dgvDoctorsPatient.TabIndex = 0;
            this.dgvDoctorsPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctorsPatient_CellClick);
            this.dgvDoctorsPatient.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoctorsPatient_CellMouseDoubleClick);
            // 
            // panelDoctorPAtientData
            // 
            this.panelDoctorPAtientData.Controls.Add(this.groupBox1);
            this.panelDoctorPAtientData.Controls.Add(this.txtAppointmentId);
            this.panelDoctorPAtientData.Controls.Add(this.btnPreviousPrescription);
            this.panelDoctorPAtientData.Controls.Add(this.btnAddPrescription);
            this.panelDoctorPAtientData.Controls.Add(this.txtAge);
            this.panelDoctorPAtientData.Controls.Add(this.txtName);
            this.panelDoctorPAtientData.Controls.Add(this.txtAppointmentDate);
            this.panelDoctorPAtientData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDoctorPAtientData.Location = new System.Drawing.Point(0, 237);
            this.panelDoctorPAtientData.Name = "panelDoctorPAtientData";
            this.panelDoctorPAtientData.Size = new System.Drawing.Size(1008, 260);
            this.panelDoctorPAtientData.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Location = new System.Drawing.Point(258, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 70);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(0, 35);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(56, 21);
            this.rbMale.TabIndex = 25;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(99, 35);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(69, 21);
            this.rbFemale.TabIndex = 26;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // txtAppointmentId
            // 
            this.txtAppointmentId.Location = new System.Drawing.Point(35, 31);
            this.txtAppointmentId.Name = "txtAppointmentId";
            this.txtAppointmentId.Size = new System.Drawing.Size(178, 25);
            this.txtAppointmentId.TabIndex = 35;
            // 
            // btnPreviousPrescription
            // 
            this.btnPreviousPrescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPreviousPrescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnPreviousPrescription.Location = new System.Drawing.Point(726, 97);
            this.btnPreviousPrescription.Name = "btnPreviousPrescription";
            this.btnPreviousPrescription.Size = new System.Drawing.Size(136, 53);
            this.btnPreviousPrescription.TabIndex = 34;
            this.btnPreviousPrescription.Text = "Previous Prescription";
            this.btnPreviousPrescription.UseVisualStyleBackColor = false;
            this.btnPreviousPrescription.Click += new System.EventHandler(this.btnPreviousPrescription_Click);
            // 
            // btnAddPrescription
            // 
            this.btnAddPrescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddPrescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAddPrescription.Location = new System.Drawing.Point(726, 31);
            this.btnAddPrescription.Name = "btnAddPrescription";
            this.btnAddPrescription.Size = new System.Drawing.Size(136, 60);
            this.btnAddPrescription.TabIndex = 33;
            this.btnAddPrescription.Text = "Add Prescription";
            this.btnAddPrescription.UseVisualStyleBackColor = false;
            this.btnAddPrescription.Click += new System.EventHandler(this.btnAddPrescription_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(35, 97);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(178, 25);
            this.txtAge.TabIndex = 31;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(483, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 25);
            this.txtName.TabIndex = 30;
            // 
            // txtAppointmentDate
            // 
            this.txtAppointmentDate.Location = new System.Drawing.Point(258, 31);
            this.txtAppointmentDate.Name = "txtAppointmentDate";
            this.txtAppointmentDate.Size = new System.Drawing.Size(178, 25);
            this.txtAppointmentDate.TabIndex = 29;
            // 
            // ViewPatientFromDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 588);
            this.Controls.Add(this.panelDoctorPAtientData);
            this.Controls.Add(this.panelDoctorPatientTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPatientFromDoctor";
            this.Text = "View Patient";
            this.panelDoctorPatientTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorsPatient)).EndInit();
            this.panelDoctorPAtientData.ResumeLayout(false);
            this.panelDoctorPAtientData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDoctorPatientTop;
        private System.Windows.Forms.DataGridView dgvDoctorsPatient;
        private System.Windows.Forms.Panel panelDoctorPAtientData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.Button btnPreviousPrescription;
        private System.Windows.Forms.Button btnAppointmentUpdate;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAppointmentDate;
        private System.Windows.Forms.Button btnAddPrescription;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}