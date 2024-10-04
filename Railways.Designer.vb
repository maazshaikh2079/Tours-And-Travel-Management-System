<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Railways
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.ReceiptLabel = New System.Windows.Forms.Label()
        Me.ReceiptRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.TaxLabel = New System.Windows.Forms.Label()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.SeatnoTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.PhonenoTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.FullnameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.AddPlanButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ReceiptButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ExtLuggageCheckBox = New System.Windows.Forms.CheckBox()
        Me.TaxCheckBox = New System.Windows.Forms.CheckBox()
        Me.DestinationComboBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DepartureComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LuggageCoachCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.HandicapCoachCheckBox = New System.Windows.Forms.CheckBox()
        Me.HalfTicketCheckBox = New System.Windows.Forms.CheckBox()
        Me.LadiesCoachCheckBox = New System.Windows.Forms.CheckBox()
        Me.FullTicketCheckBox = New System.Windows.Forms.CheckBox()
        Me.GeneralCoachCheckBox = New System.Windows.Forms.CheckBox()
        Me.SecondClassCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FirstClassCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReturnTicketCheckBox = New System.Windows.Forms.CheckBox()
        Me.SingleTicketCheckBox = New System.Windows.Forms.CheckBox()
        Me.NonACRadioButton = New System.Windows.Forms.RadioButton()
        Me.ACRadioButton = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TotalButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1509, 103)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(3, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1506, 104)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Railways System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.TimeLabel)
        Me.Panel3.Controls.Add(Me.DateLabel)
        Me.Panel3.Controls.Add(Me.ReceiptLabel)
        Me.Panel3.Controls.Add(Me.ReceiptRichTextBox)
        Me.Panel3.Location = New System.Drawing.Point(1033, 121)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(490, 588)
        Me.Panel3.TabIndex = 13
        '
        'TimeLabel
        '
        Me.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TimeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TimeLabel.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(379, 35)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(90, 20)
        Me.TimeLabel.TabIndex = 3
        Me.TimeLabel.Text = "00:00.00"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateLabel
        '
        Me.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DateLabel.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(20, 34)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(104, 20)
        Me.DateLabel.TabIndex = 2
        Me.DateLabel.Text = "00-00-0000"
        Me.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReceiptLabel
        '
        Me.ReceiptLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ReceiptLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ReceiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReceiptLabel.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold)
        Me.ReceiptLabel.Location = New System.Drawing.Point(190, 23)
        Me.ReceiptLabel.Name = "ReceiptLabel"
        Me.ReceiptLabel.Size = New System.Drawing.Size(110, 32)
        Me.ReceiptLabel.TabIndex = 1
        Me.ReceiptLabel.Text = "Receipt"
        Me.ReceiptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReceiptRichTextBox
        '
        Me.ReceiptRichTextBox.BackColor = System.Drawing.Color.White
        Me.ReceiptRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptRichTextBox.Location = New System.Drawing.Point(21, 62)
        Me.ReceiptRichTextBox.Name = "ReceiptRichTextBox"
        Me.ReceiptRichTextBox.ReadOnly = True
        Me.ReceiptRichTextBox.Size = New System.Drawing.Size(449, 499)
        Me.ReceiptRichTextBox.TabIndex = 5
        Me.ReceiptRichTextBox.Text = ""
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.TotalLabel)
        Me.Panel4.Controls.Add(Me.TaxLabel)
        Me.Panel4.Controls.Add(Me.SubTotalLabel)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(532, 509)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(495, 200)
        Me.Panel4.TabIndex = 14
        '
        'TotalLabel
        '
        Me.TotalLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TotalLabel.BackColor = System.Drawing.Color.White
        Me.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(162, 144)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(283, 22)
        Me.TotalLabel.TabIndex = 42
        Me.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaxLabel
        '
        Me.TaxLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TaxLabel.BackColor = System.Drawing.Color.White
        Me.TaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxLabel.Location = New System.Drawing.Point(162, 89)
        Me.TaxLabel.Name = "TaxLabel"
        Me.TaxLabel.Size = New System.Drawing.Size(283, 22)
        Me.TaxLabel.TabIndex = 41
        Me.TaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SubTotalLabel.BackColor = System.Drawing.Color.White
        Me.SubTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SubTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalLabel.Location = New System.Drawing.Point(162, 34)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(283, 22)
        Me.SubTotalLabel.TabIndex = 40
        Me.SubTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(52, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 22)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Total     :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(56, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 22)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Tax       :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(38, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 22)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Sub Total :"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.SeatnoTextBox)
        Me.Panel10.Controls.Add(Me.Label5)
        Me.Panel10.Controls.Add(Me.Label9)
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Controls.Add(Me.Label4)
        Me.Panel10.Controls.Add(Me.EmailIDTextBox)
        Me.Panel10.Controls.Add(Me.PhonenoTextBox)
        Me.Panel10.Controls.Add(Me.AddressTextBox)
        Me.Panel10.Controls.Add(Me.FullnameTextBox)
        Me.Panel10.Location = New System.Drawing.Point(12, 121)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(513, 382)
        Me.Panel10.TabIndex = 18
        '
        'SeatnoTextBox
        '
        Me.SeatnoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatnoTextBox.Location = New System.Drawing.Point(160, 99)
        Me.SeatnoTextBox.Name = "SeatnoTextBox"
        Me.SeatnoTextBox.Size = New System.Drawing.Size(318, 24)
        Me.SeatnoTextBox.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 22)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Seat no.  :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 22)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Email ID  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 22)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Phone no.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 22)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Address   :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = " Full name :"
        '
        'EmailIDTextBox
        '
        Me.EmailIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailIDTextBox.Location = New System.Drawing.Point(159, 295)
        Me.EmailIDTextBox.Name = "EmailIDTextBox"
        Me.EmailIDTextBox.Size = New System.Drawing.Size(318, 24)
        Me.EmailIDTextBox.TabIndex = 5
        '
        'PhonenoTextBox
        '
        Me.PhonenoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhonenoTextBox.Location = New System.Drawing.Point(160, 165)
        Me.PhonenoTextBox.Name = "PhonenoTextBox"
        Me.PhonenoTextBox.Size = New System.Drawing.Size(318, 24)
        Me.PhonenoTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(159, 231)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(318, 24)
        Me.AddressTextBox.TabIndex = 2
        '
        'FullnameTextBox
        '
        Me.FullnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullnameTextBox.Location = New System.Drawing.Point(159, 35)
        Me.FullnameTextBox.Name = "FullnameTextBox"
        Me.FullnameTextBox.Size = New System.Drawing.Size(318, 24)
        Me.FullnameTextBox.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.AddPlanButton)
        Me.Panel5.Controls.Add(Me.ExitButton)
        Me.Panel5.Location = New System.Drawing.Point(1033, 715)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(490, 63)
        Me.Panel5.TabIndex = 15
        '
        'AddPlanButton
        '
        Me.AddPlanButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AddPlanButton.Enabled = False
        Me.AddPlanButton.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPlanButton.Location = New System.Drawing.Point(6, 8)
        Me.AddPlanButton.Name = "AddPlanButton"
        Me.AddPlanButton.Size = New System.Drawing.Size(122, 45)
        Me.AddPlanButton.TabIndex = 8
        Me.AddPlanButton.Text = "Add Plan"
        Me.AddPlanButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Firebrick
        Me.ExitButton.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(424, 10)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(62, 45)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ReceiptButton
        '
        Me.ReceiptButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ReceiptButton.Enabled = False
        Me.ReceiptButton.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptButton.Location = New System.Drawing.Point(364, 8)
        Me.ReceiptButton.Name = "ReceiptButton"
        Me.ReceiptButton.Size = New System.Drawing.Size(122, 45)
        Me.ReceiptButton.TabIndex = 4
        Me.ReceiptButton.Text = "Receipt"
        Me.ReceiptButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(303, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(145, 24)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "  Extra :"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(34, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(145, 24)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "  Applied :"
        '
        'ExtLuggageCheckBox
        '
        Me.ExtLuggageCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.ExtLuggageCheckBox.BackColor = System.Drawing.Color.White
        Me.ExtLuggageCheckBox.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ExtLuggageCheckBox.Location = New System.Drawing.Point(303, 88)
        Me.ExtLuggageCheckBox.Name = "ExtLuggageCheckBox"
        Me.ExtLuggageCheckBox.Size = New System.Drawing.Size(145, 26)
        Me.ExtLuggageCheckBox.TabIndex = 25
        Me.ExtLuggageCheckBox.Text = "Ext Luggage"
        Me.ExtLuggageCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ExtLuggageCheckBox.UseVisualStyleBackColor = False
        '
        'TaxCheckBox
        '
        Me.TaxCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.TaxCheckBox.BackColor = System.Drawing.Color.White
        Me.TaxCheckBox.Checked = True
        Me.TaxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TaxCheckBox.Enabled = False
        Me.TaxCheckBox.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TaxCheckBox.Location = New System.Drawing.Point(33, 89)
        Me.TaxCheckBox.Name = "TaxCheckBox"
        Me.TaxCheckBox.Size = New System.Drawing.Size(145, 28)
        Me.TaxCheckBox.TabIndex = 23
        Me.TaxCheckBox.Text = "Tax (5%)"
        Me.TaxCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TaxCheckBox.UseVisualStyleBackColor = False
        '
        'DestinationComboBox
        '
        Me.DestinationComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinationComboBox.FormattingEnabled = True
        Me.DestinationComboBox.Items.AddRange(New Object() {"Agartala Railway Station [Tripura]", "Amaravati Railway Station [Andhra Pradesh]", "Bairabi Railway Station [Mizoram]", "Bangalore Railway Station [Karnataka]", "Bhopal Railway Station [Madhya Pradesh]", "Bhubaneshwar Railway Station [Odisha]", "Chandighar Railway Station [Chandigarh/Punjab/Haryana]", "Dehradun Railway Station [Uttarakhand]", "Delhi Railway Station [Delhi]", "Dispur Railway Station [Assam]", "Gandhinagar Railway Station [Gujarat]", "Rangpo Railway Station [Sikkim]", "Hyderabad Railway Station [Telangana]", "Imphal Railway Station [Manipur]", "Itanagar Railway Station [Arunachal Pradesh]", "Jaipur Railway Station [Rajashthan]", "Kohima Railway Station [Nagaland]", "Kolkata Railway Station [West Bengal]", "Lucknow Railway Station [Uttar Pradesh]", "Madgaon Railway Station [Goa]", "Mumbai Central Railway Station [Maharashtra]", "Nolbari Railway Station [Meghalaya]", "Patna Railway Station [Bihar]", "Puducherry Railway Station [Puducherry]", "Puratchi Thalaivar Dr. MGR Central Railway Station [Tamil Nadu]", "Raipur Railway Station [Chhattisgarh]", "Ranchi Railway Station [Jharkhand]", "Shimla Railway Station [Himachal Pradesh]", "Srinagar Railway Station [Jammu & Kashhmir]", "Thiruvananthapuram Railway Station [Kerala]"})
        Me.DestinationComboBox.Location = New System.Drawing.Point(191, 96)
        Me.DestinationComboBox.Name = "DestinationComboBox"
        Me.DestinationComboBox.Size = New System.Drawing.Size(283, 26)
        Me.DestinationComboBox.TabIndex = 20
        Me.DestinationComboBox.Text = " none"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 22)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = " Destination   :"
        '
        'DepartureComboBox
        '
        Me.DepartureComboBox.AllowDrop = True
        Me.DepartureComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartureComboBox.FormattingEnabled = True
        Me.DepartureComboBox.Items.AddRange(New Object() {"Agartala Railway Station [Tripura]", "Amaravati Railway Station [Andhra Pradesh]", "Bairabi Railway Station [Mizoram]", "Bangalore Railway Station [Karnataka]", "Bhopal Railway Station [Madhya Pradesh]", "Bhubaneshwar Railway Station [Odisha]", "Chandighar Railway Station [Chandigarh/Punjab/Haryana]", "Dehradun Railway Station [Uttarakhand]", "Delhi Railway Station [Delhi]", "Dispur Railway Station [Assam]", "Gandhinagar Railway Station [Gujarat]", "Rangpo Railway Station [Sikkim]", "Hyderabad Railway Station [Telangana]", "Imphal Railway Station [Manipur]", "Itanagar Railway Station [Arunachal Pradesh]", "Jaipur Railway Station [Rajashthan]", "Kohima Railway Station [Nagaland]", "Kolkata Railway Station [West Bengal]", "Lucknow Railway Station [Uttar Pradesh]", "Madgaon Railway Station [Goa]", "Mumbai Central Railway Station [Maharashtra]", "Nolbari Railway Station [Meghalaya]", "Patna Railway Station [Bihar]", "Puducherry Railway Station [Puducherry]", "Puratchi Thalaivar Dr. MGR Central Railway Station [Tamil Nadu]", "Raipur Railway Station [Chhattisgarh]", "Ranchi Railway Station [Jharkhand]", "Shimla Railway Station [Himachal Pradesh]", "Srinagar Railway Station [Jammu & Kashhmir]", "Thiruvananthapuram Railway Station [Kerala]"})
        Me.DepartureComboBox.Location = New System.Drawing.Point(191, 37)
        Me.DepartureComboBox.Name = "DepartureComboBox"
        Me.DepartureComboBox.Size = New System.Drawing.Size(283, 26)
        Me.DepartureComboBox.TabIndex = 14
        Me.DepartureComboBox.Text = " none"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.LuggageCoachCheckBox)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.TaxCheckBox)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.ExtLuggageCheckBox)
        Me.Panel6.Location = New System.Drawing.Point(12, 509)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(513, 200)
        Me.Panel6.TabIndex = 16
        '
        'LuggageCoachCheckBox
        '
        Me.LuggageCoachCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LuggageCoachCheckBox.Enabled = False
        Me.LuggageCoachCheckBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LuggageCoachCheckBox.Location = New System.Drawing.Point(303, 144)
        Me.LuggageCoachCheckBox.Name = "LuggageCoachCheckBox"
        Me.LuggageCoachCheckBox.Size = New System.Drawing.Size(145, 22)
        Me.LuggageCoachCheckBox.TabIndex = 49
        Me.LuggageCoachCheckBox.Text = " Luggage coach"
        Me.LuggageCoachCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LuggageCoachCheckBox.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 22)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = " Departure     :"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.HandicapCoachCheckBox)
        Me.Panel9.Controls.Add(Me.HalfTicketCheckBox)
        Me.Panel9.Controls.Add(Me.LadiesCoachCheckBox)
        Me.Panel9.Controls.Add(Me.FullTicketCheckBox)
        Me.Panel9.Controls.Add(Me.GeneralCoachCheckBox)
        Me.Panel9.Controls.Add(Me.SecondClassCheckBox)
        Me.Panel9.Controls.Add(Me.Label12)
        Me.Panel9.Controls.Add(Me.FirstClassCheckBox)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.ReturnTicketCheckBox)
        Me.Panel9.Controls.Add(Me.SingleTicketCheckBox)
        Me.Panel9.Controls.Add(Me.NonACRadioButton)
        Me.Panel9.Controls.Add(Me.ACRadioButton)
        Me.Panel9.Controls.Add(Me.DestinationComboBox)
        Me.Panel9.Controls.Add(Me.DepartureComboBox)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Location = New System.Drawing.Point(532, 121)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(495, 382)
        Me.Panel9.TabIndex = 17
        '
        'HandicapCoachCheckBox
        '
        Me.HandicapCoachCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.HandicapCoachCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.HandicapCoachCheckBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HandicapCoachCheckBox.Location = New System.Drawing.Point(116, 298)
        Me.HandicapCoachCheckBox.Name = "HandicapCoachCheckBox"
        Me.HandicapCoachCheckBox.Size = New System.Drawing.Size(84, 22)
        Me.HandicapCoachCheckBox.TabIndex = 56
        Me.HandicapCoachCheckBox.Text = "Handicap"
        Me.HandicapCoachCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HandicapCoachCheckBox.UseVisualStyleBackColor = False
        '
        'HalfTicketCheckBox
        '
        Me.HalfTicketCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.HalfTicketCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.HalfTicketCheckBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HalfTicketCheckBox.Location = New System.Drawing.Point(412, 255)
        Me.HalfTicketCheckBox.Name = "HalfTicketCheckBox"
        Me.HalfTicketCheckBox.Size = New System.Drawing.Size(56, 22)
        Me.HalfTicketCheckBox.TabIndex = 44
        Me.HalfTicketCheckBox.Text = "Half "
        Me.HalfTicketCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HalfTicketCheckBox.UseVisualStyleBackColor = False
        '
        'LadiesCoachCheckBox
        '
        Me.LadiesCoachCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.LadiesCoachCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LadiesCoachCheckBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LadiesCoachCheckBox.Location = New System.Drawing.Point(122, 254)
        Me.LadiesCoachCheckBox.Name = "LadiesCoachCheckBox"
        Me.LadiesCoachCheckBox.Size = New System.Drawing.Size(78, 22)
        Me.LadiesCoachCheckBox.TabIndex = 55
        Me.LadiesCoachCheckBox.Text = "Ladies "
        Me.LadiesCoachCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LadiesCoachCheckBox.UseVisualStyleBackColor = False
        '
        'FullTicketCheckBox
        '
        Me.FullTicketCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.FullTicketCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FullTicketCheckBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullTicketCheckBox.Location = New System.Drawing.Point(412, 211)
        Me.FullTicketCheckBox.Name = "FullTicketCheckBox"
        Me.FullTicketCheckBox.Size = New System.Drawing.Size(56, 22)
        Me.FullTicketCheckBox.TabIndex = 43
        Me.FullTicketCheckBox.Text = "Full "
        Me.FullTicketCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FullTicketCheckBox.UseVisualStyleBackColor = False
        '
        'GeneralCoachCheckBox
        '
        Me.GeneralCoachCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GeneralCoachCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GeneralCoachCheckBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralCoachCheckBox.Location = New System.Drawing.Point(122, 212)
        Me.GeneralCoachCheckBox.Name = "GeneralCoachCheckBox"
        Me.GeneralCoachCheckBox.Size = New System.Drawing.Size(78, 22)
        Me.GeneralCoachCheckBox.TabIndex = 54
        Me.GeneralCoachCheckBox.Text = "General "
        Me.GeneralCoachCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GeneralCoachCheckBox.UseVisualStyleBackColor = False
        '
        'SecondClassCheckBox
        '
        Me.SecondClassCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SecondClassCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SecondClassCheckBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondClassCheckBox.Location = New System.Drawing.Point(216, 255)
        Me.SecondClassCheckBox.Name = "SecondClassCheckBox"
        Me.SecondClassCheckBox.Size = New System.Drawing.Size(88, 22)
        Me.SecondClassCheckBox.TabIndex = 42
        Me.SecondClassCheckBox.Text = "Second "
        Me.SecondClassCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SecondClassCheckBox.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(122, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 24)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "  Coach :"
        '
        'FirstClassCheckBox
        '
        Me.FirstClassCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.FirstClassCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FirstClassCheckBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstClassCheckBox.Location = New System.Drawing.Point(216, 211)
        Me.FirstClassCheckBox.Name = "FirstClassCheckBox"
        Me.FirstClassCheckBox.Size = New System.Drawing.Size(88, 22)
        Me.FirstClassCheckBox.TabIndex = 41
        Me.FirstClassCheckBox.Text = "First "
        Me.FirstClassCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FirstClassCheckBox.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(216, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 24)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "  Class :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(318, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 24)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "  Ticket :"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(22, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 24)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "  Train :"
        '
        'ReturnTicketCheckBox
        '
        Me.ReturnTicketCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReturnTicketCheckBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnTicketCheckBox.Location = New System.Drawing.Point(318, 255)
        Me.ReturnTicketCheckBox.Name = "ReturnTicketCheckBox"
        Me.ReturnTicketCheckBox.Size = New System.Drawing.Size(81, 22)
        Me.ReturnTicketCheckBox.TabIndex = 37
        Me.ReturnTicketCheckBox.Text = "Return"
        Me.ReturnTicketCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ReturnTicketCheckBox.UseVisualStyleBackColor = False
        '
        'SingleTicketCheckBox
        '
        Me.SingleTicketCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SingleTicketCheckBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SingleTicketCheckBox.Location = New System.Drawing.Point(318, 212)
        Me.SingleTicketCheckBox.Name = "SingleTicketCheckBox"
        Me.SingleTicketCheckBox.Size = New System.Drawing.Size(81, 22)
        Me.SingleTicketCheckBox.TabIndex = 36
        Me.SingleTicketCheckBox.Text = "Single "
        Me.SingleTicketCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SingleTicketCheckBox.UseVisualStyleBackColor = False
        '
        'NonACRadioButton
        '
        Me.NonACRadioButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.NonACRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NonACRadioButton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NonACRadioButton.Location = New System.Drawing.Point(23, 211)
        Me.NonACRadioButton.Name = "NonACRadioButton"
        Me.NonACRadioButton.Size = New System.Drawing.Size(82, 22)
        Me.NonACRadioButton.TabIndex = 35
        Me.NonACRadioButton.TabStop = True
        Me.NonACRadioButton.Text = "Non AC"
        Me.NonACRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NonACRadioButton.UseVisualStyleBackColor = False
        '
        'ACRadioButton
        '
        Me.ACRadioButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ACRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ACRadioButton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACRadioButton.Location = New System.Drawing.Point(25, 254)
        Me.ACRadioButton.Name = "ACRadioButton"
        Me.ACRadioButton.Size = New System.Drawing.Size(80, 22)
        Me.ACRadioButton.TabIndex = 34
        Me.ACRadioButton.TabStop = True
        Me.ACRadioButton.Text = "AC"
        Me.ACRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ACRadioButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.BackButton)
        Me.Panel2.Controls.Add(Me.ResetButton)
        Me.Panel2.Location = New System.Drawing.Point(12, 715)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(513, 63)
        Me.Panel2.TabIndex = 19
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BackButton.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.Black
        Me.BackButton.Location = New System.Drawing.Point(2, 10)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(62, 45)
        Me.BackButton.TabIndex = 7
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ResetButton.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(380, 8)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(124, 45)
        Me.ResetButton.TabIndex = 5
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.TotalButton)
        Me.Panel7.Controls.Add(Me.ReceiptButton)
        Me.Panel7.Location = New System.Drawing.Point(532, 715)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(495, 63)
        Me.Panel7.TabIndex = 43
        '
        'TotalButton
        '
        Me.TotalButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TotalButton.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalButton.Location = New System.Drawing.Point(6, 8)
        Me.TotalButton.Name = "TotalButton"
        Me.TotalButton.Size = New System.Drawing.Size(124, 45)
        Me.TotalButton.TabIndex = 5
        Me.TotalButton.Text = "Total"
        Me.TotalButton.UseVisualStyleBackColor = False
        '
        'Railways
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1536, 821)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Railways"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Railways System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TimeLabel As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents ReceiptLabel As Label
    Friend WithEvents ReceiptRichTextBox As RichTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EmailIDTextBox As TextBox
    Friend WithEvents PhonenoTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents FullnameTextBox As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ExitButton As Button
    Friend WithEvents ReceiptButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ExtLuggageCheckBox As CheckBox
    Friend WithEvents TaxCheckBox As CheckBox
    Friend WithEvents DestinationComboBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DepartureComboBox As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents SeatnoTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents TaxLabel As Label
    Friend WithEvents SubTotalLabel As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents SecondClassCheckBox As CheckBox
    Friend WithEvents FirstClassCheckBox As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ReturnTicketCheckBox As CheckBox
    Friend WithEvents SingleTicketCheckBox As CheckBox
    Friend WithEvents NonACRadioButton As RadioButton
    Friend WithEvents ACRadioButton As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents HalfTicketCheckBox As CheckBox
    Friend WithEvents FullTicketCheckBox As CheckBox
    Friend WithEvents LuggageCoachCheckBox As CheckBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents TotalButton As Button
    Friend WithEvents HandicapCoachCheckBox As CheckBox
    Friend WithEvents LadiesCoachCheckBox As CheckBox
    Friend WithEvents GeneralCoachCheckBox As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents AddPlanButton As Button
End Class
