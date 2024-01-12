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
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(313, 81)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(138, 22)
        Me.TxtInput.TabIndex = 0
        '
        'BtnCheck
        '
        Me.BtnCheck.Location = New System.Drawing.Point(345, 130)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(75, 37)
        Me.BtnCheck.TabIndex = 1
        Me.BtnCheck.Text = "Start"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.Location = New System.Drawing.Point(358, 198)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(48, 16)
        Me.LblResult.TabIndex = 2
        Me.LblResult.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.TxtInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtInput As TextBox
    Friend WithEvents BtnCheck As Button
    Friend WithEvents LblResult As Label
End Class
