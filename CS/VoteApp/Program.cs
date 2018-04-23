using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.VoteApp {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WindowsFormsSettings.SetDPIAware(); 
            DevExpress.Skins.SkinManager.EnableFormSkins();
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch;
            Application.Run(new Map());
        }
    }
}
