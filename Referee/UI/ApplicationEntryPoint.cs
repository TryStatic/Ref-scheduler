using System;
using System.Windows.Forms;
using Referee.Core;

namespace Referee.UI
{
    public partial class ApplicationEntryPoint : Form
    {
        public static DataBank ApplicationData;

        public static string period;
        public static string organization;
        public static string agwnistiki;

        public ApplicationEntryPoint()
        {
            InitializeComponent();
            ApplicationData = DataBank.LoadData();
            if (ApplicationData == null)
            {
                ApplicationData = new DataBank();
                ApplicationData.SaveData();
            }
        }

        private void ApplicationEntryPoint_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(period))
                cbAgonistikiPeriodos.Text = period;

            if (!string.IsNullOrWhiteSpace(organization))
                cbDiorganwsi.Text = organization;

            if (!string.IsNullOrWhiteSpace(agwnistiki))
                cbAgwnistiki.Text = agwnistiki;

            CenterToScreen();
        }

        private void btn_editTeams_Click(object sender, EventArgs e)
        {
            Hide();
            new EditTeams().ShowDialog();
            Close();
        }

        private void btn_editReferee_Click(object sender, EventArgs e)
        {
            Hide();
            new EditReferees().ShowDialog();
            Close();
        }

        private void btn_editPeriods_Click(object sender, EventArgs e)
        {
            Hide();
            new EditPeriods().ShowDialog();
            Close();
        }

        private void btn_switchRefereeAssignment(object sender, EventArgs e)
        {
            if (cbAgonistikiPeriodos.SelectedItem == null)
            {
                MessageBox.Show("Το πεδίο της ΑΓΩΝΙΣΤΙΚΗΣ ΠΕΡΙΟΔΟΥ δεν μπορεί να είναι κενό", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbDiorganwsi.SelectedItem == null)

            {
                MessageBox.Show("Το πεδίο της ΔΙΟΡΓΑΝΩΣΗΣ δεν μπορεί να είναι κενό", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (cbAgwnistiki.SelectedItem == null)
            {
                MessageBox.Show("Το πεδίο της ΑΓΩΝΙΣΤΙΚΗΣ δεν μπορεί να είναι κενό", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            period = cbAgonistikiPeriodos.Text;
            organization = cbDiorganwsi.Text;
            agwnistiki = cbAgwnistiki.Text;

            Hide();
            var ep = new RefereeAssignment();
            ep.ShowDialog();
            Close();
        }

        private void btnEditFields_Click(object sender, EventArgs e)
        {
            Hide();
            new EditFields().ShowDialog();
            Close();
        }

        private void editRefWatch_Click(object sender, EventArgs e)
        {
            Hide();
            new EditRefWatch().ShowDialog();
            Close();
        }
    }
}