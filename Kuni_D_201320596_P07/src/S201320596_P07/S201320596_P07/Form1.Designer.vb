<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArties
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
        Me.btnaddPro = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txthigh = New System.Windows.Forms.TextBox()
        Me.txtave = New System.Windows.Forms.TextBox()
        Me.btntest = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsetup
        '
        Me.btnsetup.Location = New System.Drawing.Point(12, 12)
        Me.btnsetup.Name = "btnsetup"
        Me.btnsetup.Size = New System.Drawing.Size(149, 23)
        Me.btnsetup.TabIndex = 0
        Me.btnsetup.Text = "Setup Application"
        Me.btnsetup.UseVisualStyleBackColor = True
        '
        'btnaddPro
        '
        Me.btnaddPro.Location = New System.Drawing.Point(12, 41)
        Me.btnaddPro.Name = "btnaddPro"
        Me.btnaddPro.Size = New System.Drawing.Size(149, 23)
        Me.btnaddPro.TabIndex = 1
        Me.btnaddPro.Text = "Input Production Data"
        Me.btnaddPro.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(170, 25)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisplay.Size = New System.Drawing.Size(380, 184)
        Me.txtDisplay.TabIndex = 2
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 70)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(149, 23)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display Production Data"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "The value of the highest Score of all eligible productions :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "The Average Score of all eligible productions :"
        '
        'txthigh
        '
        Me.txthigh.Location = New System.Drawing.Point(450, 241)
        Me.txthigh.Name = "txthigh"
        Me.txthigh.ReadOnly = True
        Me.txthigh.Size = New System.Drawing.Size(100, 20)
        Me.txthigh.TabIndex = 5
        '
        'txtave
        '
        Me.txtave.Location = New System.Drawing.Point(450, 215)
        Me.txtave.Name = "txtave"
        Me.txtave.ReadOnly = True
        Me.txtave.Size = New System.Drawing.Size(100, 20)
        Me.txtave.TabIndex = 5
        '
        'btntest
        '
        Me.btntest.Location = New System.Drawing.Point(12, 99)
        Me.btntest.Name = "btntest"
        Me.btntest.Size = New System.Drawing.Size(149, 23)
        Me.btntest.TabIndex = 3
        Me.btntest.Text = "Use sample data"
        Me.btntest.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(387, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = " A table showing the UJ Arts Centre’s annual award's various theatre productions"
        '
        'frmArties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 307)
        Me.Controls.Add(Me.txtave)
        Me.Controls.Add(Me.txthigh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btntest)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnaddPro)
        Me.Controls.Add(Me.btnsetup)
        Me.Name = "frmArties"
        Me.Text = "UJ Arts Centre’s annual award ceremony Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsetup As System.Windows.Forms.Button
    Friend WithEvents btnaddPro As System.Windows.Forms.Button
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txthigh As System.Windows.Forms.TextBox
    Friend WithEvents txtave As System.Windows.Forms.TextBox
    Friend WithEvents btntest As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
