Public Class AddCommandWin
    'Pour une raison de code PRODUCT_NAME.Text est devenu PRODUCT_CODE.Text vis vers a
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
        command.setDate(CDate(DATE_COMMANDE.Text))
        command.setClientName(Me.CLIENT_NAME.Text)
        command.setAdressLivraison(Me.COMMUNE_NAME.Text)
        command.setClientContact(Me.CONTACT.Text)
        command.setNetToPay(CInt(Me.PRIX_PRODUIT_TTC.Text))
        command.setProduct(productManager.getProductByCode(Me.SEARCH_TEXT.Text))
        command.setAgent(221)
        command.setCommandStat("En Cours")
        Me.Close()
    End Sub
    Private Sub SEARCH_TEXT_TextChanged(sender As Object, e As EventArgs) Handles SEARCH_TEXT.TextChanged
        Me.SELECT_PRODUCT_NAME.Items.Clear()
        listProduct = productManager.rechercheFilterParCode(SEARCH_TEXT.Text)
        For Each product As Product In listProduct
            Me.SELECT_PRODUCT_NAME.Items.Add(product.getCode)
        Next
    End Sub
    Private Sub SELECT_PRODUCT_NAME_Selected(sender As Object, e As EventArgs) Handles SELECT_PRODUCT_NAME.SelectedValueChanged
        Me.SEARCH_TEXT.Text = Me.SELECT_PRODUCT_NAME.Text
        product = productManager.getProductByCode(Me.SEARCH_TEXT.Text)
        Me.CODE_PRODUIT.Text = product.getNom
        Me.PRODUCT_PRICE.Text = product.getPrixAchat
        PRIX_UNITAIRE_PRODUIT.Text = product.getPrixAchat

    End Sub
    Private Sub QUANTITE_PRODUIT_TextChanged(sender As Object, e As EventArgs) Handles QUANTITE_PRODUIT.TextChanged
        If Not IsNumeric(QUANTITE_PRODUIT.Text) Then
            Button1.Enabled = False
            QUANTITE_PRODUIT.BackColor = Color.Red
        Else
            QUANTITE_PRODUIT.BackColor = Color.White
            PRIX_PRODUIT_HT.Text = CInt(QUANTITE_PRODUIT.Text) * product.getPrixAchat
            If Not IsNumeric(CONTACT.Text) Or Not IsNumeric(QUANTITE_PRODUIT.Text) Or CLIENT_NAME.Text = "" Or COMMUNE_NAME.Text = "" Or
                DATE_COMMANDE.Text = "" Or LIEUR_LIVRAISON.Text = "" Or Not IsNumeric(FRAIR_LIVRAISON.Text) Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub FRAIR_LIVRAISON_TextChanged(sender As Object, e As EventArgs) Handles FRAIR_LIVRAISON.TextChanged
        If Not IsNumeric(FRAIR_LIVRAISON.Text) Then
            Button1.Enabled = False
            FRAIR_LIVRAISON.BackColor = Color.Red
        Else
            FRAIR_LIVRAISON.BackColor = Color.White
            PRIX_PRODUIT_TTC.Text = CInt(PRIX_PRODUIT_HT.Text) + CInt(FRAIR_LIVRAISON.Text)
            PRIX_PRODUIT_HT.Text = CInt(QUANTITE_PRODUIT.Text) * product.getPrixAchat
            If Not IsNumeric(CONTACT.Text) Or Not IsNumeric(QUANTITE_PRODUIT.Text) Or CLIENT_NAME.Text = "" Or COMMUNE_NAME.Text = "" Or
                DATE_COMMANDE.Text = "" Or LIEUR_LIVRAISON.Text = "" Or Not IsNumeric(FRAIR_LIVRAISON.Text) Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If

    End Sub
#Region "Function for win"
    Private Sub eraseContente()
        With Me.
                CLIENT_NAME.Text = ""
            COMMUNE_NAME.Text = ""
            CONTACT.Text = ""

            SELECT_PRODUCT_NAME.Text = ""
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

    Private Sub CONTACT_TextChanged(sender As Object, e As EventArgs) Handles CONTACT.TextChanged
        If Not IsNumeric(CONTACT.Text) Then
            Button1.Enabled = False
            CONTACT.BackColor = Color.Red
        Else
            CONTACT.BackColor = Color.White
            If Not IsNumeric(CONTACT.Text) Or Not IsNumeric(QUANTITE_PRODUIT.Text) Or CLIENT_NAME.Text = "" Or COMMUNE_NAME.Text = "" Or
                DATE_COMMANDE.Text = "" Or LIEUR_LIVRAISON.Text = "" Or Not IsNumeric(FRAIR_LIVRAISON.Text) Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub CLIENT_NAME_TextChanged(sender As Object, e As EventArgs) Handles CLIENT_NAME.TextChanged
        If CLIENT_NAME.Text = "" Then
            Button1.Enabled = False
            CLIENT_NAME.BackColor = Color.Red
        Else
            CLIENT_NAME.BackColor = Color.White
            If Not IsNumeric(CONTACT.Text) Or Not IsNumeric(QUANTITE_PRODUIT.Text) Or CLIENT_NAME.Text = "" Or COMMUNE_NAME.Text = "" Or
                DATE_COMMANDE.Text = "" Or LIEUR_LIVRAISON.Text = "" Or Not IsNumeric(FRAIR_LIVRAISON.Text) Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub COMMUNE_NAME_TextChanged(sender As Object, e As EventArgs) Handles COMMUNE_NAME.TextChanged
        If COMMUNE_NAME.Text = "" Then
            Button1.Enabled = False
            COMMUNE_NAME.BackColor = Color.Red
        Else
            COMMUNE_NAME.BackColor = Color.White
            If Not IsNumeric(CONTACT.Text) Or Not IsNumeric(QUANTITE_PRODUIT.Text) Or CLIENT_NAME.Text = "" Or COMMUNE_NAME.Text = "" Or
                DATE_COMMANDE.Text = "" Or LIEUR_LIVRAISON.Text = "" Or Not IsNumeric(FRAIR_LIVRAISON.Text) Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub LIEUR_LIVRAISON_TextChanged(sender As Object, e As EventArgs) Handles LIEUR_LIVRAISON.TextChanged
        If LIEUR_LIVRAISON.Text = "" Then
            Button1.Enabled = False
            LIEUR_LIVRAISON.BackColor = Color.Red
        Else
            LIEUR_LIVRAISON.BackColor = Color.White
            If Not IsNumeric(CONTACT.Text) Or Not IsNumeric(QUANTITE_PRODUIT.Text) Or CLIENT_NAME.Text = "" Or COMMUNE_NAME.Text = "" Or
                DATE_COMMANDE.Text = "" Or LIEUR_LIVRAISON.Text = "" Or Not IsNumeric(FRAIR_LIVRAISON.Text) Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub
#End Region
End Class