Public Class Command
    Private mId As Integer
    Private mProductList As List(Of Product)
    Private mClient As Client
    Private mAdresseDeLivraison As String
    Private mNetToPay As Integer
    Private mCommandStat As String
    Private mIdAgent As Integer

#Region "Constructor"
    Sub New()

    End Sub
    Sub New(productList As List(Of Product), client As Client, adressDeLivraison As String, netToPay As Integer, commandStat As String, agent As Integer)
        mProductList = productList
        mClient = client
        mAdresseDeLivraison = adressDeLivraison
        mNetToPay = netToPay
        mCommandStat = commandStat
        mIdAgent = agent
    End Sub
    Sub New(id As Integer, productList As List(Of Product), client As Client, adressDeLivraison As String, netToPay As Integer, commandStat As String, agent As Integer)
        mId = id
        mProductList = productList
        mClient = client
        mAdresseDeLivraison = adressDeLivraison
        mNetToPay = netToPay
        mCommandStat = commandStat
        mIdAgent = agent
    End Sub
#End Region

#Region "SETTER"
    Private Sub setId(id As Integer)
        mId = id
    End Sub
    Public Sub setProduct(productList As List(Of Product))
        mProductList = productList
    End Sub
    Public Sub setClient(client As Client)
        mClient = client
    End Sub
    Public Sub setAdressLivraison(adress As String)
        mAdresseDeLivraison = adress
    End Sub
    Public Sub setNetToPay(netToPay As Integer)
        mNetToPay = netToPay
    End Sub
    Public Sub setCommandStat(commandStat As String)
        mCommandStat = commandStat
    End Sub
    Public Sub setAgent(agent As Integer)
        mIdAgent = agent
    End Sub
#End Region

#Region "GETTER"
    Public Function getId() As Integer
        Return mId
    End Function
    Public Function getPoductList() As List(Of Product)
        Return mProductList
    End Function
    Public Function getClient() As Client
        Return mClient
    End Function
    Public Function getAdressLivraison() As String
        Return mAdresseDeLivraison
    End Function
    Public Function getNetToPay() As Integer
        Return mNetToPay
    End Function
    Public Function getCommandStat() As String
        Return mCommandStat
    End Function
    Public Function getAgent() As Integer
        Return mIdAgent
    End Function
#End Region

    Public Sub addProduct(product As Product)
        mProductList.Add(product)
    End Sub
    Public Sub detProduct(product As Product, index As Integer)
        Try
            mProductList.RemoveAt(index)
        Catch ex As Exception
            MsgBox("Erreur d'execution du code. Source: " & ex.ToString)
        End Try
    End Sub

End Class
