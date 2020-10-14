using System;

namespace Referee.UI
{
    partial class ApplicationEntryPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationEntryPoint));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAgonistikiPeriodos = new System.Windows.Forms.ComboBox();
            this.btnSwitchRefereeAssignment = new System.Windows.Forms.Button();
            this.cbAgwnistiki = new System.Windows.Forms.ComboBox();
            this.cbDiorganwsi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.editRefWatch = new System.Windows.Forms.Button();
            this.btnEditFields = new System.Windows.Forms.Button();
            this.btnEditPeriods = new System.Windows.Forms.Button();
            this.btnEditReferee = new System.Windows.Forms.Button();
            this.btnEditTeams = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ΠΕΡΙΟΔΟΣ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ΑΓΩΝΙΣΤΙΚΗ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ΔΙΟΡΓΑΝΩΣΗ:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.cbAgonistikiPeriodos);
            this.groupBox1.Controls.Add(this.btnSwitchRefereeAssignment);
            this.groupBox1.Controls.Add(this.cbAgwnistiki);
            this.groupBox1.Controls.Add(this.cbDiorganwsi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ΕΙΣΟΔΟΣ";
            // 
            // cbAgonistikiPeriodos
            // 
            this.cbAgonistikiPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgonistikiPeriodos.FormattingEnabled = true;
            this.cbAgonistikiPeriodos.Items.AddRange(new object[] {
            "2020-21",
            "2021-22"});
            this.cbAgonistikiPeriodos.Location = new System.Drawing.Point(302, 44);
            this.cbAgonistikiPeriodos.Name = "cbAgonistikiPeriodos";
            this.cbAgonistikiPeriodos.Size = new System.Drawing.Size(72, 21);
            this.cbAgonistikiPeriodos.TabIndex = 8;
            // 
            // btnSwitchRefereeAssignment
            // 
            this.btnSwitchRefereeAssignment.Location = new System.Drawing.Point(177, 170);
            this.btnSwitchRefereeAssignment.Name = "btnSwitchRefereeAssignment";
            this.btnSwitchRefereeAssignment.Size = new System.Drawing.Size(75, 28);
            this.btnSwitchRefereeAssignment.TabIndex = 7;
            this.btnSwitchRefereeAssignment.Text = "ΕΙΣΟΔΟΣ";
            this.btnSwitchRefereeAssignment.UseVisualStyleBackColor = true;
            this.btnSwitchRefereeAssignment.Click += new System.EventHandler(this.btn_switchRefereeAssignment);
            // 
            // cbAgwnistiki
            // 
            this.cbAgwnistiki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgwnistiki.FormattingEnabled = true;
            this.cbAgwnistiki.Items.AddRange(new object[] {
            "1ή",
            "2ή",
            "3ή",
            "4ή",
            "5ή",
            "6ή",
            "7ή",
            "8ή",
            "9ή",
            "10ή",
            "11ή",
            "12ή",
            "13ή",
            "14ή",
            "15ή",
            "16ή",
            "17ή",
            "18ή",
            "19ή",
            "20ή",
            "21ή",
            "22ή",
            "23ή",
            "24ή",
            "25ή",
            "26ή",
            "27ή",
            "28ή",
            "29ή",
            "30ή",
            "31ή",
            "32ή",
            "33ή",
            "34ή",
            "35ή",
            "36ή",
            "37ή",
            "38ή",
            "39ή",
            "40ή",
            "41ή",
            "42ή",
            "43ή",
            "44ή",
            "45ή",
            "46ή",
            "47ή",
            "48ή",
            "49ή",
            "50ή"});
            this.cbAgwnistiki.Location = new System.Drawing.Point(322, 117);
            this.cbAgwnistiki.Name = "cbAgwnistiki";
            this.cbAgwnistiki.Size = new System.Drawing.Size(52, 21);
            this.cbAgwnistiki.TabIndex = 6;
            // 
            // cbDiorganwsi
            // 
            this.cbDiorganwsi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiorganwsi.FormattingEnabled = true;
            this.cbDiorganwsi.Items.AddRange(new object[] {
            "Α\' Ερασιτεχνική",
            "Β\' Ερασιτεχνική",
            "Γ\' Ερασιτεχνική"});
            this.cbDiorganwsi.Location = new System.Drawing.Point(258, 83);
            this.cbDiorganwsi.Name = "cbDiorganwsi";
            this.cbDiorganwsi.Size = new System.Drawing.Size(117, 21);
            this.cbDiorganwsi.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.editRefWatch);
            this.groupBox2.Controls.Add(this.btnEditFields);
            this.groupBox2.Controls.Add(this.btnEditPeriods);
            this.groupBox2.Controls.Add(this.btnEditReferee);
            this.groupBox2.Controls.Add(this.btnEditTeams);
            this.groupBox2.Location = new System.Drawing.Point(491, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 208);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ΔΙΑΧΕΙΡΗΣΗ";
            // 
            // editRefWatch
            // 
            this.editRefWatch.Location = new System.Drawing.Point(183, 71);
            this.editRefWatch.Name = "editRefWatch";
            this.editRefWatch.Size = new System.Drawing.Size(157, 21);
            this.editRefWatch.TabIndex = 6;
            this.editRefWatch.Text = "ΤΡΟΠΟΠΟΙΗΣΗ ΠΑΡ. ΔΙΑΙΤ.";
            this.editRefWatch.UseVisualStyleBackColor = true;
            this.editRefWatch.Click += new System.EventHandler(this.editRefWatch_Click);
            // 
            // btnEditFields
            // 
            this.btnEditFields.Location = new System.Drawing.Point(183, 44);
            this.btnEditFields.Name = "btnEditFields";
            this.btnEditFields.Size = new System.Drawing.Size(157, 21);
            this.btnEditFields.TabIndex = 5;
            this.btnEditFields.Text = "ΤΡΟΠΟΠΟΙΗΣΗ ΓΗΠΕΔΩΝ";
            this.btnEditFields.UseVisualStyleBackColor = true;
            this.btnEditFields.Click += new System.EventHandler(this.btnEditFields_Click);
            // 
            // btnEditPeriods
            // 
            this.btnEditPeriods.Enabled = false;
            this.btnEditPeriods.Location = new System.Drawing.Point(20, 98);
            this.btnEditPeriods.Name = "btnEditPeriods";
            this.btnEditPeriods.Size = new System.Drawing.Size(157, 21);
            this.btnEditPeriods.TabIndex = 4;
            this.btnEditPeriods.Text = "ΤΡΟΠΟΠΟΙΗΣΗ ΠΕΡΙΟΔΩΝ";
            this.btnEditPeriods.UseVisualStyleBackColor = true;
            this.btnEditPeriods.Click += new System.EventHandler(this.btn_editPeriods_Click);
            // 
            // btnEditReferee
            // 
            this.btnEditReferee.Location = new System.Drawing.Point(20, 71);
            this.btnEditReferee.Name = "btnEditReferee";
            this.btnEditReferee.Size = new System.Drawing.Size(157, 21);
            this.btnEditReferee.TabIndex = 3;
            this.btnEditReferee.Text = "ΤΡΟΠΟΠΟΙΗΣΗ ΔΙΑΙΤΗΤΩΝ";
            this.btnEditReferee.UseVisualStyleBackColor = true;
            this.btnEditReferee.Click += new System.EventHandler(this.btn_editReferee_Click);
            // 
            // btnEditTeams
            // 
            this.btnEditTeams.Location = new System.Drawing.Point(20, 46);
            this.btnEditTeams.Name = "btnEditTeams";
            this.btnEditTeams.Size = new System.Drawing.Size(157, 20);
            this.btnEditTeams.TabIndex = 2;
            this.btnEditTeams.Text = "ΤΡΟΠΟΠΟΙΗΣΗ ΣΩΜΑΤΕΙΩΝ";
            this.btnEditTeams.UseVisualStyleBackColor = true;
            this.btnEditTeams.Click += new System.EventHandler(this.btn_editTeams_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(584, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "ΠΡΟΓΡΑΜΜΑ ΟΡΓΑΝΩΣΗΣ ΔΙΑΙΤΗΣΙΑΣ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Copyright © 2019 Dimitrios Gazis, All rights reserved.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(225, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(462, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ένωση Ποδοσφαιρικών Σωματείων Πιερίας";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Referee.Properties.Resources.LOGO_EPSP_320x320;
            this.pictureBox1.Location = new System.Drawing.Point(397, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(838, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "v.1.0.1";
            // 
            // ApplicationEntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 428);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationEntryPoint";
            this.Text = "ΔΙΑΙΤΗΣΙΑ";
            this.Load += new System.EventHandler(this.ApplicationEntryPoint_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDiorganwsi;
        private System.Windows.Forms.ComboBox cbAgwnistiki;
        private System.Windows.Forms.Button btnSwitchRefereeAssignment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditReferee;
        private System.Windows.Forms.Button btnEditTeams;
        private System.Windows.Forms.Button btnEditPeriods;
        private System.Windows.Forms.ComboBox cbAgonistikiPeriodos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditFields;
        private System.Windows.Forms.Button editRefWatch;
        private System.Windows.Forms.Label label7;
    }
}