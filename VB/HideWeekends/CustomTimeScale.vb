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
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Native

Namespace TimelineTimeScales

    Public Class TimeScaleWorkWeekDay
        Inherits TimeScale

        Protected Overrides ReadOnly Property DefaultDisplayFormat() As String
            Get
                Return "d ddd"
            End Get
        End Property
        Protected Overrides ReadOnly Property DefaultMenuCaption() As String
            Get
                Return "WorkWeek"
            End Get
        End Property

        Protected Overrides ReadOnly Property SortingWeight() As TimeSpan
            Get
                Return TimeSpan.FromDays(1.1)
            End Get
        End Property
        Public Overrides Function Floor(ByVal [date] As Date) As Date
            Dim start As Date = [date].Date
            If start.DayOfWeek = DayOfWeek.Saturday Then
                Return start.AddDays(-1)
            End If
            If start.DayOfWeek = DayOfWeek.Sunday Then
                Return start.AddDays(-2)
            End If
            Return start
        End Function
        Protected Overrides Function HasNextDate(ByVal [date] As Date) As Boolean
            Dim days As Integer = GetNextDayOffset([date].DayOfWeek)
            Return [date] <= Date.MaxValue.AddDays(-days)
        End Function
        Public Overrides Function GetNextDate(ByVal [date] As Date) As Date
            Dim days As Integer = GetNextDayOffset([date].DayOfWeek)
            Return [date].AddDays(days)
        End Function
        Protected Function GetNextDayOffset(ByVal dayOfWeek As DayOfWeek) As Integer
            If dayOfWeek = System.DayOfWeek.Friday Then
                Return 3
            End If
            If dayOfWeek = System.DayOfWeek.Saturday Then
                Return 2
            End If
            Return 1
        End Function
    End Class
End Namespace
