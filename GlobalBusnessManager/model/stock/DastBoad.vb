Public Class DastBoad
    Private mRupture As Integer
    Private mFaible As Integer
    Private mBon As Integer
    Private mTropFort As Integer
    Private mStockManager As StockManager

    Sub New()
        mStockManager = New StockManager(MainController.getMainConnexion)
        mRupture = Me.countAllProduct(Me.mStockManager.getUnstockedProducts())
        mFaible = Me.countAllProduct(Me.mStockManager.getLowStockedProducts())
        mBon = Me.countAllProduct(Me.mStockManager.getGoodStockedProducts())
        mTropFort = Me.countAllProduct(Me.mStockManager.getOverStockedProducts())
        'Implemented
        MainController.RUPTURE_NUMBER.Text = mRupture
        MainController.FAIBLE__NUMBER.Text = mFaible
        MainController.BON__NUMBER.Text = mBon
        MainController.FORT__NUMBER.Text = mTropFort
    End Sub

    Public Function countAllProduct(listOfProduct As List(Of Product)) As Integer
        Dim count As Integer = 0
        If listOfProduct IsNot Nothing Then
            For Each product As Product In listOfProduct
                count += 1
            Next
        End If
        Return count
    End Function

    Public Function upDateDastBoad() As Boolean
        mRupture = Me.countAllProduct(Me.mStockManager.getUnstockedProducts())
        mFaible = Me.countAllProduct(Me.mStockManager.getLowStockedProducts())
        mBon = Me.countAllProduct(Me.mStockManager.getGoodStockedProducts())
        mTropFort = Me.countAllProduct(Me.mStockManager.getOverStockedProducts())
        'Implemented
        MainController.RUPTURE_NUMBER.Text = mRupture
        MainController.FAIBLE__NUMBER.Text = mFaible
        MainController.BON__NUMBER.Text = mBon
        MainController.FORT__NUMBER.Text = mTropFort

        Return mStockManager.getExecuteError
    End Function
    Public Event M_Timer_Event(ByVal sender As Object, ByVal e As EventArgs)

End Class
