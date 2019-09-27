namespace Referee.UI
{
    partial class EditReferees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReferees));
            this.RefereeData = new System.Windows.Forms.DataGridView();
            this.gvRefereeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturnToEntryPoint = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnEditRefBlocks = new System.Windows.Forms.Button();
            this.btnSaveReferees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RefereeData)).BeginInit();
            this.SuspendLayout();
            // 
            // RefereeData
            // 
            this.RefereeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RefereeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RefereeData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvRefereeName});
            this.RefereeData.Location = new System.Drawing.Point(12, 12);
            this.RefereeData.MultiSelect = false;
            this.RefereeData.Name = "RefereeData";
            this.RefereeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RefereeData.Size = new System.Drawing.Size(742, 512);
            this.RefereeData.TabIndex = 10;
            this.RefereeData.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.RefereeData_UserDeletingRow);
            // 
            // gvRefereeName
            // 
            this.gvRefereeName.HeaderText = "ΟΝΟΜΑΤΕΠΩΝΥΜΟ ΔΙΑΙΤΗΤΗ";
            this.gvRefereeName.Name = "gvRefereeName";
            // 
            // btnReturnToEntryPoint
            // 
            this.btnReturnToEntryPoint.Location = new System.Drawing.Point(642, 549);
            this.btnReturnToEntryPoint.Name = "btnReturnToEntryPoint";
            this.btnReturnToEntryPoint.Size = new System.Drawing.Size(112, 38);
            this.btnReturnToEntryPoint.TabIndex = 14;
            this.btnReturnToEntryPoint.Text = "ΕΠΙΣΤΡΟΦΗ";
            this.btnReturnToEntryPoint.UseVisualStyleBackColor = true;
            this.btnReturnToEntryPoint.Click += new System.EventHandler(this.btnReturnToEntryPoint_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(130, 538);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 49);
            this.button5.TabIndex = 19;
            this.button5.Text = "ΙΣΤΟΡΙΚΟ ΕΠΙΛΕΓΜΕΝΟΥ ΔΙΑΙΤΗΤΗ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnEditRefBlocks
            // 
            this.btnEditRefBlocks.Location = new System.Drawing.Point(12, 538);
            this.btnEditRefBlocks.Name = "btnEditRefBlocks";
            this.btnEditRefBlocks.Size = new System.Drawing.Size(112, 49);
            this.btnEditRefBlocks.TabIndex = 21;
            this.btnEditRefBlocks.Text = "ΜΠΛΟΚΑΡΙΣΜΑΤΑ ΕΠΙΛΕΓΜΕΝΟΥ ΔΙΑΙΤΗΤΗ";
            this.btnEditRefBlocks.UseVisualStyleBackColor = true;
            this.btnEditRefBlocks.Click += new System.EventHandler(this.btnEditRefBlocks_Click);
            // 
            // btnSaveReferees
            // 
            this.btnSaveReferees.Location = new System.Drawing.Point(524, 538);
            this.btnSaveReferees.Name = "btnSaveReferees";
            this.btnSaveReferees.Size = new System.Drawing.Size(112, 49);
            this.btnSaveReferees.TabIndex = 22;
            this.btnSaveReferees.Text = "ΑΠΟΘΗΚΕΥΣΗ";
            this.btnSaveReferees.UseVisualStyleBackColor = true;
            this.btnSaveReferees.Click += new System.EventHandler(this.btnSaveReferees_Click);
            // 
            // EditReferees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 599);
            this.Controls.Add(this.btnSaveReferees);
            this.Controls.Add(this.btnEditRefBlocks);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RefereeData);
            this.Controls.Add(this.btnReturnToEntryPoint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditReferees";
            this.Text = "ΤΡΟΠΟΠΟΙΗΣΗ ΔΙΑΙΤΗΤΩΝ";
            this.Load += new System.EventHandler(this.EditReferees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RefereeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView RefereeData;
        private System.Windows.Forms.Button btnReturnToEntryPoint;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnEditRefBlocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvRefereeName;
        private System.Windows.Forms.Button btnSaveReferees;
    }
}