using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Referee.UI.ApplicationEntryPoint;
using Referee = Referee.Core.Referee;

namespace Referee.UI
{
    public partial class EditReferees : Form
    {
        public static EditRefBlocks editRefBlocksPage;
        public static EditReferees editReferees;

        public EditReferees()
        {
            InitializeComponent();
            this.CenterToParent();
            editRefBlocksPage = new EditRefBlocks();
            editReferees = this;
        }


        // Click Edit Ref Blocks
        private void btnEditRefBlocks_Click(object sender, EventArgs e)
        {
            if (RefereeData.SelectedRows.Count != 1 || RefereeData.SelectedCells.Count != 1)
                return;


            SaveRefereeData();
            EditRefBlocks.SelectedRefName = RefereeData.SelectedCells[0].Value.ToString();
            editRefBlocksPage.ShowDialog();


        }

        // Click ReturnToEntryPoint
        private void btnReturnToEntryPoint_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaveRefereeData();
            new ApplicationEntryPoint().ShowDialog();
            this.Close();
        }

        // EditReferee page loaded
        private void EditReferees_Load(object sender, EventArgs e)
        {
            ReloadRefereeData();

        }

        // Save Referees Button clicked.
        private void btnSaveReferees_Click(object sender, EventArgs e)
        {
            SaveRefereeData();
            ReloadRefereeData();

        }

        // Custom: Save referee data
        public void SaveRefereeData()
        {

            // For each row in the grid
            foreach (DataGridViewRow row in RefereeData.Rows)
            {
                // skip new entry row
                if (row.IsNewRow) continue;

                // Get the Referee written in the grid
                string tRefName = row.Cells[0].Value.ToString();

                // Check if he is already in the database
                bool found = false;
                foreach (var j in ApplicationData.Refs)
                    // Found in File Database
                    if (j.name == tRefName)
                        found = true;
                
                // We found them in the database therefore he exists so go to the next grid entry
                if (found) continue;

                // He's not in, so add him.
                ApplicationData.AddRef(new Core.Referee { name = tRefName });
            }

            ApplicationData.SaveData();
        }


        private void ReloadRefereeData()
        {
            RefereeData.Rows.Clear();
            foreach (var i in ApplicationData.Refs)
            {
                DataGridViewRow row = (DataGridViewRow)RefereeData.Rows[0].Clone();
                row.Cells[0].Value = i.name;
                RefereeData.Rows.Add(row);
            }
        }

        private void RefereeData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string name = RefereeData.SelectedRows[0].Cells[0].Value.ToString();
            foreach (var i in ApplicationData.Refs)
            {
                if (i.name == name)
                {
                    ApplicationData.Refs.Remove(i);
                    break;
                }
            }
            ApplicationData.SaveData();
        }
    }
}
