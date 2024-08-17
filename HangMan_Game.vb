Imports System.Diagnostics.Eventing.Reader

Public Class HangMan_Game
    Dim str As String
    Dim i, j As Integer
    Dim char1 As Char
    Dim n As Integer = 0
    Dim nextf As Integer
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        txtresult.Clear()
        PictureBox1.Image = My.Resources.hang0
        str = "Apple"
        nextf = 1
        str = str.ToUpper()
        txtresult.Text = New String("-"c, str.Length) ' Initialize with dashes

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
            txtresult.Clear()
            PictureBox1.Image = My.Resources.hang0
            str = "Apple"
            nextf = 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        End If
    End Sub

    Sub change(str1 As Char, ind As Integer)
        Dim strresult As String = txtresult.Text
        Dim charArray As Char() = strresult.ToCharArray() ' Convert the string to a character array
        charArray(ind) = str1 ' Replace the character at the specific index
        txtresult.Text = New String(charArray) ' Convert the character array back to a string and update the text
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
        PictureBox1.Image = My.Resources.hang0
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        If nextf = 1 Then
            str = "banana"
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 2 Then
            str = "Grapes"
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 3 Then
            str = "mango"
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 4 Then
            str = "orange"
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 5 Then
            str = "fig"
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 6 Then
            str = "coconut"
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        ElseIf nextf = 7 Then
            str = "pomegrante"
            nextf += 1
            str = str.ToUpper()
            txtresult.Text = New String("-"c, str.Length)
        End If

    End Sub
End Class
