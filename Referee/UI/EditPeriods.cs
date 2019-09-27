using System;
using System.Windows.Forms;

namespace Referee.UI
{
    public partial class EditPeriods : Form
    {
        public EditPeriods()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void EditPeriods_Load(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            var er = new ApplicationEntryPoint();
            er.ShowDialog();
            Close();
        }
    }
}