<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUPD
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
        Me.grdDisplay = New UJ.ACSSE.UJGrid()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.txtfencing = New System.Windows.Forms.TextBox()
        Me.txtlaundering = New System.Windows.Forms.TextBox()
        Me.txtfraud = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnfraud = New System.Windows.Forms.Button()
        Me.btnfence = New System.Windows.Forms.Button()
        Me.btnlaunder = New System.Windows.Forms.Button()
        Me.lblgrid = New System.Windows.Forms.Label()
        Me.btndisplayfr = New System.Windows.Forms.Button()
        Me.btndisplayl = New System.Windows.Forms.Button()
        Me.btndisplayfe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grdDisplay
        '
        Me.grdDisplay.Cols = 3
        Me.grdDisplay.FixedCols = 1
        Me.grdDisplay.FixedRows = 1
        Me.grdDisplay.Location = New System.Drawing.Point(25, 183)
        Me.grdDisplay.Name = "grdDisplay"
        Me.grdDisplay.Rows = 6
        Me.grdDisplay.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdDisplay.Size = New System.Drawing.Size(437, 161)
        Me.grdDisplay.TabIndex = 0
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(188, 102)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(100, 23)
        Me.btnSetup.TabIndex = 1
        Me.btnSetup.Text = "Enter Settings"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'txtfencing
        '
        Me.txtfencing.Location = New System.Drawing.Point(188, 50)
        Me.txtfencing.Name = "txtfencing"
        Me.txtfencing.Size = New System.Drawing.Size(100, 20)
        Me.txtfencing.TabIndex = 2
        '
        'txtlaundering
        '
        Me.txtlaundering.Location = New System.Drawing.Point(188, 76)
        Me.txtlaundering.Name = "txtlaundering"
        Me.txtlaundering.Size = New System.Drawing.Size(100, 20)
        Me.txtlaundering.TabIndex = 2
        '
        'txtfraud
        '
        Me.txtfraud.Location = New System.Drawing.Point(188, 24)
        Me.txtfraud.Name = "txtfraud"
        Me.txtfraud.Size = New System.Drawing.Size(100, 20)
        Me.txtfraud.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Number of Fraud cases:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number of Fencing Cases:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Number of Laundering cases:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Program Settings"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(485, 356)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape1.CornerRadius = 10
        Me.RectangleShape1.Location = New System.Drawing.Point(25, 16)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(277, 115)
        '
        'btnfraud
        '
        Me.btnfraud.Location = New System.Drawing.Point(317, 21)
        Me.btnfraud.Name = "btnfraud"
        Me.btnfraud.Size = New System.Drawing.Size(145, 23)
        Me.btnfraud.TabIndex = 1
        Me.btnfraud.Text = "Enter Data for Frauding"
        Me.btnfraud.UseVisualStyleBackColor = True
        '
        'btnfence
        '
        Me.btnfence.Location = New System.Drawing.Point(317, 50)
        Me.btnfence.Name = "btnfence"
        Me.btnfence.Size = New System.Drawing.Size(145, 23)
        Me.btnfence.TabIndex = 1
        Me.btnfence.Text = "Enter Data for Fencing"
        Me.btnfence.UseVisualStyleBackColor = True
        '
        'btnlaunder
        '
        Me.btnlaunder.Location = New System.Drawing.Point(317, 78)
        Me.btnlaunder.Name = "btnlaunder"
        Me.btnlaunder.Size = New System.Drawing.Size(145, 23)
        Me.btnlaunder.TabIndex = 1
        Me.btnlaunder.Text = "Enter Data for Laundering"
        Me.btnlaunder.UseVisualStyleBackColor = True
        '
        'lblgrid
        '
        Me.lblgrid.AutoSize = True
        Me.lblgrid.Location = New System.Drawing.Point(22, 167)
        Me.lblgrid.Name = "lblgrid"
        Me.lblgrid.Size = New System.Drawing.Size(122, 13)
        Me.lblgrid.TabIndex = 3
        Me.lblgrid.Text = "A table showing Nothing"
        '
        'btndisplayfr
        '
        Me.btndisplayfr.Location = New System.Drawing.Point(41, 141)
        Me.btndisplayfr.Name = "btndisplayfr"
        Me.btndisplayfr.Size = New System.Drawing.Size(132, 23)
        Me.btndisplayfr.TabIndex = 5
        Me.btndisplayfr.Text = "Display Fraud Cases"
        Me.btndisplayfr.UseVisualStyleBackColor = True
        '
        'btndisplayl
        '
        Me.btndisplayl.Location = New System.Drawing.Point(317, 141)
        Me.btndisplayl.Name = "btndisplayl"
        Me.btndisplayl.Size = New System.Drawing.Size(132, 23)
        Me.btndisplayl.TabIndex = 5
        Me.btndisplayl.Text = "Display Laundery cases"
        Me.btndisplayl.UseVisualStyleBackColor = True
        '
        'btndisplayfe
        '
        Me.btndisplayfe.Location = New System.Drawing.Point(179, 141)
        Me.btndisplayfe.Name = "btndisplayfe"
        Me.btndisplayfe.Size = New System.Drawing.Size(132, 23)
        Me.btndisplayfe.TabIndex = 5
        Me.btndisplayfe.Text = "Display Fencing cases"
        Me.btndisplayfe.UseVisualStyleBackColor = True
        '
        'frmUPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 356)
        Me.Controls.Add(Me.btndisplayfe)
        Me.Controls.Add(Me.btndisplayl)
        Me.Controls.Add(Me.btndisplayfr)
        Me.Controls.Add(Me.lblgrid)
        Me.Controls.Add(Me.btnlaunder)
        Me.Controls.Add(Me.btnfence)
        Me.Controls.Add(Me.btnfraud)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtlaundering)
        Me.Controls.Add(Me.txtfraud)
        Me.Controls.Add(Me.txtfencing)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.grdDisplay)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmUPD"
        Me.Text = "Utopian Police Department"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdDisplay As UJ.ACSSE.UJGrid
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents txtfencing As System.Windows.Forms.TextBox
    Friend WithEvents txtlaundering As System.Windows.Forms.TextBox
    Friend WithEvents txtfraud As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnfraud As System.Windows.Forms.Button
    Friend WithEvents btnfence As System.Windows.Forms.Button
    Friend WithEvents btnlaunder As System.Windows.Forms.Button
    Friend WithEvents lblgrid As System.Windows.Forms.Label
    Friend WithEvents btndisplayfr As System.Windows.Forms.Button
    Friend WithEvents btndisplayl As System.Windows.Forms.Button
    Friend WithEvents btndisplayfe As System.Windows.Forms.Button

End Class
