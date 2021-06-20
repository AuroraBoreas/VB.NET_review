Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = "Loan Calculator v.0.01 @ZL, 20210620"
            With .Label1
                .Text = "Loan Calculator"
            End With
            .Label2.Text = "Loan Amount:"
            .Label3.Text = "Intereste Rate:"
            .Label4.Text = "Duration months:"
            .Label5.Text = "Early Payment:"
            .Label6.Text = "Monthly Payment:"

            .Button1.Text = "Monthly Payment"
            .Button1.AutoSize = True
            .Button2.Text = "Exit"
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim payEarly As DueDate
        payEarly = IIf(Me.chkPayEerly.Checked, DueDate.BegOfPeriod, DueDate.EndOfPeriod)
        Dim LA, IR, LM As Double
        If Double.TryParse(Me.InterestRate.Text, IR) And
            Double.TryParse(Me.LoanAmount.Text, LA) And
            Double.TryParse(Me.Months.Text, LM) Then
            Me.MonthlyPayment.Text = Pmt(IR * 0.01 / 12, LM, LA * -1,
                                       payEarly).ToString("#,0.00")
        Else
            MessageBox.Show("numeric input only!", "Error")
            Exit Sub
        End If
    End Sub
End Class
