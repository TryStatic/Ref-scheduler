using System;
using System.Linq;
using System.Windows.Forms;
using Referee.Core;
using static Referee.UI.ApplicationEntryPoint;

namespace Referee.UI
{
    public partial class EditFields : Form
    {
        public EditFields()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnEditFieldsReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationEntryPoint aep = new ApplicationEntryPoint();
            aep.ShowDialog();
            this.Close();
        }

        private void EditFields_Load(object sender, EventArgs e)
        {
            ReloadFieldsIntoGrid();
        }

        private void btnSaveFields_Click(object sender, EventArgs e)
        {
            SaveFieldData();
            ReloadFieldsIntoGrid();

            MessageBox.Show(ApplicationData.SaveData()
                ? "ΤΑ ΔΕΔΟΜΕΝΑ ΑΠΟΘΗΚΕΥΤΗΚΑΝ ΜΕ ΕΠΙΤΥΧΙΑ"
                : "ΥΠΗΡΞΕ ΠΡΟΒΛΗΜΑ ΣΤΗΝ ΑΠΟΘΗΚΕΥΣΗ ΤΩΝ ΔΕΔΟΜΕΝΩΝ");
        }

        private void SaveFieldData()
        {
            var newFields = (
                from DataGridViewRow row
                    in fieldData.Rows
                where !row.IsNewRow
                select row.Cells[0].Value.ToString()
                into fieldName
                select new Field { fieldName = fieldName }).ToList();

            ApplicationData.Fields.Clear();

            foreach (var i in newFields)
                ApplicationData.AddField(i);
        }


        private void ReloadFieldsIntoGrid()
        {
            fieldData.Rows.Clear();
            foreach (var field in ApplicationData.Fields)
            {
                var row = (DataGridViewRow)fieldData.Rows[0].Clone();
                row.Cells[0].Value = field.fieldName;
                fieldData.Rows.Add(row);
            }
        }
    }
}
