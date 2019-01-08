
Public Class MainController
#Region "section variable"
    Dim connexion As Connexion
    Dim product As Product
    Dim productManager As ProductManager
    Dim clientManager As ClientManager
    Dim dataGridManager As DataGridManager
    Dim basicCommande As BasicCommand
    Dim basicCommandeManager As BasicCommandManager
    Dim leClient As Client
    Dim productDataController As New DataGridController
    Dim dastBoad As DastBoad
    Dim host As String
    Dim stockManager As StockManager
#End Region
    Private Sub MainController_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activatButton(False)
        Me.PRODUCT_DATA_GRID.Visible = False
        Me.CLIENT_DATA_VIEW.Visible = False
        Me.VU_RAPPORT.Visible = False
        Me.BAR_ETAT.Text = "En attente de connexion"
        host = ""
    End Sub
#Region "Connexion Event"
    Private Sub BT_CON_Click(sender As Object, e As EventArgs) Handles BT_CON.Click
        Dim exite As Boolean = False
        Do
            ConnexionBeeshop.ShowDialog()
            If ConnexionBeeshop.DialogResult = DialogResult.OK Then
                connexion = New Connexion(ConnexionBeeshop.LOGING.Text, ConnexionBeeshop.PASSWORD.Text, host)
                If connexion.establishConnexion Then
                    activatButton(True)
                    productManager = New ProductManager(connexion)
                    clientManager = New ClientManager(connexion)
                    productManager.updateProductDataGrid()
                    clientManager.updateClientDataGrid()
                    dataGridManager = New DataGridManager
                    basicCommandeManager = New BasicCommandManager(connexion)
                    dastBoad = New DastBoad()
                    UpDateTimer.Enabled = True
                    stockManager = New StockManager(connexion)
                    stockManager.uppdateProductStat()
                    exite = True
                End If
            Else
                exite = True
            End If
        Loop Until (exite)
    End Sub
    Private Sub BT_DCO_Click(sender As Object, e As EventArgs) Handles BT_DCO.Click
        If Not connexion.closeConnexion Then
            UpDateTimer.Enabled = False
            activatButton(False)
            dataGridManager.deconnexionView()

        End If
    End Sub
#End Region
#Region "Parametre de l'hote"
    Private Sub MENU_PROGRAMME_Click(sender As Object, e As EventArgs) Handles MENU_PROGRAMME.Click
        AppConfig.ShowDialog()
        host = AppConfig.SERVER_NAME.Text
    End Sub
#End Region
#Region "Product manager function"
    Private Sub BT_PRODUCT_ADD_Click(sender As Object, e As EventArgs) Handles BT_PRODUCT_ADD.Click
        Ajoute_Un_Produit.ShowDialog()
        If Ajoute_Un_Produit.DialogResult = DialogResult.OK Then
            product = New Product(Ajoute_Un_Produit.CODE_PRODUIT.Text, Ajoute_Un_Produit.NOM_PRODUIT.Text, Ajoute_Un_Produit.PRIX_ACHAT.Text, Ajoute_Un_Produit.DESCRIPTION_PRODUIT.Text)
            productManager.addProduct(product)
        End If

    End Sub
    Private Sub BT_EDIT_PRODUCT_Click(sender As Object, e As EventArgs) Handles BT_EDIT_PRODUCT.Click
        product = productManager.getProduct(productManager.getRowSelectedIdValue())
        EditProduct.ShowDialog()
        If EditProduct.DialogResult = DialogResult.Cancel Then
            Exit Sub
        End If
        product.setCode(EditProduct.CODE_PRODUIT.Text)
        product.setNom(EditProduct.NOM_PRODUIT.Text)
        product.setPrixAchat(CInt(EditProduct.PRIX_ACHAT.Text))
        product.setDescription(EditProduct.DESCRIPTION_PRODUIT.Text)
        productManager.edditProduct(product)
    End Sub
    Private Sub BT_DEL_PRODUCT_Click(sender As Object, e As EventArgs) Handles BT_DEL_PRODUCT.Click
        If MsgBox("Etre vous sûr de vouloir supprimer ce produit de la Base de donné ?" & Chr(13) & "Attention: cette action est irréversible.", 4, "Avertissement !") = MsgBoxResult.No Then
            Exit Sub
        End If
        productManager.deletteProduct(productManager.getRowSelectedIdValue())
    End Sub
    Private Sub BT_STOCK_MANAGER_Click(sender As Object, e As EventArgs) Handles BT_STOCK_MANAGER.Click
        WIN_STOCK_MANAGER.Show()
    End Sub
#End Region
#Region "Command manager"
    Private Sub BT_ADD_COMMAND_Click(sender As Object, e As EventArgs) Handles BT_ADD_COMMAND.Click
        AddCommandWin.ShowDialog()
        If AddCommandWin.DialogResult = DialogResult.Cancel Then
            Exit Sub
        End If
        basicCommandeManager.addCommand(AddCommandWin.getCommand)
    End Sub
    Private Sub BT_DELETE_COMMAND_Click(sender As Object, e As EventArgs) Handles BT_DELETE_COMMAND.Click
        If MsgBox("Etre vous sûr de vouloir supprimer cette commande de la Base de donné ?" & Chr(13) & "Attention: cette action est irréversible.", 4, "Avertissement !") = MsgBoxResult.No Then
            Exit Sub
        End If
        basicCommandeManager.deleteCommand(basicCommandeManager.getRowSelectedIdValue)
    End Sub
    Private Sub BT_EDIT_COMMAND_Click(sender As Object, e As EventArgs) Handles BT_EDIT_COMMAND.Click

    End Sub
#End Region
#Region "Client manager function"
    Private Sub BT_ADD_CLIENT_Click(sender As Object, e As EventArgs) Handles BT_ADD_CLIENT.Click
        AddClientWin.Text = "Ajouter un client"
        AddClientWin.ShowDialog()
        If AddClientWin.DialogResult = DialogResult.Cancel Then
            MsgBox("Le progralle va sort de la fonction ajouter")
            Exit Sub
        End If
        clientManager.addClient(New Client(AddClientWin.CLIENT_NAME.Text, CInt(AddClientWin.CLIENT_CONTACT.Text), AddClientWin.CLIENT_COMMUNE.Text))
    End Sub
    Private Sub BT_EDIT_ClIENT_Click(sender As Object, e As EventArgs) Handles BT_EDIT_ClIENT.Click
        leClient = clientManager.getClient(clientManager.getRowSelectedIdValue)
        If leClient Is Nothing Then
            MsgBox("Aucune client n'a été selctionner.")
            Exit Sub
        End If
        AddClientWin.Text = "Modification de Client"
        AddClientWin.CLIENT_NAME.Text = leClient.getName
        AddClientWin.CLIENT_CONTACT.Text = leClient.getContact
        AddClientWin.CLIENT_COMMUNE.Text = leClient.getCommune
        AddClientWin.ShowDialog()
        leClient.setName(AddClientWin.CLIENT_NAME.Text)
        leClient.setContact(CInt(AddClientWin.CLIENT_CONTACT.Text))
        leClient.setCommune(AddClientWin.CLIENT_COMMUNE.Text)
        clientManager.edditClient(clientManager.getRowSelectedIdValue, leClient)
    End Sub
    Private Sub BT_DEL_CLIENT_Click(sender As Object, e As EventArgs) Handles BT_DEL_CLIENT.Click
        If MsgBox("Etre vous sûr de vouloir supprimer ce client de DATA BASE ?" & Chr(13) & "Attention: cette action est irréversible.", 4, "Avertissement !") = MsgBoxResult.No Then
            Exit Sub
        End If
        clientManager.deleteClient(clientManager.getRowSelectedIdValue)
    End Sub
#End Region
#Region "View function"
    Private Sub UpDateTimer_Tick(sender As Object, e As EventArgs) Handles UpDateTimer.Tick
        If dastBoad.upDateDastBoad() Then
            UpDateTimer.Enabled = False
            activatButton(False)
            dataGridManager.deconnexionView()
            connexion.closeConnexion()
        Else
            'basicCommandeManager.updateCommandDataGrid()
            'productManager.updateProductDataGrid()
            'stockManager.updateStockListe()
        End If
    End Sub
    Private Sub BT_VUE_COM_Click(sender As Object, e As EventArgs) Handles BT_VUE_COM.Click
        basicCommandeManager.updateCommandDataGrid()
        dataGridManager.commandView()
    End Sub
    Private Sub BT_VUE_PRODUIT_Click(sender As Object, e As EventArgs) Handles BT_VUE_PRODUIT.Click
        productManager.updateProductDataGrid()
        dataGridManager.productView()
    End Sub
    Private Sub BT_VUE_CLIENT_Click(sender As Object, e As EventArgs) Handles BT_VUE_CLIENT.Click
        dataGridManager.clientView()
    End Sub
    Private Sub BT_VUE_FOURNISSEUR_Click(sender As Object, e As EventArgs) Handles BT_VUE_FOURNISSEUR.Click
        dataGridManager.fournisseurView()
    End Sub
    Private Sub BT_PRODUCT_STOCK_Click(sender As Object, e As EventArgs) Handles BT_PRODUCT_STOCK.Click
        stockManager.updateStockListe()
        dataGridManager.stockView()
    End Sub
    Private Sub VU_COMMAND_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles VU_COMMAND.CellClick
        If basicCommandeManager.getSelectedCellContenteValue <> "En Cours" Then
            Exit Sub
        End If
        'MsgBox(basicCommandeManager.getProductNameFromCounrrantRow)
        stockManager.updateProductQuantity(basicCommandeManager.getProductNameFromCounrrantRow)
        basicCommandeManager.validateCourrantStat(basicCommandeManager.getRowSelectedIdValue)
        'MsgBox(basicCommandeManager.getRowSelectedIdValue)
    End Sub
#End Region
#Region "Function interface"
    Public Sub activatButton(ByVal seting As Boolean)
        With Me.
            BT_VUE_COM.Enabled = seting
            BT_VUE_CLIENT.Enabled = seting
            BT_VUE_PRODUIT.Enabled = seting
            BT_VUE_FOURNISSEUR.Enabled = seting

            BT_ADD_CLIENT.Enabled = seting
            BT_EDIT_ClIENT.Enabled = seting
            BT_DEL_CLIENT.Enabled = seting

            BT_ADD_COMMAND.Enabled = seting
            BT_DELETE_COMMAND.Enabled = seting
            BT_EDIT_COMMAND.Enabled = seting

            BT_PRODUCT_ADD.Enabled = seting
            BT_DEL_PRODUCT.Enabled = seting
            BT_EDIT_PRODUCT.Enabled = seting
            BT_PRODUCT_STOCK.Enabled = seting

            BT_RAP_JOUR.Enabled = seting
            BT_RAP_WEEK.Enabled = seting
            BT_RAP_MONTH.Enabled = seting

        End With
        If seting Then
            Me.BT_CON.Enabled = False
            Me.BT_DCO.Enabled = True
            Me.PRODUCT_DATA_GRID.Visible = True
        Else
            Me.BT_CON.Enabled = True
            Me.BT_DCO.Enabled = False
            Me.PRODUCT_DATA_GRID.Visible = False
        End If
    End Sub
    Public Function getMainConnexion() As Connexion
        Return connexion
    End Function
#End Region
    Private Sub STOCK_LIST_Click(sender As Object, e As EventArgs) Handles STOCK_LIST.CellValueChanged
        Try
            stockManager.updateProductStockValue()
        Catch ex As Exception

        End Try
    End Sub
End Class

