<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Deposit_Cash
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
        Me.CloudLabel4 = New CloudToolkitN6.CloudLabel
        Me.CloudLabel1 = New CloudToolkitN6.CloudLabel
        Me.txt_DepositCash = New CloudToolkitN6.CloudTextBox
        Me.btnDeposit = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton
        Me.btnExit = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton
        Me.SuspendLayout()
        '
        'CloudLabel4
        '
        Me.CloudLabel4.AutoSize = True
        Me.CloudLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel4.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel4.ForeColor = System.Drawing.Color.White
        Me.CloudLabel4.Location = New System.Drawing.Point(12, 20)
        Me.CloudLabel4.Name = "CloudLabel4"
        Me.CloudLabel4.Size = New System.Drawing.Size(160, 33)
        Me.CloudLabel4.TabIndex = 15
        Me.CloudLabel4.Text = "Deposit Cash"
        '
        'CloudLabel1
        '
        Me.CloudLabel1.AutoSize = True
        Me.CloudLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel1.ForeColor = System.Drawing.Color.White
        Me.CloudLabel1.Location = New System.Drawing.Point(23, 129)
        Me.CloudLabel1.Name = "CloudLabel1"
        Me.CloudLabel1.Size = New System.Drawing.Size(200, 23)
        Me.CloudLabel1.TabIndex = 16
        Me.CloudLabel1.Text = "Enter Deposit Cash (Rs.)"
        '
        'txt_DepositCash
        '
        Me.txt_DepositCash.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DepositCash.Location = New System.Drawing.Point(244, 130)
        Me.txt_DepositCash.MaxLength = 6
        Me.txt_DepositCash.Name = "txt_DepositCash"
        Me.txt_DepositCash.Size = New System.Drawing.Size(153, 26)
        Me.txt_DepositCash.TabIndex = 25
        Me.txt_DepositCash.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'btnDeposit
        '
        Me.btnDeposit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeposit.AnimationOpacityChange = 0.1
        Me.btnDeposit.BackColor = System.Drawing.Color.Transparent
        Me.btnDeposit.ButtonText = "Deposit"
        Me.btnDeposit.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDeposit.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnDeposit.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnDeposit.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnDeposit.ControlOpacity = 255
        Me.btnDeposit.CornerRadius = 8
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.DrawHoverOverIcon = False
        Me.btnDeposit.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnDeposit.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnDeposit.Icon = Nothing
        Me.btnDeposit.IsAnimated = True
        Me.btnDeposit.Location = New System.Drawing.Point(137, 308)
        Me.btnDeposit.MaximumGlowOpacity = 0.8
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.NormalColors_1 = System.Drawing.Color.PowderBlue
        Me.btnDeposit.NormalColors_2 = System.Drawing.Color.PowderBlue
        Me.btnDeposit.NormalColors_3 = System.Drawing.Color.PowderBlue
        Me.btnDeposit.NormalColors_4 = System.Drawing.Color.PowderBlue
        Me.btnDeposit.Size = New System.Drawing.Size(114, 39)
        Me.btnDeposit.StartMenuIndex = 0
        Me.btnDeposit.TabIndex = 26
        Me.btnDeposit.TextCentered = True
        Me.btnDeposit.TextDistanceFromBorder = 5
        Me.btnDeposit.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.AnimationOpacityChange = 0.1
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.ButtonText = "Exit"
        Me.btnExit.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExit.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnExit.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnExit.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnExit.ControlOpacity = 255
        Me.btnExit.CornerRadius = 8
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DrawHoverOverIcon = False
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnExit.Icon = Nothing
        Me.btnExit.IsAnimated = True
        Me.btnExit.Location = New System.Drawing.Point(257, 308)
        Me.btnExit.MaximumGlowOpacity = 0.8
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NormalColors_1 = System.Drawing.Color.PowderBlue
        Me.btnExit.NormalColors_2 = System.Drawing.Color.PowderBlue
        Me.btnExit.NormalColors_3 = System.Drawing.Color.PowderBlue
        Me.btnExit.NormalColors_4 = System.Drawing.Color.PowderBlue
        Me.btnExit.Size = New System.Drawing.Size(114, 39)
        Me.btnExit.StartMenuIndex = 0
        Me.btnExit.TabIndex = 27
        Me.btnExit.TextCentered = True
        Me.btnExit.TextDistanceFromBorder = 5
        Me.btnExit.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'Frm_Deposit_Cash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATM.My.Resources.Resources.darkaurora
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(509, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.txt_DepositCash)
        Me.Controls.Add(Me.CloudLabel1)
        Me.Controls.Add(Me.CloudLabel4)
        Me.Location = New System.Drawing.Point(278, 220)
        Me.Name = "Frm_Deposit_Cash"
        Me.Text = "Frm_Deposit_Cash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloudLabel4 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudLabel1 As CloudToolkitN6.CloudLabel
    Friend WithEvents txt_DepositCash As CloudToolkitN6.CloudTextBox
    Friend WithEvents btnDeposit As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents btnExit As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
End Class
