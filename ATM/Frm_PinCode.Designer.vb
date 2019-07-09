<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PinCode
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
        Me.components = New System.ComponentModel.Container
        Me.CloudLabel1 = New CloudToolkitN6.CloudLabel
        Me.CloudLabel2 = New CloudToolkitN6.CloudLabel
        Me.btnOK = New CloudToolkitN6.CloudDesktopButton
        Me.btnClear = New CloudToolkitN6.CloudDesktopButton
        Me.txt_code = New CloudToolkitN6.CloudTextBox
        Me.btnExit = New CloudToolkitN6.CloudDesktopButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CloudDigitalClock1 = New CloudToolkitN6.CloudDigitalClock
        Me.btnAdmin = New CloudToolkitN6.CloudDesktopButton
        Me.btnAbout = New CloudToolkitN6.CloudDesktopButton
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloudLabel1
        '
        Me.CloudLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CloudLabel1.AutoSize = True
        Me.CloudLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel1.ForeColor = System.Drawing.Color.White
        Me.CloudLabel1.Location = New System.Drawing.Point(193, 18)
        Me.CloudLabel1.Name = "CloudLabel1"
        Me.CloudLabel1.Size = New System.Drawing.Size(315, 33)
        Me.CloudLabel1.TabIndex = 0
        Me.CloudLabel1.Text = "Welcome To ATM Pakistan"
        '
        'CloudLabel2
        '
        Me.CloudLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CloudLabel2.AutoSize = True
        Me.CloudLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel2.ForeColor = System.Drawing.Color.White
        Me.CloudLabel2.Location = New System.Drawing.Point(103, 152)
        Me.CloudLabel2.Name = "CloudLabel2"
        Me.CloudLabel2.Size = New System.Drawing.Size(156, 29)
        Me.CloudLabel2.TabIndex = 1
        Me.CloudLabel2.Text = "Enter Your Pin"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.AnimationSpeed = 5
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BackgroundOpacity = 100
        Me.btnOK.BackgroundOpacity_MouseDown = 170
        Me.btnOK.BorderColor = System.Drawing.Color.White
        Me.btnOK.BorderOpacity = 170
        Me.btnOK.BorderWidth = 1
        Me.btnOK.ControlText = "Ok"
        Me.btnOK.CornerRadius = 12
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.DrawBlackTextBackground = True
        Me.btnOK.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Icon = Global.ATM.My.Resources.Resources._492
        Me.btnOK.Location = New System.Drawing.Point(247, 284)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(120, 87)
        Me.btnOK.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.AnimationSpeed = 5
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundOpacity = 100
        Me.btnClear.BackgroundOpacity_MouseDown = 170
        Me.btnClear.BorderColor = System.Drawing.Color.White
        Me.btnClear.BorderOpacity = 170
        Me.btnClear.BorderWidth = 1
        Me.btnClear.ControlText = "Clear"
        Me.btnClear.CornerRadius = 12
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DrawBlackTextBackground = True
        Me.btnClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Icon = Global.ATM.My.Resources.Resources.looknfeel
        Me.btnClear.Location = New System.Drawing.Point(375, 284)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 87)
        Me.btnClear.TabIndex = 3
        '
        'txt_code
        '
        Me.txt_code.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Location = New System.Drawing.Point(297, 152)
        Me.txt_code.MaxLength = 4
        Me.txt_code.Name = "txt_code"
        Me.txt_code.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_code.Size = New System.Drawing.Size(184, 29)
        Me.txt_code.TabIndex = 1
        Me.txt_code.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.AnimationSpeed = 5
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundOpacity = 100
        Me.btnExit.BackgroundOpacity_MouseDown = 170
        Me.btnExit.BorderColor = System.Drawing.Color.White
        Me.btnExit.BorderOpacity = 170
        Me.btnExit.BorderWidth = 1
        Me.btnExit.ControlText = "Exit"
        Me.btnExit.CornerRadius = 12
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DrawBlackTextBackground = True
        Me.btnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Icon = Global.ATM.My.Resources.Resources.DeleteRed2
        Me.btnExit.Location = New System.Drawing.Point(609, 377)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 87)
        Me.btnExit.TabIndex = 5
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CloudDigitalClock1
        '
        Me.CloudDigitalClock1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloudDigitalClock1.BackColor = System.Drawing.Color.Transparent
        Me.CloudDigitalClock1.ColorLower_1 = System.Drawing.Color.Transparent
        Me.CloudDigitalClock1.ColorLower_2 = System.Drawing.Color.Transparent
        Me.CloudDigitalClock1.ColorUpper_1 = System.Drawing.Color.Transparent
        Me.CloudDigitalClock1.ColorUpper_2 = System.Drawing.Color.Transparent
        Me.CloudDigitalClock1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloudDigitalClock1.DateColor = System.Drawing.Color.White
        Me.CloudDigitalClock1.DateFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CloudDigitalClock1.DrawDate = True
        Me.CloudDigitalClock1.Location = New System.Drawing.Point(458, 2)
        Me.CloudDigitalClock1.Name = "CloudDigitalClock1"
        Me.CloudDigitalClock1.NumberColor = System.Drawing.Color.White
        Me.CloudDigitalClock1.NumberFont = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CloudDigitalClock1.Size = New System.Drawing.Size(271, 99)
        Me.CloudDigitalClock1.TabIndex = 6
        '
        'btnAdmin
        '
        Me.btnAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdmin.AnimationSpeed = 5
        Me.btnAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAdmin.BackgroundOpacity = 100
        Me.btnAdmin.BackgroundOpacity_MouseDown = 170
        Me.btnAdmin.BorderColor = System.Drawing.Color.White
        Me.btnAdmin.BorderOpacity = 170
        Me.btnAdmin.BorderWidth = 1
        Me.btnAdmin.ControlText = "Admin"
        Me.btnAdmin.CornerRadius = 12
        Me.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmin.DrawBlackTextBackground = True
        Me.btnAdmin.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Icon = Global.ATM.My.Resources.Resources.linuxconf
        Me.btnAdmin.Location = New System.Drawing.Point(0, 377)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(120, 87)
        Me.btnAdmin.TabIndex = 7
        '
        'btnAbout
        '
        Me.btnAbout.AnimationSpeed = 5
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.BackgroundOpacity = 100
        Me.btnAbout.BackgroundOpacity_MouseDown = 170
        Me.btnAbout.BorderColor = System.Drawing.Color.White
        Me.btnAbout.BorderOpacity = 170
        Me.btnAbout.BorderWidth = 1
        Me.btnAbout.ControlText = "About"
        Me.btnAbout.CornerRadius = 12
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.DrawBlackTextBackground = True
        Me.btnAbout.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Icon = Global.ATM.My.Resources.Resources.messenger
        Me.btnAbout.Location = New System.Drawing.Point(0, 2)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(120, 87)
        Me.btnAbout.TabIndex = 8
        '
        'Frm_PinCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATM.My.Resources.Resources.darkaurora
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(727, 462)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.CloudDigitalClock1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.CloudLabel2)
        Me.Controls.Add(Me.CloudLabel1)
        Me.name = "Frm_PinCode"
        Me.Text = "Frm_PinCode"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloudLabel1 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudLabel2 As CloudToolkitN6.CloudLabel
    Friend WithEvents btnOK As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnClear As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents txt_code As CloudToolkitN6.CloudTextBox
    Friend WithEvents btnExit As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CloudDigitalClock1 As CloudToolkitN6.CloudDigitalClock
    Friend WithEvents btnAdmin As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnAbout As CloudToolkitN6.CloudDesktopButton

End Class
