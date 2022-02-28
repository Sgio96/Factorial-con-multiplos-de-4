Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, s, n, j, k As Double
        Dim p As String
        s = TextBox1.Text
        j = 1
        k = 0
        For n = 1 To s
            j = j * n
        Next
        Label3.Text = j
        For a = 0 To j
            If a Mod 4 = 0 And Not a = 0 Then
                k = k + 1
                p = p + a.ToString + " "
            End If
        Next
        Label4.Text = k
        Label6.Text = p
    End Sub
End Class
