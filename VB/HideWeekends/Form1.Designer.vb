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
Namespace TimelineTimeScales

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler4 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 30)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(649, 438)
            Me.schedulerControl1.Start = New System.DateTime(2009, 2, 6, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler4)
            AddHandler Me.schedulerControl1.SelectionChanged, New System.EventHandler(AddressOf Me.schedulerControl1_SelectionChanged)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.checkEdit1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(649, 30)
            Me.panelControl1.TabIndex = 1
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.Location = New System.Drawing.Point(12, 4)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Hide Weekends"
            Me.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style6
            Me.checkEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.checkEdit1.Size = New System.Drawing.Size(103, 22)
            Me.checkEdit1.TabIndex = 0
            AddHandler Me.checkEdit1.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(649, 468)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
    End Class
End Namespace
