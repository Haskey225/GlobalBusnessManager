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
    End Sub

    Private Sub BT_O_APLY_Click(sender As Object, e As EventArgs) Handles BT_O_APLY.Click
        If O_DAY.Text = "" Or O_MONTH.Text = "" Or O_YEAR.Text = "" Or PRODUCT_ID.Text = "" Or
            O_CAUSE.Text = "" Or O_DESTINATION.Text = "" Or O_QUANTITE.Text = "" Then
            MsgBox("Veuillez à ce que les champs soient bien remplis.")
            Exit Sub
        End If

        Me.Close()
    End Sub

    Private Sub PRODUCT_ID_SelectedChanged(sender As Object, e As EventArgs) Handles PRODUCT_ID.TextChanged
        mListOfProduct = mProductManager.rechercheFilterParCode(Me.PRODUCT_ID.Text)
        For Each produit As Product In mListOfProduct
            Me.PRODUCT_ID.Items.Add(produit.getCode)
        Next
    End Sub
    Private Sub PRODUCT_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PRODUCT_ID.LostFocus
    End Sub
End Class