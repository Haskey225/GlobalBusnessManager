Public Class DataGridController
    Private controller As String

    Sub New()

    End Sub

    Public Sub dataLoader()
        MainController.PRODUCT_DATA_GRID.Rows.Add("", "Nicer Dicer", "NAS5655", "", "", "")
    End Sub
End Class
