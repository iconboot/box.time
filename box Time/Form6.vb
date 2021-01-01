Public Class Form6

    Dim totaltime As Long

    Function AddZero(ByVal par As Integer) As String
        Dim a = ""
        If par < 10 Then
            a = "0" & par
        Else
            a = par
        End If
        Return a
    End Function

    Private Sub set_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_button.Click
        totaltime = hr_input.Value * 60 * 60 + mn_input.Value * 60 + se_input.Value

        If totaltime <> 0 Then
            main_button.Show()
            main_button.Enabled = True
            hr_label.Text = AddZero(totaltime \ 3600)
            mn_label.Text = AddZero((totaltime Mod 3600) \ 60)
            se_label.Text = AddZero((totaltime Mod 3600) Mod 60)
            main_button.Text = "Start"
            main_button.BackColor = Color.SteelBlue
            set_button.Enabled = False
            set_button.Hide()

            hr_label.Show()
            mn_label.Show()
            se_label.Show()


            hr_input.Hide()

            mn_input.Hide()

            se_input.Hide()




        Else
            MsgBox("Select time please", MsgBoxStyle.Exclamation)
        End If
        Label1.Show()
        Label7.Show()
        Label8.Show()
        Label12.Show()
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        main_button.Enabled = False
        main_button.Hide()
        hr_label.Hide()
        mn_label.Hide()
        se_label.Hide()

    End Sub

    Private Sub main_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main_button.Click
        If main_button.Text = "Start" Or main_button.Text = "Continue" Then
            hr_label.Show()
            mn_label.Show()
            se_label.Show()
            hr_input.Enabled = False
            mn_input.Enabled = False
            se_input.Enabled = False
            count.Enabled = True
            main_button.Text = "Stop"
            main_button.BackColor = Color.Red
        Else
            main_button.Text = "Continue"
            hr_input.Enabled = True
            mn_input.Enabled = True
            se_input.Enabled = True
            count.Enabled = False
            Shell("shutdown -a")
            Process.Start("cmd.exe", "/c netsh interface set interface Ethernet admin=ENABLE")
            Process.Start("cmd.exe", "/c netsh interface set interface Wi-Fi admin=ENABLE")
            set_button.Enabled = True
            set_button.Show()
            main_button.Hide()
            hr_label.Hide()
            mn_label.Hide()
            se_label.Hide()

            'hr_label.BackColor = Color.DimGray
            'mn_label.BackColor = Color.DimGray
            se_label.ForeColor = Color.Black
            mn_label.ForeColor = Color.Black

            hr_input.Show()
            mn_input.Show()
            se_input.Show()

        End If
    End Sub

    Private Sub count_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles count.Tick

        If totaltime > 600 Then
            'totaltime -= 1
        Else
            se_label.ForeColor = Color.Red
            mn_label.ForeColor = Color.Red
            set_button.Enabled = True
            main_button.Text = "Stop"
        End If
        hr_label.Text = AddZero(totaltime \ 3600)
        mn_label.Text = AddZero((totaltime Mod 3600) \ 60)
        se_label.Text = AddZero((totaltime Mod 3600) Mod 60)

        If totaltime > 60 Then
            totaltime -= 0

        Else
            mn_label.ForeColor = Color.Black
            set_button.Enabled = True
            main_button.Text = "Stop"
        End If
        hr_label.Text = AddZero(totaltime \ 3600)
        mn_label.Text = AddZero((totaltime Mod 3600) \ 60)
        se_label.Text = AddZero((totaltime Mod 3600) Mod 60)


        If totaltime > 0 Then
            totaltime -= 1
        Else
            Shell("shutdown /s /t 60")
            Process.Start("cmd.exe", "/c netsh interface set interface Ethernet admin=DISABLED")
            Process.Start("cmd.exe", "/c netsh interface set interface Wi-Fi admin=DISABLED")
            count.Enabled = False
            se_label.ForeColor = Color.Black
            If MsgBox("Goodbye friend", MsgBoxStyle.Critical, "Time is over !") Then

                hr_label.Hide()
                mn_label.Hide()
                se_label.Hide()

                hr_input.Show()
                mn_input.Show()
                se_input.Show()

            End If
            'End
            set_button.Enabled = True
            set_button.Show()
            main_button.Text = "Stop"
            hr_input.Enabled = True
            mn_input.Enabled = True
            se_input.Enabled = True
        End If
        hr_label.Text = AddZero(totaltime \ 3600)
        mn_label.Text = AddZero((totaltime Mod 3600) \ 60)
        se_label.Text = AddZero((totaltime Mod 3600) Mod 60)

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Process.Start("https://twitter.com/iconboot")
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Today
        Label3.Text = TimeValue(Now)
    End Sub
    Private Sub Form6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.T Then
            Process.Start("https://iconboot.github.io")
        End If
        If e.KeyCode = Keys.E Then
            Form4.Show()
            Me.Hide()
        End If
        If e.KeyCode = Keys.B Then
            Form5.Show()
            Me.Hide()
        End If
        If e.KeyCode = Keys.X Then
            Form2.Show()
            Me.Hide()
        End If
        If e.KeyCode = Keys.O Then
            End
        End If
        If e.KeyCode = Keys.Back Then
            Form1.Show()
            Me.Hide()
        End If
        If e.KeyCode = Keys.Escape Then
            End
        End If
        If e.KeyCode = Keys.F1 Then
            Form2.Show()
            Me.Hide()
        End If
        If e.KeyCode = Keys.M Then
            Form3.Show()
            Me.Hide()
        End If
    End Sub

End Class

