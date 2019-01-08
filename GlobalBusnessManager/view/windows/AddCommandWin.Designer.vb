<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCommandWin
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CONTACT = New System.Windows.Forms.TextBox()
        Me.COMMUNE_NAME = New System.Windows.Forms.TextBox()
        Me.CLIENT_NAME = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PRODUCT_PRICE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CODE_PRODUIT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SELECT_PRODUCT_NAME = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PRIX_PRODUIT_TTC = New System.Windows.Forms.TextBox()
        Me.FRAIR_LIVRAISON = New System.Windows.Forms.TextBox()
        Me.LIEUR_LIVRAISON = New System.Windows.Forms.TextBox()
        Me.DATE_COMMANDE = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PRIX_PRODUIT_HT = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PRIX_UNITAIRE_PRODUIT = New System.Windows.Forms.TextBox()
        Me.QUANTITE_PRODUIT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 134)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information du client"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CONTACT)
        Me.GroupBox5.Controls.Add(Me.COMMUNE_NAME)
        Me.GroupBox5.Controls.Add(Me.CLIENT_NAME)
        Me.GroupBox5.Location = New System.Drawing.Point(69, 17)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(126, 112)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'CONTACT
        '
        Me.CONTACT.Location = New System.Drawing.Point(6, 80)
        Me.CONTACT.MaxLength = 8
        Me.CONTACT.Name = "CONTACT"
        Me.CONTACT.Size = New System.Drawing.Size(117, 20)
        Me.CONTACT.TabIndex = 3
        '
        'COMMUNE_NAME
        '
        Me.COMMUNE_NAME.Location = New System.Drawing.Point(6, 48)
        Me.COMMUNE_NAME.MaxLength = 20
        Me.COMMUNE_NAME.Name = "COMMUNE_NAME"
        Me.COMMUNE_NAME.Size = New System.Drawing.Size(117, 20)
        Me.COMMUNE_NAME.TabIndex = 2
        '
        'CLIENT_NAME
        '
        Me.CLIENT_NAME.Location = New System.Drawing.Point(6, 10)
        Me.CLIENT_NAME.MaxLength = 20
        Me.CLIENT_NAME.Name = "CLIENT_NAME"
        Me.CLIENT_NAME.Size = New System.Drawing.Size(117, 20)
        Me.CLIENT_NAME.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(60, 112)
        Me.GroupBox4.TabIndex = 100
        Me.GroupBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Contact"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Commune"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.PRODUCT_PRICE)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CODE_PRODUIT)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.SELECT_PRODUCT_NAME)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 134)
        Me.GroupBox2.TabIndex = 112
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information sur le produit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(178, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 1015
        Me.Label7.Text = "F CFA"
        '
        'PRODUCT_PRICE
        '
        Me.PRODUCT_PRICE.Location = New System.Drawing.Point(94, 93)
        Me.PRODUCT_PRICE.Name = "PRODUCT_PRICE"
        Me.PRODUCT_PRICE.ReadOnly = True
        Me.PRODUCT_PRICE.Size = New System.Drawing.Size(80, 20)
        Me.PRODUCT_PRICE.TabIndex = 1014
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Prix du produit: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Code du poduit: "
        '
        'CODE_PRODUIT
        '
        Me.CODE_PRODUIT.Location = New System.Drawing.Point(94, 53)
        Me.CODE_PRODUIT.Name = "CODE_PRODUIT"
        Me.CODE_PRODUIT.ReadOnly = True
        Me.CODE_PRODUIT.Size = New System.Drawing.Size(133, 20)
        Me.CODE_PRODUIT.TabIndex = 1011
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 1010
        Me.Label4.Text = "Nom du produit: "
        '
        'SELECT_PRODUCT_NAME
        '
        Me.SELECT_PRODUCT_NAME.FormattingEnabled = True
        Me.SELECT_PRODUCT_NAME.Location = New System.Drawing.Point(94, 19)
        Me.SELECT_PRODUCT_NAME.Name = "SELECT_PRODUCT_NAME"
        Me.SELECT_PRODUCT_NAME.Size = New System.Drawing.Size(133, 21)
        Me.SELECT_PRODUCT_NAME.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(588, 156)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Commande et livraison"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.PRIX_PRODUIT_TTC)
        Me.GroupBox7.Controls.Add(Me.FRAIR_LIVRAISON)
        Me.GroupBox7.Controls.Add(Me.LIEUR_LIVRAISON)
        Me.GroupBox7.Controls.Add(Me.DATE_COMMANDE)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Location = New System.Drawing.Point(284, 18)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(294, 125)
        Me.GroupBox7.TabIndex = 1133
        Me.GroupBox7.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(248, 87)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 1015
        Me.Label16.Text = "F CFA"
        '
        'PRIX_PRODUIT_TTC
        '
        Me.PRIX_PRODUIT_TTC.Location = New System.Drawing.Point(132, 84)
        Me.PRIX_PRODUIT_TTC.Name = "PRIX_PRODUIT_TTC"
        Me.PRIX_PRODUIT_TTC.ReadOnly = True
        Me.PRIX_PRODUIT_TTC.Size = New System.Drawing.Size(110, 20)
        Me.PRIX_PRODUIT_TTC.TabIndex = 12
        '
        'FRAIR_LIVRAISON
        '
        Me.FRAIR_LIVRAISON.Location = New System.Drawing.Point(132, 58)
        Me.FRAIR_LIVRAISON.Name = "FRAIR_LIVRAISON"
        Me.FRAIR_LIVRAISON.Size = New System.Drawing.Size(156, 20)
        Me.FRAIR_LIVRAISON.TabIndex = 11
        '
        'LIEUR_LIVRAISON
        '
        Me.LIEUR_LIVRAISON.Location = New System.Drawing.Point(132, 35)
        Me.LIEUR_LIVRAISON.Name = "LIEUR_LIVRAISON"
        Me.LIEUR_LIVRAISON.Size = New System.Drawing.Size(156, 20)
        Me.LIEUR_LIVRAISON.TabIndex = 10
        '
        'DATE_COMMANDE
        '
        Me.DATE_COMMANDE.Location = New System.Drawing.Point(132, 12)
        Me.DATE_COMMANDE.Name = "DATE_COMMANDE"
        Me.DATE_COMMANDE.Size = New System.Drawing.Size(110, 20)
        Me.DATE_COMMANDE.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 1132
        Me.Label15.Text = "Prix total TTC: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 13)
        Me.Label14.TabIndex = 1131
        Me.Label14.Text = "Frairs de livraison: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 1130
        Me.Label13.Text = "Lieu de livraison: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 13)
        Me.Label12.TabIndex = 1129
        Me.Label12.Text = "Date de la commande: "
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.PRIX_PRODUIT_HT)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.PRIX_UNITAIRE_PRODUIT)
        Me.GroupBox6.Controls.Add(Me.QUANTITE_PRODUIT)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Location = New System.Drawing.Point(4, 18)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(273, 126)
        Me.GroupBox6.TabIndex = 1128
        Me.GroupBox6.TabStop = False
        '
        'PRIX_PRODUIT_HT
        '
        Me.PRIX_PRODUIT_HT.Location = New System.Drawing.Point(111, 81)
        Me.PRIX_PRODUIT_HT.Name = "PRIX_PRODUIT_HT"
        Me.PRIX_PRODUIT_HT.ReadOnly = True
        Me.PRIX_PRODUIT_HT.Size = New System.Drawing.Size(100, 20)
        Me.PRIX_PRODUIT_HT.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(228, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 1016
        Me.Label17.Text = "F CFA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(228, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 1016
        Me.Label11.Text = "F CFA"
        '
        'PRIX_UNITAIRE_PRODUIT
        '
        Me.PRIX_UNITAIRE_PRODUIT.Location = New System.Drawing.Point(111, 41)
        Me.PRIX_UNITAIRE_PRODUIT.Name = "PRIX_UNITAIRE_PRODUIT"
        Me.PRIX_UNITAIRE_PRODUIT.ReadOnly = True
        Me.PRIX_UNITAIRE_PRODUIT.Size = New System.Drawing.Size(100, 20)
        Me.PRIX_UNITAIRE_PRODUIT.TabIndex = 7
        '
        'QUANTITE_PRODUIT
        '
        Me.QUANTITE_PRODUIT.Location = New System.Drawing.Point(111, 9)
        Me.QUANTITE_PRODUIT.MaxLength = 2
        Me.QUANTITE_PRODUIT.Name = "QUANTITE_PRODUIT"
        Me.QUANTITE_PRODUIT.Size = New System.Drawing.Size(40, 20)
        Me.QUANTITE_PRODUIT.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 1127
        Me.Label10.Text = "Prix total HT: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 1126
        Me.Label9.Text = "Prix unitaire: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 1125
        Me.Label8.Text = "Quantité du produit: "
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(511, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(430, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label22)
        Me.GroupBox8.Controls.Add(Me.Label21)
        Me.GroupBox8.Controls.Add(Me.Label20)
        Me.GroupBox8.Controls.Add(Me.TextBox3)
        Me.GroupBox8.Controls.Add(Me.TextBox2)
        Me.GroupBox8.Controls.Add(Me.TextBox1)
        Me.GroupBox8.Controls.Add(Me.Label19)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.ComboBox1)
        Me.GroupBox8.Location = New System.Drawing.Point(203, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(151, 134)
        Me.GroupBox8.TabIndex = 113
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Agent et date"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(103, 63)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 13)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "année"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(72, 63)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(15, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "m"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(51, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(9, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "j"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(93, 81)
        Me.TextBox3.MaxLength = 4
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(55, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(68, 81)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(21, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(43, 81)
        Me.TextBox1.MaxLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(21, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1, 85)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Date: "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1, 27)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Agent: "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(43, 23)
        Me.ComboBox1.MaxLength = 10
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(85, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'AddCommandWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 345)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddCommandWin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Commande"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CONTACT As TextBox
    Friend WithEvents COMMUNE_NAME As TextBox
    Friend WithEvents CLIENT_NAME As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PRODUCT_PRICE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CODE_PRODUIT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SELECT_PRODUCT_NAME As ComboBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents PRIX_PRODUIT_TTC As TextBox
    Friend WithEvents FRAIR_LIVRAISON As TextBox
    Friend WithEvents LIEUR_LIVRAISON As TextBox
    Friend WithEvents DATE_COMMANDE As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents PRIX_PRODUIT_HT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PRIX_UNITAIRE_PRODUIT As TextBox
    Friend WithEvents QUANTITE_PRODUIT As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
