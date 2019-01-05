Imports MySql.Data.MySqlClient
Public Class ClientManager
    Private mConnexion As MySqlConnection
    Private query As String
    Private reader As MySqlDataReader
    Private cmd As MySqlCommand
    Private mClient As Client
    Private mListOfClient As List(Of Client)

    Sub New()

    End Sub
    Public Sub New(ByVal connexion As Connexion)
        mConnexion = connexion.getConnexion
    End Sub

    Public Sub addClient(ByVal client As Client)
        query = "INSERT INTO client (name, tel, commune) VALUE(@val1, @val2, @val3)"
        Try
            cmd = New MySqlCommand(query, mConnexion)
            cmd.Parameters.AddWithValue("@val1", client.getName)
            cmd.Parameters.AddWithValue("@val2", CInt(client.getContact))
            cmd.Parameters.AddWithValue("@val3", client.getCommune)
            cmd.ExecuteNonQuery()
            MsgBox("Le client " & client.getName & " a été ajouter à la base donnée")
        Catch ex As Exception
            MsgBox("Erreur de command ou de connexion. Source: " & ex.ToString)
        Finally
            cmd.Dispose()
            updateClientDataGrid()
        End Try
    End Sub

    Public Sub deleteClient(ByVal index As Integer)
        query = "DELETE FROM client WHERE id = @val"
        Try
            cmd = New MySqlCommand(query, mConnexion)
            cmd.Parameters.AddWithValue("@val", index)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cmd.Dispose()
            updateClientDataGrid()
        End Try
    End Sub
    Public Sub edditClient(index As Integer, client As Client)
        query = "UPDATE client SET name = @val1, tel = @val2, commune = @val3 WHERE id = @val"
        Try
            cmd = New MySqlCommand(query, mConnexion)
            cmd.Parameters.AddWithValue("@val", index)
            cmd.Parameters.AddWithValue("@val1", client.getName())
            cmd.Parameters.AddWithValue("@val2", CInt(client.getContact))
            cmd.Parameters.AddWithValue("@val3", client.getCommune)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("" & ex.ToString)
        Finally
            cmd.Dispose()
            updateClientDataGrid()
        End Try
    End Sub
    Public Function getClient(ByVal index As Integer) As Client
        query = "SELECT * FROM client WHERE id = @val"
        Try
            cmd = New MySqlCommand(query, mConnexion)
            cmd.Parameters.AddWithValue("@val", index)
            reader = cmd.ExecuteReader
            While reader.Read
                mClient = New Client(reader.GetString("id"), reader.GetString("name"), reader.GetString("tel"), reader.GetString("commune"))
            End While
        Catch ex As Exception
            MsgBox("Erreur la connexion a été perdue. Source: " & ex.ToString)
        Finally
            cmd.Dispose()
            reader.Close()
        End Try
        Return mClient
    End Function

    Public Function getAllClients() As List(Of Client)
        query = "SELECT * FROM client"
        Try
            cmd = New MySqlCommand(query, mConnexion)
            reader = cmd.ExecuteReader()
            While reader.Read
                mListOfClient.Add(New Client(reader.GetString("id"), reader.GetString("name"), reader.GetString("tel"), reader.GetString("commune")))
            End While
        Catch ex As Exception
            MsgBox("Erreur de commande. Source: " & ex.ToString)
        Finally
            cmd.Dispose()
            reader.Close()
        End Try
        Return mListOfClient
    End Function

#Region "Surchage de method"
    Public Function getClient(ByVal name As String) As Client
        query = "SELECT * FORM client WHERE name = @val"
        Try
            cmd = New MySqlCommand(query, mConnexion)
            cmd.Parameters.AddWithValue("@val", name)
            reader = cmd.ExecuteReader
            While reader.Read
                mClient = New Client(reader.GetString("id"), reader.GetString("name"), reader.GetString("tel"), reader.GetString("commune"))
            End While
        Catch ex As Exception
            MsgBox("Erreur la connexion a été perdue. Source: " & ex.ToString)
        Finally
            cmd.Dispose()
            reader.Close()
        End Try
        Return mClient
    End Function
#End Region
    Public Sub updateClientDataGrid()
        query = "SELECT * FROM client"
        Try
            cmd = New MySqlCommand(query, mConnexion)
            reader = cmd.ExecuteReader
            MainController.CLIENT_DATA_VIEW.Rows.Clear()

            While reader.Read
                MainController.CLIENT_DATA_VIEW.Rows.Add(reader.GetString("id"), reader.GetString("name"),
                                                          reader.GetString("tel"), reader.GetString("commune"))
            End While
        Catch ex As Exception
            MsgBox("Erreur de commande. Source erreur: " & ex.ToString)
        Finally
            cmd.Dispose()
            reader.Close()
        End Try
    End Sub
    Public Function getRowSelectedIdValue()
        Dim idcl As Integer
        Try
            idcl = CInt(MainController.CLIENT_DATA_VIEW.CurrentRow.Cells().Item(0).Value)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return idcl
    End Function
End Class
