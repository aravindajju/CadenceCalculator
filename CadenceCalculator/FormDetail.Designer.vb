<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetail
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
        Me.rtbDetail = New System.Windows.Forms.RichTextBox()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbDetail
        '
        Me.rtbDetail.Location = New System.Drawing.Point(12, 16)
        Me.rtbDetail.Name = "rtbDetail"
        Me.rtbDetail.Size = New System.Drawing.Size(223, 376)
        Me.rtbDetail.TabIndex = 0
        Me.rtbDetail.Text = ""
        '
        'BtnCopy
        '
        Me.BtnCopy.Location = New System.Drawing.Point(13, 408)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(75, 23)
        Me.BtnCopy.TabIndex = 1
        Me.BtnCopy.Text = "Copy"
        Me.BtnCopy.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(151, 408)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FormDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 450)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.rtbDetail)
        Me.Name = "FormDetail"
        Me.Text = "Detail"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbDetail As RichTextBox
    Friend WithEvents BtnCopy As Button
    Friend WithEvents BtnClose As Button
End Class
