<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaiteWin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PROGRESS_BAR = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'PROGRESS_BAR
        '
        Me.PROGRESS_BAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PROGRESS_BAR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PROGRESS_BAR.Location = New System.Drawing.Point(0, 0)
        Me.PROGRESS_BAR.Name = "PROGRESS_BAR"
        Me.PROGRESS_BAR.Size = New System.Drawing.Size(294, 26)
        Me.PROGRESS_BAR.TabIndex = 0
        Me.PROGRESS_BAR.Value = 10
        '
        'WaiteWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(294, 26)
        Me.ControlBox = False
        Me.Controls.Add(Me.PROGRESS_BAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WaiteWin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "WaiteWin"
        Me.TopMost = True
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PROGRESS_BAR As ProgressBar
End Class
