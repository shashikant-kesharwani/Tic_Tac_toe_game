Imports System.Diagnostics.Eventing.Reader

Public Class HangMan_Game
    Dim str As String
    Dim i, j As Integer
    Dim char1 As Char
    Dim n As Integer = 0
    Dim nextf, number As Integer
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        txtresult.Clear()
        PictureBox1.Image = My.Resources.hang0
        n = 0
        str = "Apple"
        nextf = 1
        number = 0
        Lblnumber.Text = number
        str = str.ToUpper()
        txtresult.Text = New String("-"c, str.Length) ' Initialize with dashes
        btnA.Enabled = True
        btnB.Enabled = True
        btnC.Enabled = True
        btnD.Enabled = True
        btnE.Enabled = True
        btnF.Enabled = True
        btnG.Enabled = True
        btnH.Enabled = True
        btnI.Enabled = True
        btnJ.Enabled = True
        btnK.Enabled = True
        btnL.Enabled = True
        btnM.Enabled = True
        btnN.Enabled = True
        btnO.Enabled = True
        btnP.Enabled = True
        btnQ.Enabled = True
        btnR.Enabled = True
        btnS.Enabled = True
        btnT.Enabled = True
        btnU.Enabled = True
        btnV.Enabled = True
        btnW.Enabled = True
        btnX.Enabled = True
        btnY.Enabled = True
        btnZ.Enabled = True
    End Sub
    Sub hang(num As Integer)
        If n = 1 Then
            PictureBox1.Image = My.Resources.hang1
        ElseIf n = 2 Then
            PictureBox1.Image = My.Resources.hang2
        ElseIf n = 3 Then
            PictureBox1.Image = My.Resources.hang3
        ElseIf n = 4 Then
            PictureBox1.Image = My.Resources.hang4
        ElseIf n = 5 Then
            PictureBox1.Image = My.Resources.hang5
        ElseIf n = 6 Then
            PictureBox1.Image = My.Resources.hang6
            MessageBox.Show("You lose the Game !!!", "SICS")
            number = 0
            Lblnumber.Text = number
            txtresult.Clear()
            PictureBox1.Image = My.Resources.hang0
            str = "Apple"
            nextf = 1
            n = 0
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        End If
    End Sub

    Sub change(str1 As Char, ind As Integer)
        Dim strresult As String = txtresult.Text
        Dim charArray As Char() = strresult.ToCharArray() ' Convert the string to a character array
        charArray(ind) = str1 ' Replace the character at the specific index
        Dim value As String = New String(charArray) ' Convert the character array back to a string and update the text
        txtresult.Text = value
        win(value)
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        char1 = "A"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If

    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        j = 0
        char1 = "B"
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        char1 = "C"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        char1 = "D"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        char1 = "E"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        char1 = "F"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        char1 = "G"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        char1 = "H"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        char1 = "I"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        char1 = "J"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        char1 = "K"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        char1 = "L"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        char1 = "M"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        char1 = "N"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        char1 = "O"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        char1 = "P"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        char1 = "Q"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        char1 = "R"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        char1 = "S"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        char1 = "T"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        char1 = "U"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        char1 = "V"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        char1 = "W"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        char1 = "X"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        char1 = "Y"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        char1 = "Z"
        j = 0
        For i = 0 To str.Length - 1
            If str.Chars(i) = char1 Then
                change(char1, i)
                j = 1
            End If
        Next
        If j = 0 Then
            n += 1
            hang(n)
        End If
    End Sub

    Private Sub HangMan_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnnext.Enabled = False
        PictureBox1.Image = My.Resources.hang0
        btnA.Enabled = False
        btnB.Enabled = False
        btnC.Enabled = False
        btnD.Enabled = False
        btnE.Enabled = False
        btnF.Enabled = False
        btnG.Enabled = False
        btnH.Enabled = False
        btnI.Enabled = False
        btnJ.Enabled = False
        btnK.Enabled = False
        btnL.Enabled = False
        btnM.Enabled = False
        btnN.Enabled = False
        btnO.Enabled = False
        btnP.Enabled = False
        btnQ.Enabled = False
        btnR.Enabled = False
        btnS.Enabled = False
        btnT.Enabled = False
        btnU.Enabled = False
        btnV.Enabled = False
        btnW.Enabled = False
        btnX.Enabled = False
        btnY.Enabled = False
        btnZ.Enabled = False
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        btnnext.Enabled = False
        n = 0
        PictureBox1.Image = My.Resources.hang0
        If nextf = 1 Then
            str = "banana"
            number += 1
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 2 Then
            str = "Grapes"
            number += 1
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 3 Then
            str = "mango"
            number += 1
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 4 Then
            str = "orange"
            number += 1
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 5 Then
            str = "fig"
            number += 1
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 6 Then
            str = "coconut"
            number += 1
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 7 Then
            str = "pomegrante"
            number += 1
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 8 Then
            str = "pineapple"
            number += 1
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 9 Then
            str = "papaya"
            number += 1
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 10 Then
            str = "guava"
            number += 1
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        End If
        Lblnumber.Text = number
        If nextf > 10 Then
            MessageBox.Show("Congratulation !!" & vbCrLf & "You Crack All level !!", "SICS")
            MessageBox.Show("******End The Game******** ", "SICS")
            Me.Close()
        End If

    End Sub

    Sub win(value2 As String)
        If str = value2 Then
            MessageBox.Show("You Win!!", "SICS")
            MessageBox.Show("Go to next level ", "SICS")
            btnnext.Enabled = True
        End If

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
