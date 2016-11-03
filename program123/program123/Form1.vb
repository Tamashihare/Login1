Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "jaka" And TextBox2.Text = "123" Then
            Form2.Show()
            MsgBox("Login Sucess", MsgBoxStyle.OkOnly, "Invalid")

        Else
            MsgBox("sorry ,Username or password  not found", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub
End Class
