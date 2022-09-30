Public Class EvenOddNumbersForm1
    'Form 1
    Private Sub EvenOddNumbersForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'To center the form
        Me.CenterToScreen()

    End Sub

    'Exit Button
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        'To exit the form.
        Me.Hide()

    End Sub

    'Calculate Button
    Private Sub calculateBtn_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click

        'Initialize 3 integers
        Dim countEven As Integer = 0
        Dim countOdd As Integer = 0


        'Mag-initialize ng isang array na may variable name na "numbers()" at may 5 value/elements na-converted sa integers
        Dim numbers(5) As Integer
        numbers(0) = Convert.ToInt32(TextBox1.Text) 'Converting string data types to integers
        numbers(1) = Convert.ToInt32(TextBox2.Text)
        numbers(2) = Convert.ToInt32(TextBox3.Text)
        numbers(3) = Convert.ToInt32(TextBox4.Text)
        numbers(4) = Convert.ToInt32(TextBox5.Text)



        'Looping 
        For i = 0 To 4
            'If Statement
            If numbers(i) Mod 2 = 0 Then
                countEven += 1
            Else
                countOdd += 1
            End If
        Next

        resultTextBox.Text = "There is/are " & Val(countEven) & " EVEN NUMBER/S" & vbCrLf & "There is/are " & Val(countOdd) & " ODD NUMBER/S"

    End Sub

    'Reset Button
    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Sub


End Class