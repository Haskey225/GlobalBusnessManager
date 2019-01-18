Module ModuleBeeshop
    Public Sub stockManagerView()
        MainController.CLIENT_DATA_VIEW.Visible = False
        MainController.PRODUCT_DATA_GRID.Visible = False
        MainController.VU_RAPPORT.Visible = False
        MainController.FORNISSEUR_DATA_GRID.Visible = False
        MainController.VU_COMMAND.Visible = True
        MainController.STOCK_LIST.Visible = False
        MainController.STOCK_MANAGER_VIEW.Visible = True
    End Sub
    Public Function makeInObjectByDiarlog() As InObject
        Dim myDate As Date
        Try
            myDate = AddInObject.I_DAY.Text + "-" + AddInObject.I_MONTH.Text + "-" + AddInObject.I_YEAR.Text
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return New InObject(myDate.ToShortDateString, AddInObject.SEARTCH_TEXT.Text, CInt(AddInObject.I_STCK_INIT.Text),
                            CInt(AddInObject.I_QUANTITE.Text), CInt(AddInObject.I_STCK_FINAL.Text))
    End Function
    Public Function makeOutObjectByDiarlog() As OutObject
        Dim myDate As Date
        Try
            myDate = AddOutObject.O_DAY.Text + "-" + AddOutObject.O_MONTH.Text + "-" + AddOutObject.O_YEAR.Text
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return New OutObject(myDate.ToShortDateString, AddOutObject.SEARCH_TEXT.Text, AddOutObject.O_CAUSE.Text,
                            AddOutObject.O_DESTINATION.Text, CInt(AddOutObject.O_QUANTITE.Text))
    End Function
    Public Sub displayOutObject(objectList As List(Of OutObject))
        If objectList Is Nothing Then
            MsgBox("Erreur de code Sql")
            Exit Sub
        End If
        WIN_STOCK_MANAGER.OUT_PRODUCT_GRID.Rows.Clear()
        MainController.OUT_PRODUCT_GRID.Rows.Clear()

        For Each obj As OutObject In objectList
            WIN_STOCK_MANAGER.OUT_PRODUCT_GRID.Rows.Add(obj.getId, obj.getDate.ToShortDateString, obj.getProductId,
                                                        obj.getCause, obj.getDestination, obj.getQuantite)
            MainController.OUT_PRODUCT_GRID.Rows.Add(obj.getId, obj.getDate.ToShortDateString, obj.getProductId,
                                                        obj.getCause, obj.getDestination, obj.getQuantite)
        Next
    End Sub
    Public Sub displayInObject(objectList As List(Of InObject))
        If objectList Is Nothing Then
            MsgBox("Erreur de code Sql")
            Exit Sub
        End If
        WIN_STOCK_MANAGER.IN_PRODUCT_GRID.Rows.Clear()
        MainController.IN_PRODUCT_GRID.Rows.Clear()

        For Each obj As InObject In objectList
            WIN_STOCK_MANAGER.IN_PRODUCT_GRID.Rows.Add(obj.getId, obj.getDate.ToShortDateString, obj.getProductId,
                                                       obj.getStockIni, obj.getQuantite, obj.getStockFinal)
            MainController.IN_PRODUCT_GRID.Rows.Add(obj.getId, obj.getDate.ToShortDateString, obj.getProductId,
                                                       obj.getStockIni, obj.getQuantite, obj.getStockFinal)
        Next
    End Sub

    Public Function productQuantityCalculator(product As Product, netAPayer As Integer) As Integer
        Dim result As Integer
        If product.getPrixAchat <> 0 And netAPayer <> 0 Then
            result = netAPayer / product.getPrixAchat
        Else
            result = 0
        End If
        Return result
    End Function

End Module
