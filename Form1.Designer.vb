<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.TxtLabel = New System.Windows.Forms.Label()
        Me.TxtIntAge = New System.Windows.Forms.TextBox()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TxtOccupation = New System.Windows.Forms.TextBox()
        Me.LstGender = New System.Windows.Forms.ListBox()
        Me.LabelOccupation = New System.Windows.Forms.Label()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(130, 50)
        Me.TxtFirstName.Multiline = True
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(258, 38)
        Me.TxtFirstName.TabIndex = 0
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(60, 343)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(132, 36)
        Me.BtnSubmit.TabIndex = 1
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'TxtLabel
        '
        Me.TxtLabel.AutoSize = True
        Me.TxtLabel.Location = New System.Drawing.Point(22, 62)
        Me.TxtLabel.Name = "TxtLabel"
        Me.TxtLabel.Size = New System.Drawing.Size(39, 15)
        Me.TxtLabel.TabIndex = 2
        Me.TxtLabel.Text = "Name"
        '
        'TxtIntAge
        '
        Me.TxtIntAge.Location = New System.Drawing.Point(130, 111)
        Me.TxtIntAge.Multiline = True
        Me.TxtIntAge.Name = "TxtIntAge"
        Me.TxtIntAge.Size = New System.Drawing.Size(258, 38)
        Me.TxtIntAge.TabIndex = 3
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = True
        Me.LabelAge.Location = New System.Drawing.Point(22, 124)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(28, 15)
        Me.LabelAge.TabIndex = 4
        Me.LabelAge.Text = "Age"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(198, 343)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(132, 36)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TxtOccupation
        '
        Me.TxtOccupation.Location = New System.Drawing.Point(130, 169)
        Me.TxtOccupation.Multiline = True
        Me.TxtOccupation.Name = "TxtOccupation"
        Me.TxtOccupation.Size = New System.Drawing.Size(258, 38)
        Me.TxtOccupation.TabIndex = 6
        '
        'LstGender
        '
        Me.LstGender.FormattingEnabled = True
        Me.LstGender.ItemHeight = 15
        Me.LstGender.Items.AddRange(New Object() {"Male", "Female", "Rather Not Say", "Others"})
        Me.LstGender.Location = New System.Drawing.Point(130, 230)
        Me.LstGender.MultiColumn = True
        Me.LstGender.Name = "LstGender"
        Me.LstGender.Size = New System.Drawing.Size(258, 79)
        Me.LstGender.TabIndex = 7
        '
        'LabelOccupation
        '
        Me.LabelOccupation.AutoSize = True
        Me.LabelOccupation.Location = New System.Drawing.Point(22, 181)
        Me.LabelOccupation.Name = "LabelOccupation"
        Me.LabelOccupation.Size = New System.Drawing.Size(69, 15)
        Me.LabelOccupation.TabIndex = 8
        Me.LabelOccupation.Text = "Occupation"
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Location = New System.Drawing.Point(22, 253)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(45, 15)
        Me.LabelGender.TabIndex = 9
        Me.LabelGender.Text = "Gender"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Location = New System.Drawing.Point(130, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(101, 15)
        Me.Title.TabIndex = 10
        Me.Title.Text = "EMPLOYEE FORM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 391)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.LabelOccupation)
        Me.Controls.Add(Me.LstGender)
        Me.Controls.Add(Me.TxtOccupation)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LabelAge)
        Me.Controls.Add(Me.TxtIntAge)
        Me.Controls.Add(Me.TxtLabel)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents TxtLabel As Label
    Friend WithEvents TxtIntAge As TextBox
    Friend WithEvents LabelAge As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents TxtOccupation As TextBox
    Friend WithEvents LstGender As ListBox
    Friend WithEvents LabelOccupation As Label
    Friend WithEvents LabelGender As Label
    Friend WithEvents Title As Label
End Class
