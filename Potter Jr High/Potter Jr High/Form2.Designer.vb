<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblRemoveAdd = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbName = New System.Windows.Forms.TextBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.txtbGrade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblRemoveAdd
        '
        Me.lblRemoveAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemoveAdd.Location = New System.Drawing.Point(92, 9)
        Me.lblRemoveAdd.Name = "lblRemoveAdd"
        Me.lblRemoveAdd.Size = New System.Drawing.Size(192, 34)
        Me.lblRemoveAdd.TabIndex = 0
        Me.lblRemoveAdd.Text = "Add/Remove"
        Me.lblRemoveAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add/Remove"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubmit
        '
        Me.lblSubmit.Location = New System.Drawing.Point(143, 178)
        Me.lblSubmit.Name = "lblSubmit"
        Me.lblSubmit.Size = New System.Drawing.Size(75, 23)
        Me.lblSubmit.TabIndex = 1
        Me.lblSubmit.Text = "Submit"
        Me.lblSubmit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student Name:"
        '
        'txtbName
        '
        Me.txtbName.Location = New System.Drawing.Point(106, 74)
        Me.txtbName.Name = "txtbName"
        Me.txtbName.Size = New System.Drawing.Size(144, 20)
        Me.txtbName.TabIndex = 3
        Me.txtbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(159, 107)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(39, 13)
        Me.lblGrade.TabIndex = 4
        Me.lblGrade.Text = "Grade:"
        '
        'txtbGrade
        '
        Me.txtbGrade.Location = New System.Drawing.Point(159, 121)
        Me.txtbGrade.Name = "txtbGrade"
        Me.txtbGrade.Size = New System.Drawing.Size(36, 20)
        Me.txtbGrade.TabIndex = 5
        Me.txtbGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 213)
        Me.Controls.Add(Me.txtbGrade)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.txtbName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRemoveAdd)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRemoveAdd As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbName As TextBox
    Friend WithEvents lblGrade As Label
    Friend WithEvents txtbGrade As TextBox
End Class
