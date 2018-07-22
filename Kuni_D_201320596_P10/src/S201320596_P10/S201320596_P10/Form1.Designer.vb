<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIG
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
        Me.msIGmenu = New System.Windows.Forms.MenuStrip()
        Me.tsmOps = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAddrec = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCreate = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmStadiumOps = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmNumbStadiums = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAssign = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmWindowops = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSwindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExtra = New System.Windows.Forms.ToolStripMenuItem()
        Me.tcStadium = New System.Windows.Forms.TabControl()
        Me.tpNormal = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIG = New System.Windows.Forms.TextBox()
        Me.tpExtra = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtextra = New System.Windows.Forms.TextBox()
        Me.msIGmenu.SuspendLayout()
        Me.tcStadium.SuspendLayout()
        Me.tpNormal.SuspendLayout()
        Me.tpExtra.SuspendLayout()
        Me.SuspendLayout()
        '
        'msIGmenu
        '
        Me.msIGmenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.msIGmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOps, Me.tsmStadiumOps, Me.tsmWindowops})
        Me.msIGmenu.Location = New System.Drawing.Point(0, 0)
        Me.msIGmenu.Name = "msIGmenu"
        Me.msIGmenu.Size = New System.Drawing.Size(328, 24)
        Me.msIGmenu.TabIndex = 0
        Me.msIGmenu.Text = "IG Menu"
        '
        'tsmOps
        '
        Me.tsmOps.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAddrec, Me.tsmCreate})
        Me.tsmOps.Name = "tsmOps"
        Me.tsmOps.Size = New System.Drawing.Size(82, 20)
        Me.tsmOps.Text = "File Options"
        '
        'tsmAddrec
        '
        Me.tsmAddrec.Name = "tsmAddrec"
        Me.tsmAddrec.Size = New System.Drawing.Size(251, 22)
        Me.tsmAddrec.Text = "Add A Record to file"
        '
        'tsmCreate
        '
        Me.tsmCreate.Name = "tsmCreate"
        Me.tsmCreate.Size = New System.Drawing.Size(251, 22)
        Me.tsmCreate.Text = "Create The File ( Only Click Once)"
        '
        'tsmStadiumOps
        '
        Me.tsmStadiumOps.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNumbStadiums, Me.tsmSDetails, Me.tsmAssign, Me.tsmDisplay})
        Me.tsmStadiumOps.Name = "tsmStadiumOps"
        Me.tsmStadiumOps.Size = New System.Drawing.Size(108, 20)
        Me.tsmStadiumOps.Text = "Stadium Options"
        '
        'tsmNumbStadiums
        '
        Me.tsmNumbStadiums.Name = "tsmNumbStadiums"
        Me.tsmNumbStadiums.Size = New System.Drawing.Size(268, 22)
        Me.tsmNumbStadiums.Text = "Enter Number Of Stadiums"
        '
        'tsmSDetails
        '
        Me.tsmSDetails.Name = "tsmSDetails"
        Me.tsmSDetails.Size = New System.Drawing.Size(268, 22)
        Me.tsmSDetails.Text = "Enter All Stadium Details"
        '
        'tsmAssign
        '
        Me.tsmAssign.Name = "tsmAssign"
        Me.tsmAssign.Size = New System.Drawing.Size(268, 22)
        Me.tsmAssign.Text = "Assign a Facility Record to a Stadium"
        '
        'tsmDisplay
        '
        Me.tsmDisplay.Name = "tsmDisplay"
        Me.tsmDisplay.Size = New System.Drawing.Size(268, 22)
        Me.tsmDisplay.Text = "Display Stadium Data"
        '
        'tsmWindowops
        '
        Me.tsmWindowops.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSwindow, Me.tsmExtra})
        Me.tsmWindowops.Name = "tsmWindowops"
        Me.tsmWindowops.Size = New System.Drawing.Size(108, 20)
        Me.tsmWindowops.Text = "Window Options"
        '
        'tsmSwindow
        '
        Me.tsmSwindow.Name = "tsmSwindow"
        Me.tsmSwindow.Size = New System.Drawing.Size(221, 22)
        Me.tsmSwindow.Text = "View Stadium Window"
        '
        'tsmExtra
        '
        Me.tsmExtra.Name = "tsmExtra"
        Me.tsmExtra.Size = New System.Drawing.Size(221, 22)
        Me.tsmExtra.Text = "View Stadium Extra Window"
        '
        'tcStadium
        '
        Me.tcStadium.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.tcStadium.Controls.Add(Me.tpNormal)
        Me.tcStadium.Controls.Add(Me.tpExtra)
        Me.tcStadium.Location = New System.Drawing.Point(-11, 12)
        Me.tcStadium.Multiline = True
        Me.tcStadium.Name = "tcStadium"
        Me.tcStadium.SelectedIndex = 0
        Me.tcStadium.Size = New System.Drawing.Size(604, 392)
        Me.tcStadium.TabIndex = 1
        '
        'tpNormal
        '
        Me.tpNormal.Controls.Add(Me.Label1)
        Me.tpNormal.Controls.Add(Me.txtIG)
        Me.tpNormal.Location = New System.Drawing.Point(4, 4)
        Me.tpNormal.Name = "tpNormal"
        Me.tpNormal.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNormal.Size = New System.Drawing.Size(577, 384)
        Me.tpNormal.TabIndex = 0
        Me.tpNormal.Text = "Normal Stuff"
        Me.tpNormal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "A Table Showing all the Stadiums Details"
        '
        'txtIG
        '
        Me.txtIG.Location = New System.Drawing.Point(18, 34)
        Me.txtIG.Multiline = True
        Me.txtIG.Name = "txtIG"
        Me.txtIG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIG.Size = New System.Drawing.Size(306, 193)
        Me.txtIG.TabIndex = 2
        '
        'tpExtra
        '
        Me.tpExtra.Controls.Add(Me.Label2)
        Me.tpExtra.Controls.Add(Me.txtextra)
        Me.tpExtra.Location = New System.Drawing.Point(4, 4)
        Me.tpExtra.Name = "tpExtra"
        Me.tpExtra.Padding = New System.Windows.Forms.Padding(3)
        Me.tpExtra.Size = New System.Drawing.Size(577, 384)
        Me.tpExtra.TabIndex = 1
        Me.tpExtra.Text = "extras"
        Me.tpExtra.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(19, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "A table Showing Stadiums that needs upgrading"
        '
        'txtextra
        '
        Me.txtextra.Location = New System.Drawing.Point(19, 42)
        Me.txtextra.Multiline = True
        Me.txtextra.Name = "txtextra"
        Me.txtextra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtextra.Size = New System.Drawing.Size(301, 157)
        Me.txtextra.TabIndex = 0
        '
        'frmIG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 256)
        Me.Controls.Add(Me.msIGmenu)
        Me.Controls.Add(Me.tcStadium)
        Me.MainMenuStrip = Me.msIGmenu
        Me.Name = "frmIG"
        Me.Text = "Intergalactic Games 2020"
        Me.msIGmenu.ResumeLayout(False)
        Me.msIGmenu.PerformLayout()
        Me.tcStadium.ResumeLayout(False)
        Me.tpNormal.ResumeLayout(False)
        Me.tpNormal.PerformLayout()
        Me.tpExtra.ResumeLayout(False)
        Me.tpExtra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msIGmenu As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmOps As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAddrec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCreate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmStadiumOps As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmNumbStadiums As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAssign As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDisplay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tcStadium As System.Windows.Forms.TabControl
    Friend WithEvents tpNormal As System.Windows.Forms.TabPage
    Friend WithEvents txtIG As System.Windows.Forms.TextBox
    Friend WithEvents tpExtra As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsmWindowops As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSwindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmExtra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtextra As System.Windows.Forms.TextBox

End Class
