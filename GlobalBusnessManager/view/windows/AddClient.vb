Public Class AddClientWin
    Private Sub AddClientWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.CLIENT_COMMUNE.Text = "" Or Me.CLIENT_CONTACT.Text = "" Or Me.CLIENT_NAME.text = "" Then
            MsgBox("Veiller remplire corectement tout les champs")
            Exit Sub
        End If
        Me.Close()
    End Sub
End Class