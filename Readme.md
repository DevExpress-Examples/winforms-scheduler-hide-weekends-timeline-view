<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128635168/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1214)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Scheduler - Hide weekends (Timeline View)

This example uses a custom scale (`TimeScaleWorkWeekDay`) to hide weekends. The `TimeScaleWorkWeekDay` class inherits base functionality from the `TimeScaleDay` class and overrides the `IsDateVisible` method:

```csharp
public class TimeScaleWorkWeekDay : TimeScaleDay {
    protected override string DefaultDisplayFormat { get { return "d ddd"; } }
    protected override string DefaultMenuCaption { get { return "WorkWeek"; } }
    public override bool IsDateVisible(DateTime date) {
        return date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday;
    }
}
```

The following code hides/shows weekends:

```csharp
private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
    CheckEdit editor = sender as CheckEdit;
    HideWeekends(editor.Checked);
}
private void HideWeekends(bool hide) {
    TimeScaleCollection scales = schedulerControl1.TimelineView.Scales;
    if (hide) {
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
```


## Files to Review

* [CustomTimeScale.cs](./CS/HideWeekends/CustomTimeScale.cs) (VB: [CustomTimeScale.vb](./VB/HideWeekends/CustomTimeScale.vb))
* [Form1.cs](./CS/HideWeekends/Form1.cs) (VB: [Form1.vb](./VB/HideWeekends/Form1.vb))


## Documentation

* [Time Scales - WinForms Scheduler](https://docs.devexpress.com/WindowsForms/3303/controls-and-libraries/scheduler/visual-elements/scheduler-control/time-scales#custom-scales)

