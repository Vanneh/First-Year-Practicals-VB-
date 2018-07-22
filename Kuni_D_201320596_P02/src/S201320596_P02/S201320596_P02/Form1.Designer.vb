<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsme
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
        Me.txtdisplay = New System.Windows.Forms.TextBox()
        Me.btnsetup = New System.Windows.Forms.Button()
        Me.btnave = New System.Windows.Forms.Button()
        Me.btnrating = New System.Windows.Forms.Button()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.lbldisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtdisplay
        '
        Me.txtdisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdisplay.Location = New System.Drawing.Point(12, 28)
        Me.txtdisplay.Multiline = True
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.Size = New System.Drawing.Size(514, 260)
        Me.txtdisplay.TabIndex = 0
        '
        'btnsetup
        '
        Me.btnsetup.BackColor = System.Drawing.SystemColors.Control
        Me.btnsetup.Location = New System.Drawing.Point(532, 28)
        Me.btnsetup.Name = "btnsetup"
        Me.btnsetup.Size = New System.Drawing.Size(137, 47)
        Me.btnsetup.TabIndex = 1
        Me.btnsetup.Text = "Click Here First to setup application and enter neccessay values"
        Me.btnsetup.UseVisualStyleBackColor = False
        '
        'btnave
        '
        Me.btnave.Location = New System.Drawing.Point(532, 81)
        Me.btnave.Name = "btnave"
        Me.btnave.Size = New System.Drawing.Size(137, 35)
        Me.btnave.TabIndex = 1
        Me.btnave.Text = "Click Here to calculate mark Averages"
        Me.btnave.UseVisualStyleBackColor = True
        '
        'btnrating
        '
        Me.btnrating.Location = New System.Drawing.Point(532, 122)
        Me.btnrating.Name = "btnrating"
        Me.btnrating.Size = New System.Drawing.Size(137, 35)
        Me.btnrating.TabIndex = 1
        Me.btnrating.Text = "Click Here to calculate student ratings"
        Me.btnrating.UseVisualStyleBackColor = True
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(532, 163)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(137, 36)
        Me.btndisplay.TabIndex = 1
        Me.btndisplay.Text = "Click here to display a specific student's data"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'lbldisplay
        '
        Me.lbldisplay.AutoSize = True
        Me.lbldisplay.Location = New System.Drawing.Point(12, 9)
        Me.lbldisplay.Name = "lbldisplay"
        Me.lbldisplay.Size = New System.Drawing.Size(268, 13)
        Me.lbldisplay.TabIndex = 2
        Me.lbldisplay.Text = "A textbox that will display a designated student's Details"
        '
        'frmsme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 300)
        Me.Controls.Add(Me.lbldisplay)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.btnrating)
        Me.Controls.Add(Me.btnave)
        Me.Controls.Add(Me.btnsetup)
        Me.Controls.Add(Me.txtdisplay)
        Me.Name = "frmsme"
        Me.Text = "Student mark Evaluator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdisplay As System.Windows.Forms.TextBox
    Friend WithEvents btnsetup As System.Windows.Forms.Button
    Friend WithEvents btnave As System.Windows.Forms.Button
    Friend WithEvents btnrating As System.Windows.Forms.Button
    Friend WithEvents btndisplay As System.Windows.Forms.Button
    Friend WithEvents lbldisplay As System.Windows.Forms.Label

End Class
