Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.T Then
            Process.Start("http://ico.esy.es/com")
        End If
        If e.KeyCode = Keys.F1 Then
            Form2.Show()
            Me.Hide()
        End If
        If e.KeyCode = Keys.E Then
            Form4.Show()
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