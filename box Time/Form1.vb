Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Today
        Label3.Text = TimeValue(Now)

    End Sub



    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.Escape Then
            End
        End If
        If e.KeyCode = Keys.ShiftKey Then

            Label1.Show()
            Label7.Show()
            Label8.Show()
            If ComboBox1.Text <> "" Then
                If ComboBox1.Text = 900 Then MsgBox("a quarter hour ¼")
                If ComboBox1.Text = 1800 Then MsgBox("half an hour ½")
                If ComboBox1.Text = 3600 Then MsgBox("hour 1")
                If ComboBox1.Text = 7200 Then MsgBox("Two hours 2")
                If ComboBox1.Text = 14400 Then MsgBox("three hours 3")
            Else
                MsgBox("Time in seconds", MsgBoxStyle.Question, "Enter")

            End If
            Shell("shutdown -s -t " + ComboBox1.Text)
        End If
        If e.KeyCode = Keys.End Then
            MsgBox("Ending", MsgBoxStyle.Information, )
            Shell("shutdown -a")
            Label1.Show()
            Label7.Show()
            Label8.Show()
        End If
        If e.KeyCode = Keys.T Then
            Process.Start("https://iconboot.github.io")
        End If
        If e.KeyCode = Keys.F1 Then
            Form2.Show()
            Me.Hide()
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
        If e.KeyCode = Keys.M Then
            Form3.Show()
            Me.Hide()
        End If
        If e.KeyCode = Keys.O Then
            End
        End If
        If e.KeyCode = Keys.Back Then
            Form6.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox2.Items.Add("5")
        ComboBox2.Items.Add("10")
        ComboBox2.Items.Add("15")
        ComboBox2.Items.Add("30")
        ComboBox2.Items.Add("60")
        ComboBox2.Items.Add("hours 2")
        If My.Settings.SDate = Nothing Then
            My.Settings.SDate = Now.Date
            My.Settings.Save()
        End If

        Dim sdate As Date = My.Settings.SDate
        Dim NDate As Date = Now.Date

        Dim Diff As Integer = DateDiff(DateInterval.Day, sdate, NDate)

        If Diff > 102 Then

            If MsgBox("Goto help ", vbQuestion + vbYesNo) = vbYes Then
                Process.Start("https://www.facebook.com/lconboot")
            End If
            End


        Else
            'MsgBox("Welcom to box Time")'
        End If
        If My.Settings.SDate = Nothing Then
            My.Settings.SDate = Now.Date
            My.Settings.Save()

        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        If ComboBox2.Text = "5" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("300")
        End If
        If ComboBox2.Text = "10" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("600")
        End If
        If ComboBox2.Text = "15" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("900")
        End If
        If ComboBox2.Text = "30" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("1800")
        End If
        If ComboBox2.Text = "60" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("3600")
        End If
        If ComboBox2.Text = "hours 2" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("7200")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Show()
        Label7.Show()
        Label8.Show()
        If ComboBox1.Text <> "" Then
            If ComboBox1.Text = 900 Then MsgBox("a quarter hour ¼")
            If ComboBox1.Text = 1800 Then MsgBox("half an hour ½")
            If ComboBox1.Text = 3600 Then MsgBox("hour 1")
            If ComboBox1.Text = 7200 Then MsgBox("Two hours 2")
            If ComboBox1.Text = 14400 Then MsgBox("three hours 3")
        Else
            MsgBox("Time in seconds", MsgBoxStyle.Question, "Enter")

        End If
        Shell("shutdown -s -t " + ComboBox1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Ending", MsgBoxStyle.Information, )
        Shell("shutdown -a")
        Label1.Show()
        Label7.Show()
        Label8.Show()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Process.Start("https://twitter.com/iconboot")
    End Sub
End Class
