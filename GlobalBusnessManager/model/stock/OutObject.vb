Public Class OutObject
    Private mId As Integer
    Private mDate As Date
    Private mProductId As String
    Private mCause As String
    Private mDestination As String
    Private mQuantite As Integer
    Sub New()
        mId = 0
        mDate = Date.Now.ToShortDateString
        mProductId = "INCONU"
        mCause = "INCONU"
        mDestination = "INCONU"
        mQuantite = 0
    End Sub
    Sub New(idate As Date, productId As String, cause As String, destination As String, quantite As Integer)
        mId = 0
        mDate = idate
        mProductId = productId
        mCause = cause
        mDestination = destination
        mQuantite = quantite
    End Sub
    Sub New(id As Integer, idate As Date, productId As String, cause As String, destination As String, quantite As Integer)
        mId = id
        mDate = idate
        mProductId = productId
        mCause = cause
        mDestination = destination
        mQuantite = quantite
    End Sub

#Region "Getter section"
    Public Function getId() As Integer
        Return mId
    End Function
    Public Function getDate() As Date
        Return mDate
    End Function
    Public Function getProductId() As String
        Return mProductId
    End Function
    Public Function getCause() As String
        Return mCause
    End Function
    Public Function getDestination() As String
        Return mDestination
    End Function
    Public Function getQuantite() As Integer
        Return mQuantite
    End Function
#End Region

#Region "Setter section"
    Public Sub setId(id As Integer)
        mId = id
    End Sub
    Public Sub setDate(iDate As Date)
        mDate = iDate
    End Sub
    Public Sub setProductId(productId As String)
        mProductId = productId
    End Sub
    Public Sub setCause(cause As String)
        mCause = cause
    End Sub
    Public Sub setDestination(destination As String)
        mDestination = destination
    End Sub
    Public Sub setQuantite(quantite As Integer)
        mQuantite = quantite
    End Sub
#End Region
End Class
