using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using myIS.Model;
using myIS.Controler;

namespace myIS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            controler c = new controler();
            c.startApp();
            
        }
    }
}
