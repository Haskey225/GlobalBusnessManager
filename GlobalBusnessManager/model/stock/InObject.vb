Public Class InObject
    Private mId As Integer
    Private mDate As Date
    Private mProductId As String
    Private mStockIni As Integer
    Private mQuantite As Integer
    Private mStockFinal As Integer

    Sub New()

    End Sub
    Sub New(idate As Date, productId As String, stockIni As Integer, quantite As Integer, stockFinal As Integer)
        mDate = idate
        mProductId = productId
        mStockIni = stockIni
        mQuantite = quantite
        mStockFinal = stockFinal
    End Sub
    Sub New(id As Integer, idate As Date, productId As String, stockIni As Integer, quantite As Integer, stockFinal As Integer)
        mId = id
        mDate = idate
        mProductId = productId
        mStockIni = stockIni
        mQuantite = quantite
        mStockFinal = stockFinal
    End Sub

    Public Function getId() As Integer
        Return mId
    End Function
    Public Function getDate() As Date
        Return mDate
    End Function
    Public Function getProductId() As String
        Return mProductId
    End Function
    Public Function getStockIni() As Integer
        Return mStockIni
    End Function
    Public Function getQuantite() As Integer
        Return mQuantite
    End Function
    Public Function getStockFinal() As Integer
        Return mStockFinal
    End Function

    Public Sub setId(id As Integer)
        mId = id
    End Sub
    Public Sub setDate(iDate As Date)
        mDate = iDate
    End Sub
    Public Sub setProductId(productId As String)
        mProductId = productId
    End Sub
    Public Sub setStockIni(stockIni As Integer)
        mStockIni = stockIni
    End Sub
    Public Sub setQuantite(quantite As Integer)
        mQuantite = quantite
    End Sub
    Public Sub setStockFinal(stockFinal As Integer)
        mStockFinal = stockFinal
    End Sub
End Class
