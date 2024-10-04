Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Railways
    Dim Ticket As String
    Dim Train_Type As String
    Dim _Class As String
    Dim Coach As String
    Dim Size As String
    Dim EmailID As Regex
    Dim isvalid As Boolean

    Private Sub FirstClassCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FirstClassCheckBox.CheckedChanged
        If FirstClassCheckBox.Checked = True Then
            SecondClassCheckBox.Checked = False
            HandicapCoachCheckBox.Checked = False
            ExtLuggageCheckBox.Checked = False
            LuggageCoachCheckBox.Checked = False
            _Class = "First"
        End If
    End Sub

    Private Sub SecondClassCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SecondClassCheckBox.CheckedChanged
        If SecondClassCheckBox.Checked = True Then
            FirstClassCheckBox.Checked = False
            HandicapCoachCheckBox.Checked = False
            ExtLuggageCheckBox.Checked = False
            LuggageCoachCheckBox.Checked = False
            _Class = "Second"
        End If
    End Sub

    Private Sub HandicapCoachCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HandicapCoachCheckBox.CheckedChanged ', ExtLuggageCheckBox.CheckedChanged
        If HandicapCoachCheckBox.Checked = True And ExtLuggageCheckBox.Checked = False And LuggageCoachCheckBox.Checked = False Then
            FirstClassCheckBox.Checked = False
            SecondClassCheckBox.Checked = False
            GeneralCoachCheckBox.Checked = False
            LadiesCoachCheckBox.Checked = False
            ExtLuggageCheckBox.Checked = False
            LuggageCoachCheckBox.Checked = False
            _Class = "------"
            Coach = "Handicap"
        ElseIf HandicapCoachCheckBox.Checked = True And ExtLuggageCheckBox.Checked = True And LuggageCoachCheckBox.Checked = False Then
            FirstClassCheckBox.Checked = False
            SecondClassCheckBox.Checked = False
            GeneralCoachCheckBox.Checked = False
            LadiesCoachCheckBox.Checked = False
            LuggageCoachCheckBox.Checked = False
            _Class = "------"
            Coach = "Handicap"
        Else HandicapCoachCheckBox.Checked = False
            ExtLuggageCheckBox.Checked = False
            LuggageCoachCheckBox.Checked = False
            _Class = ""
            Coach = ""
        End If
    End Sub

    Private Sub ExtLuggageCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ExtLuggageCheckBox.CheckedChanged', HandicapCoachCheckBox.CheckedChanged
        If ExtLuggageCheckBox.Checked = True And HandicapCoachCheckBox.Checked = False Then
            FirstClassCheckBox.Checked = False
            SecondClassCheckBox.Checked = False
            GeneralCoachCheckBox.Checked = False
            LadiesCoachCheckBox.Checked = False
            HandicapCoachCheckBox.Checked = False
            LuggageCoachCheckBox.Checked = True
            _Class = "------"
            Coach = "Luggage"
        ElseIf ExtLuggageCheckBox.Checked = True And HandicapCoachCheckBox.Checked = True Then
            FirstClassCheckBox.Checked = False
            SecondClassCheckBox.Checked = False
            GeneralCoachCheckBox.Checked = False
            LadiesCoachCheckBox.Checked = False
            LuggageCoachCheckBox.Checked = False
            _Class = "------"
            Coach = "Handicap"
        ElseIf ExtLuggageCheckBox.Checked = False Then
            LuggageCoachCheckBox.Checked = False
            _Class = ""
            Coach = ""
        End If
    End Sub

    Private Sub GeneralCoachCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles GeneralCoachCheckBox.CheckedChanged
        If GeneralCoachCheckBox.Checked = True Then
            LadiesCoachCheckBox.Checked = False
            HandicapCoachCheckBox.Checked = False
            ExtLuggageCheckBox.Checked = False
            LuggageCoachCheckBox.Checked = False
            Coach = "General"
        End If
    End Sub

    Private Sub LadiesCoachCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LadiesCoachCheckBox.CheckedChanged
        If LadiesCoachCheckBox.Checked = True Then
            GeneralCoachCheckBox.Checked = False
            HandicapCoachCheckBox.Checked = False
            ExtLuggageCheckBox.Checked = False
            LuggageCoachCheckBox.Checked = False
            Coach = "Ladies"
        End If
    End Sub

    Private Sub SingleTicketCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SingleTicketCheckBox.CheckedChanged
        If SingleTicketCheckBox.Checked = True Then
            ReturnTicketCheckBox.Checked = False
            Ticket = "Single"
        End If
    End Sub

    Private Sub ReturnTicketCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ReturnTicketCheckBox.CheckedChanged
        If ReturnTicketCheckBox.Checked = True Then
            SingleTicketCheckBox.Checked = False
            Ticket = "Return"
        End If
    End Sub

    Private Sub FullTicketCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FullTicketCheckBox.CheckedChanged
        If FullTicketCheckBox.Checked = True Then
            HalfTicketCheckBox.Checked = False
            Size = "Full"
        End If
    End Sub

    Private Sub HalfTicketCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HalfTicketCheckBox.CheckedChanged
        If HalfTicketCheckBox.Checked = True Then
            FullTicketCheckBox.Checked = False
            Size = "Half"
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        AddPlanButton.Enabled = False
        ReceiptButton.Enabled = False

        ReceiptRichTextBox.Clear()
        FullnameTextBox.Clear()
        SeatnoTextBox.Clear()
        PhonenoTextBox.Clear()
        AddressTextBox.Clear()
        EmailIDTextBox.Clear()

        SubTotalLabel.Text = ""
        TaxLabel.Text = ""
        TotalLabel.Text = ""

        DepartureComboBox.Text = " none"
        DestinationComboBox.Text = " none"

        NonACRadioButton.Checked = False
        ACRadioButton.Checked = False

        FirstClassCheckBox.Checked = False
        SecondClassCheckBox.Checked = False

        GeneralCoachCheckBox.Checked = False
        LadiesCoachCheckBox.Checked = False
        HandicapCoachCheckBox.Checked = False

        SingleTicketCheckBox.Checked = False
        ReturnTicketCheckBox.Checked = False

        FullTicketCheckBox.Checked = False
        HalfTicketCheckBox.Checked = False

        TaxCheckBox.Checked = True

        ExtLuggageCheckBox.Checked = False
        LuggageCoachCheckBox.Checked = False

    End Sub

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles TotalButton.Click

        SeatnoTextBox.Text = SeatnoTextBox.Text.Replace(" ", "")
        PhonenoTextBox.Text = PhonenoTextBox.Text.Replace(" ", "")
        EmailID = New Regex("^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
        isvalid = EmailID.IsMatch(EmailIDTextBox.Text.Replace(" ", ""))

        If ((FullnameTextBox.Text = "" Or SeatnoTextBox.Text = "" Or PhonenoTextBox.Text = "" Or AddressTextBox.Text = "" Or EmailIDTextBox.Text = "") Or
           (DepartureComboBox.Text = " none" Or DepartureComboBox.Text = "" Or DestinationComboBox.Text = " none" Or DestinationComboBox.Text = "") Or
           (NonACRadioButton.Checked = False And ACRadioButton.Checked = False) Or ((GeneralCoachCheckBox.Checked = False And LadiesCoachCheckBox.Checked = False And HandicapCoachCheckBox.Checked = False And FirstClassCheckBox.Checked = False And SecondClassCheckBox.Checked = False) And ExtLuggageCheckBox.Checked = False) Or
           ((GeneralCoachCheckBox.Checked = False And LadiesCoachCheckBox.Checked = False And HandicapCoachCheckBox.Checked = False) And (FirstClassCheckBox.Checked = True Or SecondClassCheckBox.Checked = True) And ExtLuggageCheckBox.Checked = False) Or
           ((FirstClassCheckBox.Checked = False And SecondClassCheckBox.Checked = False) And (GeneralCoachCheckBox.Checked = True Or LadiesCoachCheckBox.Checked = True Or HandicapCoachCheckBox.Checked = False) And ExtLuggageCheckBox.Checked = False) Or
           (SingleTicketCheckBox.Checked = False And ReturnTicketCheckBox.Checked = False) Or (FullTicketCheckBox.Checked = False And HalfTicketCheckBox.Checked = False)) Then
            MsgBox("Enter all required details and click Total button before generating Receipt.")

        ElseIf SeatnoTextBox.Text = "" Then
            MsgBox("Invalid seat no.: Number not entered.")
        ElseIf IsNumeric(SeatnoTextBox.Text) = False Or SeatnoTextBox.Text < 0 Then
            MsgBox("Invalid seat no.: Only whole numbers accepted.")
        ElseIf Len(SeatnoTextBox.Text) <> 3 Then
            MsgBox("Invalid seat no.: Only three numbers are allowed.")
        ElseIf PhonenoTextBox.Text = "" Then
            MsgBox("Invalid phone no.: Number not entered.")
        ElseIf IsNumeric(PhonenoTextBox.Text) = False Or PhonenoTextBox.Text < 0 Then
            MsgBox("Invalid phone no.: Only whole numbers accepted.")
        ElseIf Len(PhonenoTextBox.Text) <> 10 Then
            MsgBox("Invalid phone no.: Only ten numbers are allowed.")
        ElseIf Not isvalid Then
            MessageBox.Show("Invalid email ID: Write propper email ID.")
        Else

            If DepartureComboBox.Text = DestinationComboBox.Text Then
                MsgBox("Departure and destination are same. Please change location.")
            Else

                If NonACRadioButton.Checked = True Then
                    Train_Type = "Non AC"
                ElseIf ACRadioButton.Checked = True Then
                    Train_Type = "AC"
                End If

                Dim TravelPrice As New PriceClass
                Dim SubTotal As Double
                Dim Total As Double
                Dim Tax As Double

                If DestinationComboBox.Text = "Agartala Railway Station [Tripura]" Then                        '[Tripura]
                    SubTotal = TravelPrice.Agartala_RS
                ElseIf DestinationComboBox.Text = "Amaravati Railway Station [Andhra Pradesh]" Then            '[Andhra Pradesh]
                    SubTotal = TravelPrice.Amaravati_RS
                ElseIf DestinationComboBox.Text = "Bairabi Railway Station [Mizoram]" Then                     '[Mizoram]
                    SubTotal = TravelPrice.Bairabi_RS
                ElseIf DestinationComboBox.Text = "Bangalore Railway Station [Karnataka]" Then                 '[Karnataka]
                    SubTotal = TravelPrice.Bangalore_RS
                ElseIf DestinationComboBox.Text = "Bhopal Railway Station [Madhya Pradesh]" Then               '[Madhya Pradesh] 
                    SubTotal = TravelPrice.Bhopal_RS
                ElseIf DestinationComboBox.Text = "Bhubaneshwar Railway Station [Odisha]" Then                 '[Odisha] 
                    SubTotal = TravelPrice.Bhubaneshwar_RS
                ElseIf DestinationComboBox.Text = "Chandighar Railway Station [Chandigarh/Punjab/Haryana]" Then '[Chandigarh/Punjab/Haryana] 
                    SubTotal = TravelPrice.Chandighar_RS
                ElseIf DestinationComboBox.Text = "Dehradun Railway Station [Uttarakhand]" Then                '[Uttarakhand]
                    SubTotal = TravelPrice.Dehradun_RS
                ElseIf DestinationComboBox.Text = "Delhi Railway Station [Delhi]" Then                         '[Delhi]
                    SubTotal = TravelPrice.Delhi_RS
                ElseIf DestinationComboBox.Text = "Dispur Railway Station [Assam]" Then                        '[Assam]
                    SubTotal = TravelPrice.Dispur_RS
                ElseIf DestinationComboBox.Text = "Gandhinagar Railway Station [Gujarat]" Then                 '[Gujarat]
                    SubTotal = TravelPrice.Gandhinagar_RS
                ElseIf DestinationComboBox.Text = "Rangpo Railway Station [Sikkim]" Then                       '[Sikkim]
                    SubTotal = TravelPrice.Rangpo_RS
                ElseIf DestinationComboBox.Text = "Hyderabad Railway Station [Telangana]" Then                 '[Telangana]
                    SubTotal = TravelPrice.Hyderabad_RS
                ElseIf DestinationComboBox.Text = "Imphal Railway Station [Manipur]" Then                      '[Manipur]
                    SubTotal = TravelPrice.Imphal_RS
                ElseIf DestinationComboBox.Text = "Itanagar Railway Station [Arunachal Pradesh]" Then          '[Arunachal Pradesh]
                    SubTotal = TravelPrice.Itanagar_RS
                ElseIf DestinationComboBox.Text = "Jaipur Railway Station [Rajashthan]" Then                   '[Rajashthan]
                    SubTotal = TravelPrice.Jaipur_RS
                ElseIf DestinationComboBox.Text = "Kohima Railway Station [Nagaland]" Then                     '[Nagaland]
                    SubTotal = TravelPrice.Kohima_RS
                ElseIf DestinationComboBox.Text = "Kolkata Railway Station [West Bengal]" Then                 '[West Bengal]
                    SubTotal = TravelPrice.Kolkata_RS
                ElseIf DestinationComboBox.Text = "Lucknow Railway Station [Uttar Pradesh]" Then               '[Uttar Pradesh]
                    SubTotal = TravelPrice.Lucknow_RS
                ElseIf DestinationComboBox.Text = "Madgaon Railway Station [Goa]" Then                         '[Goa]
                    SubTotal = TravelPrice.Madgaon_RS
                ElseIf DestinationComboBox.Text = "Mumbai Central Railway Station [Maharashtra]" Then          '[Maharashtra]
                    SubTotal = TravelPrice.Mumbai_Central_RS
                ElseIf DestinationComboBox.Text = "Nolbari Railway Station [Meghalaya]" Then                   '[Meghalaya]
                    SubTotal = TravelPrice.Nolbari_RS
                ElseIf DestinationComboBox.Text = "Patna Railway Station [Bihar]" Then                         '[Bihar]
                    SubTotal = TravelPrice.Patna_RS
                ElseIf DestinationComboBox.Text = "Puducherry Railway Station [Puducherry]" Then               '[Bihar]
                    SubTotal = TravelPrice.Puducherry_RS
                ElseIf DestinationComboBox.Text = "Puratchi Thalaivar Dr. MGR Central Railway Station [Tamil Nadu]" Then '[Tamil Nadu]
                    SubTotal = TravelPrice.Puratchi_Thalaivar_Dr_MGR_Central_RS
                ElseIf DestinationComboBox.Text = "Raipur Railway Station [Chhattisgarh]" Then                 '[Chhattisgarh]
                    SubTotal = TravelPrice.Raipur_RS
                ElseIf DestinationComboBox.Text = "Ranchi Railway Station [Jharkhand]" Then                    '[Jharkhand]
                    SubTotal = TravelPrice.Ranchi_RS
                ElseIf DestinationComboBox.Text = "Shimla Railway Station [Himachal Pradesh]" Then             '[Himachal Pradesh]
                    SubTotal = TravelPrice.Shimla_RS
                ElseIf DestinationComboBox.Text = "Srinagar Railway Station [Jammu & Kashmir]" Then            '[Jammu & Kashhmir]
                    SubTotal = TravelPrice.Srinagar_RS
                ElseIf DestinationComboBox.Text = "Thiruvananthapuram Railway Station [Kerala]" Then           '[Kerala]
                    SubTotal = TravelPrice.Thiruvananthapuram_Central_RS
                End If

                If ExtLuggageCheckBox.Checked = True Then
                    TravelPrice.Ext_Luggage = 70
                    SubTotal = SubTotal + TravelPrice.Ext_Luggage
                End If

                If ACRadioButton.Checked = True Then
                    SubTotal = SubTotal * 2
                End If

                If FirstClassCheckBox.Checked = True Then
                    SubTotal = SubTotal * 2
                End If

                If ReturnTicketCheckBox.Checked = True Then
                    SubTotal = SubTotal * 2
                End If

                If HalfTicketCheckBox.Checked = True Then
                    SubTotal = SubTotal - (SubTotal * 0.5)
                End If

                If HandicapCoachCheckBox.Checked = True Then
                    SubTotal = SubTotal - (SubTotal * 0.5)
                End If
                Tax = SubTotal - (SubTotal * 0.95)
                SubTotal = SubTotal - Tax
                SubTotalLabel.Text = FormatCurrency(SubTotal)
                TaxLabel.Text = FormatCurrency(Tax)
                Total = SubTotal + Tax
                TotalLabel.Text = FormatCurrency(Total)
                ReceiptButton.Enabled = True
                ReceiptRichTextBox.Clear()
            End If
        End If
    End Sub

    Private Sub ReceiptButton_Click(sender As Object, e As EventArgs) Handles ReceiptButton.Click

        ReceiptRichTextBox.Clear()
            ReceiptRichTextBox.AppendText(vbTab + vbTab + vbTab + " Railways System" + vbNewLine + vbNewLine)
            ReceiptRichTextBox.AppendText("_______________________________________________________" + vbNewLine)
            ReceiptRichTextBox.AppendText("  Full name   :  " + FullnameTextBox.Text.TrimStart.TrimEnd + vbNewLine)
            ReceiptRichTextBox.AppendText("  Seat no.      :  " + SeatnoTextBox.Text.Replace(" ", "") + vbNewLine)
            ReceiptRichTextBox.AppendText("  Phone no.   :  " + PhonenoTextBox.Text.Replace(" ", "") + vbNewLine)
            ReceiptRichTextBox.AppendText("  Address      :  " + AddressTextBox.Text.TrimStart.TrimEnd + vbNewLine)
            ReceiptRichTextBox.AppendText("  Email ID     :  " + EmailIDTextBox.Text.Replace(" ", "") + vbNewLine)
            ReceiptRichTextBox.AppendText("  Departure   :  " + DepartureComboBox.Text + vbNewLine)
            ReceiptRichTextBox.AppendText("  Destination :  " + DestinationComboBox.Text + vbNewLine)
            ReceiptRichTextBox.AppendText("  Train type   :  " + Train_Type + vbNewLine)
            ReceiptRichTextBox.AppendText("  Coach         :  " + Coach + vbNewLine)
            ReceiptRichTextBox.AppendText("  Class          :  " + _Class + vbNewLine)
            ReceiptRichTextBox.AppendText("  Ticket         :  " + Ticket + vbTab + Size + vbNewLine)
            ReceiptRichTextBox.AppendText("_______________________________________________________" + vbNewLine)
            ReceiptRichTextBox.AppendText("  Sub Total   :  " + SubTotalLabel.Text + vbNewLine)
            ReceiptRichTextBox.AppendText("  Tax            :  " + TaxLabel.Text + vbNewLine)
            ReceiptRichTextBox.AppendText("  Total          :  " + TotalLabel.Text + vbNewLine)
            ReceiptRichTextBox.AppendText("_______________________________________________________" + vbNewLine)
            ReceiptRichTextBox.AppendText(Today + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TimeOfDay + vbNewLine)
            ReceiptRichTextBox.AppendText("_______________________________________________________" + vbNewLine + vbNewLine)
        ReceiptRichTextBox.AppendText(vbTab + "                  Thanks for using Railways System" + vbNewLine)

        ReceiptButton.Enabled = False

        Dim AddPlan As DialogResult
        AddPlan = MessageBox.Show("Do you want to add the plan", "Railways System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If AddPlan = DialogResult.Yes Then
            MessageBox.Show("Click Add Plan button below reciept.", "Railways System")
            AddPlanButton.Enabled = True
        Else
            AddPlanButton.Enabled = False
        End If

    End Sub

    Private Sub AddPlanButton_Click(sender As Object, e As EventArgs) Handles AddPlanButton.Click

        Dim constr As String = "server=localhost;user=root;database=tntmsdb;port=3306;password=Shaikh@2079;"
        Using con As MySqlConnection = New MySqlConnection(constr)

            Using cmd As MySqlCommand = New MySqlCommand("insert into Railways (Full_name,seat_no,Phone_no,Address,Email_ID,Departure,Destination,Train_type,Coach,Class,Ticket,Size,Sub_Total,Tax,Total)
                                                         values (""" & FullnameTextBox.Text & """," & SeatnoTextBox.Text & "," & PhonenoTextBox.Text & ",""" & AddressTextBox.Text & """,""" & EmailIDTextBox.Text & """,""" & DepartureComboBox.Text & """,""" & DestinationComboBox.Text & """,""" & Train_Type & """,""" & Coach & """,""" & _Class & """,""" & Ticket & """,""" & Size & """,""" & SubTotalLabel.Text & """,""" & TaxLabel.Text & """,""" & TotalLabel.Text & """" & ");")

                cmd.CommandType = CommandType.Text
                cmd.Connection = con
                con.Open()

                Using sdr As MySqlDataReader = cmd.ExecuteReader()

                    sdr.Read()

                    con.Close()

                End Using
            End Using
        End Using
        ReceiptRichTextBox.Clear()
        AddPlanButton.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = TimeOfDay
        DateLabel.Text = Today

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Tours_And_Travel_Management_System.Show()
        Me.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ExitClass.ExitSystem()
    End Sub

End Class