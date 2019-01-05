Public Class DataGridManager
    Dim dataGrid As New DataGrid
    Sub New()
        MainController.CLIENT_DATA_VIEW.Visible = False
        MainController.PRODUCT_DATA_GRID.Visible = True
        MainController.VU_RAPPORT.Visible = False
        MainController.FORNISSEUR_DATA_GRID.Visible = False
        MainController.VU_COMMAND.Visible = False
        MainController.STOCK_LIST.Visible = False
    End Sub
    Public Sub deconnexionView()
        MainController.CLIENT_DATA_VIEW.Visible = False
        MainController.PRODUCT_DATA_GRID.Visible = False
        MainController.VU_RAPPORT.Visible = False
        MainController.FORNISSEUR_DATA_GRID.Visible = False
        MainController.VU_COMMAND.Visible = False
        MainController.STOCK_LIST.Visible = False
    End Sub
    Public Sub commandView()
        MainController.CLIENT_DATA_VIEW.Visible = False
        MainController.PRODUCT_DATA_GRID.Visible = False
        MainController.VU_RAPPORT.Visible = False
        MainController.FORNISSEUR_DATA_GRID.Visible = False
        MainController.VU_COMMAND.Visible = True
        MainController.STOCK_LIST.Visible = False
    End Sub
    Public Sub clientView()
        MainController.CLIENT_DATA_VIEW.Visible = True
        MainController.PRODUCT_DATA_GRID.Visible = False
        MainController.VU_RAPPORT.Visible = False
        MainController.FORNISSEUR_DATA_GRID.Visible = False
        MainController.VU_COMMAND.Visible = False
        MainController.STOCK_LIST.Visible = False
    End Sub
    Public Sub productView()
        MainController.CLIENT_DATA_VIEW.Visible = False
        MainController.PRODUCT_DATA_GRID.Visible = True
        MainController.VU_RAPPORT.Visible = False
        MainController.FORNISSEUR_DATA_GRID.Visible = False
        MainController.VU_COMMAND.Visible = False
        MainController.STOCK_LIST.Visible = False
    End Sub
    Public Sub rapportView()
        MainController.CLIENT_DATA_VIEW.Visible = False
        MainController.PRODUCT_DATA_GRID.Visible = False
        MainController.VU_RAPPORT.Visible = True
        MainController.FORNISSEUR_DATA_GRID.Visible = False
        MainController.VU_COMMAND.Visible = False
    End Sub
    Public Sub fournisseurView()
        MainController.CLIENT_DATA_VIEW.Visible = False
        MainController.PRODUCT_DATA_GRID.Visible = False
        MainController.VU_RAPPORT.Visible = False
        MainController.FORNISSEUR_DATA_GRID.Visible = True
        MainController.VU_COMMAND.Visible = False
        MainController.STOCK_LIST.Visible = False
    End Sub
    Public Sub stockView()
        MainController.CLIENT_DATA_VIEW.Visible = False
        MainController.PRODUCT_DATA_GRID.Visible = False
        MainController.VU_RAPPORT.Visible = False
        MainController.FORNISSEUR_DATA_GRID.Visible = False
        MainController.VU_COMMAND.Visible = False
        MainController.STOCK_LIST.Visible = True
    End Sub
End Class
