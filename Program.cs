using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolmanagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new student());
            //Application.Run(new teacher());
            // Application.Run(new attendances());
            // Application.Run(new @event());
            //Application.Run(new fees());
            //Application.Run(new dashborad());
            Application.Run(new login());

        }
    }
}
