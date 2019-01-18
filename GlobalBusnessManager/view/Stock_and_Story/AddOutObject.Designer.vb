<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOutObject
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
        Me.O_DAY = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PRODUCT_ID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.O_MONTH = New System.Windows.Forms.TextBox()
        Me.O_YEAR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.O_CAUSE = New System.Windows.Forms.TextBox()
        Me.O_DESTINATION = New System.Windows.Forms.TextBox()
        Me.O_QUANTITE = New System.Windows.Forms.TextBox()
        Me.BT_O_APLY = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Error_Message = New System.Windows.Forms.Label()
        Me.SEARCH_TEXT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'O_DAY
        '
        Me.O_DAY.Location = New System.Drawing.Point(134, 22)
        Me.O_DAY.Name = "O_DAY"
        Me.O_DAY.ReadOnly = True
        Me.O_DAY.Size = New System.Drawing.Size(25, 20)
        Me.O_DAY.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date de sortie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Produit / Id"
        '
        'PRODUCT_ID
        '
        Me.PRODUCT_ID.FormattingEnabled = True
        Me.PRODUCT_ID.Location = New System.Drawing.Point(134, 48)
        Me.PRODUCT_ID.MaxDropDownItems = 20
        Me.PRODUCT_ID.Name = "PRODUCT_ID"
        Me.PRODUCT_ID.Size = New System.Drawing.Size(149, 21)
        Me.PRODUCT_ID.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cause"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Destination"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Quantité"
        '
        'O_MONTH
        '
        Me.O_MONTH.Location = New System.Drawing.Point(165, 22)
        Me.O_MONTH.Name = "O_MONTH"
        Me.O_MONTH.ReadOnly = True
        Me.O_MONTH.Size = New System.Drawing.Size(25, 20)
        Me.O_MONTH.TabIndex = 0
        '
        'O_YEAR
        '
        Me.O_YEAR.Location = New System.Drawing.Point(196, 22)
        Me.O_YEAR.Name = "O_YEAR"
        Me.O_YEAR.ReadOnly = True
        Me.O_YEAR.Size = New System.Drawing.Size(49, 20)
        Me.O_YEAR.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(142, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "j"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(172, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "m"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(212, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "A"
        '
        'O_CAUSE
        '
        Me.O_CAUSE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.O_CAUSE.Location = New System.Drawing.Point(134, 80)
        Me.O_CAUSE.Name = "O_CAUSE"
        Me.O_CAUSE.Size = New System.Drawing.Size(149, 20)
        Me.O_CAUSE.TabIndex = 8
        '
        'O_DESTINATION
        '
        Me.O_DESTINATION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.O_DESTINATION.Location = New System.Drawing.Point(134, 107)
        Me.O_DESTINATION.Name = "O_DESTINATION"
        Me.O_DESTINATION.Size = New System.Drawing.Size(149, 20)
        Me.O_DESTINATION.TabIndex = 9
        '
        'O_QUANTITE
        '
        Me.O_QUANTITE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.O_QUANTITE.Location = New System.Drawing.Point(134, 135)
        Me.O_QUANTITE.Name = "O_QUANTITE"
        Me.O_QUANTITE.Size = New System.Drawing.Size(100, 20)
        Me.O_QUANTITE.TabIndex = 10
        '
        'BT_O_APLY
        '
        Me.BT_O_APLY.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BT_O_APLY.Location = New System.Drawing.Point(266, 191)
        Me.BT_O_APLY.Name = "BT_O_APLY"
        Me.BT_O_APLY.Size = New System.Drawing.Size(75, 23)
        Me.BT_O_APLY.TabIndex = 11
        Me.BT_O_APLY.Text = "Appliquer"
        Me.BT_O_APLY.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(185, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Annuler"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Error_Message
        '
        Me.Error_Message.AutoSize = True
        Me.Error_Message.ForeColor = System.Drawing.Color.Red
        Me.Error_Message.Location = New System.Drawing.Point(122, 163)
        Me.Error_Message.Name = "Error_Message"
        Me.Error_Message.Size = New System.Drawing.Size(158, 13)
        Me.Error_Message.TabIndex = 31
        Me.Error_Message.Text = "Entrez des informations valides !"
        Me.Error_Message.Visible = False
        '
        'SEARCH_TEXT
        '
        Me.SEARCH_TEXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SEARCH_TEXT.Location = New System.Drawing.Point(134, 48)
        Me.SEARCH_TEXT.Name = "SEARCH_TEXT"
        Me.SEARCH_TEXT.Size = New System.Drawing.Size(134, 20)
        Me.SEARCH_TEXT.TabIndex = 32
        '
        'AddOutObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 218)
        Me.ControlBox = False
        Me.Controls.Add(Me.SEARCH_TEXT)
        Me.Controls.Add(Me.Error_Message)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BT_O_APLY)
        Me.Controls.Add(Me.O_QUANTITE)
        Me.Controls.Add(Me.O_DESTINATION)
        Me.Controls.Add(Me.O_CAUSE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PRODUCT_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.O_YEAR)
        Me.Controls.Add(Me.O_MONTH)
        Me.Controls.Add(Me.O_DAY)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddOutObject"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sortir un produit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents O_DAY As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PRODUCT_ID As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents O_MONTH As TextBox
    Friend WithEvents O_YEAR As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents O_CAUSE As TextBox
    Friend WithEvents O_DESTINATION As TextBox
    Friend WithEvents O_QUANTITE As TextBox
    Friend WithEvents BT_O_APLY As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Error_Message As Label
    Friend WithEvents SEARCH_TEXT As TextBox
End Class
