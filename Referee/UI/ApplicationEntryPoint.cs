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

            this.CenterToScreen();

        }

        private void btn_editTeams_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditTeams().ShowDialog();
            this.Close();
        }

        private void btn_editReferee_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditReferees().ShowDialog();
            this.Close();
        }

        private void btn_editPeriods_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditPeriods().ShowDialog();
            this.Close();
        }

        private void btn_switchRefereeAssignment(object sender, EventArgs e)
        {
            if (cbAgonistikiPeriodos.SelectedItem == null)
            {
                MessageBox.Show("Το πεδίο της ΑΓΩΝΙΣΤΙΚΗΣ ΠΕΡΙΟΔΟΥ δεν μπορεί να είναι κενό", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbDiorganwsi.SelectedItem == null)

            {
                MessageBox.Show("Το πεδίο της ΔΙΟΡΓΑΝΩΣΗΣ δεν μπορεί να είναι κενό", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbAgwnistiki.SelectedItem == null)
            {
                MessageBox.Show("Το πεδίο της ΑΓΩΝΙΣΤΙΚΗΣ δεν μπορεί να είναι κενό", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            period = cbAgonistikiPeriodos.Text;
            organization = cbDiorganwsi.Text;
            agwnistiki = cbAgwnistiki.Text;

            this.Hide();
            RefereeAssignment ep = new RefereeAssignment();
            ep.ShowDialog();
            this.Close();
        }

        private void btnEditFields_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditFields().ShowDialog();
            this.Close();
        }
        
        private void editRefWatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditRefWatch().ShowDialog();
            this.Close();
        }
    }
}
