<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGDU
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnOps = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCreate = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnenterInfo = New System.Windows.Forms.Button()
        Me.btnAveBudget = New System.Windows.Forms.Button()
        Me.txtAve = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.txthigh = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOps})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(465, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "msOtherOps"
        '
        'btnOps
        '
        Me.btnOps.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCreate, Me.btnSave})
        Me.btnOps.Name = "btnOps"
        Me.btnOps.Size = New System.Drawing.Size(82, 20)
        Me.btnOps.Text = "File Options"
        '
        'btnCreate
        '
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(250, 22)
        Me.btnCreate.Text = "Create file (click when Necessary)"
        '
        'btnSave
        '
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(250, 22)
        Me.btnSave.Text = "Save Data to File"
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(12, 27)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisplay.Size = New System.Drawing.Size(275, 203)
        Me.txtDisplay.TabIndex = 1
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(294, 47)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(140, 23)
        Me.btnSetup.TabIndex = 2
        Me.btnSetup.Text = "Initalize Application"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnenterInfo
        '
        Me.btnenterInfo.Location = New System.Drawing.Point(294, 77)
        Me.btnenterInfo.Name = "btnenterInfo"
        Me.btnenterInfo.Size = New System.Drawing.Size(140, 23)
        Me.btnenterInfo.TabIndex = 3
        Me.btnenterInfo.Text = "Enter Information"
        Me.btnenterInfo.UseVisualStyleBackColor = True
        '
        'btnAveBudget
        '
        Me.btnAveBudget.Location = New System.Drawing.Point(294, 106)
        Me.btnAveBudget.Name = "btnAveBudget"
        Me.btnAveBudget.Size = New System.Drawing.Size(140, 35)
        Me.btnAveBudget.TabIndex = 3
        Me.btnAveBudget.Text = "Calculate Average Proposed Budget "
        Me.btnAveBudget.UseVisualStyleBackColor = True
        '
        'txtAve
        '
        Me.txtAve.Location = New System.Drawing.Point(293, 180)
        Me.txtAve.Name = "txtAve"
        Me.txtAve.Size = New System.Drawing.Size(155, 20)
        Me.txtAve.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "The Average proposed budget:"
        '
        'btnHigh
        '
        Me.btnHigh.Location = New System.Drawing.Point(12, 236)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(240, 23)
        Me.btnHigh.TabIndex = 6
        Me.btnHigh.Text = "Display Minister With Highest Portfolio from file"
        Me.btnHigh.UseVisualStyleBackColor = True
        '
        'txthigh
        '
        Me.txthigh.Location = New System.Drawing.Point(12, 278)
        Me.txthigh.Name = "txthigh"
        Me.txthigh.Size = New System.Drawing.Size(275, 20)
        Me.txthigh.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Minister with the highest Portfolio:"
        '
        'frmGDU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 312)
        Me.Controls.Add(Me.txthigh)
        Me.Controls.Add(Me.btnHigh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAve)
        Me.Controls.Add(Me.btnAveBudget)
        Me.Controls.Add(Me.btnenterInfo)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGDU"
        Me.Text = "Grand Duchy of Utopia"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnOps As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCreate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents btnenterInfo As System.Windows.Forms.Button
    Friend WithEvents btnAveBudget As System.Windows.Forms.Button
    Friend WithEvents txtAve As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHigh As System.Windows.Forms.Button
    Friend WithEvents txthigh As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
