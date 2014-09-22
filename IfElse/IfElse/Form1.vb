Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        ' Modify the program such that it does not crash 
        ' if the user types incorrect input

        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text


        ' BEEGIN checkpoint 1, must type integers
        If Not (IsNumeric(st1) And IsNumeric(st2)) Then
            MessageBox.Show("Please type integers in both boxes")
            Return
        End If
        ' END checkpoint 1

        'BEGIN Checkpoint 2, no negatives
        If Not (num1 > 0 And num2 > 0) Then

            MessageBox.Show("Please do not type negative numbers")
            Return
            'END Checkpoint 2

        End If


        num1 = CDbl(st1)
        num2 = CDbl(st2)

        Dim result As String

        If num1 > num2 Then
            result = "The larger number is " & num1
        ElseIf num2 > num1 Then
            result = "The larger number is " & num2
        Else
            result = "They are equal"
        End If

        txtResult.Text = result

    End Sub

    Private Sub txtFirstNum_TextChanged(sender As Object, e As EventArgs) Handles txtFirstNum.TextChanged

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
