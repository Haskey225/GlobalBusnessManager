Public Class AddInObject
    Dim mProductManager As ProductManager
    Dim mListOfProduct As List(Of Product)
    Private Sub AddInObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mProductManager = New ProductManager(MainController.getMainConnexion)
        mListOfProduct = New List(Of Product)
        I_DAY.Text = Date.Now.Day
        I_MONTH.Text = Date.Now.Month
        I_YEAR.Text = Date.Now.Year
        PRODUCT_ID.Text = ""
        I_STCK_FINAL.Text = "0"
        I_STCK_INIT.Text = "0"
        I_QUANTITE.Text = "0"
    End Sub

    Private Sub BT_I_APLY_Click(sender As Object, e As EventArgs) Handles BT_I_APLY.Click
        If I_DAY.Text = "" Or I_MONTH.Text = "" Or I_YEAR.Text = "" Or PRODUCT_ID.Text = "" Or
            I_STCK_FINAL.Text = "" Or I_STCK_INIT.Text = "" Or I_QUANTITE.Text = "" Then
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub PRODUCT_ID_TextChanged(sender As Object, e As EventArgs) Handles PRODUCT_ID.SelectedValueChanged
        Me.SEARTCH_TEXT.Text = Me.PRODUCT_ID.Text
        I_STCK_INIT.Text = mProductManager.getProductByCode(Me.PRODUCT_ID.Text).getQuantite
    End Sub

    Private Sub I_STCK_INIT_TextChanged(sender As Object, e As EventArgs) Handles I_STCK_INIT.TextChanged
        Try
            I_STCK_FINAL.Text = CInt(I_STCK_INIT.Text) + CInt(I_QUANTITE.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SEARTCH_TEXT_TextChanged(sender As Object, e As EventArgs) Handles SEARTCH_TEXT.TextChanged
        If Me.SEARTCH_TEXT.Text <> "" Then
            mListOfProduct = mProductManager.rechercheFilterParCodeIn(Me.SEARTCH_TEXT.Text)
            Me.PRODUCT_ID.Items.Clear()

            For Each produit As Product In mListOfProduct
                Me.PRODUCT_ID.Items.Add(produit.getCode)
            Next
        End If
    End Sub
    Private Sub I_QUANTITE_TextChanged(sender As Object, e As EventArgs) Handles I_QUANTITE.TextChanged
        If Not IsNumeric(Me.I_QUANTITE.Text) Or Not IsNumeric(I_STCK_INIT.Text) Then
            Me.BT_I_APLY.Enabled = False
            Me.I_QUANTITE.BackColor = Color.Red
            Me.Error_Message.Visible = True
        Else

            Me.I_QUANTITE.BackColor = Color.White
            I_STCK_FINAL.Text = CInt(I_STCK_INIT.Text) + CInt(I_QUANTITE.Text)
            Me.BT_I_APLY.Enabled = True
            Me.Error_Message.Visible = False
        End If
    End Sub

    Private Sub PRODUCT_ID_TextChanged_1(sender As Object, e As EventArgs) Handles PRODUCT_ID.TextChanged
        If Me.PRODUCT_ID.Text = "" And Me.SEARTCH_TEXT.Text = "" Then
            Me.BT_I_APLY.Enabled = False
            Me.SEARTCH_TEXT.BackColor = Color.Red
        Else
            If Not IsNumeric(Me.I_QUANTITE.Text) Or Me.PRODUCT_ID.Text = "" Then
                Me.Error_Message.Visible = False
                Me.BT_I_APLY.Enabled = False
            Else
                Me.SEARTCH_TEXT.BackColor = Color.White
                Me.Error_Message.Visible = False
                Me.BT_I_APLY.Enabled = True
            End If
        End If
    End Sub


End Class