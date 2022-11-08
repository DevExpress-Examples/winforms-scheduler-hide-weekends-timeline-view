' Developer Express Code Central Example:
' How to hide weekends in the Timeline view
' 
' This example illustrates the use of a custom scale to hide the weekends in the
' Timeline view. The Saturday and Sunday are considered weekend. The Friday column
' actually contains three days - Friday, Saturday and Sunday. So it is painted
' with the color specified for the non-working days. To correct this, the
' CustomDrawTimeCell event can be handled and the time cell can be painted
' manually. The Paint Correction check box is used for switching the event
' handling on and off.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1214
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.Drawing
Imports System.Drawing

Namespace TimelineTimeScales

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            schedulerControl1.OptionsView.FirstDayOfWeek = FirstDayOfWeek.Monday
            HideWeekends(False)
        End Sub

        Private Sub schedulerControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            Text = "Selected interval: " & schedulerControl1.SelectedInterval.ToString()
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim editor As CheckEdit = TryCast(sender, CheckEdit)
            HideWeekends(editor.Checked)
        End Sub

        Private Sub HideWeekends(ByVal hide As Boolean)
            Dim scales As TimeScaleCollection = schedulerControl1.TimelineView.Scales
            If hide Then
                scales.BeginUpdate()
                Try
                    scales.Clear()
                    scales.Add(New TimeScaleMonth())
                    Dim customWorkWeekScale As TimeScaleWorkWeekDay = New TimeScaleWorkWeekDay()
                    customWorkWeekScale.Width = 125
                    scales.Add(customWorkWeekScale)
                Finally
                    scales.EndUpdate()
                End Try
            Else
                scales.BeginUpdate()
                Try
                    scales.Clear()
                    scales.Add(New TimeScaleMonth())
                    Dim dayScale As TimeScaleDay = New TimeScaleDay()
                    dayScale.Width = 125
                    scales.Add(dayScale)
                Finally
                    scales.EndUpdate()
                End Try
            End If
        End Sub
    End Class
End Namespace
