Public Class Story
    Private mId As Integer
    Private mProduct As Product
    Private mQuantite As Integer
    Private mDestination As String
    Private mCause As String

    Sub New()
        mId = 0
        mProduct = New Product
        mQuantite = 0
        mDestination = "NULL"
        mCause = "NULL"
    End Sub
    Sub New(product As Product, quantite As Integer, destination As String, cause As String)
        mProduct = product
        mQuantite = quantite
        mDestination = destination
        mCause = cause
    End Sub
    Sub New(id As Integer, product As Product, quantite As Integer, destination As String, cause As String)
        mId = id
        mProduct = product
        mQuantite = quantite
        mDestination = destination
        mCause = cause
    End Sub

    'SETTER
    Private Sub setId(id As Integer)
        mId = id
    End Sub
    Private Sub setProduct(product As Product)
        mProduct = product
    End Sub
    Private Sub setQuantite(quantite As Integer)
        mQuantite = quantite
    End Sub
    Private Sub setCause(cause As String)
        mCause = cause
    End Sub

    'GETTER
    Public Function getId() As Integer
        Return mId
    End Function
    Public Function getProduct() As Product
        Return mProduct
    End Function
    Public Function getQuantite() As Integer
        Return mQuantite
    End Function
    Public Function getDestination() As String
        Return mDestination
    End Function
    Public Function getCause() As String
        Return mCause
    End Function

End Class
