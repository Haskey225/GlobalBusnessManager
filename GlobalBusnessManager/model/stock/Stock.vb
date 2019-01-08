Imports MySql.Data.MySqlClient

Public Class Stock
    Private mDate As Date
    Private mProduct As Product
    Private mDestination As String
    Private mCause As String
    Private mQuantite As Integer
    Private mPrixAchat As Integer

    Sub New()
    End Sub
    'SETTER
    Public Sub setDate(lDate As Date)
        mDate = lDate
    End Sub
    Public Sub setProduct(product As Product)
        mProduct = product
    End Sub
    Public Sub setDestination(destination As String)
        mDestination = destination
    End Sub
    Public Sub setCause(cause As String)
        mCause = cause
    End Sub
    Public Sub setQuantite(quantite As Integer)
        mQuantite = quantite
    End Sub
    Public Sub setPrixAchat(prixAchat As Integer)
        mPrixAchat = prixAchat
    End Sub
    'GETTER
    Public Function getDate() As Date
        Return mDate
    End Function
    Public Function getProduct() As Product
        Return mProduct
    End Function
    Public Function getDestination() As String
        Return mDestination
    End Function
    Public Function getCause() As String
        Return mCause
    End Function
    Public Function getQuantite() As Integer
        Return mQuantite
    End Function
    Public Function getPrixAchat() As Integer
        Return mPrixAchat
    End Function
End Class
