Public Class Ajoute_Un_Produit
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Ajoute_Un_Produit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ERROR_MSG.Visible = False
        Button1.Enabled = false
    End Sub

    Private Sub PRIX_ACHAT_TextChanged(sender As Object, e As EventArgs) Handles PRIX_ACHAT.TextChanged
        If Not IsNumeric(PRIX_VENTE.Text) Or Not IsNumeric(PRIX_ACHAT.Text) Or CODE_PRODUIT.Text = "" Or NOM_PRODUIT.Text = "" Then
            ERROR_MSG.Visible = True
            Button1.Enabled = False
            Exit Sub
        Else
            ERROR_MSG.Visible = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub PRIX_VENTE_TextChanged(sender As Object, e As EventArgs) Handles PRIX_VENTE.TextChanged
        If Not IsNumeric(PRIX_VENTE.Text) Or Not IsNumeric(PRIX_ACHAT.Text) Or CODE_PRODUIT.Text = "" Or NOM_PRODUIT.Text = "" Then
            ERROR_MSG.Visible = True
            Button1.Enabled = False
            Exit Sub
        Else
            ERROR_MSG.Visible = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub CODE_PRODUIT_TextChanged(sender As Object, e As EventArgs) Handles CODE_PRODUIT.TextChanged
        If Not IsNumeric(PRIX_VENTE.Text) Or Not IsNumeric(PRIX_ACHAT.Text) Or CODE_PRODUIT.Text = "" Or NOM_PRODUIT.Text = "" Then
            ERROR_MSG.Visible = True
            Button1.Enabled = False
            Exit Sub
        Else
            ERROR_MSG.Visible = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub NOM_PRODUIT_TextChanged(sender As Object, e As EventArgs) Handles NOM_PRODUIT.TextChanged
        If Not IsNumeric(PRIX_VENTE.Text) Or Not IsNumeric(PRIX_ACHAT.Text) Or CODE_PRODUIT.Text = "" Or NOM_PRODUIT.Text = "" Then
            ERROR_MSG.Visible = True
            Button1.Enabled = False
            Exit Sub
        Else
            ERROR_MSG.Visible = False
            Button1.Enabled = True
        End If
    End Sub


End Class