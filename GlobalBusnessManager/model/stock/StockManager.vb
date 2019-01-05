Imports MySql.Data.MySqlClient
Public Class StockManager
    Private mListOfProduct As List(Of Product)
    Private mQuery As String
    Private mCmd As MySqlCommand
    Private mConnexion As MySqlConnection
    Private mReader As MySqlDataReader
    Private mExecuteError As Boolean
    Sub New(connexion As Connexion)
        mConnexion = connexion.getConnexion
        mExecuteError = False
    End Sub

    'Recuperation de tou les produit et retour a la DATA GRID cette fonction est a appeler frequemment: Chaque 30 seconde
    Public Function getUnstockedProducts() As List(Of Product)
        If mExecuteError Then
            Return New List(Of Product)
            Exit Function
        End If
        mListOfProduct = New List(Of Product)
        mQuery = "SELECT id, name, code, quantite FROM produit WHERE quantite = 0"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mReader = mCmd.ExecuteReader
            If mReader IsNot Nothing Then
                While mReader.Read
                    mListOfProduct.Add(New Product(mReader.GetString("code"), mReader.GetString("name"), CInt(mReader.GetString("quantite"))))
                End While
            End If
        Catch ex As Exception
            mExecuteError = True
            MsgBox("La connexion au serveur semble être perdue.")
        Finally
            If mCmd IsNot Nothing Then
                mCmd.Dispose()
            End If
            If mReader IsNot Nothing Then
                mReader.Close()
            End If
        End Try
        Return mListOfProduct
    End Function
    Public Function getLowStockedProducts() As List(Of Product)
        If mExecuteError Then
            Return New List(Of Product)
            Exit Function
        End If
        mListOfProduct = New List(Of Product)
        mQuery = "SELECT id, name, code, quantite FROM produit WHERE quantite < 5 AND quantite > 0"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mReader = mCmd.ExecuteReader
            If mReader IsNot Nothing Then
                While mReader.Read
                    mListOfProduct.Add(New Product(mReader.GetString("code"), mReader.GetString("name"), CInt(mReader.GetString("quantite"))))
                End While
            End If
        Catch ex As Exception
            mExecuteError = True
            MsgBox("Erreur d'execution. Source de l'erreur: " & ex.ToString)
        Finally
            If mCmd IsNot Nothing Then
                mCmd.Dispose()
            End If
            If mReader IsNot Nothing Then
                mReader.Close()
            End If
        End Try
        Return mListOfProduct
    End Function
    Public Function getGoodStockedProducts() As List(Of Product)
        If mExecuteError Then
            Return New List(Of Product)
            Exit Function
        End If
        mListOfProduct = New List(Of Product)
        mQuery = "SELECT id, name, code, quantite FROM produit WHERE quantite >= 5 AND quantite < 30"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mReader = mCmd.ExecuteReader
            If mReader IsNot Nothing Then
                While mReader.Read
                    mListOfProduct.Add(New Product(mReader.GetString("code"), mReader.GetString("name"), CInt(mReader.GetString("quantite"))))
                End While
            End If
        Catch ex As Exception
            mExecuteError = True
            MsgBox("Erreur d'execution. Source de l'erreur: " & ex.ToString)
        Finally
            If mCmd IsNot Nothing Then
                mCmd.Dispose()
            End If
            If mReader IsNot Nothing Then
                mReader.Close()
            End If
        End Try
        Return mListOfProduct
    End Function
    Public Function getOverStockedProducts() As List(Of Product)
        If mExecuteError Then
            Return New List(Of Product)
            Exit Function
        End If
        mListOfProduct = New List(Of Product)
        mQuery = "SELECT id, name, code, quantite FROM produit WHERE quantite >= 30"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mReader = mCmd.ExecuteReader
            If mReader IsNot Nothing Then
                While mReader.Read
                    mListOfProduct.Add(New Product(mReader.GetString("code"), mReader.GetString("name"), CInt(mReader.GetString("quantite"))))
                End While
            End If
        Catch ex As Exception
            mExecuteError = True
            MsgBox("Erreur d'execution. Source de l'erreur: " & ex.ToString)
        Finally
            If mCmd IsNot Nothing Then
                mCmd.Dispose()
            End If
            If mReader IsNot Nothing Then
                mReader.Close()
            End If
        End Try
        Return mListOfProduct
    End Function
    Public Function getAllProducts() As List(Of Product)
        mListOfProduct = New List(Of Product)
        mQuery = "SELECT * FROM produit"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mReader = mCmd.ExecuteReader
            If mReader IsNot Nothing Then
                While mReader.Read
                    mListOfProduct.Add(New Product(CInt(mReader.GetString("id")), mReader.GetString("code"), mReader.GetString("name"), CInt(mReader.GetString("price")), mReader.GetString("description"), mReader.GetString("status"), CInt(mReader.GetString("quantite"))))
                End While
            End If
        Catch ex As Exception
            MsgBox("Erreur d'execution. Source de l'erreur: " & ex.ToString)
        Finally
            If mCmd IsNot Nothing Then
                mCmd.Dispose()
            End If
            If mReader IsNot Nothing Then
                mReader.Close()
            End If
        End Try
        Return mListOfProduct
    End Function

    Public Sub updateProductQuantity(name As String)
        Me.uppdateProductStat()
        Dim quantite As Integer
        mQuery = "SELECT quantite FROM produit WHERE name = @val"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val", name)
            mReader = mCmd.ExecuteReader
            If mReader IsNot Nothing Then
                mReader.Read()
                quantite = CInt(mReader.GetString("quantite"))
            End If
        Catch ex As Exception
            MsgBox("Erreur d'execution. Source de l'erreur: " & ex.ToString)
        Finally
            mCmd.Dispose()
            mReader.Close()
        End Try
        quantite -= 1
        mQuery = "UPDATE produit SET quantite = @val1 WHERE name = @val2"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val1", quantite)
            mCmd.Parameters.AddWithValue("@val2", name)

            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erreur d'execution. Source de l'erreur: " & ex.ToString)
        Finally
            Me.uppdateProductStat()

            If mCmd IsNot Nothing Then
                mCmd.Dispose()
            End If
            If mReader IsNot Nothing Then
                mReader.Close()
            End If
        End Try
    End Sub
    Public Sub uppdateProductStat()
        Dim lisOfProduct As List(Of Product)
        lisOfProduct = Me.getAllProducts()
        mQuery = "UPDATE produit SET status = @val1 WHERE id = @val2"
        Try
            For Each product As Product In lisOfProduct
                mCmd = New MySqlCommand(mQuery, mConnexion)
                If product.getQuantite = 0 Then
                    mCmd.Parameters.AddWithValue("@val1", "En Rupture")
                    mCmd.Parameters.AddWithValue("@val2", CInt(product.getId))
                    mCmd.ExecuteNonQuery()
                Else
                    mCmd.Parameters.AddWithValue("@val1", "En Stock")
                    mCmd.Parameters.AddWithValue("@val2", CInt(product.getId))
                    mCmd.ExecuteNonQuery()
                End If
                mCmd.Dispose()
            Next
        Catch ex As Exception
            MsgBox("Erreur d'execution. Source de l'erreur: " & ex.ToString)
        Finally
            If mCmd IsNot Nothing Then
                mCmd.Dispose()
            End If
            If mReader IsNot Nothing Then
                mReader.Close()
            End If
        End Try
    End Sub
    Public Sub updateStockListe()
        Dim listOfProduct As List(Of Product)
        Me.uppdateProductStat()
        MainController.STOCK_LIST.Rows.Clear()
        Try
            listOfProduct = Me.getAllProducts
            For Each product As Product In listOfProduct
                MainController.STOCK_LIST.Rows.Add(CInt(product.getId), product.getNom, product.getStatus, product.getQuantite)
            Next
        Catch ex As Exception
            MsgBox("Erreur d'execution de la commande. Source de l'erreur: " & ex.ToString)
        Finally
            If mCmd IsNot Nothing Then
                mCmd.Dispose()
            End If
            If mReader IsNot Nothing Then
                mReader.Close()
            End If
        End Try
    End Sub
    Public Sub updateProductStockValue()
        Dim id As Integer
        Dim quantite As Integer

        id = CInt(MainController.STOCK_LIST.CurrentRow.Cells().Item(0).Value)
        quantite = CInt(MainController.STOCK_LIST.CurrentRow.Cells().Item(3).Value)
        If quantite < 0 Then
            quantite = 0
        End If
        mQuery = "UPDATE produit SET quantite = @val1 WHERE id = @val2"
        mCmd = New MySqlCommand(mQuery, mConnexion)
        Try
            mCmd.Parameters.AddWithValue("@val1", quantite)
            mCmd.Parameters.AddWithValue("@val2", id)

            mCmd.ExecuteNonQuery()
            Me.uppdateProductStat()
        Catch ex As Exception
            MsgBox("Erreur d'execution de la commande. Source de l'erreur: " & ex.ToString)
        Finally
            Me.updateStockListe()

            If mCmd IsNot Nothing Then
                mCmd.Dispose()
            End If
            If mReader IsNot Nothing Then
                mReader.Close()
            End If
        End Try
    End Sub
    Public Function getExecuteError() As Boolean
        Return mExecuteError
    End Function
End Class
