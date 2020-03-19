using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_BerkayGürbüz
{
    static class Program
    {
        /// Date: 20.02.2020
        /// created by Berkay Gürbüz
        /// Calculator example
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
