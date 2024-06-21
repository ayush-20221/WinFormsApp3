Imports System.Net
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchTime As TimeSpan = TimeSpan.Zero

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            timerStopwatch.Stop()
            btnToggleStopwatch.Text = "Start"
        Else
            timerStopwatch.Start()
            btnToggleStopwatch.Text = "Stop"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub timerStopwatch_Tick(sender As Object, e As EventArgs) Handles timerStopwatch.Tick
        stopwatchTime += TimeSpan.FromSeconds(1)
        lblStopwatch.Text = stopwatchTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission() With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GithubLink = txtGithubLink.Text,
            .StopwatchTime = stopwatchTime.ToString("hh\:mm\:ss")
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Using client As New WebClient()
            client.Headers(HttpRequestHeader.ContentType) = "application/json"
            Try
                client.UploadString("http://localhost:3000/submit", json)
                MessageBox.Show("Submission saved successfully!")
            Catch ex As Exception
                MessageBox.Show("Error saving submission: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class
