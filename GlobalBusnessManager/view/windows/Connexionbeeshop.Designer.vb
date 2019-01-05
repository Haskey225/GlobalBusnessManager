<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConnexionBeeshop
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
        Me.BT_CONNEXION = New System.Windows.Forms.Button()
        Me.BT_ANNULER = New System.Windows.Forms.Button()
        Me.LOGING = New System.Windows.Forms.TextBox()
        Me.PASSWORD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BT_CONNEXION
        '
        Me.BT_CONNEXION.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BT_CONNEXION.Location = New System.Drawing.Point(211, 88)
        Me.BT_CONNEXION.Name = "BT_CONNEXION"
        Me.BT_CONNEXION.Size = New System.Drawing.Size(75, 23)
        Me.BT_CONNEXION.TabIndex = 0
        Me.BT_CONNEXION.Text = "Connexion"
        Me.BT_CONNEXION.UseVisualStyleBackColor = True
        '
        'BT_ANNULER
        '
        Me.BT_ANNULER.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BT_ANNULER.Location = New System.Drawing.Point(130, 88)
        Me.BT_ANNULER.Name = "BT_ANNULER"
        Me.BT_ANNULER.Size = New System.Drawing.Size(75, 23)
        Me.BT_ANNULER.TabIndex = 1
        Me.BT_ANNULER.Text = "Annuler"
        Me.BT_ANNULER.UseVisualStyleBackColor = True
        '
        'LOGING
        '
        Me.LOGING.Location = New System.Drawing.Point(99, 12)
        Me.LOGING.Name = "LOGING"
        Me.LOGING.Size = New System.Drawing.Size(175, 20)
        Me.LOGING.TabIndex = 1
        '
        'PASSWORD
        '
        Me.PASSWORD.Location = New System.Drawing.Point(99, 47)
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.Size = New System.Drawing.Size(175, 20)
        Me.PASSWORD.TabIndex = 2
        Me.PASSWORD.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nom d'utilisateur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mot de passe :"
        '
        'ConnexionBeeshop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 116)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PASSWORD)
        Me.Controls.Add(Me.LOGING)
        Me.Controls.Add(Me.BT_ANNULER)
        Me.Controls.Add(Me.BT_CONNEXION)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConnexionBeeshop"
        Me.Opacity = 0.9R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Connexion Besshop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_CONNEXION As Button
    Friend WithEvents BT_ANNULER As Button
    Friend WithEvents LOGING As TextBox
    Friend WithEvents PASSWORD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
