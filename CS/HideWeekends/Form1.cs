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
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Drawing;
using System.Drawing;

namespace TimelineTimeScales {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
         schedulerControl1.OptionsView.FirstDayOfWeek = FirstDayOfWeek.Monday;
            HideWeekends(false);

        }

        private void schedulerControl1_SelectionChanged(object sender, EventArgs e) {
            Text = "Selected interval: " + schedulerControl1.SelectedInterval.ToString();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            CheckEdit editor = sender as CheckEdit;
            HideWeekends(editor.Checked);
        }

        private void HideWeekends(bool hide) {
            TimeScaleCollection scales = schedulerControl1.TimelineView.Scales;
            if(hide) {
                scales.BeginUpdate();
                try {
                    scales.Clear();
                    scales.Add(new TimeScaleMonth());
                    TimeScaleWorkWeekDay customWorkWeekScale = new TimeScaleWorkWeekDay();
                    customWorkWeekScale.Width = 125;
                    scales.Add(customWorkWeekScale);

                }
                finally {
                    scales.EndUpdate();
                }
            }
            else {
                scales.BeginUpdate();
                try {
                    scales.Clear();
                    scales.Add(new TimeScaleMonth());
                    TimeScaleDay dayScale = new TimeScaleDay();
                    dayScale.Width = 125;
                    scales.Add(dayScale);
                }
                finally {
                    scales.EndUpdate();
                }
            }
        
        }
    }
}
