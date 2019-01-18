Public Class AddOutObject
    Private mProductManager As ProductManager
    Private mListOfProduct As List(Of Product)
    Private Sub AddOutObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mProductManager = New ProductManager(MainController.getMainConnexion)
        mListOfProduct = New List(Of Product)
        O_DAY.Text = Date.Now.Day
        O_MONTH.Text = Date.Now.Month
        O_YEAR.Text = Date.Now.Year
        PRODUCT_ID.Text = ""
        O_CAUSE.Text = ""
        O_DESTINATION.Text = ""
        O_QUANTITE.Text = ""
        Me.BT_O_APLY.Enabled = False
    End Sub

    Private Sub BT_O_APLY_Click(sender As Object, e As EventArgs) Handles BT_O_APLY.Click

    End Sub

    Private Sub PRODUCT_ID_TextChanged(sender As Object, e As EventArgs) Handles PRODUCT_ID.SelectedValueChanged
        Me.SEARCH_TEXT.Text = Me.PRODUCT_ID.Text
    End Sub

    Private Sub SEARCH_TEXT_TextChanged(sender As Object, e As EventArgs) Handles SEARCH_TEXT.TextChanged
        mListOfProduct = mProductManager.rechercheFilterParCode(Me.SEARCH_TEXT.Text)
        Me.PRODUCT_ID.Items.Clear()

        For Each produit As Product In mListOfProduct
            Me.PRODUCT_ID.Items.Add(produit.getCode)
        Next
        If SEARCH_TEXT.Text = "" Then
            Error_Message.Visible = True
            BT_O_APLY.Enabled = False
            SEARCH_TEXT.BackColor = Color.Red
        Else
            If O_DESTINATION.Text = "" Or O_QUANTITE.Text = "" Or O_CAUSE.Text = "" Then
                BT_O_APLY.Enabled = False
            Else
                SEARCH_TEXT.BackColor = Color.White
                Error_Message.Visible = False
                BT_O_APLY.Enabled = True
            End If
        End If
    End Sub

    Private Sub O_CAUSE_TextChanged(sender As Object, e As EventArgs) Handles O_CAUSE.TextChanged
        If O_CAUSE.Text = "" Then
            Error_Message.Visible = True
            BT_O_APLY.Enabled = False
            O_CAUSE.BackColor = Color.Red
        Else
            If O_DESTINATION.Text = "" Or O_QUANTITE.Text = "" Or SEARCH_TEXT.Text = "" Then
                BT_O_APLY.Enabled = False
            Else
                O_CAUSE.BackColor = Color.White
                Error_Message.Visible = False
                BT_O_APLY.Enabled = True
            End If
        End If
    End Sub

    Private Sub O_DESTINATION_TextChanged(sender As Object, e As EventArgs) Handles O_DESTINATION.TextChanged
        If O_DESTINATION.Text = "" Then
            Error_Message.Visible = True
            BT_O_APLY.Enabled = False
            O_DESTINATION.BackColor = Color.Red
        Else
            If O_CAUSE.Text = "" Or O_QUANTITE.Text = "" Or SEARCH_TEXT.Text = "" Then
                BT_O_APLY.Enabled = False
            Else
                O_DESTINATION.BackColor = Color.White
                Error_Message.Visible = False
                BT_O_APLY.Enabled = True
            End If
        End If
    End Sub

    Private Sub O_QUANTITE_TextChanged(sender As Object, e As EventArgs) Handles O_QUANTITE.TextChanged
        If Not IsNumeric(O_QUANTITE.Text) Then
            Error_Message.Visible = True
            BT_O_APLY.Enabled = False
            O_QUANTITE.BackColor = Color.Red
        Else
            If O_CAUSE.Text = "" Or O_DESTINATION.Text = "" Or SEARCH_TEXT.Text = "" Then
                BT_O_APLY.Enabled = False
            Else
                O_QUANTITE.BackColor = Color.White
                Error_Message.Visible = False
                BT_O_APLY.Enabled = True
            End If
        End If
    End Sub
End Class