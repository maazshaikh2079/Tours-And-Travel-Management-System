Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Roadways
    Dim Ticket As String
    Dim Bus_Type As String
    Dim Noofadults As Integer
    Dim Noofkids As Integer
    Dim Nooftravellers As Integer
    Dim EmailID As Regex
    Dim isvalid As Boolean

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

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ReceiptButton.Enabled = False
        AddPlanButton.Enabled = False

        ReceiptRichTextBox.Clear()
        PlancodeTextBox.Clear()
        NoofadultsTextBox.Clear()
        NoofkidsTextBox.Clear()
        AddressTextBox.Clear()
        PhonenoTextBox.Clear()
        EmailIDTextBox.Clear()
        DistanceinkmTextBox.Clear()

        TaxLabel.Text = ""
        SubTotalLabel.Text = ""
        DiscountLabel.Text = ""
        TotalLabel.Text = ""

        NoofbusesLabel.Text = ""

        TravellingfromComboBox.Text = " none"
        TravellingtoComboBox.Text = " none"


        TollFeeCheckBox.Checked = True
        TaxCheckBox.Checked = True
        DiscountCheckBox.Checked = True
        ExtLuggageCheckBox.Checked = False
        ExtHaltsCheckBox.Checked = False

        NonACRadioButton.Checked = False
        ACRadioButton.Checked = False

        SingleCheckBox.Checked = False
        ReturnCheckBox.Checked = False

    End Sub


    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click

        PlancodeTextBox.Text = PlancodeTextBox.Text.Replace(" ", "")
        NoofadultsTextBox.Text = NoofadultsTextBox.Text.Replace(" ", "")
        NoofkidsTextBox.Text = NoofkidsTextBox.Text.Replace(" ", "")
        PhonenoTextBox.Text = PhonenoTextBox.Text.Replace(" ", "")
        EmailID = New Regex("^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
        isvalid = EmailID.IsMatch(EmailIDTextBox.Text.Replace(" ", ""))

        If ((PlancodeTextBox.Text = "" Or NoofadultsTextBox.Text = "" Or NoofkidsTextBox.Text = "" Or AddressTextBox.Text = "" Or PhonenoTextBox.Text = "" Or EmailIDTextBox.Text = "") Or
           (ACRadioButton.Checked = False And NonACRadioButton.Checked = False) Or (SingleCheckBox.Checked = False And ReturnCheckBox.Checked = False) Or
           (TravellingfromComboBox.Text = " none" Or TravellingfromComboBox.Text = "" Or TravellingtoComboBox.Text = " none" Or TravellingtoComboBox.Text = "" Or DistanceinkmTextBox.Text = "")) Then
            MsgBox("Enter all required details and click Total button before generating Receipt.")

        ElseIf PlancodeTextBox.Text = "" Then
            MsgBox("Invalid plan code: Number not entered.")
        ElseIf IsNumeric(PlancodeTextBox.Text) = False Or PlancodeTextBox.Text < 0 Then
            MsgBox("Invalid plan code: Only whole numbers accepted.")
        ElseIf Len(PlancodeTextBox.Text) <> 4 Then
            MsgBox("Invalid plan code: Only four numbers are allowed.")
        ElseIf NoofadultsTextBox.Text = "" Then
            MsgBox("Invalid no. of adults: Number not entered.")
        ElseIf IsNumeric(NoofadultsTextBox.Text) = False Or NoofadultsTextBox.Text < 1 Then
            MsgBox("Invalid no. of adults: Only natural numbers accepted.")
        ElseIf Len(NoofadultsTextBox.Text) > 3 Then
            MsgBox("Invalid no. of adults: Only numbers under four digits are allowed.")
        ElseIf NoofkidsTextBox.Text = "" Then
            MsgBox("Invalid no. of kids: Number not entered.")
        ElseIf IsNumeric(NoofkidsTextBox.Text) = False Or NoofkidsTextBox.Text < 0 Then
            MsgBox("Invalid no. of kids: Only whole numbers accepted.")
        ElseIf Len(NoofkidsTextBox.Text) > 3 Then
            MsgBox("Invalid no. of kids: Only numbers under four digits are allowed.")
        ElseIf IsNumeric(PhonenoTextBox.Text) = False Then
            MsgBox("Invalid phone no.: Only numbers accepted.")
        ElseIf Len(Trim(PhonenoTextBox.Text)) <> 10 Then
            MsgBox("Invalid phone no.: Only ten numbers are allowed.")
        ElseIf Not isvalid Then
            MessageBox.Show("Invalid email ID: Write propper email ID.")

        Else

            If TravellingfromComboBox.Text = TravellingtoComboBox.Text Then
                MsgBox("Departure and destination are same. Please change location.")
            Else
                If NonACRadioButton.Checked = True Then
                    Bus_Type = "Non AC"
                ElseIf ACRadioButton.Checked = True Then
                    Bus_Type = "AC"
                End If

                Noofadults = Val(NoofadultsTextBox.Text)
                Noofkids = Val(NoofkidsTextBox.Text)
                Nooftravellers = Noofadults + Noofkids

                If Nooftravellers > 9 And Nooftravellers < 301 Then
                    Dim TravelPrice As New PriceClass
                    Dim SubTotal As Double
                    Dim Total As Double
                    Dim Tax As Double
                    Dim Discount As Double
                    If ExtLuggageCheckBox.Checked = True Then
                        TravelPrice.Ext_Luggage = 150
                    Else
                        TravelPrice.Ext_Luggage = 0
                    End If
                    If ExtHaltsCheckBox.Checked = True Then
                        TravelPrice.Ext_Halts = 210
                    Else
                        TravelPrice.Ext_Luggage = 0
                    End If

                    If Nooftravellers >= 10 And Nooftravellers <= 20 Then          ' 1 (20 seater bus)
                        NoofbusesLabel.Text = "1 (20 seater bus)"
                    ElseIf Nooftravellers >= 20 And Nooftravellers <= 40 Then      ' 1 (40 seater bus)
                        NoofbusesLabel.Text = "1 (40 seater bus)"
                    ElseIf Nooftravellers >= 40 And Nooftravellers <= 60 Then      ' 1 (60 seater bus)
                        NoofbusesLabel.Text = "1 (60 seater bus)"
                    ElseIf Nooftravellers >= 60 And Nooftravellers <= 80 Then      ' 2 (40 seater bus)
                        NoofbusesLabel.Text = "2 (40 seater bus)"
                    ElseIf Nooftravellers >= 80 And Nooftravellers <= 100 Then     ' 2 (60 seater bus)
                        NoofbusesLabel.Text = "2 (60 seater bus)"
                    ElseIf Nooftravellers >= 100 And Nooftravellers <= 120 Then    ' 3 (40 seater bus)
                        NoofbusesLabel.Text = "3 (40 seater bus)"
                    ElseIf Nooftravellers >= 100 And Nooftravellers <= 140 Then    ' 3 (60 seater bus)
                        NoofbusesLabel.Text = "3 (60 seater bus)"
                    ElseIf Nooftravellers >= 100 And Nooftravellers <= 160 Then    ' 4 (40 seater bus)
                        NoofbusesLabel.Text = "4 (40 seater bus)"
                    ElseIf Nooftravellers >= 100 And Nooftravellers <= 180 Then    ' 3 (60 seater bus)
                        NoofbusesLabel.Text = "3 (60 seater bus)"
                    ElseIf Nooftravellers >= 100 And Nooftravellers <= 200 Then    ' 5 (40 seater bus)
                        NoofbusesLabel.Text = "5 (40 seater bus)"
                    ElseIf Nooftravellers >= 100 And Nooftravellers <= 220 Then    ' 4 (60 seater bus)
                        NoofbusesLabel.Text = "4 (60 seater bus)"
                    ElseIf Nooftravellers >= 100 And Nooftravellers <= 240 Then    ' 6 (40 seater bus)
                        NoofbusesLabel.Text = "6 (40 seater bus)"
                    ElseIf Nooftravellers >= 100 And Nooftravellers <= 260 Then    ' 5 (60 seater bus)
                        NoofbusesLabel.Text = "5 (60 seater bus)"
                    ElseIf Nooftravellers >= 100 And Nooftravellers <= 280 Then    ' 7 (40 seater bus)
                        NoofbusesLabel.Text = "7 (40 seater bus)"
                    ElseIf Nooftravellers >= 100 And Nooftravellers <= 300 Then    ' 6 (60 seater bus)
                        NoofbusesLabel.Text = "6 (60 seater bus)"
                    End If

                    If (TravellingtoComboBox.Text = "Alambagh Bus Depot [Uttar Pradesh]") Then                       '[Uttar Pradesh]
                        SubTotal = (TravelPrice.Alambagh_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Bhopal Bus Depot [Madhya Pradesh]") Then                    '[Madhya Pradesh]
                        SubTotal = (TravelPrice.Bhopal_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Blue Hill Bus Depot [Arunachal Pradesh]") Then              '[Arunachal Pradesh]
                        SubTotal = (TravelPrice.Blue_Hill_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "DSM Bus Depot [Assam]") Then                                '[Assam]
                        SubTotal = (TravelPrice.DSM_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "DTC Bus Depot [Delhi]") Then                                '[Delhi]
                        SubTotal = (TravelPrice.DTC_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "DTS Bus Depot [Odisha]") Then                               '[Odisha]
                        SubTotal = (TravelPrice.DTS_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Daman Bus Depot [Dadra/NagarHaveli/Daman/Diu]") Then        '[Dadra/NagarHaveli/Daman/Diu]
                        SubTotal = (TravelPrice.Daman_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Dehradun Bus Depot [Uttarakhand]") Then                     '[Uttarakhand]
                        SubTotal = (TravelPrice.Dehradun_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "GSRTC Bus Depot [Gujarat]") Then                            '[Gujarat]
                        SubTotal = (TravelPrice.GSRTC_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Hyderabad Bus Depot [Telangana]") Then                      '[Telangana]
                        SubTotal = (TravelPrice.Hyderabad_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "ISBT Bus Depot [Chandigarh/Punjab/Haryana]") Then           '[Chandigarh/Punjab/Haryana]
                        SubTotal = (TravelPrice.ISBT_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Imphal Bus Depot [Manipur]") Then                           '[Manipur]
                        SubTotal = (TravelPrice.Imphal_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Jaipur Bus Depot [Rajasthan]") Then                         '[Rajasthan]
                        SubTotal = (TravelPrice.Jaipur_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "K2 Bus Depot [Andhra Pradesh]") Then                        '[Andhra Pradesh]
                        SubTotal = (TravelPrice.K2_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Kempegowda Bus Depot [Karnataka]") Then                     '[Karnataka]
                        SubTotal = (TravelPrice.Kempegowda_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Leh Bus Depot [Ladakh]") Then                               '[Ladakh]
                        SubTotal = (TravelPrice.Leh_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "MSRTC Bus Depot [Maharashtra]") Then                        '[Maharashtra]
                        SubTotal = (TravelPrice.MSRTC_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "MST Bus Depot [Mizoram]") Then                              '[Mizoram]
                        SubTotal = (TravelPrice.MST_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "MTC Bus Depot [Tamil Nadu]") Then                           '[Tamil Nadu]
                        SubTotal = (TravelPrice.MTC_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "NST Bus Depot [Nagaland]") Then                             '[Nagaland]
                        SubTotal = (TravelPrice.NST_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Nepal Yatayat Bus Depot [Nepal]") Then                      '[Nepal]
                        SubTotal = (TravelPrice.Nepal_Yatayat_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Panaji Bus Depot [Goa]") Then                               '[Goa]
                        SubTotal = (TravelPrice.Panaji_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Patliputra Bus Depot [Bihar]") Then                         '[Bihar]
                        SubTotal = (TravelPrice.Patliputra_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Puducherry Bus Depot [Puducherry]") Then                    '[Puducherry]
                        SubTotal = (TravelPrice.Puducherry_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Raipur Bus Depot [Chhattisgarh]") Then                      '[Chhattisgarh]
                        SubTotal = (TravelPrice.Raipur_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Ranchi Bus Depot [Jharkhand]") Then                         '[Jharkhand]
                        SubTotal = (TravelPrice.Ranchi_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "SNT Bus Depot [Sikkim]") Then                               '[Sikkim]
                        SubTotal = (TravelPrice.SNT_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Shillong Bus Depot [Meghalaya]") Then                       '[Meghalaya]
                        SubTotal = (TravelPrice.Shillong_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Shimla Bus Depot [Himachal Pradesh]") Then                  '[Himachal Pradesh]
                        SubTotal = (TravelPrice.Shimla_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Srinagar Bus Depot [Jammu & Kashmir]") Then                 '[Jammu & Kashmir]
                        SubTotal = (TravelPrice.Srinagar_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "TRTC Bus Depot [Tripura]") Then                             '[Tripura]
                        SubTotal = (TravelPrice.TRTC_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "Trivandrum Bus Depot [Kerala]") Then                        '[Kerala]
                        SubTotal = (TravelPrice.Trivandrum_BD * Nooftravellers)
                    ElseIf (TravellingtoComboBox.Text = "WBSTC Bus Depot [West Bengal]") Then                        '[West Bengal]
                        SubTotal = (TravelPrice.WBSTC_BD * Nooftravellers)
                    End If
                    SubTotal = SubTotal + TravelPrice.Toll_Fee + TravelPrice.Ext_Luggage + TravelPrice.Ext_Halts
                    If ACRadioButton.Checked = True Then
                        SubTotal = SubTotal + TravelPrice.AC_Bus
                    End If
                    If ReturnCheckBox.Checked = True Then
                        SubTotal = SubTotal * 2
                    End If
                    Tax = SubTotal - (SubTotal * 0.95)
                    SubTotal = SubTotal - Tax
                    If Noofkids > Noofadults Then
                        Discount = SubTotal - (SubTotal * 0.96)
                        SubTotal = SubTotal - Discount
                    End If
                    TaxLabel.Text = FormatCurrency(Tax)
                    SubTotalLabel.Text = FormatCurrency(SubTotal)
                    DiscountLabel.Text = (FormatCurrency(Discount) + " off")
                    Total = SubTotal + Tax
                    TotalLabel.Text = FormatCurrency(Total)
                    ReceiptButton.Enabled = True
                    ReceiptRichTextBox.Clear()
                Else
                    MsgBox(" 10 to 300 trevellers are allowed.")
                End If
            End If
        End If
    End Sub

    Private Sub ReceiptButton_Click(sender As Object, e As EventArgs) Handles ReceiptButton.Click

        ReceiptRichTextBox.Clear()
        ReceiptRichTextBox.AppendText(vbTab + vbTab + vbTab + " Roadways System" + vbNewLine + vbNewLine)
        ReceiptRichTextBox.AppendText("_______________________________________________________" + vbNewLine)
        ReceiptRichTextBox.AppendText("  Plan code       :  " + PlancodeTextBox.Text.Replace(" ", "") + vbNewLine)
        ReceiptRichTextBox.AppendText("  No. of adults   :  " + NoofadultsTextBox.Text.Replace(" ", "") + vbNewLine)
        ReceiptRichTextBox.AppendText("  No. of kids      :  " + NoofkidsTextBox.Text.Replace(" ", "") + vbNewLine)
        ReceiptRichTextBox.AppendText("  Address          :  " + AddressTextBox.Text.TrimStart.TrimEnd + vbNewLine)
        ReceiptRichTextBox.AppendText("  Phone no.       :  " + PhonenoTextBox.Text.Replace(" ", "") + vbNewLine)
        ReceiptRichTextBox.AppendText("  Email ID         :  " + EmailIDTextBox.Text.Replace(" ", "") + vbNewLine)
        ReceiptRichTextBox.AppendText("  Travelling from :  " + TravellingfromComboBox.Text + vbNewLine)
        ReceiptRichTextBox.AppendText("  Travelling to     :  " + TravellingtoComboBox.Text + vbNewLine)
        ReceiptRichTextBox.AppendText("  No. of buses   :  " + NoofbusesLabel.Text + vbNewLine)
        ReceiptRichTextBox.AppendText("  Bus type         :  " + Bus_Type + vbNewLine)
        ReceiptRichTextBox.AppendText("  Ticket             :  " + Ticket + vbNewLine)
        ReceiptRichTextBox.AppendText("_______________________________________________________" + vbNewLine)
        ReceiptRichTextBox.AppendText("  Sub Total       :  " + SubTotalLabel.Text + vbNewLine)
        ReceiptRichTextBox.AppendText("  Tax                :  " + TaxLabel.Text + vbNewLine)
        ReceiptRichTextBox.AppendText("  Total              :  " + TotalLabel.Text + vbNewLine)
        ReceiptRichTextBox.AppendText("_______________________________________________________" + vbNewLine)
        ReceiptRichTextBox.AppendText(Today + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TimeOfDay + vbNewLine)
        ReceiptRichTextBox.AppendText("_______________________________________________________" + vbNewLine + vbNewLine)
        ReceiptRichTextBox.AppendText(vbTab + "                  Thanks for using Roadways System" + vbNewLine)
        ReceiptButton.Enabled = False

        Dim AddPlan As DialogResult
        AddPlan = MessageBox.Show("Do you want to add the plan", "Roadways System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If AddPlan = DialogResult.Yes Then
            MessageBox.Show("Click Add Plan button below reciept.", "Roadways System")
            AddPlanButton.Enabled = True
        Else
            AddPlanButton.Enabled = False
        End If

    End Sub

    Private Sub AddPlanButton_Click(sender As Object, e As EventArgs) Handles AddPlanButton.Click

        Dim constr As String = "server=localhost;user=root;database=tntmsdb;port=3306;password=Shaikh@2079;"
        Using con As MySqlConnection = New MySqlConnection(constr)

            Using cmd As MySqlCommand = New MySqlCommand("insert into Roadways (Plan_code,No_of_adults,No_of_kids,Address,Phone_no,Email_ID,Travelling_from,Travelling_to,No_of_buses,Bus_type,Ticket,Sub_Total,Tax,Total)
                                                                        values (" & PlancodeTextBox.Text & "," & NoofadultsTextBox.Text & "," & NoofkidsTextBox.Text & ",""" & AddressTextBox.Text & """," & PhonenoTextBox.Text & ",""" & EmailIDTextBox.Text & """,""" & TravellingfromComboBox.Text & """,""" & TravellingtoComboBox.Text & """,""" & NoofbusesLabel.Text & """,""" & Bus_Type & """,""" & Ticket & """,""" & SubTotalLabel.Text & """,""" & TaxLabel.Text & """,""" & TotalLabel.Text & """);")

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