﻿using System;
using System.Windows.Forms;

namespace HW2
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
            //Show first form and start the message loop
            new Form1().Show();
            Application.Run(); // needed, otherwise app closes immediately
        }
    }
}
