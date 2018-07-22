<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCPLA
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
        Me.grddisplayRum = New UJ.ACSSE.UJGrid()
        Me.grdDisplayGrog = New UJ.ACSSE.UJGrid()
        Me.grdDisplayBooty = New UJ.ACSSE.UJGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtrum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtgrog = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtboot = New System.Windows.Forms.TextBox()
        Me.tsmFlieOps = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCreate = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmAddmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRum = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmGrog = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmBooty = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmextra = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEnterEx = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDrinks = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmgraderum = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmgradegrog = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExBoot = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grddisplayRum
        '
        Me.grddisplayRum.FixedCols = 1
        Me.grddisplayRum.FixedRows = 1
        Me.grddisplayRum.Location = New System.Drawing.Point(12, 54)
        Me.grddisplayRum.Name = "grddisplayRum"
        Me.grddisplayRum.Rows = 6
        Me.grddisplayRum.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grddisplayRum.Size = New System.Drawing.Size(446, 159)
        Me.grddisplayRum.TabIndex = 0
        '
        'grdDisplayGrog
        '
        Me.grdDisplayGrog.FixedCols = 1
        Me.grdDisplayGrog.FixedRows = 1
        Me.grdDisplayGrog.Location = New System.Drawing.Point(12, 232)
        Me.grdDisplayGrog.Name = "grdDisplayGrog"
        Me.grdDisplayGrog.Rows = 5
        Me.grdDisplayGrog.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdDisplayGrog.Size = New System.Drawing.Size(446, 137)
        Me.grdDisplayGrog.TabIndex = 0
        '
        'grdDisplayBooty
        '
        Me.grdDisplayBooty.FixedCols = 1
        Me.grdDisplayBooty.FixedRows = 1
        Me.grdDisplayBooty.Location = New System.Drawing.Point(12, 388)
        Me.grdDisplayBooty.Name = "grdDisplayBooty"
        Me.grdDisplayBooty.Rows = 4
        Me.grdDisplayBooty.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdDisplayBooty.Size = New System.Drawing.Size(446, 113)
        Me.grdDisplayBooty.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A table showing All the Captains Rums"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A table showing All the Captains Grogs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "A table showing All the Captains Booties(Not Nicky Minaj)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(468, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Number Of A-Rated " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rum Bottles :"
        '
        'txtrum
        '
        Me.txtrum.Location = New System.Drawing.Point(471, 83)
        Me.txtrum.Name = "txtrum"
        Me.txtrum.Size = New System.Drawing.Size(95, 20)
        Me.txtrum.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(468, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 26)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Number Of C-Rated " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grog Bottles :"
        '
        'txtgrog
        '
        Me.txtgrog.Location = New System.Drawing.Point(471, 261)
        Me.txtgrog.Name = "txtgrog"
        Me.txtgrog.Size = New System.Drawing.Size(95, 20)
        Me.txtgrog.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(464, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Value Of All Booty :"
        '
        'txtboot
        '
        Me.txtboot.Location = New System.Drawing.Point(471, 404)
        Me.txtboot.Name = "txtboot"
        Me.txtboot.Size = New System.Drawing.Size(91, 20)
        Me.txtboot.TabIndex = 8
        '
        'tsmFlieOps
        '
        Me.tsmFlieOps.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCreate, Me.tsmSave, Me.tsmDisplay})
        Me.tsmFlieOps.Name = "tsmFlieOps"
        Me.tsmFlieOps.Size = New System.Drawing.Size(82, 20)
        Me.tsmFlieOps.Text = "File Options"
        '
        'tsmCreate
        '
        Me.tsmCreate.Name = "tsmCreate"
        Me.tsmCreate.Size = New System.Drawing.Size(251, 22)
        Me.tsmCreate.Text = "Create The Files ( Clickonly Once)"
        '
        'tsmSave
        '
        Me.tsmSave.Name = "tsmSave"
        Me.tsmSave.Size = New System.Drawing.Size(251, 22)
        Me.tsmSave.Text = "Save Data To Files"
        '
        'tsmDisplay
        '
        Me.tsmDisplay.Name = "tsmDisplay"
        Me.tsmDisplay.Size = New System.Drawing.Size(251, 22)
        Me.tsmDisplay.Text = "Display Data From Files"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFlieOps, Me.tsmAddmenu, Me.tsmextra})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(587, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MsCPLA"
        '
        'tsmAddmenu
        '
        Me.tsmAddmenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmRum, Me.tsmGrog, Me.tsmBooty})
        Me.tsmAddmenu.Name = "tsmAddmenu"
        Me.tsmAddmenu.Size = New System.Drawing.Size(122, 20)
        Me.tsmAddmenu.Text = "Add a Pillaged Item"
        '
        'tsmRum
        '
        Me.tsmRum.Name = "tsmRum"
        Me.tsmRum.Size = New System.Drawing.Size(199, 22)
        Me.tsmRum.Text = "Bottle Of Rum"
        '
        'tsmGrog
        '
        Me.tsmGrog.Name = "tsmGrog"
        Me.tsmGrog.Size = New System.Drawing.Size(199, 22)
        Me.tsmGrog.Text = "Bottle Of Grog"
        '
        'tsmBooty
        '
        Me.tsmBooty.Name = "tsmBooty"
        Me.tsmBooty.Size = New System.Drawing.Size(199, 22)
        Me.tsmBooty.Text = "Booty(Not Nicky Minaj)"
        '
        'tsmextra
        '
        Me.tsmextra.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmEnterEx, Me.tsmDrinks, Me.tsmExBoot})
        Me.tsmextra.Name = "tsmextra"
        Me.tsmextra.Size = New System.Drawing.Size(71, 20)
        Me.tsmextra.Text = "Extra stuff"
        '
        'tsmEnterEx
        '
        Me.tsmEnterEx.Name = "tsmEnterEx"
        Me.tsmEnterEx.Size = New System.Drawing.Size(189, 22)
        Me.tsmEnterEx.Text = "Enter Exchange Rate"
        '
        'tsmDrinks
        '
        Me.tsmDrinks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmgraderum, Me.tsmgradegrog})
        Me.tsmDrinks.Name = "tsmDrinks"
        Me.tsmDrinks.Size = New System.Drawing.Size(189, 22)
        Me.tsmDrinks.Text = "Calculate Drinks :"
        '
        'tsmgraderum
        '
        Me.tsmgraderum.Name = "tsmgraderum"
        Me.tsmgraderum.Size = New System.Drawing.Size(247, 22)
        Me.tsmgraderum.Text = "Number Of A grade Rum Bottles"
        '
        'tsmgradegrog
        '
        Me.tsmgradegrog.Name = "tsmgradegrog"
        Me.tsmgradegrog.Size = New System.Drawing.Size(247, 22)
        Me.tsmgradegrog.Text = "Number Of C Grade Grog Bottles"
        '
        'tsmExBoot
        '
        Me.tsmExBoot.Name = "tsmExBoot"
        Me.tsmExBoot.Size = New System.Drawing.Size(189, 22)
        Me.tsmExBoot.Text = "Exchange The Booties"
        '
        'frmCPLA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 510)
        Me.Controls.Add(Me.txtboot)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtgrog)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtrum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdDisplayBooty)
        Me.Controls.Add(Me.grdDisplayGrog)
        Me.Controls.Add(Me.grddisplayRum)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCPLA"
        Me.Text = "The Captains Pillage Log Application"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grddisplayRum As UJ.ACSSE.UJGrid
    Friend WithEvents grdDisplayGrog As UJ.ACSSE.UJGrid
    Friend WithEvents grdDisplayBooty As UJ.ACSSE.UJGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtrum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtgrog As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtboot As System.Windows.Forms.TextBox
    Friend WithEvents tsmFlieOps As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCreate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDisplay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmAddmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRum As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmGrog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmBooty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmextra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEnterEx As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDrinks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmgraderum As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmgradegrog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmExBoot As System.Windows.Forms.ToolStripMenuItem

End Class
