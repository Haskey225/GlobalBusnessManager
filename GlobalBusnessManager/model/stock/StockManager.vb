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
            MsgBox("La connexion au serveur semble être perdue." & Chr(13) & "Veuillez vous reconnecter s'il vous plaît")
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
            MsgBox("La connexion au serveur semble être perdue." & Chr(13) & "Veuillez vous reconnecter s'il vous plaît")
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
            MsgBox("La connexion au serveur semble être perdue." & Chr(13) & "Veuillez vous reconnecter s'il vous plaît")
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
            MsgBox("La connexion au serveur semble être perdue." & Chr(13) & "Veuillez vous reconnecter s'il vous plaît")
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
    Public Sub updateProductQuantityByCodem(code As String, aretirer As Integer)
        Me.uppdateProductStat()
        Dim quantite As Integer
        mQuery = "SELECT quantite FROM produit WHERE code = @val"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val", code)
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
        quantite = quantite - aretirer
        mQuery = "UPDATE produit SET quantite = @val1 WHERE code = @val2"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val1", quantite)
            mCmd.Parameters.AddWithValue("@val2", code)

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
    Public Sub updateProductQuantityByCodep(code As String, aRetirer As Integer)
        Me.uppdateProductStat()
        Dim quantite As Integer
        mQuery = "SELECT quantite FROM produit WHERE code = @val"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val", code)
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
        quantite = quantite + aRetirer
        mQuery = "UPDATE produit SET quantite = @val1 WHERE code = @val2"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val1", quantite)
            mCmd.Parameters.AddWithValue("@val2", code)

            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erreur d'execution. Source de l'erreur: " & ex.ToString)
        Finally


            If mCmd IsNot Nothing Then
                mCmd.Dispose()
            End If
            If mReader IsNot Nothing Then
                mReader.Close()
            End If
            Me.uppdateProductStat()
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
    'Entrer Sortie function
#Region "Section entrer sortir"
    Public Sub addInObject(inObject As InObject)
        mQuery = "INSERT INTO entree(date_e, produit_id, stock_init, quantite, stock_final) VALUE(@val1, @val2, @val3, @val4, @val5)"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            With mCmd.Parameters
                .AddWithValue("@val1", inObject.getDate.ToShortDateString)
                .AddWithValue("@val2", inObject.getProductId)
                .AddWithValue("@val3", inObject.getStockIni)
                .AddWithValue("@val4", inObject.getQuantite)
                .AddWithValue("@val5", inObject.getStockFinal)
            End With
            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erreur d'execution du programme. Source de l'erreur: " & ex.ToString)
        Finally
            eraseMemory()
            updateProductQuantityByCodep(inObject.getProductId, inObject.getQuantite)
        End Try
    End Sub
    Public Sub addOutObject(outObject As OutObject)
        mQuery = "INSERT INTO sortie (date_s, produit_id, cause, destination, quantite) VALUE(@val1, @val2, @val3, @val4, @val5)"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            With mCmd.Parameters
                .AddWithValue("@val1", outObject.getDate.ToShortDateString)
                .AddWithValue("@val2", outObject.getProductId)
                .AddWithValue("@val3", outObject.getCause)
                .AddWithValue("@val4", outObject.getDestination)
                .AddWithValue("@val5", outObject.getQuantite)
            End With
            mCmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erreur d'execution du programme. Source de l'erreur: " & ex.ToString)
        Finally
            eraseMemory()
            updateProductQuantityByCodem(outObject.getProductId, outObject.getQuantite)
        End Try
    End Sub
    Public Function getInObject() As List(Of InObject)
        Dim inObjectList As New List(Of InObject)
        mQuery = "SELECT * FROM entree"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mReader = mCmd.ExecuteReader
            While mReader.Read
                inObjectList.Add(New InObject(mReader.GetString("id"), CDate(mReader.GetString("date_e")).ToShortDateString, mReader.GetString("produit_id"),
                                              CInt(mReader.GetString("stock_init")), CInt(mReader.GetString("quantite")),
                                              CInt(mReader.GetString("stock_final"))))
            End While
        Catch ex As Exception
            MsgBox("Erreur d'execution du programme. Source: " & ex.ToString)
        Finally
            eraseMemory()
        End Try
        Return inObjectList
    End Function
    Public Function getOutObject() As List(Of OutObject)
        Dim outObjectList As New List(Of OutObject)
        mQuery = "SELECT * FROM sortie"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mReader = mCmd.ExecuteReader

            While mReader.Read
                outObjectList.Add(New OutObject(mReader.GetString("id"), CDate(mReader.GetString("date_s")).ToShortDateString, mReader.GetString("produit_id"),
                                              mReader.GetString("cause"), mReader.GetString("destination"),
                                              mReader.GetString("quantite")))
            End While
        Catch ex As Exception
            MsgBox("Erreur d'execution du programe. Source: " & ex.ToString)
        Finally
            eraseMemory()
        End Try
        Return outObjectList
    End Function
#End Region

    Public Sub eraseMemory()
        If mCmd IsNot Nothing Then
            mCmd.Dispose()
        End If
        If mReader IsNot Nothing Then
            mReader.Close()
        End If
    End Sub
End Class
