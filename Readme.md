<!-- default file list -->
*Files to look at*:

* [CustomTimeScale.cs](./CS/HideWeekends/CustomTimeScale.cs) (VB: [CustomTimeScale.vb](./VB/HideWeekends/CustomTimeScale.vb))
* [Form1.cs](./CS/HideWeekends/Form1.cs) (VB: [Form1.vb](./VB/HideWeekends/Form1.vb))
<!-- default file list end -->
# How to hide weekends in the Timeline view


<p>This example illustrates the use of a custom scale to hide the weekends in the Timeline view. </p><p>The Saturday and Sunday are considered weekend. The Friday column actually contains three days - Friday, Saturday and Sunday. So it is painted with the color specified for the non-working days. To correct this, the CustomDrawTimeCell event can be handled and the time cell can be painted manually. The Paint Correction check box is used for switching the event handling on and off.</p>

<br/>


