<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Transaction_History
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
        Me.dgv_NewUsers = New System.Windows.Forms.DataGridView
        Me.Deposit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Withdraw = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnExit = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton
        CType(Me.dgv_NewUsers, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CloudLabel4.Size = New System.Drawing.Size(233, 33)
        Me.CloudLabel4.TabIndex = 15
        Me.CloudLabel4.Text = "Transcation History"
        '
        'dgv_NewUsers
        '
        Me.dgv_NewUsers.AllowUserToAddRows = False
        Me.dgv_NewUsers.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dgv_NewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_NewUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Deposit, Me.Withdraw, Me.TDate})
        Me.dgv_NewUsers.Enabled = False
        Me.dgv_NewUsers.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_NewUsers.Location = New System.Drawing.Point(80, 115)
        Me.dgv_NewUsers.Name = "dgv_NewUsers"
        Me.dgv_NewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_NewUsers.Size = New System.Drawing.Size(343, 192)
        Me.dgv_NewUsers.TabIndex = 39
        '
        'Deposit
        '
        Me.Deposit.HeaderText = "Deposit Amount"
        Me.Deposit.Name = "Deposit"
        Me.Deposit.ReadOnly = True
        '
        'Withdraw
        '
        Me.Withdraw.HeaderText = "Withdraw Amount"
        Me.Withdraw.Name = "Withdraw"
        Me.Withdraw.ReadOnly = True
        '
        'TDate
        '
        Me.TDate.HeaderText = "Date"
        Me.TDate.Name = "TDate"
        Me.TDate.ReadOnly = True
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
        Me.btnExit.Location = New System.Drawing.Point(203, 370)
        Me.btnExit.MaximumGlowOpacity = 0.8
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NormalColors_1 = System.Drawing.Color.PowderBlue
        Me.btnExit.NormalColors_2 = System.Drawing.Color.PowderBlue
        Me.btnExit.NormalColors_3 = System.Drawing.Color.PowderBlue
        Me.btnExit.NormalColors_4 = System.Drawing.Color.PowderBlue
        Me.btnExit.Size = New System.Drawing.Size(114, 39)
        Me.btnExit.StartMenuIndex = 0
        Me.btnExit.TabIndex = 40
        Me.btnExit.TextCentered = True
        Me.btnExit.TextDistanceFromBorder = 5
        Me.btnExit.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'Frm_Transaction_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATM.My.Resources.Resources.darkaurora
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(520, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgv_NewUsers)
        Me.Controls.Add(Me.CloudLabel4)
        Me.Name = "Frm_Transaction_History"
        Me.Text = "Frm_Transaction_History"
        CType(Me.dgv_NewUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloudLabel4 As CloudToolkitN6.CloudLabel
    Friend WithEvents dgv_NewUsers As System.Windows.Forms.DataGridView
    Friend WithEvents Deposit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Withdraw As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExit As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
End Class
