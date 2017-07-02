Public Class Form4

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.T Then
            Process.Start("http://ico.esy.es/com")
        End If
        If e.KeyCode = Keys.B Then
            Form5.Show()
            Me.Hide()
        End If
        If e.KeyCode = Keys.X Then
            Form2.Show()
            Me.Hide()
        End If
        If e.KeyCode = Keys.M Then
            Form3.Show()
            Me.Hide()
        End If
        If e.KeyCode = Keys.O Then
            End
        End If
        If e.KeyCode = Keys.I Then
            Form6.Show()
            Me.Hide()
        End If
        If e.KeyCode = Keys.Back Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class