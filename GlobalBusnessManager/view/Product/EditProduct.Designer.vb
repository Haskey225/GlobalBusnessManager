<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProduct
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
        Me.PRIX_ACHAT = New System.Windows.Forms.TextBox()
        Me.NOM_PRODUIT = New System.Windows.Forms.TextBox()
        Me.CODE_PRODUIT = New System.Windows.Forms.TextBox()
        Me.DESCRIPTION_PRODUIT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PRIX_ACHAT
        '
        Me.PRIX_ACHAT.Location = New System.Drawing.Point(98, 63)
        Me.PRIX_ACHAT.Name = "PRIX_ACHAT"
        Me.PRIX_ACHAT.Size = New System.Drawing.Size(195, 20)
        Me.PRIX_ACHAT.TabIndex = 3
        '
        'NOM_PRODUIT
        '
        Me.NOM_PRODUIT.Location = New System.Drawing.Point(98, 33)
        Me.NOM_PRODUIT.Name = "NOM_PRODUIT"
        Me.NOM_PRODUIT.Size = New System.Drawing.Size(195, 20)
        Me.NOM_PRODUIT.TabIndex = 2
        '
        'CODE_PRODUIT
        '
        Me.CODE_PRODUIT.Location = New System.Drawing.Point(98, 7)
        Me.CODE_PRODUIT.Name = "CODE_PRODUIT"
        Me.CODE_PRODUIT.Size = New System.Drawing.Size(195, 20)
        Me.CODE_PRODUIT.TabIndex = 1
        '
        'DESCRIPTION_PRODUIT
        '
        Me.DESCRIPTION_PRODUIT.Location = New System.Drawing.Point(98, 104)
        Me.DESCRIPTION_PRODUIT.Multiline = True
        Me.DESCRIPTION_PRODUIT.Name = "DESCRIPTION_PRODUIT"
        Me.DESCRIPTION_PRODUIT.Size = New System.Drawing.Size(310, 89)
        Me.DESCRIPTION_PRODUIT.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Prix achat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nom du produit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Code du produit"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(276, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Annuler"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button2.Location = New System.Drawing.Point(345, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(369, 7)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(0, 13)
        Me.id.TabIndex = 35
        Me.id.Visible = False
        '
        'EditProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 227)
        Me.ControlBox = False
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PRIX_ACHAT)
        Me.Controls.Add(Me.NOM_PRODUIT)
        Me.Controls.Add(Me.CODE_PRODUIT)
        Me.Controls.Add(Me.DESCRIPTION_PRODUIT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modification de produit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PRIX_ACHAT As TextBox
    Friend WithEvents NOM_PRODUIT As TextBox
    Friend WithEvents CODE_PRODUIT As TextBox
    Friend WithEvents DESCRIPTION_PRODUIT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents id As Label
End Class
