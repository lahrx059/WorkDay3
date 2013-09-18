Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largernum As Double

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        If num1 > num2 Then
            largernum = num1
            txtResult.Text = "The larger number is " & largernum
        ElseIf (num1 < num2) Then
            largernum = num2
            txtResult.Text = "The larger number is " & largernum
        Else
            txtResult.Text = "They are equal"
        End If

 
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
