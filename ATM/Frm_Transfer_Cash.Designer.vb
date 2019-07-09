<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Transfer_Cash
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
        Me.CloudLabel2 = New CloudToolkitN6.CloudLabel
        Me.txt_AccountNo = New CloudToolkitN6.CloudTextBox
        Me.txt_TransferCash = New CloudToolkitN6.CloudTextBox
        Me.btnExit = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton
        Me.btnTransfer = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton
        Me.SuspendLayout()
        '
        'CloudLabel4
        '
        Me.CloudLabel4.AutoSize = True
        Me.CloudLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel4.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel4.ForeColor = System.Drawing.Color.White
        Me.CloudLabel4.Location = New System.Drawing.Point(12, 25)
        Me.CloudLabel4.Name = "CloudLabel4"
        Me.CloudLabel4.Size = New System.Drawing.Size(167, 33)
        Me.CloudLabel4.TabIndex = 17
        Me.CloudLabel4.Text = "Transfer Cash"
        '
        'CloudLabel1
        '
        Me.CloudLabel1.AutoSize = True
        Me.CloudLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel1.ForeColor = System.Drawing.Color.White
        Me.CloudLabel1.Location = New System.Drawing.Point(45, 201)
        Me.CloudLabel1.Name = "CloudLabel1"
        Me.CloudLabel1.Size = New System.Drawing.Size(180, 23)
        Me.CloudLabel1.TabIndex = 18
        Me.CloudLabel1.Text = "Enter Amount In (Rs.)"
        '
        'CloudLabel2
        '
        Me.CloudLabel2.AutoSize = True
        Me.CloudLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel2.ForeColor = System.Drawing.Color.White
        Me.CloudLabel2.Location = New System.Drawing.Point(45, 144)
        Me.CloudLabel2.Name = "CloudLabel2"
        Me.CloudLabel2.Size = New System.Drawing.Size(154, 23)
        Me.CloudLabel2.TabIndex = 19
        Me.CloudLabel2.Text = "Enter Account No."
        '
        'txt_AccountNo
        '
        Me.txt_AccountNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AccountNo.Location = New System.Drawing.Point(244, 141)
        Me.txt_AccountNo.MaxLength = 10
        Me.txt_AccountNo.Name = "txt_AccountNo"
        Me.txt_AccountNo.Size = New System.Drawing.Size(153, 26)
        Me.txt_AccountNo.TabIndex = 27
        Me.txt_AccountNo.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'txt_TransferCash
        '
        Me.txt_TransferCash.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TransferCash.Location = New System.Drawing.Point(244, 198)
        Me.txt_TransferCash.MaxLength = 5
        Me.txt_TransferCash.Name = "txt_TransferCash"
        Me.txt_TransferCash.Size = New System.Drawing.Size(153, 26)
        Me.txt_TransferCash.TabIndex = 28
        Me.txt_TransferCash.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias
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
        Me.btnExit.Location = New System.Drawing.Point(256, 333)
        Me.btnExit.MaximumGlowOpacity = 0.8
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NormalColors_1 = System.Drawing.Color.PowderBlue
        Me.btnExit.NormalColors_2 = System.Drawing.Color.PowderBlue
        Me.btnExit.NormalColors_3 = System.Drawing.Color.PowderBlue
        Me.btnExit.NormalColors_4 = System.Drawing.Color.PowderBlue
        Me.btnExit.Size = New System.Drawing.Size(114, 39)
        Me.btnExit.StartMenuIndex = 0
        Me.btnExit.TabIndex = 31
        Me.btnExit.TextCentered = True
        Me.btnExit.TextDistanceFromBorder = 5
        Me.btnExit.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'btnTransfer
        '
        Me.btnTransfer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTransfer.AnimationOpacityChange = 0.1
        Me.btnTransfer.BackColor = System.Drawing.Color.Transparent
        Me.btnTransfer.ButtonText = "Transfer"
        Me.btnTransfer.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnTransfer.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnTransfer.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnTransfer.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnTransfer.ControlOpacity = 255
        Me.btnTransfer.CornerRadius = 8
        Me.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransfer.DrawHoverOverIcon = False
        Me.btnTransfer.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnTransfer.ForeColor = System.Drawing.Color.Black
        Me.btnTransfer.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnTransfer.Icon = Nothing
        Me.btnTransfer.IsAnimated = True
        Me.btnTransfer.Location = New System.Drawing.Point(136, 333)
        Me.btnTransfer.MaximumGlowOpacity = 0.8
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.NormalColors_1 = System.Drawing.Color.PowderBlue
        Me.btnTransfer.NormalColors_2 = System.Drawing.Color.PowderBlue
        Me.btnTransfer.NormalColors_3 = System.Drawing.Color.PowderBlue
        Me.btnTransfer.NormalColors_4 = System.Drawing.Color.PowderBlue
        Me.btnTransfer.Size = New System.Drawing.Size(114, 39)
        Me.btnTransfer.StartMenuIndex = 0
        Me.btnTransfer.TabIndex = 30
        Me.btnTransfer.TextCentered = True
        Me.btnTransfer.TextDistanceFromBorder = 5
        Me.btnTransfer.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'Frm_Transfer_Cash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATM.My.Resources.Resources.darkaurora
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(509, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.txt_TransferCash)
        Me.Controls.Add(Me.txt_AccountNo)
        Me.Controls.Add(Me.CloudLabel2)
        Me.Controls.Add(Me.CloudLabel1)
        Me.Controls.Add(Me.CloudLabel4)
        Me.Location = New System.Drawing.Point(278, 220)
        Me.Name = "Frm_Transfer_Cash"
        Me.Text = "Frm_Transfer_Cash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloudLabel4 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudLabel1 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudLabel2 As CloudToolkitN6.CloudLabel
    Friend WithEvents txt_AccountNo As CloudToolkitN6.CloudTextBox
    Friend WithEvents txt_TransferCash As CloudToolkitN6.CloudTextBox
    Friend WithEvents btnExit As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents btnTransfer As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
End Class
