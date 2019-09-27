using System;
using System.Linq;
using System.Windows.Forms;
using Referee.Core;
using static Referee.UI.ApplicationEntryPoint;

namespace Referee.UI
{
    public partial class EditTeams : Form
    {
        public EditTeams()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ApplicationEntryPoint().ShowDialog();
            this.Close();
        }

        private void EditTeams_Load(object sender, EventArgs e)
        {
            ReloadTeamsIntoGrid();
        }

        private void btnSaveTeams_Click(object sender, EventArgs e)
        {
            SaveTeamData();
            ReloadTeamsIntoGrid();

            MessageBox.Show(ApplicationData.SaveData()
                ? "ΤΑ ΔΕΔΟΜΕΝΑ ΑΠΟΘΗΚΕΥΤΗΚΑΝ ΜΕ ΕΠΙΤΥΧΙΑ"
                : "ΥΠΗΡΞΕ ΠΡΟΒΛΗΜΑ ΣΤΗΝ ΑΠΟΘΗΚΕΥΣΗ ΤΩΝ ΔΕΔΟΜΕΝΩΝ");
        }

        private void SaveTeamData()
        {
            var newTeams = (
                from DataGridViewRow row
                    in teamData.Rows
                where !row.IsNewRow
                select row.Cells[0].Value.ToString()
                into teamName
                select new Team { teamName = teamName }).ToList();

            ApplicationData.Teams.Clear();

            foreach (var i in newTeams)
                ApplicationData.AddTeam(i);
        }

        private void ReloadTeamsIntoGrid()
        {
            teamData.Rows.Clear();
            foreach (var team in ApplicationData.Teams)
            {
                var row = (DataGridViewRow)teamData.Rows[0].Clone();
                row.Cells[0].Value = team.teamName;
                teamData.Rows.Add(row);
            }
        }
    }
}
