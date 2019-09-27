using System;
using System.Windows.Forms;

namespace Referee.UI
{
    public partial class EditPeriods : Form
    {
        public EditPeriods()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void EditPeriods_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationEntryPoint er = new ApplicationEntryPoint();
            er.ShowDialog();
            this.Close();
        }
    }
}
