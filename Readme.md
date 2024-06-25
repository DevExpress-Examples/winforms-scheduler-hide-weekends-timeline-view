<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128635168/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1214)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomTimeScale.cs](./CS/HideWeekends/CustomTimeScale.cs) (VB: [CustomTimeScale.vb](./VB/HideWeekends/CustomTimeScale.vb))
* [Form1.cs](./CS/HideWeekends/Form1.cs) (VB: [Form1.vb](./VB/HideWeekends/Form1.vb))
<!-- default file list end -->
# How to hide weekends in the Timeline view


<p>This example illustrates the use of a custom scale to hide the weekends in the Timeline view. </p><p>The Saturday and Sunday are considered weekend. The Friday column actually contains three days - Friday, Saturday and Sunday. So it is painted with the color specified for the non-working days. To correct this, the CustomDrawTimeCell event can be handled and the time cell can be painted manually. The Paint Correction check box is used for switching the event handling on and off.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-scheduler-hide-weekends-timeline-view&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-scheduler-hide-weekends-timeline-view&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
