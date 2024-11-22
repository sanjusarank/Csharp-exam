Public Class Form1

    ' Calculate the Net Salary when Button1 is clicked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ensure the user input is valid before performing calculations
        If IsNumeric(TextBox5.Text) And IsNumeric(TextBox6.Text) Then
            ' Calculate Net Salary
            TextBox7.Text = (Val(TextBox5.Text) - Val(TextBox6.Text))
            MsgBox("Hi! " & TextBox1.Text & ", your Net Salary is Rs " & TextBox7.Text)
        Else
            MsgBox("Please enter valid numeric values for Salary and Deductions.")
        End If
    End Sub

    ' This event handler is triggered when the form loads
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: Initialize the form with any defaults or settings
    End Sub

    ' Automatically update TextBox5 when other fields change
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        ' Validate input before performing calculation
        If IsNumeric(TextBox2.Text) And IsNumeric(TextBox3.Text) And IsNumeric(TextBox4.Text) Then
            ' Update TextBox5 with the sum of TextBox2, TextBox3, and TextBox4
            TextBox5.Text = (Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text)).ToString()
        End If
    End Sub

    ' Optional: Button2 click to clear the textboxes
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear all textboxes
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

End Class
