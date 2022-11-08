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
Imports DevExpress.XtraScheduler

Namespace TimelineTimeScales

    Public Class TimeScaleWorkWeekDay
        Inherits TimeScaleDay

        Protected Overrides ReadOnly Property DefaultDisplayFormat As String
            Get
                Return "d ddd"
            End Get
        End Property

        Protected Overrides ReadOnly Property DefaultMenuCaption As String
            Get
                Return "WorkWeek"
            End Get
        End Property

        Public Overrides Function IsDateVisible(ByVal [date] As Date) As Boolean
            Return [date].DayOfWeek <> DayOfWeek.Sunday AndAlso [date].DayOfWeek <> DayOfWeek.Saturday
        End Function
    End Class
End Namespace
