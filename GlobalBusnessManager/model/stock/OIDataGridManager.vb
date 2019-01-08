Public Class OIDataGridManager
    Public Sub displayOutObject(objectList As List(Of OutObject))
        If objectList Is Nothing Then
            MsgBox("Erreur de code Sql")
            Exit Sub
        End If
        For Each obj As OutObject In objectList
            WIN_STOCK_MANAGER.OUT_PRODUCT_GRID.Rows.Add(obj.getId, obj.getDate, obj.getProductId,
                                                        obj.getCause, obj.getDestination, obj.getQuantite)
        Next
    End Sub
    Public Sub displayInObject(objectList As List(Of InObject))
        If objectList Is Nothing Then
            MsgBox("Erreur de code Sql")
            Exit Sub
        End If
        For Each obj As InObject In objectList
            WIN_STOCK_MANAGER.IN_PRODUCT_GRID.Rows.Add(obj.getId, obj.getDate, obj.getProductId,
                                                       obj.getStockIni, obj.getQuantite, obj.getStockFinal)
        Next
    End Sub
End Class
