<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        btnPrevious = New Button()
        btnNext = New Button()
        lblName = New TextBox()
        lblEmail = New TextBox()
        lblGithubLink = New TextBox()
        lblPhone = New TextBox()
        lblStopwatchTime = New TextBox()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(188, 356)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(94, 29)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "Button1"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(577, 356)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(94, 29)
        btnNext.TabIndex = 1
        btnNext.Text = "Button2"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' lblName
        ' 
        lblName.Location = New Point(358, 117)
        lblName.Name = "lblName"
        lblName.Size = New Size(125, 27)
        lblName.TabIndex = 2
        ' 
        ' lblEmail
        ' 
        lblEmail.Location = New Point(358, 150)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(125, 27)
        lblEmail.TabIndex = 3
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.Location = New Point(358, 216)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(125, 27)
        lblGithubLink.TabIndex = 4
        ' 
        ' lblPhone
        ' 
        lblPhone.Location = New Point(358, 183)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(125, 27)
        lblPhone.TabIndex = 5
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.Location = New Point(358, 258)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(125, 27)
        lblStopwatchTime.TabIndex = 6
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblPhone)
        Controls.Add(lblGithubLink)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblName As TextBox
    Friend WithEvents lblEmail As TextBox
    Friend WithEvents lblGithubLink As TextBox
    Friend WithEvents lblPhone As TextBox
    Friend WithEvents lblStopwatchTime As TextBox
End Class
