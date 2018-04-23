Imports Microsoft.VisualBasic
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
		Public Overrides Function Floor(ByVal [date] As DateTime) As DateTime
			Dim start As DateTime = [date].Date
			If start.DayOfWeek = DayOfWeek.Saturday Then
				Return start.AddDays(-1)
			End If
			If start.DayOfWeek = DayOfWeek.Sunday Then
				start.AddDays(-2)
			End If
			Return start
		End Function
		Protected Overrides Function HasNextDate(ByVal [date] As DateTime) As Boolean
			Dim days As Integer = GetNextDayOffset([date].DayOfWeek)
			Return [date] <= DateTime.MaxValue.AddDays(-days)
		End Function
		Public Overrides Function GetNextDate(ByVal [date] As DateTime) As DateTime
			Dim days As Integer = GetNextDayOffset([date].DayOfWeek)
			Return [date].AddDays(days)
		End Function
		Protected Function GetNextDayOffset(ByVal dayOfWeek As DayOfWeek) As Integer
			If dayOfWeek = DayOfWeek.Friday Then
				Return 3
			End If
			If dayOfWeek = DayOfWeek.Saturday Then
				Return 2
			End If
			Return 1
		End Function
	End Class
End Namespace
