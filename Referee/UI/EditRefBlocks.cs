using System;
using System.Windows.Forms;
using Referee.Core;
using static Referee.UI.ApplicationEntryPoint;

namespace Referee.UI
{
    public partial class EditRefBlocks : Form
    {
        public static string SelectedRefName;
        public static Core.Referee SelectedReferee;

        public EditRefBlocks()
        {
            InitializeComponent();
            foreach (var i in ApplicationData.Teams) refBlockTeamList.Items.Add(i.teamName);

            //this.CenterToParent();
        }

        private void RefBlocks_Load(object sender, EventArgs e)
        {
        }

        // RETURN TO EDIT REF PAGE
        private void btnReturnToEditRefs_Click(object sender, EventArgs e)
        {
            Hide();
            EditReferees.editRefBlocksPage.Show();
            Close();
        }

        private void EditRefBlocks_Shown(object sender, EventArgs e)
        {
            labelRefName.Text = SelectedRefName;
            SelectedReferee = GetSelectedRefereeAddress();
            if (SelectedReferee == null) MessageBox.Show("Error-13");
            ReloadBlockData();
        }

        private Core.Referee GetSelectedRefereeAddress()
        {
            // For each Referee
            foreach (var i in ApplicationData.Refs)
                // If his name matches ours
                if (i.name == SelectedRefName)
                    return i;

            return null;
        }

        private void btnSaveBlocks_Click(object sender, EventArgs e)
        {
            SaveBlockData();
        }


        private void SaveBlockData()
        {
            foreach (DataGridViewRow row in blockData.Rows)
            {
                if (row.IsNewRow) continue;

                var tBlockTeam = row.Cells[0].Value.ToString();

                var found = false;
                foreach (var j in SelectedReferee.blocks)
                    if (j.teamName == tBlockTeam)
                        found = true;

                if (found) continue;

                SelectedReferee.blocks.Add(new Team {teamName = tBlockTeam});
            }

            ApplicationData.SaveData();
        }

        private void blockData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var blockTeamName = blockData.SelectedRows[0].Cells[0].Value.ToString();
            foreach (var i in SelectedReferee.blocks)
                if (i.teamName == blockTeamName)
                {
                    SelectedReferee.blocks.Remove(i);
                    break;
                }

            ApplicationData.SaveData();
        }

        private void ReloadBlockData()
        {
            blockData.Rows.Clear();

            foreach (var j in SelectedReferee.blocks)
            {
                var row = (DataGridViewRow) blockData.Rows[0].Clone();
                row.Cells[0].Value = j.teamName;
                blockData.Rows.Add(row);
            }
        }

        private void labelRefName_Click(object sender, EventArgs e)
        {
        }
    }
}