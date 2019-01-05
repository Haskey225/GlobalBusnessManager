<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajouter_une_commande
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BT_OK = New System.Windows.Forms.Button()
        Me.BT_CANCEL = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CLIENT_NAME_TEXT_BOX = New System.Windows.Forms.TextBox()
        Me.CLIENT_CONTACT_TEXT_BOX = New System.Windows.Forms.TextBox()
        Me.CLIENT_ADRESSE_TEXT_BOX = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CLIENT_ADRESSE_TEXT_BOX)
        Me.GroupBox1.Controls.Add(Me.CLIENT_CONTACT_TEXT_BOX)
        Me.GroupBox1.Controls.Add(Me.CLIENT_NAME_TEXT_BOX)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information client"
        '
        'BT_OK
        '
        Me.BT_OK.Location = New System.Drawing.Point(637, 415)
        Me.BT_OK.Name = "BT_OK"
        Me.BT_OK.Size = New System.Drawing.Size(68, 23)
        Me.BT_OK.TabIndex = 1
        Me.BT_OK.Text = "OK"
        Me.BT_OK.UseVisualStyleBackColor = True
        '
        'BT_CANCEL
        '
        Me.BT_CANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BT_CANCEL.Location = New System.Drawing.Point(723, 415)
        Me.BT_CANCEL.Name = "BT_CANCEL"
        Me.BT_CANCEL.Size = New System.Drawing.Size(68, 23)
        Me.BT_CANCEL.TabIndex = 2
        Me.BT_CANCEL.Text = "ANNULER"
        Me.BT_CANCEL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contact:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Adresse:"
        '
        'CLIENT_NAME_TEXT_BOX
        '
        Me.CLIENT_NAME_TEXT_BOX.Location = New System.Drawing.Point(66, 18)
        Me.CLIENT_NAME_TEXT_BOX.Name = "CLIENT_NAME_TEXT_BOX"
        Me.CLIENT_NAME_TEXT_BOX.Size = New System.Drawing.Size(177, 20)
        Me.CLIENT_NAME_TEXT_BOX.TabIndex = 3
        '
        'CLIENT_CONTACT_TEXT_BOX
        '
        Me.CLIENT_CONTACT_TEXT_BOX.Location = New System.Drawing.Point(66, 57)
        Me.CLIENT_CONTACT_TEXT_BOX.Name = "CLIENT_CONTACT_TEXT_BOX"
        Me.CLIENT_CONTACT_TEXT_BOX.Size = New System.Drawing.Size(177, 20)
        Me.CLIENT_CONTACT_TEXT_BOX.TabIndex = 4
        '
        'CLIENT_ADRESSE_TEXT_BOX
        '
        Me.CLIENT_ADRESSE_TEXT_BOX.Location = New System.Drawing.Point(66, 93)
        Me.CLIENT_ADRESSE_TEXT_BOX.Name = "CLIENT_ADRESSE_TEXT_BOX"
        Me.CLIENT_ADRESSE_TEXT_BOX.Size = New System.Drawing.Size(177, 20)
        Me.CLIENT_ADRESSE_TEXT_BOX.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 101)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information du produit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Designtation:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Prix:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(83, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 20)
        Me.TextBox2.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(262, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(529, 252)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Information sur la commande"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Quantité"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Prix unitaire"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Prix total:"
        '
        'Ajouter_une_commande
        '
        Me.AcceptButton = Me.BT_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BT_CANCEL
        Me.ClientSize = New System.Drawing.Size(800, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BT_CANCEL)
        Me.Controls.Add(Me.BT_OK)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ajouter_une_commande"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajouter_une_commande"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CLIENT_ADRESSE_TEXT_BOX As TextBox
    Friend WithEvents CLIENT_CONTACT_TEXT_BOX As TextBox
    Friend WithEvents CLIENT_NAME_TEXT_BOX As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BT_OK As Button
    Friend WithEvents BT_CANCEL As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
