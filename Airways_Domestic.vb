Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Airways_Domestic
    Dim Ticket As String
    Dim Flight_Class As String
    Dim Age As String
    Dim EmailID As Regex
    Dim isvalid As Boolean
    Dim Name As String

    Private Sub EconomyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles EconomyRadioButton.CheckedChanged
        If EconomyRadioButton.Checked = True Then
            Flight_Class = "Economy"
            AccomodationComboBox.Text = " none "
            AccomodationComboBox.Enabled = False
        Else
            AccomodationComboBox.Text = " none"
            AccomodationComboBox.Enabled = True
        End If

    End Sub

    Private Sub BusinessClassRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BusinessClassRadioButton.CheckedChanged
        If BusinessClassRadioButton.Checked = True Then
            Flight_Class = "Business Class"
            AccomodationComboBox.Text = " none"
            AccomodationComboBox.Enabled = True
        End If
    End Sub

    Private Sub FirstClassRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FirstClassRadioButton.CheckedChanged
        If FirstClassRadioButton.Checked = True Then
            Flight_Class = "First Class"
            AccomodationComboBox.Text = " none"
            AccomodationComboBox.Enabled = True
        End If
    End Sub

    Private Sub SingleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SingleCheckBox.CheckedChanged
        If SingleCheckBox.Checked = True Then
            ReturnCheckBox.Checked = False
            Ticket = "Single"
        End If
    End Sub

    Private Sub ReturnCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ReturnCheckBox.CheckedChanged
        If ReturnCheckBox.Checked = True Then
            SingleCheckBox.Checked = False
            Ticket = "Return"
        End If
    End Sub

    Private Sub AdultCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AdultCheckBox.CheckedChanged
        If AdultCheckBox.Checked = True Then
            NonAdultCheckBox.Checked = False
            Age = "Adult"
        End If
    End Sub

    Private Sub NonAdultCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles NonAdultCheckBox.CheckedChanged
        If NonAdultCheckBox.Checked = True Then
            AdultCheckBox.Checked = False
            Age = "Non Adult"
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        AddPlanButton.Enabled = False
        ReceiptButton.Enabled = False

        ReceiptRichTextBox.Clear()
        FirstnameTextBox.Clear()
        MidnameTextBox.Clear()
        SurnameTextBox.Clear()
        AddressTextBox.Clear()
        PINCodeTextBox.Clear()
        PhonenoTextBox.Clear()
        EmailIDTextBox.Clear()

        SubTotalLabel.Text = ""
        TaxLabel.Text = ""
        TotalLabel.Text = ""

        AccomodationComboBox.Enabled = True
        AccomodationComboBox.Text = " none"
        DepartureComboBox.Text = " none"
        DestinationComboBox.Text = " none"

        AirportTaxCheckBox.Checked = True
        ExtLuggageCheckBox.Checked = True
        TravelInsuranceCheckBox.Checked = True

        BusinessClassRadioButton.Checked = False
        EconomyRadioButton.Checked = False
        FirstClassRadioButton.Checked = False

        SingleCheckBox.Checked = False
        ReturnCheckBox.Checked = False
        AdultCheckBox.Checked = False
        NonAdultCheckBox.Checked = False

    End Sub


    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click

        PINCodeTextBox.Text = PINCodeTextBox.Text.Replace(" ", "")
        PhonenoTextBox.Text = PhonenoTextBox.Text.Replace(" ", "")
        EmailID = New Regex("^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
        isvalid = EmailID.IsMatch(EmailIDTextBox.Text.Replace(" ", ""))


        If ((FirstnameTextBox.Text = "" Or MidnameTextBox.Text = "" Or SurnameTextBox.Text = "" Or AddressTextBox.Text = "" Or PINCodeTextBox.Text = "" Or
            PhonenoTextBox.Text = "" Or EmailIDTextBox.Text = "" Or DepartureComboBox.Text = " none" Or DepartureComboBox.Text = "" Or DestinationComboBox.Text = " none" Or
            DestinationComboBox.Text = "" Or AccomodationComboBox.Text = " none") Or (EconomyRadioButton.Checked = False And BusinessClassRadioButton.Checked = False And
            FirstClassRadioButton.Checked = False) Or (SingleCheckBox.Checked = False And ReturnCheckBox.Checked = False) Or (AdultCheckBox.Checked = False And
            NonAdultCheckBox.Checked = False)) Then
            MsgBox("Enter all required details and click Total button before generating Receipt.")

        ElseIf PINcodeTextBox.Text = "" Then
            MsgBox("Invalid PIN code: Number not entered.")
        ElseIf IsNumeric(PINcodeTextBox.Text) = False Or PINcodeTextBox.Text < 0 Then
            MsgBox("Invalid PIN code: Only whole numbers accepted.")
        ElseIf Len(PINcodeTextBox.Text) <> 6 Then
            MsgBox("Invalid PIN code: Only six numbers are allowed.")

        ElseIf IsNumeric(PhonenoTextBox.Text) = False Then
            MsgBox("Invalid phone no.: Only numbers accepted.")
        ElseIf Len(Trim(PhonenoTextBox.Text)) <> 10 Then
            MsgBox("Invalid phone no.: Only ten numbers are allowed.")
        ElseIf Not isvalid Then
            MessageBox.Show("Invalid email ID: Write propper email ID.")

        Else

            If DepartureComboBox.Text = DestinationComboBox.Text Then
                MsgBox("Departure and destination are same. Please change loction.")
            Else

                If EconomyRadioButton.Checked = True Then
                    Flight_Class = "Economy"
                    AccomodationComboBox.Text = " none "
                    AccomodationComboBox.Enabled = False
                ElseIf BusinessClassRadioButton.Checked = True Then
                    Flight_Class = "Business Class"
                ElseIf FirstClassRadioButton.Checked = True Then
                    Flight_Class = "First Class"
                Else
                    AccomodationComboBox.Text = " none"
                    AccomodationComboBox.Enabled = True

                End If

                Dim TravelPrice As New PriceClass
                Dim SubTotal As Double
                Dim Total As Double
                Dim Tax As Double = TravelPrice.Airport_Tax

                If ExtLuggageCheckBox.Checked = True Then
                    TravelPrice.Ext_Luggage = 100
                Else
                    TravelPrice.Ext_Luggage = 0
                End If

                If DestinationComboBox.Text = "Agartala Airport [Tripura]" Then                                '[Tripura]
                    SubTotal = TravelPrice.Agartala_AP
                ElseIf DestinationComboBox.Text = "Aizawl Airport [Mizoram]" Then                              '[Mizoram]  
                    SubTotal = TravelPrice.Aizawl_AP
                ElseIf DestinationComboBox.Text = "Amaravati Airport  [Andhra Pradesh]" Then                   '[Andhra Pradesh]
                    SubTotal = TravelPrice.Amaravati_AP
                ElseIf DestinationComboBox.Text = "Bangalore Airport [Karnataka]" Then                         '[Karnataka]
                    SubTotal = TravelPrice.Bangalore_AP
                ElseIf DestinationComboBox.Text = "Bhopal Airport [Madhya Pradesh]" Then                       '[Madhya Pradesh]
                    SubTotal = TravelPrice.Bhopal_AP
                ElseIf DestinationComboBox.Text = "Bhubaneshwar Airport [Odisha]" Then                         '[Odisha]
                    SubTotal = TravelPrice.Bhubaneshwar_AP
                ElseIf DestinationComboBox.Text = "Chandighar Airport  [Chandigarh/Punjab/Haryana]" Then       '[Chandigarh/Punjab/Haryana]
                    SubTotal = TravelPrice.Chandighar_AP
                ElseIf DestinationComboBox.Text = "Chennai Airport [Tamil Nadu]" Then                          '[Tamil Nadu]
                    SubTotal = TravelPrice.Chennai_AP
                ElseIf DestinationComboBox.Text = "Daman Airport [Dadra/NagarHaveli/Daman/Diu]" Then           '[Dadra/NagarHaveli/Daman/Diu]
                    SubTotal = TravelPrice.Daman_AP
                ElseIf DestinationComboBox.Text = "Dehradun Airport [Uttarakhand]" Then                        '[Uttarakhand]
                    SubTotal = TravelPrice.Dehradun_AP
                ElseIf DestinationComboBox.Text = "Delhi Airport [Delhi]" Then                                 '[Delhi]
                    SubTotal = TravelPrice.Delhi_AP
                ElseIf DestinationComboBox.Text = "Dispur Airport [Assam]" Then                                '[Assam]
                    SubTotal = TravelPrice.Dispur_AP
                ElseIf DestinationComboBox.Text = "Gandhinagar Airport [Gujarat]" Then                         '[Gujarat]
                    SubTotal = TravelPrice.Gandhinagar_AP
                ElseIf DestinationComboBox.Text = "Gangtok Airport [Sikkim]" Then                              '[Sikkim]
                    SubTotal = TravelPrice.Gangtok_AP
                ElseIf DestinationComboBox.Text = "Hyderabad Airport [Telangana]" Then                         '[Telangana]
                    SubTotal = TravelPrice.Hyderabad_AP
                ElseIf DestinationComboBox.Text = "Imphal Airport [Manipur]" Then                              '[Manipur]
                    SubTotal = TravelPrice.Imphal_AP
                ElseIf DestinationComboBox.Text = "Itanagar Airport [Arunachal Pradesh]" Then                  '[Arunachal Pradesh]
                    SubTotal = TravelPrice.Itanagar_AP
                ElseIf DestinationComboBox.Text = "Jaipur Airport [Rajasthan]" Then                            '[Rajasthan]
                    SubTotal = TravelPrice.Jaipur_AP
                ElseIf DestinationComboBox.Text = "Katmandu Airport [Nepal]" Then                              '[Nepal]
                    SubTotal = TravelPrice.Katmandu_AP
                ElseIf DestinationComboBox.Text = "Kavarathi Airport [Lakshadweep]" Then                       '[Lakshadweep]
                    SubTotal = TravelPrice.Kavarathi_AP
                ElseIf DestinationComboBox.Text = "Kohima Airport [Nagaland]" Then                             '[Nagaland]
                    SubTotal = TravelPrice.Kohima_AP
                ElseIf DestinationComboBox.Text = "Kolkata Airport [West Bengal]" Then                         '[West Bengal]
                    SubTotal = TravelPrice.Kolkata_AP
                ElseIf DestinationComboBox.Text = "Leh Airport [Ladakh]" Then                                  '[Ladakh]
                    SubTotal = TravelPrice.Leh_AP
                ElseIf DestinationComboBox.Text = "Lucknow Airport [Uttar Pradesh]" Then                       '[Uttar Pradesh]
                    SubTotal = TravelPrice.Lucknow_AP
                ElseIf DestinationComboBox.Text = "Mumbai Airport [Maharashtra]" Then                          '[Maharashtra]
                    SubTotal = TravelPrice.Mumbai_AP
                ElseIf DestinationComboBox.Text = "Panaji Airport [Goa]" Then                                  '[Goa]
                    SubTotal = TravelPrice.Panaji_AP
                ElseIf DestinationComboBox.Text = "Patna Airport [Bihar]" Then                                 '[Bihar] 
                    SubTotal = TravelPrice.Patna_AP
                ElseIf DestinationComboBox.Text = "Port Blair Airport [Andaman Nicobar Islands]" Then          '[Andaman Nicobar Islands]
                    SubTotal = TravelPrice.Port_Blair_AP
                ElseIf DestinationComboBox.Text = "Puducherry Airport [Puducherry]" Then                       '[Puducherry]
                    SubTotal = TravelPrice.Puducherry_AP
                ElseIf DestinationComboBox.Text = "Raipur Airport [Chhattisgarh]" Then                         '[Chhattisgarh]
                    SubTotal = TravelPrice.Raipur_AP
                ElseIf DestinationComboBox.Text = "Ranchi Airport [Jharkhand]" Then                            '[Jharkhand]
                    SubTotal = TravelPrice.Ranchi_AP
                ElseIf DestinationComboBox.Text = "Shillong Airport [Meghalaya]" Then                          '[Meghalaya]
                    SubTotal = TravelPrice.Shillong_AP
                ElseIf DestinationComboBox.Text = "Shimla Airport [Himachal Pradesh]" Then                     '[Himachal Pradesh]
                    SubTotal = TravelPrice.Shimla_AP
                ElseIf DestinationComboBox.Text = "Srinagar Airport [Jammu & Kashmir]" Then                    '[Jammu & Kashmir]
                    SubTotal = TravelPrice.Srinagar_AP
                ElseIf DestinationComboBox.Text = "Thiruvananthapuram Airport [Kerala]" Then                   '[Kerala]
                    SubTotal = TravelPrice.Thiruvananthapuram_AP
                End If

                SubTotal = SubTotal + TravelPrice.Travel_Insurance + TravelPrice.Ext_Luggage

                If BusinessClassRadioButton.Checked = True Then
                    SubTotal = SubTotal + TravelPrice.Flight_Bussiness_Class
                End If

                If FirstClassRadioButton.Checked = True Then
                    SubTotal = SubTotal + TravelPrice.Flight_First_Class
                End If

                If ReturnCheckBox.Checked = True Then
                    SubTotal = SubTotal * 2
                    Tax = Tax * 2
                End If

                Total = SubTotal + Tax

                SubTotalLabel.Text = FormatCurrency(SubTotal)
                TaxLabel.Text = FormatCurrency(Tax)
                TotalLabel.Text = FormatCurrency(Total)

                ReceiptButton.Enabled = True
                ReceiptRichTextBox.Clear()

            End If

        End If
    End Sub


    Private Sub ReceiptButton_Click(sender As Object, e As EventArgs) Handles ReceiptButton.Click

        ReceiptRichTextBox.Clear()
        Name = FirstnameTextBox.Text.TrimStart.TrimEnd + " " + MidnameTextBox.Text.TrimStart.TrimEnd + " " + SurnameTextBox.Text.TrimStart.TrimEnd
        ReceiptRichTextBox.AppendText(vbTab + vbTab + vbTab + " Airways System [Domestic]" + vbNewLine + vbNewLine)
        ReceiptRichTextBox.AppendText("_______________________________________________________" + vbNewLine)
        ReceiptRichTextBox.AppendText("  Name           :  " + Name + vbNewLine)
        ReceiptRichTextBox.AppendText("  Age              :  " + Age + vbNewLine)
        ReceiptRichTextBox.AppendText("  PIN Code     :  " + PINCodeTextBox.Text.TrimStart.TrimEnd + vbNewLine)
        ReceiptRichTextBox.AppendText("  Phone no.    :  " + PhonenoTextBox.Text.Replace(" ", "") + vbNewLine)
        ReceiptRichTextBox.AppendText("  Email ID      :  " + EmailIDTextBox.Text.Replace(" ", "") + vbNewLine)
        ReceiptRichTextBox.AppendText("  Address       :  " + AddressTextBox.Text.TrimStart.TrimEnd + vbNewLine)
        ReceiptRichTextBox.AppendText("  Departure    :  " + DepartureComboBox.Text + vbNewLine)
        ReceiptRichTextBox.AppendText("  Destination  :  " + DestinationComboBox.Text + vbNewLine)
        ReceiptRichTextBox.AppendText("  Ticket           :  " + Ticket + vbNewLine)
        ReceiptRichTextBox.AppendText("  Class            :  " + Flight_Class + vbNewLine)
        ReceiptRichTextBox.AppendText("  Accommodation :  " + AccomodationComboBox.Text + vbNewLine)
        ReceiptRichTextBox.AppendText("_______________________________________________________" + vbNewLine)
        ReceiptRichTextBox.AppendText("  Sub Total     :  " + SubTotalLabel.Text + vbNewLine)
        ReceiptRichTextBox.AppendText("  Tax              :  " + TaxLabel.Text + vbNewLine)
        ReceiptRichTextBox.AppendText("  Total            :  " + TotalLabel.Text + vbNewLine)
        ReceiptRichTextBox.AppendText("_______________________________________________________" + vbNewLine)
        ReceiptRichTextBox.AppendText(Today + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TimeOfDay + vbNewLine)
        ReceiptRichTextBox.AppendText("_______________________________________________________" + vbNewLine + vbNewLine)
        ReceiptRichTextBox.AppendText(vbTab + "                  Thanks for using Airways System" + vbNewLine)
        ReceiptButton.Enabled = False


        Dim AddPlan As DialogResult
        AddPlan = MessageBox.Show("Do you want to add the plan", "Airways System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If AddPlan = DialogResult.Yes Then
            MessageBox.Show("Click Add Plan button below reciept.", "Airways System")
            AddPlanButton.Enabled = True
        Else
            AddPlanButton.Enabled = False
        End If

    End Sub

    Private Sub AddPlanButton_Click(sender As Object, e As EventArgs) Handles AddPlanButton.Click

        Dim constr As String = "server=localhost;user=root;database=tntmsdb;port=3306;password=Shaikh@2079;"
        Using con As MySqlConnection = New MySqlConnection(constr)

            Using cmd As MySqlCommand = New MySqlCommand("insert into Airways_Domestic (Name, Age, PIN_Code, Phone_no, Email_ID, Address, Departure, Destination, Ticket, Class, Accommodation, Sub_Total, Tax, Total)
                                                                                values (""" & Name & """,""" & Age & """," & PINCodeTextBox.Text & "," & PhonenoTextBox.Text & ",""" & EmailIDTextBox.Text & """,""" & AddressTextBox.Text & """,""" & DepartureComboBox.Text & """,""" & DestinationComboBox.Text & """,""" & Ticket & """,""" & Flight_Class & """,""" & AccomodationComboBox.Text & """,""" & SubTotalLabel.Text & """,""" & TaxLabel.Text & """,""" & TotalLabel.Text & """);")

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