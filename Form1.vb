Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnClear.PerformClick()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints As String = ""
        Dim intPoints As Integer

        If IsNumeric(txtPts.Text) Then
            intPoints = Convert.ToInt32(txtPts.Text)
            strPoints = " after discount of " & intPoints.ToString() & " loyalty points."

            If rbtnGCheese.Checked Then
                decCost = 49.99D
                strOrder = "Cheese"
            ElseIf rbtnWraps.Checked Then
                decCost = 59.99D
                strOrder = "Wrap"
            ElseIf rbtnVeggie.Checked Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf rbtnSausageAndCheese.Checked Then
                decCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf rbtnFruit.Checked Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If

            If rbtnPrePay.Checked Then
                strPay = " using Pre-Pay"
            ElseIf rbtnPickupPay.Checked Then
                strPay = " with pay upon pickup"
            End If

            intPoints = Convert.ToInt32(intPoints / 10I)

            decPoints = (intPoints * cdecDiscount) / 100

            If decPoints > 1 Then
                decPoints = 1
            End If

            decFinal = decCost * (1 - decPoints)

            lblOutput.Text = "Your order " & strOrder & " platter costs " & decFinal.ToString("C") & strPay & strPoints

        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            Me.btnClear.PerformClick()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rbtnGCheese.Checked = True
        rbtnPrePay.Checked = True
        txtPts.Text = ""
        lblOutput.Text = ""
        txtPts.Focus()
    End Sub
End Class
