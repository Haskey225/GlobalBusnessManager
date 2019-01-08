Module ModuleBeeshop
    Public Function makeInObjectByDiarlog() As InObject
        Dim myDate As Date
        Try
            myDate = AddInObject.I_DAY.Text + "-" + AddInObject.I_MONTH.Text + "-" + AddInObject.I_YEAR.Text
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return New InObject(myDate.ToShortDateString, AddInObject.PRODUCT_ID.Text, CInt(AddInObject.I_STCK_INIT.Text),
                            CInt(AddInObject.I_QUANTITE.Text), CInt(AddInObject.I_STCK_FINAL.Text))
    End Function
    Public Function makeOutObjectByDiarlog() As OutObject
        Dim myDate As Date
        Try
            myDate = AddOutObject.O_DAY.Text + "-" + AddOutObject.O_MONTH.Text + "-" + AddOutObject.O_YEAR.Text
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return New OutObject(myDate.ToShortDateString, AddOutObject.PRODUCT_ID.Text, AddOutObject.O_CAUSE.Text,
                            AddOutObject.O_DESTINATION.Text, CInt(AddOutObject.O_QUANTITE.Text))
    End Function
    Public Sub displayOutObject(objectList As List(Of OutObject))
        If objectList Is Nothing Then
            MsgBox("Erreur de code Sql")
            Exit Sub
        End If
        WIN_STOCK_MANAGER.OUT_PRODUCT_GRID.Rows.Clear()

        For Each obj As OutObject In objectList
            WIN_STOCK_MANAGER.OUT_PRODUCT_GRID.Rows.Add(obj.getId, obj.getDate.ToShortDateString, obj.getProductId,
                                                        obj.getCause, obj.getDestination, obj.getQuantite)
        Next
    End Sub
    Public Sub displayInObject(objectList As List(Of InObject))
        If objectList Is Nothing Then
            MsgBox("Erreur de code Sql")
            Exit Sub
        End If
        WIN_STOCK_MANAGER.IN_PRODUCT_GRID.Rows.Clear()

        For Each obj As InObject In objectList
            WIN_STOCK_MANAGER.IN_PRODUCT_GRID.Rows.Add(obj.getId, obj.getDate.ToShortDateString, obj.getProductId,
                                                       obj.getStockIni, obj.getQuantite, obj.getStockFinal)
        Next
    End Sub

End Module
