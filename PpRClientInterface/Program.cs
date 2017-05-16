using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PpRClientInterface.Forms;

namespace PpRClientInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var Form = new ClientInterface();

            SplashScreen.ShowSplashScreen();

            Application.DoEvents();
            SplashScreen.SetStatus("Loading Client Interface");
            System.Threading.Thread.Sleep(1000);
            SplashScreen.SetStatus("Loading module 1");
            System.Threading.Thread.Sleep(500);
            /*
            SplashScreen.SetStatus("Loading module 2");
            System.Threading.Thread.Sleep(300);
            SplashScreen.SetStatus("Loading module 3");
            System.Threading.Thread.Sleep(900);
            SplashScreen.SetStatus("Loading module 4");
            System.Threading.Thread.Sleep(100);
             * */
            SplashScreen.CloseForm();
            Application.Run(Form);
            


        }
    }
}
