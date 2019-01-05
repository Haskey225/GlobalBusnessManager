Imports MySql.Data.MySqlClient

Public Class CommandManager
    Private mConnexion As MySqlConnection
    Private mQuery As String
    Private mCmd As MySqlCommand
    Private mReader As MySqlDataReader
    Private mClient As Client
    Private mNomProduit As String

    Sub New(connexion As Connexion)
        mConnexion = connexion.getConnexion
    End Sub
    Public Sub addCommand(command As Command)
        mQuery = ("INSERT INTO commande (nom_produit, id_client, adresse_livraison, net_payer, status, id_agent)
                    VALUE(@val1, @val2, @val3, @val4, @val5, @val6)")
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val1", getProductsFullName(command))
            mCmd.Parameters.AddWithValue("@val2", CInt(command.getClient.getId))
            mCmd.Parameters.AddWithValue("@val3", command.getAdressLivraison)
            mCmd.Parameters.AddWithValue("@val4", CInt(command.getNetToPay))
            mCmd.Parameters.AddWithValue("@val5", command.getCommandStat)
            mCmd.Parameters.AddWithValue("@val6", CInt(command.getAgent))

            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erreur d'insertion dans la base de donnée. Source: " & ex.ToString)
        Finally
            Me.eraseSpace()
            updateCommandDataGrid()
        End Try
    End Sub

    Public Sub deleteCommand(idCommand As Integer)
        mQuery = "DELETE FROM commande WHERE id = @val"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val", idCommand)
            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erreur de commande. Source: " & ex.ToString)
        Finally
            eraseSpace()
            updateCommandDataGrid()
        End Try
    End Sub
    Public Sub edditCommand(index As Integer)
        mQuery = "UPDATE commande SET nom_produit = @val1, id_client = @val2, adresse_livraison = @val3, net_payer, status = @val4, id_agent = @val5 WHERE id = @val6"
        mCmd = New MySqlCommand(mQuery, mConnexion)
        'mCmd.Parameters.AddWithValue("@val1", )
    End Sub

#Region "Paralelle function"
    Private Sub eraseSpace()
        If mCmd IsNot Nothing Then
            mCmd.Dispose()
        End If
        If mReader IsNot Nothing Then
            mReader.Close()
        End If
    End Sub
    Private Function getProductsFullName(command As Command) As String
        For Each product As Product In command.getPoductList
            mNomProduit += product.getNom()
        Next
        Return mNomProduit
    End Function
    Public Sub updateCommandDataGrid()
        mQuery = "SELECT * FROM commande"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mReader = mCmd.ExecuteReader
            MainController.VU_COMMAND.Rows.Clear()

            While mReader.Read
                MainController.VU_COMMAND.Rows.Add(mReader.GetString("id"), mReader.GetString("nom_produit"),
                                                          mReader.GetString("id_client"), mReader.GetString("adresse_livraison"),
                                                          mReader.GetString("net_payer"), mReader.GetString("status"),
                                                          mReader.GetString("id_agent"))
            End While
        Catch ex As Exception
            MsgBox("Erreur de commande. Source erreur: " & ex.ToString)
        Finally
            eraseSpace()
        End Try
    End Sub
    Public Function getRowSelectedIdValue()
        Dim idcl As Integer
        Try
            idcl = CInt(MainController.VU_COMMAND.CurrentRow.Cells().Item(0).Value)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return idcl
    End Function
#End Region

End Class
