namespace Referee.UI
{
    partial class EditTeams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTeams));
            this.button4 = new System.Windows.Forms.Button();
            this.teamData = new System.Windows.Forms.DataGridView();
            this.gvTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveTeams = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teamData)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(642, 549);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 38);
            this.button4.TabIndex = 9;
            this.button4.Text = "ΕΠΙΣΤΡΟΦΗ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // teamData
            // 
            this.teamData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teamData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvTeamName});
            this.teamData.Location = new System.Drawing.Point(12, 12);
            this.teamData.MultiSelect = false;
            this.teamData.Name = "teamData";
            this.teamData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teamData.Size = new System.Drawing.Size(742, 512);
            this.teamData.TabIndex = 10;
            // 
            // gvTeamName
            // 
            this.gvTeamName.HeaderText = "ΟΝΟΜΑ ΑΘΛΗΤΙΚΟΥ ΣΩΜΑΤΕΙΟΥ";
            this.gvTeamName.Name = "gvTeamName";
            // 
            // btnSaveTeams
            // 
            this.btnSaveTeams.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveTeams.Location = new System.Drawing.Point(524, 538);
            this.btnSaveTeams.Name = "btnSaveTeams";
            this.btnSaveTeams.Size = new System.Drawing.Size(112, 49);
            this.btnSaveTeams.TabIndex = 14;
            this.btnSaveTeams.Text = "ΑΠΘΗΚΕΥΣΗ ΣΩΜΑΤΕΙΩΝ";
            this.btnSaveTeams.UseVisualStyleBackColor = false;
            this.btnSaveTeams.Click += new System.EventHandler(this.btnSaveTeams_Click);
            // 
            // EditTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 599);
            this.Controls.Add(this.btnSaveTeams);
            this.Controls.Add(this.teamData);
            this.Controls.Add(this.button4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTeams";
            this.Text = "ΤΡΟΠΟΠΟΙΗΣΗ ΣΩΜΑΤΕΙΩΝ";
            this.Load += new System.EventHandler(this.EditTeams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView teamData;
        private System.Windows.Forms.Button btnSaveTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvTeamName;
    }
}