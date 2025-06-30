using E_commerce.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commerce
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
            //Application.Run(new frmStore());
            //Application.Run(new frmTest());
            Application.Run(new frmLogin());
            //Application.Run(new frmAddNewProduct());
            //Application.Run(new frm);
        }
    }
}
