Public Class Form1
    Dim myChar As Char
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        myChar = lbltext.Text.Chars(0)
        btn1.Text = myChar
        If myChar = "X" Then
            lbltext.Text = "O's Term"
        Else
            lbltext.Text = "X's Term"
        End If
        btn1.Enabled = False
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        myChar = lbltext.Text.Chars(0)
        btn2.Text = myChar
        If myChar = "X" Then
            lbltext.Text = "O's Term"
        Else
            lbltext.Text = "X's Term"
        End If
        btn2.Enabled = False
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        myChar = lbltext.Text.Chars(0)
        btn3.Text = myChar
        If myChar = "X" Then
            lbltext.Text = "O's Term"
        Else
            lbltext.Text = "X's Term"
        End If
        btn3.Enabled = False
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        myChar = lbltext.Text.Chars(0)
        btn4.Text = myChar
        If myChar = "X" Then
            lbltext.Text = "O's Term"
        Else
            lbltext.Text = "X's Term"
        End If
        btn4.Enabled = False
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        myChar = lbltext.Text.Chars(0)
        btn5.Text = myChar
        If myChar = "X" Then
            lbltext.Text = "O's Term"
        Else
            lbltext.Text = "X's Term"
        End If
        btn5.Enabled = False
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        myChar = lbltext.Text.Chars(0)
        btn6.Text = myChar
        If myChar = "X" Then
            lbltext.Text = "O's Term"
        Else
            lbltext.Text = "X's Term"
        End If
        btn6.Enabled = False
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        myChar = lbltext.Text.Chars(0)
        btn7.Text = myChar
        If myChar = "X" Then
            lbltext.Text = "O's Term"
        Else
            lbltext.Text = "X's Term"
        End If
        btn7.Enabled = False
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        myChar = lbltext.Text.Chars(0)
        btn8.Text = myChar
        If myChar = "X" Then
            lbltext.Text = "O's Term"
        Else
            lbltext.Text = "X's Term"
        End If
        btn8.Enabled = False
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        myChar = lbltext.Text.Chars(0)
        btn9.Text = myChar
        If myChar = "X" Then
            lbltext.Text = "O's Term"
        Else
            lbltext.Text = "X's Term"
        End If
        btn9.Enabled = False
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
    End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        If (btn1.Text = btn2.Text) And (btn2.Text = btn3.Text) Then
            MessageBox.Show("Winner  " & btn1.Text)
        ElseIf (btn1.Text = btn4.Text) And (btn4.Text = btn7.Text) Then
            MessageBox.Show("Winner  " & btn1.Text)
        ElseIf (btn1.Text = btn5.Text) And (btn5.Text = btn9.Text) Then
            MessageBox.Show("Winner  " & btn1.Text)
        ElseIf (btn2.Text = btn5.Text) And (btn5.Text = btn8.Text) Then
            MessageBox.Show("Winner  " & btn2.Text)
        ElseIf (btn3.Text = btn6.Text) And (btn6.Text = btn9.Text) Then
            MessageBox.Show("Winner  " & btn3.Text)
        ElseIf (btn4.Text = btn5.Text) And (btn5.Text = btn6.Text) Then
            MessageBox.Show("Winner  " & btn4.Text)
        ElseIf (btn7.Text = btn8.Text) And (btn8.Text = btn9.Text) Then
            MessageBox.Show("Winner  " & btn7.Text)
        ElseIf (btn3.Text = btn5.Text) And (btn5.Text = btn7.Text) Then
            MessageBox.Show("Winner  " & btn3.Text)
        Else
            MessageBox.Show("Not Win any Player!!")
        End If
    End Sub
End Class