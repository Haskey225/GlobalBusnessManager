<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddInObject
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BT_I_APLY = New System.Windows.Forms.Button()
        Me.I_STCK_FINAL = New System.Windows.Forms.TextBox()
        Me.I_QUANTITE = New System.Windows.Forms.TextBox()
        Me.I_STCK_INIT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PRODUCT_ID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.I_YEAR = New System.Windows.Forms.TextBox()
        Me.I_MONTH = New System.Windows.Forms.TextBox()
        Me.I_DAY = New System.Windows.Forms.TextBox()
        Me.Error_Message = New System.Windows.Forms.Label()
        Me.SEARTCH_TEXT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(189, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Annuler"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BT_I_APLY
        '
        Me.BT_I_APLY.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BT_I_APLY.Location = New System.Drawing.Point(270, 193)
        Me.BT_I_APLY.Name = "BT_I_APLY"
        Me.BT_I_APLY.Size = New System.Drawing.Size(75, 23)
        Me.BT_I_APLY.TabIndex = 28
        Me.BT_I_APLY.Text = "Appliquer"
        Me.BT_I_APLY.UseVisualStyleBackColor = True
        '
        'I_STCK_FINAL
        '
        Me.I_STCK_FINAL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.I_STCK_FINAL.Location = New System.Drawing.Point(122, 134)
        Me.I_STCK_FINAL.Name = "I_STCK_FINAL"
        Me.I_STCK_FINAL.ReadOnly = True
        Me.I_STCK_FINAL.Size = New System.Drawing.Size(69, 20)
        Me.I_STCK_FINAL.TabIndex = 27
        Me.I_STCK_FINAL.Text = "0"
        '
        'I_QUANTITE
        '
        Me.I_QUANTITE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.I_QUANTITE.Location = New System.Drawing.Point(122, 106)
        Me.I_QUANTITE.MaxLength = 5
        Me.I_QUANTITE.Name = "I_QUANTITE"
        Me.I_QUANTITE.Size = New System.Drawing.Size(69, 20)
        Me.I_QUANTITE.TabIndex = 26
        Me.I_QUANTITE.Text = "0"
        '
        'I_STCK_INIT
        '
        Me.I_STCK_INIT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.I_STCK_INIT.Location = New System.Drawing.Point(122, 79)
        Me.I_STCK_INIT.Name = "I_STCK_INIT"
        Me.I_STCK_INIT.ReadOnly = True
        Me.I_STCK_INIT.Size = New System.Drawing.Size(56, 20)
        Me.I_STCK_INIT.TabIndex = 25
        Me.I_STCK_INIT.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(200, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "A"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "m"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "j"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Stock final"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Quantité"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Stock initial"
        '
        'PRODUCT_ID
        '
        Me.PRODUCT_ID.FormattingEnabled = True
        Me.PRODUCT_ID.Location = New System.Drawing.Point(122, 49)
        Me.PRODUCT_ID.Name = "PRODUCT_ID"
        Me.PRODUCT_ID.Size = New System.Drawing.Size(149, 21)
        Me.PRODUCT_ID.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Produit / Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Date d'entré"
        '
        'I_YEAR
        '
        Me.I_YEAR.Location = New System.Drawing.Point(184, 21)
        Me.I_YEAR.Name = "I_YEAR"
        Me.I_YEAR.ReadOnly = True
        Me.I_YEAR.Size = New System.Drawing.Size(49, 20)
        Me.I_YEAR.TabIndex = 14
        '
        'I_MONTH
        '
        Me.I_MONTH.Location = New System.Drawing.Point(153, 21)
        Me.I_MONTH.Name = "I_MONTH"
        Me.I_MONTH.ReadOnly = True
        Me.I_MONTH.Size = New System.Drawing.Size(25, 20)
        Me.I_MONTH.TabIndex = 15
        '
        'I_DAY
        '
        Me.I_DAY.Location = New System.Drawing.Point(122, 21)
        Me.I_DAY.Name = "I_DAY"
        Me.I_DAY.ReadOnly = True
        Me.I_DAY.Size = New System.Drawing.Size(25, 20)
        Me.I_DAY.TabIndex = 13
        '
        'Error_Message
        '
        Me.Error_Message.AutoSize = True
        Me.Error_Message.ForeColor = System.Drawing.Color.Red
        Me.Error_Message.Location = New System.Drawing.Point(112, 161)
        Me.Error_Message.Name = "Error_Message"
        Me.Error_Message.Size = New System.Drawing.Size(158, 13)
        Me.Error_Message.TabIndex = 30
        Me.Error_Message.Text = "Entrez des informations valides !"
        Me.Error_Message.Visible = False
        '
        'SEARTCH_TEXT
        '
        Me.SEARTCH_TEXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SEARTCH_TEXT.Location = New System.Drawing.Point(122, 49)
        Me.SEARTCH_TEXT.Name = "SEARTCH_TEXT"
        Me.SEARTCH_TEXT.Size = New System.Drawing.Size(134, 20)
        Me.SEARTCH_TEXT.TabIndex = 33
        '
        'AddInObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 218)
        Me.ControlBox = False
        Me.Controls.Add(Me.SEARTCH_TEXT)
        Me.Controls.Add(Me.Error_Message)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BT_I_APLY)
        Me.Controls.Add(Me.I_STCK_FINAL)
        Me.Controls.Add(Me.I_QUANTITE)
        Me.Controls.Add(Me.I_STCK_INIT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PRODUCT_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.I_YEAR)
        Me.Controls.Add(Me.I_MONTH)
        Me.Controls.Add(Me.I_DAY)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddInObject"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entrer un objet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BT_I_APLY As Button
    Friend WithEvents I_STCK_FINAL As TextBox
    Friend WithEvents I_QUANTITE As TextBox
    Friend WithEvents I_STCK_INIT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PRODUCT_ID As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents I_YEAR As TextBox
    Friend WithEvents I_MONTH As TextBox
    Friend WithEvents I_DAY As TextBox
    Friend WithEvents Error_Message As Label
    Friend WithEvents SEARTCH_TEXT As TextBox
End Class
