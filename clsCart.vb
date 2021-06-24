Public Class clsCart
    Public Property orderid As Integer
    Public Property orderdetail As List(Of Tuple(Of Integer, Decimal))
    Public Property orderRawTotal As Decimal
    Public Property orderdisc As Decimal
    Public Property orderRebate As Decimal
    Public Property ordertotal As Decimal
End Class
