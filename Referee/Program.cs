using System;
using System.Threading;
using System.Windows.Forms;
using Referee.UI;

namespace Referee
{
    static class Program
    {
        private static string appGuid = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b9";

        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Η ΕΦΑΡΜΟΓΗ ΕΙΝΑΙ ΗΔΗ ΑΝΟΙΧΤΗ.");
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ApplicationEntryPoint());
            }
        }
    }
}
