Imports MySql.Data.MySqlClient

Public Class WIN_STOCK_MANAGER
#Region "Atributes"
    Private mStockManager As StockManager
    Private mConnexion As MySqlConnection
#End Region
    Private Sub WIN_STOCK_MANAGER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mStockManager = New StockManager(MainController.getMainConnexion)
        displayInObject(mStockManager.getInObject)
        displayOutObject(mStockManager.getOutObject)
    End Sub

    Private Sub FermerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerToolStripMenuItem.Click
        If MsgBox("Voulez vous fermer la fenetre en cours ?", 4, "Avertissement") = MsgBoxResult.Abort Then
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub SortieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortieToolStripMenuItem.Click
        AddOutObject.ShowDialog()
        If AddOutObject.DialogResult = DialogResult.Cancel Then
            Exit Sub
        End If
        mStockManager.addOutObject(makeOutObjectByDiarlog)
        displayOutObject(mStockManager.getOutObject)
    End Sub

    Private Sub EntrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrerToolStripMenuItem.Click
        AddInObject.ShowDialog()
        If AddInObject.DialogResult = DialogResult.Cancel Then
            Exit Sub
        End If
        mStockManager.addInObject(makeInObjectByDiarlog)
        displayInObject(mStockManager.getInObject)
    End Sub
#Region "Function for programme"

#End Region
End Class