Public Class Client
    Private mId As Integer
    Private mName As String
    Private mContact As Integer
    Private mCommune As String

    Sub New()
        mName = ""
        mContact = 0
        mCommune = ""
    End Sub
    Sub New(ByVal name As String, ByVal contact As Integer, ByVal commune As String)
        mName = name
        mContact = contact
        mCommune = commune
    End Sub
    Sub New(ByVal id As Integer, ByVal name As String, ByVal contact As Integer, ByVal commune As String)
        mId = id
        mName = name
        mContact = contact
        mCommune = commune
    End Sub
#Region "Gette"
    Public Function getId()
        Return mId
    End Function
    Public Function getName() As String
        Return mName
    End Function
    Public Function getContact() As Integer
        Return mContact
    End Function

    Public Function getCommune() As String
        Return mCommune
    End Function
#End Region

#Region "Setter"
    Public Sub setName(ByVal name As String)
        mName = name
    End Sub
    Public Sub setContact(ByVal contact As Integer)
        mContact = contact
    End Sub
    Public Sub setCommune(ByVal commune As String)
        mCommune = commune
    End Sub
#End Region

End Class
