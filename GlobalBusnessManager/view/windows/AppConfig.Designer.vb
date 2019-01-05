<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppConfig
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
        Dim CMB_PROTOCOL As System.Windows.Forms.ComboBox
        Me.BT_CLOSE = New System.Windows.Forms.Button()
        Me.BT_VALIDER = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PORT_NAME = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMB_SERVER_TYPE = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SERVER_NAME = New System.Windows.Forms.TextBox()
        CMB_PROTOCOL = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMB_PROTOCOL
        '
        CMB_PROTOCOL.Location = New System.Drawing.Point(139, 113)
        CMB_PROTOCOL.Name = "CMB_PROTOCOL"
        CMB_PROTOCOL.Size = New System.Drawing.Size(163, 21)
        CMB_PROTOCOL.TabIndex = 3
        '
        'BT_CLOSE
        '
        Me.BT_CLOSE.BackColor = System.Drawing.Color.Red
        Me.BT_CLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CLOSE.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BT_CLOSE.Location = New System.Drawing.Point(769, -1)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.Size = New System.Drawing.Size(31, 31)
        Me.BT_CLOSE.TabIndex = 0
        Me.BT_CLOSE.Text = "X"
        Me.BT_CLOSE.UseVisualStyleBackColor = False
        '
        'BT_VALIDER
        '
        Me.BT_VALIDER.Location = New System.Drawing.Point(730, 379)
        Me.BT_VALIDER.Name = "BT_VALIDER"
        Me.BT_VALIDER.Size = New System.Drawing.Size(64, 29)
        Me.BT_VALIDER.TabIndex = 1
        Me.BT_VALIDER.Text = "VALIDER"
        Me.BT_VALIDER.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Configuration de Beeshop Global Manager APP 3.0.01"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BT_VALIDER)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 414)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PORT_NAME)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(CMB_PROTOCOL)
        Me.GroupBox2.Controls.Add(Me.CMB_SERVER_TYPE)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.SERVER_NAME)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 156)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Host config"
        '
        'PORT_NAME
        '
        Me.PORT_NAME.Location = New System.Drawing.Point(241, 34)
        Me.PORT_NAME.Name = "PORT_NAME"
        Me.PORT_NAME.Size = New System.Drawing.Size(61, 20)
        Me.PORT_NAME.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Protocol"
        '
        'CMB_SERVER_TYPE
        '
        Me.CMB_SERVER_TYPE.FormattingEnabled = True
        Me.CMB_SERVER_TYPE.Items.AddRange(New Object() {"apache-server", "localhost", "online-host"})
        Me.CMB_SERVER_TYPE.Location = New System.Drawing.Point(139, 69)
        Me.CMB_SERVER_TYPE.Name = "CMB_SERVER_TYPE"
        Me.CMB_SERVER_TYPE.Size = New System.Drawing.Size(163, 21)
        Me.CMB_SERVER_TYPE.Sorted = True
        Me.CMB_SERVER_TYPE.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Serveur name / Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Type of serveur"
        '
        'SERVER_NAME
        '
        Me.SERVER_NAME.Location = New System.Drawing.Point(139, 34)
        Me.SERVER_NAME.Name = "SERVER_NAME"
        Me.SERVER_NAME.Size = New System.Drawing.Size(96, 20)
        Me.SERVER_NAME.TabIndex = 0
        '
        'AppConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_CLOSE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AppConfig"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppConfig"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_CLOSE As Button
    Friend WithEvents BT_VALIDER As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PORT_NAME As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CMB_SERVER_TYPE As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SERVER_NAME As TextBox
End Class
