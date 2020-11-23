'Header - TJR
'Repo, Solution, Project and File Names PascalCase - TJR
'Only the Form Class should have Form suffix - TJR
'Option Statements - TJR

Public Class Form1 ' Bad name - TJR
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        If FirstNameTextBox.Text = Nothing Or LastNameTextBox.Text = Nothing Or
            StreetAddressLabel.Text = Nothing Or ZipTextBox.Text = Nothing Or
            StateTextBox.Text = Nothing Or CityTextBox.Text = Nothing Then ' ' "" works too - TJR
            MsgBox("Fill out information to continue")
            Exit Sub
        End If
        'Exit sub applies to when IF is condition is met

        DisplayLabel.Text = FirstNameTextBox.Text & " " & LastNameTextBox.Text &
            vbNewLine & StreetAddressTextBox.Text & vbNewLine & CityTextBox.Text &
            ", " & StateTextBox.Text & " " & ZipTextBox.Text

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = String.Empty ' "" works too - TJR

    End Sub
End Class
