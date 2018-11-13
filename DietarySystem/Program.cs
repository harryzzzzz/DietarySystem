﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietarySystem
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

            FrmLogin login = new FrmLogin();
            if(login.ShowDialog() == DialogResult.Ignore)
            {
                Application.Run(new frmRegistration());
            }
            else if(login.ShowDialog() == DialogResult.OK)
            {
                //Start app
            }            
        }
    }
}
