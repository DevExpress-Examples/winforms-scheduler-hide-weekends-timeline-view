// Developer Express Code Central Example:
// How to hide weekends in the Timeline view
// 
// This example illustrates the use of a custom scale to hide the weekends in the
// Timeline view. The Saturday and Sunday are considered weekend. The Friday column
// actually contains three days - Friday, Saturday and Sunday. So it is painted
// with the color specified for the non-working days. To correct this, the
// CustomDrawTimeCell event can be handled and the time cell can be painted
// manually. The Paint Correction check box is used for switching the event
// handling on and off.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1214

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TimelineTimeScales
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
            Application.Run(new Form1());
        }
    }
}