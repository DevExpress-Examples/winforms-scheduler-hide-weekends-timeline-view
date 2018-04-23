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
Imports System.Windows.Forms

Namespace TimelineTimeScales
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace