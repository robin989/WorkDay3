Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        Dim num1, num2 As Double

        'if the user did the wrong thing, then MsgBox and eliminate them
        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("dumb")
            Return
        End If

        'sterile area
        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        'if the user did the wrong thing, then msgbox and eliminate them
        If (num1 < 0 Or num2 < 0) Then
            MessageBox.Show("dumb")
            Return

        End If
        If num1 > num2 Then
            txtResult.Text = "The larger number is " & num1
        ElseIf (num2 > num1) Then
            txtResult.Text = "The larger number is " & num2
        Else
            txtResult.Text = "the two are equal"
        End If





    End Sub
End Class
