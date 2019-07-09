<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MainMenu
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
        Me.CloudLabel1 = New CloudToolkitN6.CloudLabel
        Me.CloudLabel3 = New CloudToolkitN6.CloudLabel
        Me.btnGetCash = New CloudToolkitN6.CloudDesktopButton
        Me.btnDepositCash = New CloudToolkitN6.CloudDesktopButton
        Me.btnBalanceInquiry = New CloudToolkitN6.CloudDesktopButton
        Me.btnTransfer = New CloudToolkitN6.CloudDesktopButton
        Me.btnSettings = New CloudToolkitN6.CloudDesktopButton
        Me.btnExit = New CloudToolkitN6.CloudDesktopButton
        Me.btnShowName = New CloudToolkitN6.CloudDesktopButton
        Me.btnTransaction = New CloudToolkitN6.CloudDesktopButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnShowBalance = New CloudToolkitN6.CloudDesktopButton
        Me.CloudLabel2 = New CloudToolkitN6.CloudLabel
        Me.CloudLabel4 = New CloudToolkitN6.CloudLabel
        Me.CloudDigitalClock1 = New CloudToolkitN6.CloudDigitalClock
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloudLabel1
        '
        Me.CloudLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CloudLabel1.AutoSize = True
        Me.CloudLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel1.ForeColor = System.Drawing.Color.White
        Me.CloudLabel1.Location = New System.Drawing.Point(263, 58)
        Me.CloudLabel1.Name = "CloudLabel1"
        Me.CloudLabel1.Size = New System.Drawing.Size(102, 23)
        Me.CloudLabel1.TabIndex = 3
        Me.CloudLabel1.Text = "Welcome ,  "
        '
        'CloudLabel3
        '
        Me.CloudLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CloudLabel3.AutoSize = True
        Me.CloudLabel3.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel3.ForeColor = System.Drawing.Color.White
        Me.CloudLabel3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CloudLabel3.Location = New System.Drawing.Point(261, 142)
        Me.CloudLabel3.Name = "CloudLabel3"
        Me.CloudLabel3.Size = New System.Drawing.Size(241, 33)
        Me.CloudLabel3.TabIndex = 4
        Me.CloudLabel3.Text = "Select A Transaction"
        '
        'btnGetCash
        '
        Me.btnGetCash.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnGetCash.AnimationSpeed = 5
        Me.btnGetCash.BackColor = System.Drawing.Color.Transparent
        Me.btnGetCash.BackgroundOpacity = 100
        Me.btnGetCash.BackgroundOpacity_MouseDown = 170
        Me.btnGetCash.BorderColor = System.Drawing.Color.White
        Me.btnGetCash.BorderOpacity = 170
        Me.btnGetCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnGetCash.BorderWidth = 5
        Me.btnGetCash.ControlText = "Withdraw Cash"
        Me.btnGetCash.CornerRadius = 12
        Me.btnGetCash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetCash.DrawBlackTextBackground = True
        Me.btnGetCash.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGetCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetCash.ForeColor = System.Drawing.Color.White
        Me.btnGetCash.Icon = Global.ATM.My.Resources.Resources.kwallet
        Me.btnGetCash.Location = New System.Drawing.Point(647, 337)
        Me.btnGetCash.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnGetCash.Name = "btnGetCash"
        Me.btnGetCash.Size = New System.Drawing.Size(135, 92)
        Me.btnGetCash.TabIndex = 5
        '
        'btnDepositCash
        '
        Me.btnDepositCash.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDepositCash.AnimationSpeed = 5
        Me.btnDepositCash.BackColor = System.Drawing.Color.Transparent
        Me.btnDepositCash.BackgroundOpacity = 100
        Me.btnDepositCash.BackgroundOpacity_MouseDown = 170
        Me.btnDepositCash.BorderColor = System.Drawing.Color.White
        Me.btnDepositCash.BorderOpacity = 170
        Me.btnDepositCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnDepositCash.BorderWidth = 5
        Me.btnDepositCash.ControlText = "Deposit Cash"
        Me.btnDepositCash.CornerRadius = 12
        Me.btnDepositCash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDepositCash.DrawBlackTextBackground = True
        Me.btnDepositCash.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDepositCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepositCash.ForeColor = System.Drawing.Color.White
        Me.btnDepositCash.Icon = Global.ATM.My.Resources.Resources.my_documents
        Me.btnDepositCash.Location = New System.Drawing.Point(647, 211)
        Me.btnDepositCash.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnDepositCash.Name = "btnDepositCash"
        Me.btnDepositCash.Size = New System.Drawing.Size(135, 92)
        Me.btnDepositCash.TabIndex = 6
        '
        'btnBalanceInquiry
        '
        Me.btnBalanceInquiry.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnBalanceInquiry.AnimationSpeed = 5
        Me.btnBalanceInquiry.BackColor = System.Drawing.Color.Transparent
        Me.btnBalanceInquiry.BackgroundOpacity = 100
        Me.btnBalanceInquiry.BackgroundOpacity_MouseDown = 170
        Me.btnBalanceInquiry.BorderColor = System.Drawing.Color.White
        Me.btnBalanceInquiry.BorderOpacity = 170
        Me.btnBalanceInquiry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnBalanceInquiry.BorderWidth = 5
        Me.btnBalanceInquiry.ControlText = "Balance Inquiry"
        Me.btnBalanceInquiry.CornerRadius = 12
        Me.btnBalanceInquiry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBalanceInquiry.DrawBlackTextBackground = True
        Me.btnBalanceInquiry.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBalanceInquiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalanceInquiry.ForeColor = System.Drawing.Color.White
        Me.btnBalanceInquiry.Icon = Global.ATM.My.Resources.Resources.Binoculars1
        Me.btnBalanceInquiry.Location = New System.Drawing.Point(4, 85)
        Me.btnBalanceInquiry.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnBalanceInquiry.Name = "btnBalanceInquiry"
        Me.btnBalanceInquiry.Size = New System.Drawing.Size(135, 92)
        Me.btnBalanceInquiry.TabIndex = 7
        '
        'btnTransfer
        '
        Me.btnTransfer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnTransfer.AnimationSpeed = 5
        Me.btnTransfer.BackColor = System.Drawing.Color.Transparent
        Me.btnTransfer.BackgroundOpacity = 100
        Me.btnTransfer.BackgroundOpacity_MouseDown = 170
        Me.btnTransfer.BorderColor = System.Drawing.Color.White
        Me.btnTransfer.BorderOpacity = 170
        Me.btnTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnTransfer.BorderWidth = 5
        Me.btnTransfer.ControlText = "Transfer Cash"
        Me.btnTransfer.CornerRadius = 12
        Me.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransfer.DrawBlackTextBackground = True
        Me.btnTransfer.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.ForeColor = System.Drawing.Color.White
        Me.btnTransfer.Icon = Global.ATM.My.Resources.Resources.kwrite
        Me.btnTransfer.Location = New System.Drawing.Point(647, 85)
        Me.btnTransfer.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(135, 92)
        Me.btnTransfer.TabIndex = 8
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSettings.AnimationSpeed = 5
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BackgroundOpacity = 100
        Me.btnSettings.BackgroundOpacity_MouseDown = 170
        Me.btnSettings.BorderColor = System.Drawing.Color.White
        Me.btnSettings.BorderOpacity = 170
        Me.btnSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnSettings.BorderWidth = 5
        Me.btnSettings.ControlText = "Settings"
        Me.btnSettings.CornerRadius = 12
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.DrawBlackTextBackground = True
        Me.btnSettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Icon = Global.ATM.My.Resources.Resources.kuser
        Me.btnSettings.Location = New System.Drawing.Point(4, 337)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(135, 92)
        Me.btnSettings.TabIndex = 9
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
        Me.btnExit.Location = New System.Drawing.Point(647, 449)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 87)
        Me.btnExit.TabIndex = 10
        '
        'btnShowName
        '
        Me.btnShowName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnShowName.AnimationSpeed = 5
        Me.btnShowName.BackColor = System.Drawing.Color.LightCyan
        Me.btnShowName.BackgroundOpacity = 100
        Me.btnShowName.BackgroundOpacity_MouseDown = 170
        Me.btnShowName.BorderColor = System.Drawing.Color.LightCyan
        Me.btnShowName.BorderOpacity = 170
        Me.btnShowName.BorderWidth = 1
        Me.btnShowName.ControlText = ""
        Me.btnShowName.CornerRadius = 12
        Me.btnShowName.DrawBlackTextBackground = True
        Me.btnShowName.FillColor = System.Drawing.Color.Azure
        Me.btnShowName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowName.ForeColor = System.Drawing.Color.Black
        Me.btnShowName.Icon = Nothing
        Me.btnShowName.Location = New System.Drawing.Point(364, 49)
        Me.btnShowName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnShowName.Name = "btnShowName"
        Me.btnShowName.Size = New System.Drawing.Size(154, 41)
        Me.btnShowName.TabIndex = 11
        '
        'btnTransaction
        '
        Me.btnTransaction.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnTransaction.AnimationSpeed = 5
        Me.btnTransaction.BackColor = System.Drawing.Color.Transparent
        Me.btnTransaction.BackgroundOpacity = 100
        Me.btnTransaction.BackgroundOpacity_MouseDown = 170
        Me.btnTransaction.BorderColor = System.Drawing.Color.White
        Me.btnTransaction.BorderOpacity = 170
        Me.btnTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnTransaction.BorderWidth = 5
        Me.btnTransaction.ControlText = "Trancation History"
        Me.btnTransaction.CornerRadius = 12
        Me.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransaction.DrawBlackTextBackground = True
        Me.btnTransaction.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.Icon = Global.ATM.My.Resources.Resources.mydocuments
        Me.btnTransaction.Location = New System.Drawing.Point(4, 211)
        Me.btnTransaction.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(135, 92)
        Me.btnTransaction.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnShowBalance)
        Me.GroupBox1.Controls.Add(Me.CloudLabel2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(178, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 139)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'btnShowBalance
        '
        Me.btnShowBalance.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnShowBalance.AnimationSpeed = 5
        Me.btnShowBalance.BackColor = System.Drawing.Color.LightCyan
        Me.btnShowBalance.BackgroundOpacity = 100
        Me.btnShowBalance.BackgroundOpacity_MouseDown = 170
        Me.btnShowBalance.BorderColor = System.Drawing.Color.LightCyan
        Me.btnShowBalance.BorderOpacity = 170
        Me.btnShowBalance.BorderWidth = 1
        Me.btnShowBalance.ControlText = ""
        Me.btnShowBalance.CornerRadius = 12
        Me.btnShowBalance.DrawBlackTextBackground = True
        Me.btnShowBalance.FillColor = System.Drawing.Color.Azure
        Me.btnShowBalance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowBalance.ForeColor = System.Drawing.Color.Black
        Me.btnShowBalance.Icon = Nothing
        Me.btnShowBalance.Location = New System.Drawing.Point(230, 51)
        Me.btnShowBalance.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnShowBalance.Name = "btnShowBalance"
        Me.btnShowBalance.Size = New System.Drawing.Size(123, 41)
        Me.btnShowBalance.TabIndex = 14
        '
        'CloudLabel2
        '
        Me.CloudLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CloudLabel2.AutoSize = True
        Me.CloudLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel2.ForeColor = System.Drawing.Color.White
        Me.CloudLabel2.Location = New System.Drawing.Point(39, 66)
        Me.CloudLabel2.Name = "CloudLabel2"
        Me.CloudLabel2.Size = New System.Drawing.Size(195, 26)
        Me.CloudLabel2.TabIndex = 13
        Me.CloudLabel2.Text = "Your Balance Is , Rs.  "
        '
        'CloudLabel4
        '
        Me.CloudLabel4.AutoSize = True
        Me.CloudLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel4.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel4.ForeColor = System.Drawing.Color.White
        Me.CloudLabel4.Location = New System.Drawing.Point(-2, 25)
        Me.CloudLabel4.Name = "CloudLabel4"
        Me.CloudLabel4.Size = New System.Drawing.Size(145, 33)
        Me.CloudLabel4.TabIndex = 14
        Me.CloudLabel4.Text = "Main Menu"
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
        Me.CloudDigitalClock1.Location = New System.Drawing.Point(526, 3)
        Me.CloudDigitalClock1.Name = "CloudDigitalClock1"
        Me.CloudDigitalClock1.NumberColor = System.Drawing.Color.White
        Me.CloudDigitalClock1.NumberFont = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CloudDigitalClock1.Size = New System.Drawing.Size(271, 99)
        Me.CloudDigitalClock1.TabIndex = 15
        '
        'Frm_MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATM.My.Resources.Resources.darkaurora
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(796, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.CloudDigitalClock1)
        Me.Controls.Add(Me.CloudLabel4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTransaction)
        Me.Controls.Add(Me.btnShowName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnBalanceInquiry)
        Me.Controls.Add(Me.btnDepositCash)
        Me.Controls.Add(Me.btnGetCash)
        Me.Controls.Add(Me.CloudLabel3)
        Me.Controls.Add(Me.CloudLabel1)
        Me.DoubleBuffered = True
        Me.Name = "Frm_MainMenu"
        Me.Text = "Frm_MainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloudLabel1 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudLabel3 As CloudToolkitN6.CloudLabel
    Friend WithEvents btnGetCash As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnDepositCash As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnBalanceInquiry As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnTransfer As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnSettings As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnExit As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnShowName As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents btnTransaction As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowBalance As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents CloudLabel2 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudLabel4 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudDigitalClock1 As CloudToolkitN6.CloudDigitalClock
End Class
