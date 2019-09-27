namespace Referee.UI
{
    partial class EditRefWatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRefWatch));
            this.WatchRefData = new System.Windows.Forms.DataGridView();
            this.btnReturnToEntryPoint = new System.Windows.Forms.Button();
            this.btnSaveRefWatch = new System.Windows.Forms.Button();
            this.gvRefWatchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WatchRefData)).BeginInit();
            this.SuspendLayout();
            // 
            // WatchRefData
            // 
            this.WatchRefData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WatchRefData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.WatchRefData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WatchRefData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvRefWatchName});
            this.WatchRefData.Location = new System.Drawing.Point(12, 12);
            this.WatchRefData.MultiSelect = false;
            this.WatchRefData.Name = "WatchRefData";
            this.WatchRefData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WatchRefData.Size = new System.Drawing.Size(742, 512);
            this.WatchRefData.TabIndex = 11;
            // 
            // btnReturnToEntryPoint
            // 
            this.btnReturnToEntryPoint.Location = new System.Drawing.Point(642, 549);
            this.btnReturnToEntryPoint.Name = "btnReturnToEntryPoint";
            this.btnReturnToEntryPoint.Size = new System.Drawing.Size(112, 38);
            this.btnReturnToEntryPoint.TabIndex = 21;
            this.btnReturnToEntryPoint.Text = "ΕΠΙΣΤΡΟΦΗ";
            this.btnReturnToEntryPoint.UseVisualStyleBackColor = true;
            this.btnReturnToEntryPoint.Click += new System.EventHandler(this.btnReturnToEntryPoint_Click);
            // 
            // btnSaveRefWatch
            // 
            this.btnSaveRefWatch.Location = new System.Drawing.Point(524, 538);
            this.btnSaveRefWatch.Name = "btnSaveRefWatch";
            this.btnSaveRefWatch.Size = new System.Drawing.Size(112, 49);
            this.btnSaveRefWatch.TabIndex = 23;
            this.btnSaveRefWatch.Text = "ΑΠΟΘΗΚΕΥΣΗ ΠΑΡΑΤΗΡΗΤΩΝ";
            this.btnSaveRefWatch.UseVisualStyleBackColor = true;
            this.btnSaveRefWatch.Click += new System.EventHandler(this.btnSaveRefWatch_Click);
            // 
            // gvRefWatchName
            // 
            this.gvRefWatchName.HeaderText = "ΟΝΟΜΑΤΕΠΩΝΥΜΟ ΠΑΡΑΤΗΡΗΤΗ";
            this.gvRefWatchName.Name = "gvRefWatchName";
            // 
            // EditRefWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 599);
            this.Controls.Add(this.btnSaveRefWatch);
            this.Controls.Add(this.btnReturnToEntryPoint);
            this.Controls.Add(this.WatchRefData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditRefWatch";
            this.Text = "ΤΡΟΠΟΠΟΙΗΣΗ ΠΑΡΑΤΗΡΗΤΩΝ ΔΙΑΙΤΗΣΙΑΣ";
            this.Load += new System.EventHandler(this.EditRefWatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WatchRefData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView WatchRefData;
        private System.Windows.Forms.Button btnReturnToEntryPoint;
        private System.Windows.Forms.Button btnSaveRefWatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvRefWatchName;
    }
}