Public Class Account
    'global variable
    Private balance As Decimal
    'get propety
    Public ReadOnly Property totalbalance() As Decimal
        Get
            Return balance
        End Get
    End Property
    'sub for income
    Sub income(ByVal amount As Decimal)
        balance = balance + amount
    End Sub
    'sub for expenses
    Sub expenses(ByVal eamount As Decimal)
        balance = balance - eamount
    End Sub


End Class
