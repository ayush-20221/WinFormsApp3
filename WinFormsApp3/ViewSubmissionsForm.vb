Imports System.Net
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub LoadSubmissions()
        Dim client As New WebClient()
        Dim json As String = client.DownloadString("http://localhost:3000/submissions")
        submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission = submissions(index)
            lblName.Text = $"Name: {submission.Name}"
            lblEmail.Text = $"Email: {submission.Email}"
            lblPhone.Text = $"Phone: {submission.Phone}"
            lblGithubLink.Text = $"GitHub: {submission.GithubLink}"
            lblStopwatchTime.Text = $"Stopwatch: {submission.StopwatchTime}"
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class
