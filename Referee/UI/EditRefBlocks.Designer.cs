namespace Referee.UI
{
    partial class EditRefBlocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRefBlocks));
            this.labelRefName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.blockData = new System.Windows.Forms.DataGridView();
            this.refBlockTeamList = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnReturnToEditRefs = new System.Windows.Forms.Button();
            this.btnSaveBlocks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blockData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRefName
            // 
            this.labelRefName.AutoSize = true;
            this.labelRefName.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefName.ForeColor = System.Drawing.Color.Brown;
            this.labelRefName.Location = new System.Drawing.Point(261, 15);
            this.labelRefName.Name = "labelRefName";
            this.labelRefName.Size = new System.Drawing.Size(212, 31);
            this.labelRefName.TabIndex = 8;
            this.labelRefName.Text = "ΟΝΟΜΑ_ΔΙΑΙΤΗΤΗ";
            this.labelRefName.Click += new System.EventHandler(this.labelRefName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ΜΠΛΟΚΑΡΙΣΜΑΤΑ ΔΙΑΙΤΗΤΗ:";
            // 
            // blockData
            // 
            this.blockData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.blockData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blockData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refBlockTeamList});
            this.blockData.Location = new System.Drawing.Point(12, 51);
            this.blockData.MultiSelect = false;
            this.blockData.Name = "blockData";
            this.blockData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.blockData.Size = new System.Drawing.Size(742, 512);
            this.blockData.TabIndex = 16;
            this.blockData.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.blockData_UserDeletingRow);
            // 
            // refBlockTeamList
            // 
            this.refBlockTeamList.HeaderText = "ΟΝΟΜΑ ΑΘΛΗΤΙΚΟΥ ΣΩΜΑΤΕΙΟΥ";
            this.refBlockTeamList.Name = "refBlockTeamList";
            this.refBlockTeamList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.refBlockTeamList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnReturnToEditRefs
            // 
            this.btnReturnToEditRefs.Location = new System.Drawing.Point(646, 596);
            this.btnReturnToEditRefs.Name = "btnReturnToEditRefs";
            this.btnReturnToEditRefs.Size = new System.Drawing.Size(112, 38);
            this.btnReturnToEditRefs.TabIndex = 15;
            this.btnReturnToEditRefs.Text = "ΕΠΙΣΤΡΟΦΗ";
            this.btnReturnToEditRefs.UseVisualStyleBackColor = true;
            this.btnReturnToEditRefs.Click += new System.EventHandler(this.btnReturnToEditRefs_Click);
            // 
            // btnSaveBlocks
            // 
            this.btnSaveBlocks.Location = new System.Drawing.Point(528, 585);
            this.btnSaveBlocks.Name = "btnSaveBlocks";
            this.btnSaveBlocks.Size = new System.Drawing.Size(112, 49);
            this.btnSaveBlocks.TabIndex = 21;
            this.btnSaveBlocks.Text = "ΑΠΟΘΗΚΕΥΣΗ";
            this.btnSaveBlocks.UseVisualStyleBackColor = true;
            this.btnSaveBlocks.Click += new System.EventHandler(this.btnSaveBlocks_Click);
            // 
            // EditRefBlocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 644);
            this.Controls.Add(this.btnSaveBlocks);
            this.Controls.Add(this.blockData);
            this.Controls.Add(this.btnReturnToEditRefs);
            this.Controls.Add(this.labelRefName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditRefBlocks";
            this.Text = "ΤΡΟΠΟΠΟΙΗΣΗ ΜΠΟΚΑΡΙΣΜΑΤΩΝ ΔΙΑΙΤΗΤΗ";
            this.Load += new System.EventHandler(this.RefBlocks_Load);
            this.Shown += new System.EventHandler(this.EditRefBlocks_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.blockData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRefName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView blockData;
        private System.Windows.Forms.Button btnReturnToEditRefs;
        private System.Windows.Forms.DataGridViewComboBoxColumn refBlockTeamList;
        private System.Windows.Forms.Button btnSaveBlocks;
    }
}