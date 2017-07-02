<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.main_button = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.se_label = New System.Windows.Forms.Label()
        Me.mn_label = New System.Windows.Forms.Label()
        Me.hr_label = New System.Windows.Forms.Label()
        Me.set_button = New System.Windows.Forms.Button()
        Me.se_input = New System.Windows.Forms.NumericUpDown()
        Me.mn_input = New System.Windows.Forms.NumericUpDown()
        Me.hr_input = New System.Windows.Forms.NumericUpDown()
        Me.count = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.se_input, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mn_input, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hr_input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(178, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 23)
        Me.Label3.TabIndex = 27
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(92, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "⏰"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(-5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(181, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 23)
        Me.Label7.TabIndex = 31
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(90, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 23)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "by@iconboot"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label8, "Twitter")
        Me.Label8.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(-5, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 23)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "  F1    "
        Me.ToolTip1.SetToolTip(Me.Label1, "Help")
        Me.Label1.Visible = False
        '
        'main_button
        '
        Me.main_button.BackColor = System.Drawing.Color.SteelBlue
        Me.main_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.main_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.main_button.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_button.Location = New System.Drawing.Point(110, 133)
        Me.main_button.Name = "main_button"
        Me.main_button.Size = New System.Drawing.Size(59, 23)
        Me.main_button.TabIndex = 3
        Me.main_button.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(175, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 35)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = ":"
        '
        'se_label
        '
        Me.se_label.AutoSize = True
        Me.se_label.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se_label.Location = New System.Drawing.Point(206, 82)
        Me.se_label.Name = "se_label"
        Me.se_label.Size = New System.Drawing.Size(49, 33)
        Me.se_label.TabIndex = 2
        Me.se_label.Text = "00"
        '
        'mn_label
        '
        Me.mn_label.AutoSize = True
        Me.mn_label.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn_label.Location = New System.Drawing.Point(115, 82)
        Me.mn_label.Name = "mn_label"
        Me.mn_label.Size = New System.Drawing.Size(49, 33)
        Me.mn_label.TabIndex = 1
        Me.mn_label.Text = "00"
        '
        'hr_label
        '
        Me.hr_label.AutoSize = True
        Me.hr_label.Cursor = System.Windows.Forms.Cursors.Default
        Me.hr_label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hr_label.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hr_label.Location = New System.Drawing.Point(29, 82)
        Me.hr_label.Name = "hr_label"
        Me.hr_label.Size = New System.Drawing.Size(49, 33)
        Me.hr_label.TabIndex = 0
        Me.hr_label.Text = "00"
        Me.hr_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'set_button
        '
        Me.set_button.BackColor = System.Drawing.Color.CadetBlue
        Me.set_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.set_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.set_button.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.set_button.Location = New System.Drawing.Point(109, 133)
        Me.set_button.Name = "set_button"
        Me.set_button.Size = New System.Drawing.Size(60, 23)
        Me.set_button.TabIndex = 4
        Me.set_button.Text = "Go"
        Me.set_button.UseVisualStyleBackColor = False
        '
        'se_input
        '
        Me.se_input.BackColor = System.Drawing.SystemColors.GrayText
        Me.se_input.Cursor = System.Windows.Forms.Cursors.Hand
        Me.se_input.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se_input.ForeColor = System.Drawing.SystemColors.Window
        Me.se_input.Location = New System.Drawing.Point(201, 87)
        Me.se_input.Name = "se_input"
        Me.se_input.Size = New System.Drawing.Size(57, 23)
        Me.se_input.TabIndex = 2
        Me.se_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mn_input
        '
        Me.mn_input.BackColor = System.Drawing.SystemColors.GrayText
        Me.mn_input.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mn_input.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn_input.ForeColor = System.Drawing.SystemColors.Window
        Me.mn_input.Location = New System.Drawing.Point(112, 87)
        Me.mn_input.Name = "mn_input"
        Me.mn_input.Size = New System.Drawing.Size(57, 23)
        Me.mn_input.TabIndex = 1
        Me.mn_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hr_input
        '
        Me.hr_input.BackColor = System.Drawing.SystemColors.GrayText
        Me.hr_input.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hr_input.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hr_input.ForeColor = System.Drawing.SystemColors.Window
        Me.hr_input.Location = New System.Drawing.Point(24, 87)
        Me.hr_input.Name = "hr_input"
        Me.hr_input.Size = New System.Drawing.Size(57, 23)
        Me.hr_input.TabIndex = 0
        Me.hr_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'count
        '
        Me.count.Interval = 1000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 33)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(110, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Minutes"
        Me.ToolTip1.SetToolTip(Me.Label9, "الدقائق")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Location = New System.Drawing.Point(193, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Seconds"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label10, "الثواني")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(32, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 16)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Hours"
        Me.ToolTip1.SetToolTip(Me.Label11, "الساعات")
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.DimGray
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(30, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 23)
        Me.Label12.TabIndex = 42
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label12.Visible = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(278, 197)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.set_button)
        Me.Controls.Add(Me.se_input)
        Me.Controls.Add(Me.hr_label)
        Me.Controls.Add(Me.mn_input)
        Me.Controls.Add(Me.hr_input)
        Me.Controls.Add(Me.main_button)
        Me.Controls.Add(Me.mn_label)
        Me.Controls.Add(Me.se_label)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HappyTime"
        CType(Me.se_input, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mn_input, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hr_input, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents main_button As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents se_label As System.Windows.Forms.Label
    Friend WithEvents mn_label As System.Windows.Forms.Label
    Friend WithEvents hr_label As System.Windows.Forms.Label
    Friend WithEvents set_button As System.Windows.Forms.Button
    Friend WithEvents se_input As System.Windows.Forms.NumericUpDown
    Friend WithEvents mn_input As System.Windows.Forms.NumericUpDown
    Friend WithEvents hr_input As System.Windows.Forms.NumericUpDown
    Friend WithEvents count As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
