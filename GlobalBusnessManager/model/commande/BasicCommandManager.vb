Imports MySql.Data.MySqlClient
Public Class BasicCommandManager
    Private mConnexion As MySqlConnection
    Private mQuery As String
    Private mCmd As MySqlCommand
    Private mReader As MySqlDataReader
    Private mClient As Client
    Private mNomProduit As String
    Private product As Product
    Private mTruck As String

    Sub New(connexion As Connexion)
        mConnexion = connexion.getConnexion
    End Sub
    Public Sub addCommand(command As BasicCommand)
        mQuery = ("INSERT INTO commande (code_produit, nom_produit, client_name, contact, adresse_livraison, net_payer, status, id_agent, date_command)
                    VALUE(@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9)")
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val1", command.getPoduct.getCode)
            mCmd.Parameters.AddWithValue("@val2", command.getPoduct.getNom)
            mCmd.Parameters.AddWithValue("@val3", command.getClientName)
            mCmd.Parameters.AddWithValue("@val4", command.getClientContact)
            mCmd.Parameters.AddWithValue("@val5", command.getAdressLivraison)
            mCmd.Parameters.AddWithValue("@val6", CInt(command.getNetToPay))
            mCmd.Parameters.AddWithValue("@val7", command.getCommandStat)
            mCmd.Parameters.AddWithValue("@val8", CInt(command.getAgent))
            mCmd.Parameters.AddWithValue("@val9", CDate(command.getDate).ToShortDateString)

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
    Public Sub edditCommand(index As Integer, commande As BasicCommand)
        mQuery = "UPDATE commande SET nom_produit = @val1, client_name = @val2, adresse_livraison = @val3, net_payer, status = @val4, id_agent = @val5 WHERE id = @val6"
        mCmd = New MySqlCommand(mQuery, mConnexion)
        'mCmd.Parameters.AddWithValue("@val1", )
    End Sub
    Public Function getProduct(name As String) As Product
        mQuery = "SELECT * FROM produit WHERE name = @val"
        product = New Product
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val", name)
            mReader = mCmd.ExecuteReader
            mReader.Read()
            product.setId(CInt(mReader.GetString("id")))
            product.setCode(mReader.GetString("code"))
            product.setNom(mReader.GetString("name"))
            product.setPrixAchat(CInt(mReader.GetString("price")))
            product.setQuantite(CInt(mReader.GetString("quantite")))
            product.setStatus(mReader.GetString("status"))
        Catch ex As Exception
            MsgBox("Erreur de communication avce la bas e donnée: " & ex.ToString)
        Finally
            eraseSpace()
        End Try
        Return product
    End Function
    Public Sub validateAllCommandStat()
        mQuery = "UPDATE commande SET status = @val"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val", "Livré")
            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erreur d'execution. Source de l'erreur: " & ex.ToString)
        Finally
            eraseSpace()
            updateCommandDataGrid()
        End Try
    End Sub
    Public Sub validateCourrantStat(index As Integer)
        mQuery = "UPDATE commande SET status = @val WHERE id = @val1"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val", "Livré")
            mCmd.Parameters.AddWithValue("@val1", index)
            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erreur d'execution. Source de l'erreur: " & ex.ToString)
        Finally
            eraseSpace()
            updateCommandDataGrid()
        End Try
    End Sub
#Region "Paralelle function et recevoir le contenu de la datagrid"
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
                MainController.VU_COMMAND.Rows.Add(mReader.GetString("id"), mReader.GetString("code_produit"), mReader.GetString("nom_produit"),
                                                          mReader.GetString("client_name"), mReader.GetString("contact"), mReader.GetString("adresse_livraison"),
                                                          mReader.GetString("net_payer"), mReader.GetString("status"),
                                                          mReader.GetString("id_agent"), mReader.GetString("date_command"))
            End While
        Catch ex As Exception
            MsgBox("Erreur de commande. Source erreur: " & ex.ToString)
        Finally
            eraseSpace()
        End Try
    End Sub
    Public Function getRowSelectedIdValue() As Integer
        Dim idcl As Integer
        Try
            idcl = CInt(MainController.VU_COMMAND.CurrentRow.Cells().Item(0).Value)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return idcl
    End Function
    Public Function getRowSelectedProductCodeValue() As String
        Dim idcl As String
        Try
            idcl = MainController.VU_COMMAND.CurrentRow.Cells().Item(1).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return idcl
    End Function
    Public Function getRowSelectedProductNameValue() As String
        Dim productName As String
        Try
            productName = MainController.VU_COMMAND.CurrentRow.Cells().Item(2).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return productName
    End Function
    Public Function getRowSelectedClientNameValue() As String
        Dim clientName As String
        Try
            clientName = MainController.VU_COMMAND.CurrentRow.Cells().Item(3).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return clientName
    End Function
    Public Function getRowSelectedClientContactValue() As String
        Dim clientContact As String
        Try
            clientContact = MainController.VU_COMMAND.CurrentRow.Cells().Item(4).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return clientContact
    End Function
    Public Function getRowSelectedClientAdresseValue() As String
        Dim clientAdresse As String
        Try
            clientAdresse = MainController.VU_COMMAND.CurrentRow.Cells().Item(5).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return clientAdresse
    End Function
    Public Function getRowSelectedNetToPayValue() As Integer
        Dim clientPay As Integer
        Try
            clientPay = CInt(MainController.VU_COMMAND.CurrentRow.Cells().Item(6).Value)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return clientPay
    End Function
    Public Function getStatColumnCellSelectedValue() As String
        Dim forme As String
        Try
            forme = MainController.VU_COMMAND.CurrentRow.Cells().Item(7).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return forme
    End Function

    Public Function getSelectedCellContenteValue() As String
        Dim valeur As String
        Try
            valeur = MainController.VU_COMMAND.CurrentCell.Value
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return valeur
    End Function
    Public Function getProductNameFromCounrrantRow() As String
        Return MainController.VU_COMMAND.CurrentRow.Cells().Item(2).Value
    End Function
#End Region
End Class
