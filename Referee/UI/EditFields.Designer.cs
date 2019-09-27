namespace Referee.UI
{
    partial class EditFields
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFields));
            this.fieldData = new System.Windows.Forms.DataGridView();
            this.gvTeamStadium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveFields = new System.Windows.Forms.Button();
            this.btnEditFieldsReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fieldData)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldData
            // 
            this.fieldData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fieldData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fieldData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvTeamStadium});
            this.fieldData.Location = new System.Drawing.Point(12, 12);
            this.fieldData.MultiSelect = false;
            this.fieldData.Name = "fieldData";
            this.fieldData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fieldData.Size = new System.Drawing.Size(742, 512);
            this.fieldData.TabIndex = 10;
            // 
            // gvTeamStadium
            // 
            this.gvTeamStadium.HeaderText = "ΟΝΟΜΑ ΓΗΠΕΔΟΥ";
            this.gvTeamStadium.Name = "gvTeamStadium";
            // 
            // btnSaveFields
            // 
            this.btnSaveFields.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveFields.Location = new System.Drawing.Point(524, 538);
            this.btnSaveFields.Name = "btnSaveFields";
            this.btnSaveFields.Size = new System.Drawing.Size(112, 49);
            this.btnSaveFields.TabIndex = 16;
            this.btnSaveFields.Text = "ΑΠΘΗΚΕΥΣΗ ΓΗΠΕΔΩΝ";
            this.btnSaveFields.UseVisualStyleBackColor = false;
            this.btnSaveFields.Click += new System.EventHandler(this.btnSaveFields_Click);
            // 
            // btnEditFieldsReturn
            // 
            this.btnEditFieldsReturn.Location = new System.Drawing.Point(642, 549);
            this.btnEditFieldsReturn.Name = "btnEditFieldsReturn";
            this.btnEditFieldsReturn.Size = new System.Drawing.Size(112, 38);
            this.btnEditFieldsReturn.TabIndex = 15;
            this.btnEditFieldsReturn.Text = "ΕΠΙΣΤΡΟΦΗ";
            this.btnEditFieldsReturn.UseVisualStyleBackColor = true;
            this.btnEditFieldsReturn.Click += new System.EventHandler(this.btnEditFieldsReturn_Click);
            // 
            // EditFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 599);
            this.Controls.Add(this.btnSaveFields);
            this.Controls.Add(this.btnEditFieldsReturn);
            this.Controls.Add(this.fieldData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditFields";
            this.Text = "ΤΡΟΠΟΠΟΙΗΣΗ ΓΗΠΕΔΩΝ";
            this.Load += new System.EventHandler(this.EditFields_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fieldData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fieldData;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvTeamStadium;
        private System.Windows.Forms.Button btnSaveFields;
        private System.Windows.Forms.Button btnEditFieldsReturn;
    }
}