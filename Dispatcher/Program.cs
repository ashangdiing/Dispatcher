using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Windows.Forms.Samples
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new Dispatcher.mainForm()); 
           Application.Run(new Dispatcher.Login()); 
          // Application.Run(new Dispatcher.testForm1());
        }
    }
}
