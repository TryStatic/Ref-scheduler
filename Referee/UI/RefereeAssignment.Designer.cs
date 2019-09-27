namespace Referee.UI
{
    partial class RefereeAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefereeAssignment));
            this.MatchRegime = new System.Windows.Forms.DataGridView();
            this.hometeam = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.guestteam = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.field = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referee = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.refereeHelperA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.refereeHelperB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.refereeObserver = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hiddenObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelOrganization = new System.Windows.Forms.Label();
            this.labelAgonistiki = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveAssignment = new System.Windows.Forms.Button();
            this.btnExportToWord = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.colorTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MatchRegime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatchRegime
            // 
            this.MatchRegime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MatchRegime.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.MatchRegime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MatchRegime.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MatchRegime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatchRegime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hometeam,
            this.guestteam,
            this.field,
            this.time,
            this.referee,
            this.refereeHelperA,
            this.refereeHelperB,
            this.refereeObserver,
            this.hiddenObs});
            this.MatchRegime.Location = new System.Drawing.Point(12, 89);
            this.MatchRegime.MultiSelect = false;
            this.MatchRegime.Name = "MatchRegime";
            this.MatchRegime.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.MatchRegime.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MatchRegime.Size = new System.Drawing.Size(1047, 467);
            this.MatchRegime.TabIndex = 0;
            this.MatchRegime.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MatchRegime_CellEndEdit);
            this.MatchRegime.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MatchRegime_CellEnter);
            this.MatchRegime.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.MatchRegime_CellFormatting);
            this.MatchRegime.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.MatchRegime_DataError);
            this.MatchRegime.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.MatchRegime_EditingControlShowing);
            // 
            // hometeam
            // 
            this.hometeam.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.hometeam.FillWeight = 108.4844F;
            this.hometeam.HeaderText = "ΓΗΠΕΔΟΥΧΟΣ";
            this.hometeam.Name = "hometeam";
            this.hometeam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // guestteam
            // 
            this.guestteam.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.guestteam.FillWeight = 108.4844F;
            this.guestteam.HeaderText = "ΦΙΛΟΞΕΝΟΥΜΕΝΟΣ";
            this.guestteam.Name = "guestteam";
            this.guestteam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // field
            // 
            this.field.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.field.FillWeight = 108.4844F;
            this.field.HeaderText = "ΓΗΠΕΔΟ";
            this.field.Name = "field";
            this.field.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // time
            // 
            this.time.FillWeight = 40.60914F;
            this.time.HeaderText = "ΩΡΑ";
            this.time.Name = "time";
            // 
            // referee
            // 
            this.referee.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.referee.FillWeight = 108.4844F;
            this.referee.HeaderText = "ΔΙΑΙΤΗΤΗΣ";
            this.referee.Name = "referee";
            // 
            // refereeHelperA
            // 
            this.refereeHelperA.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.refereeHelperA.FillWeight = 108.4844F;
            this.refereeHelperA.HeaderText = "ΒΟΗΘΟΣ Α΄";
            this.refereeHelperA.Name = "refereeHelperA";
            // 
            // refereeHelperB
            // 
            this.refereeHelperB.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.refereeHelperB.FillWeight = 108.4844F;
            this.refereeHelperB.HeaderText = "ΒΟΗΘΟΣ Β΄";
            this.refereeHelperB.Name = "refereeHelperB";
            // 
            // refereeObserver
            // 
            this.refereeObserver.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.refereeObserver.FillWeight = 108.4844F;
            this.refereeObserver.HeaderText = "ΠΑΡ. ΔΙΑΙΤΗΣΙΑΣ";
            this.refereeObserver.Name = "refereeObserver";
            // 
            // hiddenObs
            // 
            this.hiddenObs.HeaderText = "ΠΑΡΑΤΗΡΗΤΗΣ";
            this.hiddenObs.Name = "hiddenObs";
            this.hiddenObs.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ΑΓΩΝΙΣΤΙΚΗ ΠΕΡΙΟΔΟΣ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ΔΙΟΡΓΑΝΩΣΗ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(785, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ΑΓΩΝΙΣΤΙΚΗ:";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriod.ForeColor = System.Drawing.Color.Brown;
            this.labelPeriod.Location = new System.Drawing.Point(272, 26);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(59, 35);
            this.labelPeriod.TabIndex = 6;
            this.labelPeriod.Text = "2018";
            // 
            // labelOrganization
            // 
            this.labelOrganization.AutoSize = true;
            this.labelOrganization.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrganization.ForeColor = System.Drawing.Color.Brown;
            this.labelOrganization.Location = new System.Drawing.Point(524, 29);
            this.labelOrganization.Name = "labelOrganization";
            this.labelOrganization.Size = new System.Drawing.Size(176, 31);
            this.labelOrganization.TabIndex = 7;
            this.labelOrganization.Text = "Α\' Ερασιτεχνικη";
            // 
            // labelAgonistiki
            // 
            this.labelAgonistiki.AutoSize = true;
            this.labelAgonistiki.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgonistiki.ForeColor = System.Drawing.Color.Brown;
            this.labelAgonistiki.Location = new System.Drawing.Point(900, 29);
            this.labelAgonistiki.Name = "labelAgonistiki";
            this.labelAgonistiki.Size = new System.Drawing.Size(36, 25);
            this.labelAgonistiki.TabIndex = 8;
            this.labelAgonistiki.Text = "1ή";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(947, 570);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 38);
            this.button4.TabIndex = 10;
            this.button4.Text = "ΕΠΙΣΤΡΟΦΗ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.labelAgonistiki);
            this.groupBox1.Controls.Add(this.labelOrganization);
            this.groupBox1.Controls.Add(this.labelPeriod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 80);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnSaveAssignment
            // 
            this.btnSaveAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAssignment.Location = new System.Drawing.Point(829, 570);
            this.btnSaveAssignment.Name = "btnSaveAssignment";
            this.btnSaveAssignment.Size = new System.Drawing.Size(112, 38);
            this.btnSaveAssignment.TabIndex = 12;
            this.btnSaveAssignment.Text = "ΑΠΟΘΗΚΕΥΣΗ";
            this.btnSaveAssignment.UseVisualStyleBackColor = true;
            this.btnSaveAssignment.Click += new System.EventHandler(this.btnSaveAssignment_Click);
            // 
            // btnExportToWord
            // 
            this.btnExportToWord.Location = new System.Drawing.Point(12, 570);
            this.btnExportToWord.Name = "btnExportToWord";
            this.btnExportToWord.Size = new System.Drawing.Size(112, 38);
            this.btnExportToWord.TabIndex = 13;
            this.btnExportToWord.Text = "ΕΞΑΓΩΓΗ ΣΕ WORD";
            this.btnExportToWord.UseVisualStyleBackColor = true;
            this.btnExportToWord.Click += new System.EventHandler(this.btnExportToWord_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(130, 570);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(112, 38);
            this.btnCheckAll.TabIndex = 14;
            this.btnCheckAll.Text = "ΕΛΕΓΧΟΣ ΟΛΩΝ";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // colorTimer
            // 
            this.colorTimer.Enabled = true;
            this.colorTimer.Interval = 700;
            this.colorTimer.Tick += new System.EventHandler(this.colorTimer_Tick);
            // 
            // RefereeAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1075, 620);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.btnExportToWord);
            this.Controls.Add(this.btnSaveAssignment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.MatchRegime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RefereeAssignment";
            this.Text = "ΔΙΑΙΤΗΣΙΑ";
            this.Activated += new System.EventHandler(this.RefereeAssignment_Activated);
            this.Load += new System.EventHandler(this.RefereeAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatchRegime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MatchRegime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelOrganization;
        private System.Windows.Forms.Label labelAgonistiki;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveAssignment;
        private System.Windows.Forms.Button btnExportToWord;
        private System.Windows.Forms.DataGridViewComboBoxColumn hometeam;
        private System.Windows.Forms.DataGridViewComboBoxColumn guestteam;
        private System.Windows.Forms.DataGridViewComboBoxColumn field;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewComboBoxColumn referee;
        private System.Windows.Forms.DataGridViewComboBoxColumn refereeHelperA;
        private System.Windows.Forms.DataGridViewComboBoxColumn refereeHelperB;
        private System.Windows.Forms.DataGridViewComboBoxColumn refereeObserver;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiddenObs;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Timer colorTimer;
    }
}

