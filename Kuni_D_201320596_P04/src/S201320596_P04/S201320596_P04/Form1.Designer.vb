<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmesl
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
        Me.btnsetup = New System.Windows.Forms.Button()
        Me.btninput = New System.Windows.Forms.Button()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.txtroster = New System.Windows.Forms.TextBox()
        Me.txtsuccess = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsetup
        '
        Me.btnsetup.Location = New System.Drawing.Point(409, 12)
        Me.btnsetup.Name = "btnsetup"
        Me.btnsetup.Size = New System.Drawing.Size(140, 23)
        Me.btnsetup.TabIndex = 0
        Me.btnsetup.Text = "Setup Application"
        Me.btnsetup.UseVisualStyleBackColor = True
        '
        'btninput
        '
        Me.btninput.Location = New System.Drawing.Point(409, 41)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(140, 23)
        Me.btninput.TabIndex = 0
        Me.btninput.Text = "Input Information"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(409, 70)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(140, 23)
        Me.btndisplay.TabIndex = 0
        Me.btndisplay.Text = "Display a Disaster's Roster"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'txtroster
        '
        Me.txtroster.Location = New System.Drawing.Point(12, 12)
        Me.txtroster.Multiline = True
        Me.txtroster.Name = "txtroster"
        Me.txtroster.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtroster.Size = New System.Drawing.Size(391, 134)
        Me.txtroster.TabIndex = 1
        '
        'txtsuccess
        '
        Me.txtsuccess.Location = New System.Drawing.Point(409, 126)
        Me.txtsuccess.Name = "txtsuccess"
        Me.txtsuccess.Size = New System.Drawing.Size(138, 20)
        Me.txtsuccess.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Success Of the Team"
        '
        'frmesl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 171)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsuccess)
        Me.Controls.Add(Me.txtroster)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.btninput)
        Me.Controls.Add(Me.btnsetup)
        Me.Name = "frmesl"
        Me.Text = "Emergancy Services Logistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsetup As System.Windows.Forms.Button
    Friend WithEvents btninput As System.Windows.Forms.Button
    Friend WithEvents btndisplay As System.Windows.Forms.Button
    Friend WithEvents txtroster As System.Windows.Forms.TextBox
    Friend WithEvents txtsuccess As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
