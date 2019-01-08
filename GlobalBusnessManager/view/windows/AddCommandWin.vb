Public Class AddCommandWin
    Private listProduct As List(Of Product)
    Private productManager As ProductManager
    Private product As Product
    Public command As BasicCommand
    Private productId As Integer
    Private Sub AddCommandWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DATE_COMMANDE.ReadOnly = True
        productManager = New ProductManager(MainController.getMainConnexion)
        product = New Product
        listProduct = New List(Of Product)
        command = New BasicCommand
        Me.eraseContente()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CLIENT_NAME.Text = "" Or COMMUNE_NAME.Text = "" Or CONTACT.Text = "" Or
        SELECT_PRODUCT_NAME.Text = "Entrez" Or CODE_PRODUIT.Text = "" Or PRODUCT_PRICE.Text = "" Or
        QUANTITE_PRODUIT.Text = "" Or PRODUCT_PRICE.Text = "" Or PRIX_PRODUIT_HT.Text = "" Or
        DATE_COMMANDE.Text = "" Or LIEUR_LIVRAISON.Text = "" Or FRAIR_LIVRAISON.Text = "" Or
        PRIX_PRODUIT_TTC.Text = "" Then
            MsgBox("Veuillez replir corectement les champs SVP")
            Exit Sub
        End If
        command.setClientName(Me.CLIENT_NAME.Text)
        command.setAdressLivraison(Me.COMMUNE_NAME.Text)
        command.setClientContact(Me.CONTACT.Text)
        command.setNetToPay(CInt(Me.PRIX_PRODUIT_HT.Text))
        command.setProduct(productManager.getProduct(Me.SELECT_PRODUCT_NAME.Text))
        command.setAgent(221)
        command.setCommandStat("En Cours")
        Me.Close()
    End Sub
    Private Sub SELECT_PRODUCT_NAME_TextChange(sender As Object, e As EventArgs) Handles SELECT_PRODUCT_NAME.TextChanged
        'Me.SELECT_PRODUCT_NAME.Items.Clear()
        listProduct = productManager.rechercheFilter(Me.SELECT_PRODUCT_NAME.Text)
        For Each product As Product In listProduct
            Me.SELECT_PRODUCT_NAME.Items.Add(product.getNom)
        Next
    End Sub
    Private Sub SELECT_PRODUCT_NAME_Selected(sender As Object, e As EventArgs) Handles SELECT_PRODUCT_NAME.SelectedValueChanged
        product = productManager.getProduct(Me.SELECT_PRODUCT_NAME.Text)
        Me.CODE_PRODUIT.Text = product.getCode
        Me.PRODUCT_PRICE.Text = product.getPrixAchat
        PRIX_UNITAIRE_PRODUIT.Text = product.getPrixAchat

    End Sub
    Private Sub QUANTITE_PRODUIT_TextChanged(sender As Object, e As EventArgs) Handles QUANTITE_PRODUIT.TextChanged
        Dim value As String
        value = QUANTITE_PRODUIT.Text
        If QUANTITE_PRODUIT.Text = "" Then
            value = 1
        End If
        PRIX_PRODUIT_HT.Text = CInt(value) * product.getPrixAchat
    End Sub

    Private Sub FRAIR_LIVRAISON_TextChanged(sender As Object, e As EventArgs) Handles FRAIR_LIVRAISON.TextChanged
        Dim value As String
        value = FRAIR_LIVRAISON.Text
        If FRAIR_LIVRAISON.Text = "" Then
            value = 1
        End If
        PRIX_PRODUIT_TTC.Text = CInt(PRIX_PRODUIT_HT.Text) + CInt(value)
    End Sub
#Region "Function for win"
    Private Sub eraseContente()
        With Me.
                CLIENT_NAME.Text = ""
            COMMUNE_NAME.Text = ""
            CONTACT.Text = ""

            SELECT_PRODUCT_NAME.Text = "Entrez"
            CODE_PRODUIT.Text = ""
            PRODUCT_PRICE.Text = "0"

            QUANTITE_PRODUIT.Text = "0"
            PRODUCT_PRICE.Text = ""
            PRIX_PRODUIT_HT.Text = "0"

            DATE_COMMANDE.Text = Date.Now.ToShortDateString
            LIEUR_LIVRAISON.Text = ""
            FRAIR_LIVRAISON.Text = "0"
            PRIX_PRODUIT_TTC.Text = "0"
        End With
    End Sub
    Public Function getCommand() As BasicCommand
        Return command
    End Function

    Private Sub DATE_COMMANDE_TextChanged(sender As Object, e As EventArgs) Handles DATE_COMMANDE.TextChanged

    End Sub
#End Region
End Class