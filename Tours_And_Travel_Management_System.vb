Public Class Tours_And_Travel_Management_System
    Private Sub RailwaysSystemButton_Click(sender As Object, e As EventArgs) Handles RailwaysSystemButton.Click
        Railways.Show()
        Me.Hide()
    End Sub

    Private Sub RoadwaysSystemButton_Click(sender As Object, e As EventArgs) Handles RoadwaysSystemButton.Click
        Roadways.Show()
        Me.Hide()
    End Sub

    Private Sub AirwaysSystemButton_Click(sender As Object, e As EventArgs) Handles AirwaysSystemButton.Click
        Airways_Domestic.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'TimeLabel.Text = TimeOfDay
        'DateLabel.Text = Today

        TimeLabel2.Text = TimeOfDay
        DateLabel2.Text = Today
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ExitClass.ExitSystem()
    End Sub


End Class