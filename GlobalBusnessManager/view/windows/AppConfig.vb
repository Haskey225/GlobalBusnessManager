Public Class AppConfig
    Private Sub BT_CLOSE_Click(sender As Object, e As EventArgs) Handles BT_CLOSE.Click
        If MsgBox("Voullez vous vraiment annuler la conguration? " & Chr(13) & " BS_GBM risque de mal fonctionner !", 4, "Attention") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BT_VALIDER_Click(sender As Object, e As EventArgs) Handles BT_VALIDER.Click
        If Me.SERVER_NAME.Text = "" Then
            MsgBox("L'application risque de mal fonctionner car le nom du serveur est vide", 16, "Erreur de configuration")
        End If
        Me.Close()
    End Sub
End Class