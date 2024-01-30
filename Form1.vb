' Classes and Objects Programming Assignment.
' This program helps an organization to calculate the cost of expenses.
' Benjamin Andrews.


' “I will not use code that was never covered in class or in our textbook. If you do you must be able to explain your code when asked by the professor.
' Using code outside of the resources provided, it can be flagged and reported as an academic integrity violation if there is any suspicion of copying/cheating.” 


Public Class frmMain
    ' instance of class
    Dim totalamt As New Account
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' error check
        Dim startingamt As String = ""
        While startingamt = ""

            startingamt = InputBox("Enter your starting balance")
        End While

        ' Display total income and pass starting balance to account class.
        Decimal.TryParse(startingamt, startingamt)
        totalamt.income(startingamt)
        txtIncome.Text = FormatCurrency(totalamt.totalbalance)

    End Sub

    Private Sub btnIncome_Click(sender As Object, e As EventArgs) Handles btnIncome.Click


        ' Error check.
        If txtAmount.Text = "" Then
            MessageBox.Show("Enter an amount.")
            txtAmount.Focus()
            Return
        End If
        Dim decription As String = InputBox("Enter a description.")
        While decription = ""
            decription = InputBox("Enter a description.")
        End While

        ' Pass amount entered to account class.
        Dim decamt As Decimal
        Decimal.TryParse(txtAmount.Text, decamt)
        totalamt.income(decamt)

        ' Add income to listbox w/ description
        lstIncome.Items.Add(decription & ": " & FormatCurrency(decamt))

        ' Display total income
        txtIncome.Text = FormatCurrency(totalamt.totalbalance)

        ' Clear amount texbox.
        txtAmount.Text = String.Empty
    End Sub

    Private Sub btnExpense_Click(sender As Object, e As EventArgs) Handles btnExpense.Click


        ' Error check.
        If txtAmount.Text = "" Then
            MessageBox.Show("Enter an amount.")
            txtAmount.Focus()
            Return
        End If

        Dim decription As String = InputBox("Enter a description.")
        While decription = ""
            decription = InputBox("Enter a description.")
        End While

        ' Pass amount entered to account class.
        Dim decamt As Decimal
        Decimal.TryParse(txtAmount.Text, decamt)
        totalamt.expenses(decamt)

        ' Add expenses to listbox w/ description
        lstExpense.Items.Add(decription & ": " & FormatCurrency(decamt))

        ' Display total income
        txtIncome.Text = FormatCurrency(totalamt.totalbalance)
        If totalamt.totalbalance < 0 Then
            MessageBox.Show("Warning: Account balance is negative.")
        End If
        ' Clear amount texbox.
        txtAmount.Text = String.Empty

    End Sub

End Class
