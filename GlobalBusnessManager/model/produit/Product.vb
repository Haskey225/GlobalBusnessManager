Public Class Product
    Private mId As Integer
    Private mCode As String
    Private mNom As String
    Private mPrixAchat As Integer
    Private mDescription As String
    Private mStatus As String
    Private mQuantity As Integer

    Sub New(code As String, name As String, quantite As Integer)
        mCode = code
        mNom = name
        mPrixAchat = 0
        mDescription = "Aucun descriptif"
        mStatus = "Inconus"
        mQuantity = quantite
    End Sub
    Sub New(ByVal code As String, ByVal nom As String, ByVal prixAchat As Integer, ByVal descriptif As String)
        mCode = code
        mNom = nom
        mPrixAchat = prixAchat
        mDescription = descriptif
        mStatus = ""
        mQuantity = 0
    End Sub
    Sub New(ByVal code As String, ByVal nom As String, ByVal prixAchat As Integer, ByVal descriptif As String, ByVal status As String, ByVal quantite As Integer)
        mCode = code
        mNom = nom
        mPrixAchat = prixAchat
        mDescription = descriptif
        mStatus = status
        mQuantity = quantite
    End Sub
    Sub New(ByVal id As Integer, ByVal code As String, ByVal nom As String, ByVal prixAchat As Integer, ByVal descriptif As String, ByVal status As String, ByVal quantite As Integer)
        mId = id
        mCode = code
        mNom = nom
        mPrixAchat = prixAchat
        mDescription = descriptif
        mStatus = status
        mQuantity = quantite
    End Sub
    Sub New()
        mCode = "Sans Code"
        mNom = "Sans Nom"
        mPrixAchat = 0
        mDescription = "Aucun descriptif"
        mStatus = "Inconus"
        mQuantity = 0
    End Sub

    'Getter for class
    Function getCode() As String
        Return mCode
    End Function
    Function getId() As Integer
        Return mId
    End Function
    Function getNom() As String
        Return mNom
    End Function
    Function getPrixAchat() As Integer
        Return mPrixAchat
    End Function
    Function getDescription() As String
        Return mDescription
    End Function
    Function getStatus() As String
        Return mStatus
    End Function
    Function getQuantite() As Integer
        Return mQuantity
    End Function

    'Setter for Class
    Sub setCode(ByVal code As String)
        mCode = code
    End Sub
    Sub setId(ByVal id As Integer)
        mId = id
    End Sub
    Sub setNom(ByVal nom As String)
        mNom = nom
    End Sub
    Sub setPrixAchat(ByVal prixAchat As Integer)
        mPrixAchat = prixAchat
    End Sub
    Sub setDescription(ByVal description As String)
        mDescription = description
    End Sub
    Sub setStatus(ByVal status As String)
        mStatus = status
    End Sub
    Sub setQuantite(ByVal quantite As Integer)
        mQuantity = quantite
    End Sub
End Class
