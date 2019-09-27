using System;
using System.Linq;
using System.Windows.Forms;
using Referee.Core;
using static Referee.UI.ApplicationEntryPoint;

namespace Referee.UI
{
    public partial class EditRefWatch : Form
    {
        public EditRefWatch()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnReturnToEntryPoint_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationEntryPoint aep = new ApplicationEntryPoint();
            aep.ShowDialog();
            this.Close();
        }

        private void EditRefWatch_Load(object sender, EventArgs e)
        {
            ReloadRefWatchIntoGrid();
        }

        private void ReloadRefWatchIntoGrid()
        {
            WatchRefData.Rows.Clear();
            foreach (var watchref in ApplicationData.WatchRefs)
            {
                var row = (DataGridViewRow)WatchRefData.Rows[0].Clone();
                row.Cells[0].Value = watchref.name;
                WatchRefData.Rows.Add(row);
            }
        }

        private void btnSaveRefWatch_Click(object sender, EventArgs e)
        {
            SaveWatchRefData();
            ReloadRefWatchIntoGrid();

            MessageBox.Show(ApplicationData.SaveData()
                ? "ΤΑ ΔΕΔΟΜΕΝΑ ΑΠΟΘΗΚΕΥΤΗΚΑΝ ΜΕ ΕΠΙΤΥΧΙΑ"
                : "ΥΠΗΡΞΕ ΠΡΟΒΛΗΜΑ ΣΤΗΝ ΑΠΟΘΗΚΕΥΣΗ ΤΩΝ ΔΕΔΟΜΕΝΩΝ");
        }

        private void SaveWatchRefData()
        {
            var newWatchRefs = (
                from DataGridViewRow row
                    in WatchRefData.Rows
                where !row.IsNewRow
                select row.Cells[0].Value.ToString()
                into watchRefNewName
                select new WatchRef { name = watchRefNewName }).ToList();

            ApplicationData.WatchRefs.Clear();

            foreach (var i in newWatchRefs)
                ApplicationData.AddWatchRef(i);
        }
    }
}
