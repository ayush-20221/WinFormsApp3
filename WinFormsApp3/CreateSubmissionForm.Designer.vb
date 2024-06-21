<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblStopwatch = New Label()
        txtName = New TextBox()
        TextBox2 = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtEmail = New TextBox()
        timerStopwatch = New Timer(components)
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(278, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(278, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(278, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 2
        Label3.Text = "Label3"
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(278, 221)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(53, 20)
        lblStopwatch.TabIndex = 3
        lblStopwatch.Text = "Label4"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(395, 98)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(522, 260)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(395, 181)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(125, 27)
        txtPhone.TabIndex = 6
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(395, 214)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(125, 27)
        txtGithubLink.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(395, 143)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 8
        ' 
        ' timerStopwatch
        ' 
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.Location = New Point(434, 307)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(94, 29)
        btnToggleStopwatch.TabIndex = 9
        btnToggleStopwatch.Text = "Button1"
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(278, 318)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "Button1"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtEmail)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(TextBox2)
        Controls.Add(txtName)
        Controls.Add(lblStopwatch)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents timerStopwatch As Timer
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
End Class
