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
using System.Text;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Native;

namespace TimelineTimeScales {

    public class TimeScaleWorkWeekDay : TimeScale {
        protected override string DefaultDisplayFormat { get { return "d ddd"; } }
        protected override string DefaultMenuCaption { get { return "WorkWeek"; } }

        protected override TimeSpan SortingWeight {
            get { return TimeSpan.FromDays(1.1); }
        }
        public override DateTime Floor(DateTime date) {
            DateTime start = date.Date;
            if(start.DayOfWeek == DayOfWeek.Saturday)
                return start.AddDays(-1);
            if(start.DayOfWeek == DayOfWeek.Sunday)
                return start.AddDays(-2);
            return start;
        }
        protected override bool HasNextDate(DateTime date) {
            int days = GetNextDayOffset(date.DayOfWeek);
            return date <= DateTime.MaxValue.AddDays(-days);
        }
        public override DateTime GetNextDate(DateTime date) {
            int days = GetNextDayOffset(date.DayOfWeek);
            return date.AddDays(days);
        }
        protected int GetNextDayOffset(DayOfWeek dayOfWeek) {
            if(dayOfWeek == DayOfWeek.Friday)
                return 3;
            if(dayOfWeek == DayOfWeek.Saturday)
                return 2;
            return 1;
        }
    }
}
