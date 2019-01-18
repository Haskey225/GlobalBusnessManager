<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajoute_Un_Produit
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DESCRIPTION_PRODUIT = New System.Windows.Forms.TextBox()
        Me.CODE_PRODUIT = New System.Windows.Forms.TextBox()
        Me.NOM_PRODUIT = New System.Windows.Forms.TextBox()
        Me.PRIX_ACHAT = New System.Windows.Forms.TextBox()
        Me.ERROR_MSG = New System.Windows.Forms.Label()
        Me.PRIX_VENTE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(397, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(321, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Code du produit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom du produit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Prix achat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Description"
        '
        'DESCRIPTION_PRODUIT
        '
        Me.DESCRIPTION_PRODUIT.Location = New System.Drawing.Point(149, 174)
        Me.DESCRIPTION_PRODUIT.Multiline = True
        Me.DESCRIPTION_PRODUIT.Name = "DESCRIPTION_PRODUIT"
        Me.DESCRIPTION_PRODUIT.Size = New System.Drawing.Size(310, 89)
        Me.DESCRIPTION_PRODUIT.TabIndex = 6
        '
        'CODE_PRODUIT
        '
        Me.CODE_PRODUIT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CODE_PRODUIT.Location = New System.Drawing.Point(149, 21)
        Me.CODE_PRODUIT.Name = "CODE_PRODUIT"
        Me.CODE_PRODUIT.Size = New System.Drawing.Size(195, 20)
        Me.CODE_PRODUIT.TabIndex = 7
        '
        'NOM_PRODUIT
        '
        Me.NOM_PRODUIT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NOM_PRODUIT.Location = New System.Drawing.Point(149, 47)
        Me.NOM_PRODUIT.Name = "NOM_PRODUIT"
        Me.NOM_PRODUIT.Size = New System.Drawing.Size(195, 20)
        Me.NOM_PRODUIT.TabIndex = 8
        '
        'PRIX_ACHAT
        '
        Me.PRIX_ACHAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PRIX_ACHAT.Location = New System.Drawing.Point(149, 77)
        Me.PRIX_ACHAT.Name = "PRIX_ACHAT"
        Me.PRIX_ACHAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PRIX_ACHAT.Size = New System.Drawing.Size(195, 20)
        Me.PRIX_ACHAT.TabIndex = 9
        '
        'ERROR_MSG
        '
        Me.ERROR_MSG.AutoSize = True
        Me.ERROR_MSG.ForeColor = System.Drawing.Color.Red
        Me.ERROR_MSG.Location = New System.Drawing.Point(146, 156)
        Me.ERROR_MSG.Name = "ERROR_MSG"
        Me.ERROR_MSG.Size = New System.Drawing.Size(275, 13)
        Me.ERROR_MSG.TabIndex = 10
        Me.ERROR_MSG.Text = "Entrez des vleurs valides. Aucun champ ne doit être vide"
        '
        'PRIX_VENTE
        '
        Me.PRIX_VENTE.Location = New System.Drawing.Point(149, 113)
        Me.PRIX_VENTE.Name = "PRIX_VENTE"
        Me.PRIX_VENTE.Size = New System.Drawing.Size(195, 20)
        Me.PRIX_VENTE.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Prix de vente"
        '
        'Ajoute_Un_Produit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.PRIX_VENTE)
        Me.Controls.Add(Me.ERROR_MSG)
        Me.Controls.Add(Me.PRIX_ACHAT)
        Me.Controls.Add(Me.NOM_PRODUIT)
        Me.Controls.Add(Me.CODE_PRODUIT)
        Me.Controls.Add(Me.DESCRIPTION_PRODUIT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ajoute_Un_Produit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajoute un produit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DESCRIPTION_PRODUIT As TextBox
    Friend WithEvents CODE_PRODUIT As TextBox
    Friend WithEvents NOM_PRODUIT As TextBox
    Friend WithEvents PRIX_ACHAT As TextBox
    Friend WithEvents ERROR_MSG As Label
    Friend WithEvents PRIX_VENTE As TextBox
    Friend WithEvents Label5 As Label
End Class
