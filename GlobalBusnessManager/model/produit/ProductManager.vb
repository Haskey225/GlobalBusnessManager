Imports MySql.Data.MySqlClient
Public Class ProductManager
    Private mConnexion As MySqlConnection
    Private produit As Product
    Private cmd As MySqlCommand
    Private query As String
    Private reader As MySqlDataReader
    Private mListOfProduct As List(Of Product)
    Public ReadOnly ADD_PRODUCT_WIN As Integer = 1
    Public ReadOnly EDDIT_PRODUCT_WIN As Integer = 2
    Public ReadOnly DELETE_PRODUCT_WIN As Integer = 3
    Sub New(ByVal con As Connexion)
        mConnexion = con.getConnexion
    End Sub

    Sub addProduct(ByVal product As Product)
        query = "INSERT INTO produit(code, name, price, description, status, quantite) values(@val, @val1, @val2, @val4, @val5, @val6)"

        Try
            cmd = New MySqlCommand(query, mConnexion)
            cmd.Parameters.AddWithValue("@val", product.getCode)
            cmd.Parameters.AddWithValue("@val1", product.getNom)
            cmd.Parameters.AddWithValue("@val2", CInt(product.getPrixAchat))
            'cmd.Parameters.AddWithValue("@val3", CInt(product.getPrixDeVente))
            cmd.Parameters.AddWithValue("@val4", product.getDescription)
            cmd.Parameters.AddWithValue("@val5", "En Stock")
            cmd.Parameters.AddWithValue("@val6", "0")

            cmd.ExecuteNonQuery()
            MsgBox("Le produit de code: " & product.getNom & " a été ajouter !")
        Catch ex As Exception
            MsgBox("Erreur d'execution de la commande ajouter. Cause: " & ex.ToString)
        Finally
            If IsNothing(cmd) Then
                cmd.Dispose()
            End If
            Me.updateProductDataGrid()
        End Try
    End Sub

    Sub addMultiProduct(ByVal productColection As List(Of Product))
        query = "INSERT INTO produit(code, name, price, description) values(@val, @val1, @val2, @val4)"
        Try
            For Each product As Product In productColection
                cmd = New MySqlCommand(query, mConnexion)
                cmd.Parameters.AddWithValue("@val", product.getCode)
                cmd.Parameters.AddWithValue("@val1", product.getNom)
                cmd.Parameters.AddWithValue("@val2", CInt(product.getPrixAchat))
                'cmd.Parameters.AddWithValue("@val3", CInt(product.getPrixDeVente))
                cmd.Parameters.AddWithValue("@val4", product.getDescription)

                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Next
        Catch ex As Exception
            MsgBox("Erreur d'execution. Source erreur: " & ex.ToString)
        Finally
            If IsNothing(cmd) Then
                cmd.Dispose()
            End If
            Me.updateProductDataGrid()
        End Try
    End Sub

    Public Function getProduct(ByVal index As Integer)
        Dim loadProduct As New Product
        Try
            query = "SELECT * FROM produit WHERE id = @val"
            cmd = New MySqlCommand(query, mConnexion)
            cmd.Parameters.AddWithValue("@val", index)

            reader = cmd.ExecuteReader

            While reader.Read
                EditProduct.CODE_PRODUIT.Text = reader.GetString("code")
                EditProduct.NOM_PRODUIT.Text = reader.GetString("name")
                EditProduct.PRIX_ACHAT.Text = reader.GetString("price")
                EditProduct.DESCRIPTION_PRODUIT.Text = reader.GetString("description")
                loadProduct.setId(CInt(reader.GetString("id")))
                loadProduct.setCode(reader.GetString("code"))
                loadProduct.setNom(reader.GetString("name"))
                loadProduct.setPrixAchat(CInt(reader.GetString("price")))
                loadProduct.setDescription(reader.GetString("description"))
            End While
        Catch ex As Exception
            MsgBox("Une erreur fatal s'est produit veillez contacter votre administrateur")
        Finally
            cmd.Dispose()
            reader.Close()
        End Try
        Return loadProduct
    End Function
    Public Function getProductByCode(code As String) As Product
        query = "SELECT * FROM produit WHERE code = @val"
        produit = New Product
        Try
            cmd = New MySqlCommand(query, mConnexion)
            cmd.Parameters.AddWithValue("@val", code)
            reader = cmd.ExecuteReader
            If reader IsNot Nothing Then
                reader.Read()
                produit.setId(CInt(reader.GetString("id")))
                produit.setCode(reader.GetString("code"))
                produit.setNom(reader.GetString("name"))
                produit.setPrixAchat(CInt(reader.GetString("price")))
                produit.setQuantite(CInt(reader.GetString("quantite")))
                produit.setStatus(reader.GetString("status"))
            End If
        Catch ex As Exception
            MsgBox("Erreur de communication avec la base de donnée: " & ex.ToString)
        Finally
            cmd.Dispose()
            reader.Close()
        End Try
        Return produit
    End Function
    Public Function getProduct(name As String) As Product
        query = "SELECT * FROM produit WHERE name = @val"
        produit = New Product
        Try
            cmd = New MySqlCommand(query, mConnexion)
            cmd.Parameters.AddWithValue("@val", name)
            reader = cmd.ExecuteReader
            If reader IsNot Nothing Then
                reader.Read()
                produit.setId(CInt(reader.GetString("id")))
                produit.setCode(reader.GetString("code"))
                produit.setNom(reader.GetString("name"))
                produit.setPrixAchat(CInt(reader.GetString("price")))
                produit.setQuantite(CInt(reader.GetString("quantite")))
                produit.setStatus(reader.GetString("status"))
            End If
        Catch ex As Exception
            MsgBox("Erreur de communication avec la base de donnée: " & ex.ToString)
        Finally
            cmd.Dispose()
            reader.Close()
        End Try
        Return produit
    End Function
    Public Sub edditProduct(ByVal product As Product)
        query = "UPDATE produit SET code = @val1, name = @val2, price = @val3, description = @val4 WHERE id = @val5"

        Try
            cmd = New MySqlCommand(query, mConnexion)
            cmd.Parameters.AddWithValue("@val1", product.getCode)
            cmd.Parameters.AddWithValue("@val2", product.getNom)
            cmd.Parameters.AddWithValue("@val3", CInt(product.getPrixAchat))
            cmd.Parameters.AddWithValue("@val4", product.getDescription)
            cmd.Parameters.AddWithValue("@val5", CInt(product.getId))

            cmd.ExecuteNonQuery()
            MsgBox("Modifications effectuées sur le produit Code: " & product.getCode)
        Catch ex As Exception
            MsgBox("Erreur de connexion. Cause probable: " & ex.ToString)
        Finally
            If IsNothing(cmd) Then
                cmd.Dispose()
            End If
            Me.updateProductDataGrid()
        End Try

    End Sub
    Public Function setProduct(ByVal source As Integer)
        produit = New Product
        Select Case (source)
            Case ADD_PRODUCT_WIN
                'Instruction
            Case EDDIT_PRODUCT_WIN
                produit.setCode(EditProduct.CODE_PRODUIT.Text)
                produit.setNom(EditProduct.NOM_PRODUIT.Text)
                produit.setPrixAchat(CInt(EditProduct.PRIX_ACHAT.Text))
                produit.setDescription(EditProduct.DESCRIPTION_PRODUIT.Text)
            Case DELETE_PRODUCT_WIN
                'Instruction
            Case Else
                'instruction
        End Select

        Return produit
    End Function
    Sub deletteProduct(ByVal index As Integer)
        query = "DELETE FROM produit WHERE id = @val"
        Try
            cmd = New MySqlCommand(query, mConnexion)
            cmd.Parameters.AddWithValue("val", index)
            cmd.ExecuteNonQuery()

            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Erreur de commande. Source erreur: " & ex.ToString)
        Finally
            If IsNothing(cmd) Then
                cmd.Dispose()
            End If
            Me.updateProductDataGrid()
        End Try
    End Sub

#Region "Private sub and function"
    Public Sub updateProductDataGrid()
        query = "SELECT * FROM produit"
        Try
            cmd = New MySqlCommand(query, mConnexion)
            reader = cmd.ExecuteReader
            MainController.PRODUCT_DATA_GRID.Rows.Clear()

            While reader.Read
                MainController.PRODUCT_DATA_GRID.Rows.Add(reader.GetString("id"), reader.GetString("code"),
                                                          reader.GetString("name"), reader.GetString("price"),
                                                          reader.GetString("description"), reader.GetString("status"),
                                                          reader.GetString("quantite"))
            End While
        Catch ex As Exception
            MsgBox("Erreur de commande. Source erreur: " & ex.ToString)
        Finally
            cmd.Dispose()
            reader.Close()
        End Try
    End Sub
    Public Function getRowSelectedIdValue()
        Dim idpro As Integer
        Try
            idpro = CInt(MainController.PRODUCT_DATA_GRID.CurrentRow.Cells().Item(0).Value)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return idpro
    End Function
    Public Function rechercheFilter(text As String) As List(Of Product)
        query = "SELECT * FROM produit WHERE quantite > 0 AND name LIKE '%" & text & "%'"
        mListOfProduct = New List(Of Product)
        Try
            cmd = New MySqlCommand(query, mConnexion)
            reader = cmd.ExecuteReader
            While reader.Read
                mListOfProduct.Add(New Product(reader.GetString("code"), reader.GetString("name"), reader.GetString("price"), reader.GetString("description")))
            End While
        Catch ex As Exception
            MsgBox("Erreur de command. Source: " & ex.ToString)
        Finally
            cmd.Dispose()
            reader.Close()
        End Try
        Return mListOfProduct
    End Function
    Public Function rechercheFilterParCode(text As String) As List(Of Product)
        query = "SELECT * FROM produit WHERE quantite > 0 AND code LIKE '" & text & "%'"
        mListOfProduct = New List(Of Product)
        Try
            cmd = New MySqlCommand(query, mConnexion)
            reader = cmd.ExecuteReader
            While reader.Read
                mListOfProduct.Add(New Product(reader.GetString("code"), reader.GetString("name"), reader.GetString("price"), reader.GetString("description")))
            End While
        Catch ex As Exception
            MsgBox("Erreur de command. Source: " & ex.ToString)
        Finally
            cmd.Dispose()
            reader.Close()
        End Try
        Return mListOfProduct
    End Function
    Public Function rechercheFilterParCodeIn(text As String) As List(Of Product)
        query = "SELECT * FROM produit WHERE code LIKE '" & text & "%'"
        mListOfProduct = New List(Of Product)
        Try
            cmd = New MySqlCommand(query, mConnexion)
            reader = cmd.ExecuteReader
            While reader.Read
                mListOfProduct.Add(New Product(reader.GetString("code"), reader.GetString("name"), reader.GetString("price"), reader.GetString("description")))
            End While
        Catch ex As Exception
            MsgBox("Erreur de command. Source: " & ex.ToString)
        Finally
            cmd.Dispose()
            reader.Close()
        End Try
        Return mListOfProduct
    End Function
#End Region
End Class
