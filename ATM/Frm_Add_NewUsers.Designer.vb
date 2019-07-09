<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_NewUsers
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
        Me.CloudLabel3 = New CloudToolkitN6.CloudLabel
        Me.CloudLabel5 = New CloudToolkitN6.CloudLabel
        Me.CloudLabel6 = New CloudToolkitN6.CloudLabel
        Me.CloudLabel7 = New CloudToolkitN6.CloudLabel
        Me.txt_Name = New CloudToolkitN6.CloudTextBox
        Me.txt_Pincode = New CloudToolkitN6.CloudTextBox
        Me.txt_Phone = New CloudToolkitN6.CloudTextBox
        Me.txt_Balance = New CloudToolkitN6.CloudTextBox
        Me.txt_Address = New CloudToolkitN6.CloudTextBox
        Me.txt_CNIC = New System.Windows.Forms.MaskedTextBox
        Me.btnAdd = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton
        Me.btnEdit = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton
        Me.btnRemove = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton
        Me.btnApply = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton
        Me.btnOk = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton
        Me.btnCancel = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton
        Me.dgv_NewUsers = New System.Windows.Forms.DataGridView
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FromDB = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CNIC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Accountno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pincode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_AccountNo = New CloudToolkitN6.CloudTextBox
        Me.CloudLabel8 = New CloudToolkitN6.CloudLabel
        CType(Me.dgv_NewUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloudLabel4
        '
        Me.CloudLabel4.AutoSize = True
        Me.CloudLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel4.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel4.ForeColor = System.Drawing.Color.White
        Me.CloudLabel4.Location = New System.Drawing.Point(12, 22)
        Me.CloudLabel4.Name = "CloudLabel4"
        Me.CloudLabel4.Size = New System.Drawing.Size(187, 33)
        Me.CloudLabel4.TabIndex = 15
        Me.CloudLabel4.Text = "Add New Users"
        '
        'CloudLabel1
        '
        Me.CloudLabel1.AutoSize = True
        Me.CloudLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel1.ForeColor = System.Drawing.Color.White
        Me.CloudLabel1.Location = New System.Drawing.Point(14, 97)
        Me.CloudLabel1.Name = "CloudLabel1"
        Me.CloudLabel1.Size = New System.Drawing.Size(57, 23)
        Me.CloudLabel1.TabIndex = 16
        Me.CloudLabel1.Text = "Name"
        '
        'CloudLabel2
        '
        Me.CloudLabel2.AutoSize = True
        Me.CloudLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel2.ForeColor = System.Drawing.Color.White
        Me.CloudLabel2.Location = New System.Drawing.Point(364, 167)
        Me.CloudLabel2.Name = "CloudLabel2"
        Me.CloudLabel2.Size = New System.Drawing.Size(61, 23)
        Me.CloudLabel2.TabIndex = 17
        Me.CloudLabel2.Text = "CNIC #"
        '
        'CloudLabel3
        '
        Me.CloudLabel3.AutoSize = True
        Me.CloudLabel3.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel3.ForeColor = System.Drawing.Color.White
        Me.CloudLabel3.Location = New System.Drawing.Point(364, 97)
        Me.CloudLabel3.Name = "CloudLabel3"
        Me.CloudLabel3.Size = New System.Drawing.Size(92, 23)
        Me.CloudLabel3.TabIndex = 18
        Me.CloudLabel3.Text = "Phone No."
        '
        'CloudLabel5
        '
        Me.CloudLabel5.AutoSize = True
        Me.CloudLabel5.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel5.ForeColor = System.Drawing.Color.White
        Me.CloudLabel5.Location = New System.Drawing.Point(14, 158)
        Me.CloudLabel5.Name = "CloudLabel5"
        Me.CloudLabel5.Size = New System.Drawing.Size(75, 23)
        Me.CloudLabel5.TabIndex = 19
        Me.CloudLabel5.Text = "Address"
        '
        'CloudLabel6
        '
        Me.CloudLabel6.AutoSize = True
        Me.CloudLabel6.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel6.ForeColor = System.Drawing.Color.White
        Me.CloudLabel6.Location = New System.Drawing.Point(364, 225)
        Me.CloudLabel6.Name = "CloudLabel6"
        Me.CloudLabel6.Size = New System.Drawing.Size(79, 23)
        Me.CloudLabel6.TabIndex = 20
        Me.CloudLabel6.Text = "Pin Code"
        '
        'CloudLabel7
        '
        Me.CloudLabel7.AutoSize = True
        Me.CloudLabel7.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel7.ForeColor = System.Drawing.Color.White
        Me.CloudLabel7.Location = New System.Drawing.Point(14, 281)
        Me.CloudLabel7.Name = "CloudLabel7"
        Me.CloudLabel7.Size = New System.Drawing.Size(112, 23)
        Me.CloudLabel7.TabIndex = 21
        Me.CloudLabel7.Text = "Balance (Rs.)"
        '
        'txt_Name
        '
        Me.txt_Name.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Name.Location = New System.Drawing.Point(135, 94)
        Me.txt_Name.MaxLength = 15
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(174, 26)
        Me.txt_Name.TabIndex = 1
        Me.txt_Name.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'txt_Pincode
        '
        Me.txt_Pincode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pincode.Location = New System.Drawing.Point(509, 223)
        Me.txt_Pincode.MaxLength = 4
        Me.txt_Pincode.Name = "txt_Pincode"
        Me.txt_Pincode.Size = New System.Drawing.Size(174, 26)
        Me.txt_Pincode.TabIndex = 6
        Me.txt_Pincode.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'txt_Phone
        '
        Me.txt_Phone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Phone.Location = New System.Drawing.Point(509, 98)
        Me.txt_Phone.MaxLength = 11
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(174, 26)
        Me.txt_Phone.TabIndex = 2
        Me.txt_Phone.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'txt_Balance
        '
        Me.txt_Balance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Balance.Location = New System.Drawing.Point(135, 281)
        Me.txt_Balance.MaxLength = 6
        Me.txt_Balance.Name = "txt_Balance"
        Me.txt_Balance.Size = New System.Drawing.Size(174, 26)
        Me.txt_Balance.TabIndex = 7
        Me.txt_Balance.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'txt_Address
        '
        Me.txt_Address.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address.Location = New System.Drawing.Point(135, 147)
        Me.txt_Address.MaxLength = 25
        Me.txt_Address.Multiline = True
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(174, 47)
        Me.txt_Address.TabIndex = 3
        Me.txt_Address.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'txt_CNIC
        '
        Me.txt_CNIC.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CNIC.Location = New System.Drawing.Point(509, 168)
        Me.txt_CNIC.Mask = "00000-0000000-0 "
        Me.txt_CNIC.Name = "txt_CNIC"
        Me.txt_CNIC.Size = New System.Drawing.Size(174, 26)
        Me.txt_CNIC.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.AnimationOpacityChange = 0.1
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.ButtonText = "Add"
        Me.btnAdd.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAdd.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnAdd.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnAdd.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnAdd.ControlOpacity = 255
        Me.btnAdd.CornerRadius = 8
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.DrawHoverOverIcon = False
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnAdd.Icon = Nothing
        Me.btnAdd.IsAnimated = True
        Me.btnAdd.Location = New System.Drawing.Point(12, 555)
        Me.btnAdd.MaximumGlowOpacity = 0.8
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.NormalColors_1 = System.Drawing.Color.PowderBlue
        Me.btnAdd.NormalColors_2 = System.Drawing.Color.PowderBlue
        Me.btnAdd.NormalColors_3 = System.Drawing.Color.PowderBlue
        Me.btnAdd.NormalColors_4 = System.Drawing.Color.PowderBlue
        Me.btnAdd.Size = New System.Drawing.Size(107, 39)
        Me.btnAdd.StartMenuIndex = 0
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.TextCentered = True
        Me.btnAdd.TextDistanceFromBorder = 5
        Me.btnAdd.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.AnimationOpacityChange = 0.1
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.ButtonText = "Edit"
        Me.btnEdit.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEdit.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEdit.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnEdit.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnEdit.ControlOpacity = 255
        Me.btnEdit.CornerRadius = 8
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.DrawHoverOverIcon = False
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnEdit.Icon = Nothing
        Me.btnEdit.IsAnimated = True
        Me.btnEdit.Location = New System.Drawing.Point(125, 555)
        Me.btnEdit.MaximumGlowOpacity = 0.8
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.NormalColors_1 = System.Drawing.Color.PowderBlue
        Me.btnEdit.NormalColors_2 = System.Drawing.Color.PowderBlue
        Me.btnEdit.NormalColors_3 = System.Drawing.Color.PowderBlue
        Me.btnEdit.NormalColors_4 = System.Drawing.Color.PowderBlue
        Me.btnEdit.Size = New System.Drawing.Size(109, 39)
        Me.btnEdit.StartMenuIndex = 0
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.TextCentered = True
        Me.btnEdit.TextDistanceFromBorder = 5
        Me.btnEdit.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRemove.AnimationOpacityChange = 0.1
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.ButtonText = "Remove"
        Me.btnRemove.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRemove.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnRemove.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnRemove.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnRemove.ControlOpacity = 255
        Me.btnRemove.CornerRadius = 8
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.DrawHoverOverIcon = False
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnRemove.Icon = Nothing
        Me.btnRemove.IsAnimated = True
        Me.btnRemove.Location = New System.Drawing.Point(240, 555)
        Me.btnRemove.MaximumGlowOpacity = 0.8
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.NormalColors_1 = System.Drawing.Color.PowderBlue
        Me.btnRemove.NormalColors_2 = System.Drawing.Color.PowderBlue
        Me.btnRemove.NormalColors_3 = System.Drawing.Color.PowderBlue
        Me.btnRemove.NormalColors_4 = System.Drawing.Color.PowderBlue
        Me.btnRemove.Size = New System.Drawing.Size(116, 39)
        Me.btnRemove.StartMenuIndex = 0
        Me.btnRemove.TabIndex = 34
        Me.btnRemove.TextCentered = True
        Me.btnRemove.TextDistanceFromBorder = 5
        Me.btnRemove.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'btnApply
        '
        Me.btnApply.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnApply.AnimationOpacityChange = 0.1
        Me.btnApply.BackColor = System.Drawing.Color.Transparent
        Me.btnApply.ButtonText = "Apply"
        Me.btnApply.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnApply.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnApply.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnApply.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnApply.ControlOpacity = 255
        Me.btnApply.CornerRadius = 8
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.DrawHoverOverIcon = False
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnApply.ForeColor = System.Drawing.Color.Black
        Me.btnApply.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnApply.Icon = Nothing
        Me.btnApply.IsAnimated = True
        Me.btnApply.Location = New System.Drawing.Point(362, 555)
        Me.btnApply.MaximumGlowOpacity = 0.8
        Me.btnApply.Name = "btnApply"
        Me.btnApply.NormalColors_1 = System.Drawing.Color.PowderBlue
        Me.btnApply.NormalColors_2 = System.Drawing.Color.PowderBlue
        Me.btnApply.NormalColors_3 = System.Drawing.Color.PowderBlue
        Me.btnApply.NormalColors_4 = System.Drawing.Color.PowderBlue
        Me.btnApply.Size = New System.Drawing.Size(111, 39)
        Me.btnApply.StartMenuIndex = 0
        Me.btnApply.TabIndex = 35
        Me.btnApply.TextCentered = True
        Me.btnApply.TextDistanceFromBorder = 5
        Me.btnApply.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOk.AnimationOpacityChange = 0.1
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.ButtonText = "Ok"
        Me.btnOk.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnOk.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnOk.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnOk.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnOk.ControlOpacity = 255
        Me.btnOk.CornerRadius = 8
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.DrawHoverOverIcon = False
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnOk.Icon = Nothing
        Me.btnOk.IsAnimated = True
        Me.btnOk.Location = New System.Drawing.Point(479, 555)
        Me.btnOk.MaximumGlowOpacity = 0.8
        Me.btnOk.Name = "btnOk"
        Me.btnOk.NormalColors_1 = System.Drawing.Color.PowderBlue
        Me.btnOk.NormalColors_2 = System.Drawing.Color.PowderBlue
        Me.btnOk.NormalColors_3 = System.Drawing.Color.PowderBlue
        Me.btnOk.NormalColors_4 = System.Drawing.Color.PowderBlue
        Me.btnOk.Size = New System.Drawing.Size(116, 39)
        Me.btnOk.StartMenuIndex = 0
        Me.btnOk.TabIndex = 36
        Me.btnOk.TextCentered = True
        Me.btnOk.TextDistanceFromBorder = 5
        Me.btnOk.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.AnimationOpacityChange = 0.1
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.ButtonText = "Cancel"
        Me.btnCancel.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancel.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCancel.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnCancel.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnCancel.ControlOpacity = 255
        Me.btnCancel.CornerRadius = 8
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DrawHoverOverIcon = False
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnCancel.Icon = Nothing
        Me.btnCancel.IsAnimated = True
        Me.btnCancel.Location = New System.Drawing.Point(601, 555)
        Me.btnCancel.MaximumGlowOpacity = 0.8
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.NormalColors_1 = System.Drawing.Color.PowderBlue
        Me.btnCancel.NormalColors_2 = System.Drawing.Color.PowderBlue
        Me.btnCancel.NormalColors_3 = System.Drawing.Color.PowderBlue
        Me.btnCancel.NormalColors_4 = System.Drawing.Color.PowderBlue
        Me.btnCancel.Size = New System.Drawing.Size(114, 39)
        Me.btnCancel.StartMenuIndex = 0
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.TextCentered = True
        Me.btnCancel.TextDistanceFromBorder = 5
        Me.btnCancel.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'dgv_NewUsers
        '
        Me.dgv_NewUsers.AllowUserToAddRows = False
        Me.dgv_NewUsers.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dgv_NewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_NewUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.UserName, Me.Phone, Me.FromDB, Me.Address, Me.CNIC, Me.Accountno, Me.Pincode, Me.Balance})
        Me.dgv_NewUsers.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_NewUsers.Location = New System.Drawing.Point(12, 336)
        Me.dgv_NewUsers.Name = "dgv_NewUsers"
        Me.dgv_NewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_NewUsers.Size = New System.Drawing.Size(703, 192)
        Me.dgv_NewUsers.TabIndex = 38
        '
        'UserID
        '
        Me.UserID.HeaderText = "UserID"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        Me.UserID.Visible = False
        '
        'UserName
        '
        Me.UserName.HeaderText = "Name"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'Phone
        '
        Me.Phone.HeaderText = "Phone"
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        '
        'FromDB
        '
        Me.FromDB.HeaderText = "FromDB"
        Me.FromDB.Name = "FromDB"
        Me.FromDB.ReadOnly = True
        Me.FromDB.Visible = False
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'CNIC
        '
        Me.CNIC.HeaderText = "CNIC"
        Me.CNIC.Name = "CNIC"
        Me.CNIC.ReadOnly = True
        '
        'Accountno
        '
        Me.Accountno.HeaderText = "AccountNo"
        Me.Accountno.Name = "Accountno"
        '
        'Pincode
        '
        Me.Pincode.HeaderText = "Pincode"
        Me.Pincode.Name = "Pincode"
        '
        'Balance
        '
        Me.Balance.HeaderText = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        '
        'txt_AccountNo
        '
        Me.txt_AccountNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AccountNo.Location = New System.Drawing.Point(135, 222)
        Me.txt_AccountNo.MaxLength = 10
        Me.txt_AccountNo.Name = "txt_AccountNo"
        Me.txt_AccountNo.Size = New System.Drawing.Size(174, 26)
        Me.txt_AccountNo.TabIndex = 5
        Me.txt_AccountNo.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias
        '
        'CloudLabel8
        '
        Me.CloudLabel8.AutoSize = True
        Me.CloudLabel8.BackColor = System.Drawing.Color.Transparent
        Me.CloudLabel8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudLabel8.ForeColor = System.Drawing.Color.White
        Me.CloudLabel8.Location = New System.Drawing.Point(12, 222)
        Me.CloudLabel8.Name = "CloudLabel8"
        Me.CloudLabel8.Size = New System.Drawing.Size(107, 23)
        Me.CloudLabel8.TabIndex = 40
        Me.CloudLabel8.Text = "Account No."
        '
        'Frm_Add_NewUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATM.My.Resources.Resources.darkaurora
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(733, 614)
        Me.ControlBox = False
        Me.Controls.Add(Me.CloudLabel8)
        Me.Controls.Add(Me.txt_AccountNo)
        Me.Controls.Add(Me.dgv_NewUsers)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txt_CNIC)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.txt_Balance)
        Me.Controls.Add(Me.txt_Phone)
        Me.Controls.Add(Me.txt_Pincode)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.CloudLabel7)
        Me.Controls.Add(Me.CloudLabel6)
        Me.Controls.Add(Me.CloudLabel5)
        Me.Controls.Add(Me.CloudLabel3)
        Me.Controls.Add(Me.CloudLabel2)
        Me.Controls.Add(Me.CloudLabel1)
        Me.Controls.Add(Me.CloudLabel4)
        Me.Name = "Frm_Add_NewUsers"
        Me.Text = "Frm_Add_NewUsers"
        CType(Me.dgv_NewUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloudLabel4 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudLabel1 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudLabel2 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudLabel3 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudLabel5 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudLabel6 As CloudToolkitN6.CloudLabel
    Friend WithEvents CloudLabel7 As CloudToolkitN6.CloudLabel
    Friend WithEvents txt_Name As CloudToolkitN6.CloudTextBox
    Friend WithEvents txt_Pincode As CloudToolkitN6.CloudTextBox
    Friend WithEvents txt_Phone As CloudToolkitN6.CloudTextBox
    Friend WithEvents txt_Balance As CloudToolkitN6.CloudTextBox
    Friend WithEvents txt_Address As CloudToolkitN6.CloudTextBox
    Friend WithEvents txt_CNIC As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnAdd As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents btnEdit As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents btnRemove As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents btnApply As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents btnOk As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents btnCancel As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents dgv_NewUsers As System.Windows.Forms.DataGridView
    Friend WithEvents UserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FromDB As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accountno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pincode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_AccountNo As CloudToolkitN6.CloudTextBox
    Friend WithEvents CloudLabel8 As CloudToolkitN6.CloudLabel
End Class
