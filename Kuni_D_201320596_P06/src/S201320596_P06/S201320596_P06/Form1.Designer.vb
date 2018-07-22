<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrge
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
        Me.btndh = New System.Windows.Forms.Button()
        Me.grdDp = New UJ.ACSSE.UJGrid()
        Me.btndo = New System.Windows.Forms.Button()
        Me.btnElfs = New System.Windows.Forms.Button()
        Me.btnhuman = New System.Windows.Forms.Button()
        Me.btnorc = New System.Windows.Forms.Button()
        Me.btnelf = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblGridText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btndh
        '
        Me.btndh.Location = New System.Drawing.Point(564, 35)
        Me.btndh.Name = "btndh"
        Me.btndh.Size = New System.Drawing.Size(106, 23)
        Me.btndh.TabIndex = 0
        Me.btndh.Text = "Display All Humans"
        Me.btndh.UseVisualStyleBackColor = True
        '
        'grdDp
        '
        Me.grdDp.Cols = 3
        Me.grdDp.FixedCols = 1
        Me.grdDp.FixedRows = 1
        Me.grdDp.Location = New System.Drawing.Point(160, 35)
        Me.grdDp.Name = "grdDp"
        Me.grdDp.Rows = 9
        Me.grdDp.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdDp.Size = New System.Drawing.Size(379, 223)
        Me.grdDp.TabIndex = 1
        '
        'btndo
        '
        Me.btndo.Location = New System.Drawing.Point(564, 64)
        Me.btndo.Name = "btndo"
        Me.btndo.Size = New System.Drawing.Size(106, 23)
        Me.btndo.TabIndex = 0
        Me.btndo.Text = "Display All Orcs"
        Me.btndo.UseVisualStyleBackColor = True
        '
        'btnElfs
        '
        Me.btnElfs.Location = New System.Drawing.Point(564, 93)
        Me.btnElfs.Name = "btnElfs"
        Me.btnElfs.Size = New System.Drawing.Size(106, 23)
        Me.btnElfs.TabIndex = 0
        Me.btnElfs.Text = "Display All Elfs"
        Me.btnElfs.UseVisualStyleBackColor = True
        '
        'btnhuman
        '
        Me.btnhuman.Location = New System.Drawing.Point(39, 35)
        Me.btnhuman.Name = "btnhuman"
        Me.btnhuman.Size = New System.Drawing.Size(99, 23)
        Me.btnhuman.TabIndex = 0
        Me.btnhuman.Text = "Add a Human"
        Me.btnhuman.UseVisualStyleBackColor = True
        '
        'btnorc
        '
        Me.btnorc.Location = New System.Drawing.Point(39, 64)
        Me.btnorc.Name = "btnorc"
        Me.btnorc.Size = New System.Drawing.Size(99, 23)
        Me.btnorc.TabIndex = 0
        Me.btnorc.Text = "Add a Orc"
        Me.btnorc.UseVisualStyleBackColor = True
        '
        'btnelf
        '
        Me.btnelf.Location = New System.Drawing.Point(39, 93)
        Me.btnelf.Name = "btnelf"
        Me.btnelf.Size = New System.Drawing.Size(99, 23)
        Me.btnelf.TabIndex = 0
        Me.btnelf.Text = "Add a Elf"
        Me.btnelf.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(703, 285)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.SystemColors.Control
        Me.RectangleShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape2.CornerRadius = 10
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape2.Location = New System.Drawing.Point(551, 18)
        Me.RectangleShape2.Name = "RectangleShape1"
        Me.RectangleShape2.Size = New System.Drawing.Size(130, 107)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape1.CornerRadius = 10
        Me.RectangleShape1.Location = New System.Drawing.Point(28, 19)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(119, 105)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(561, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "    Click to Display a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " particular race Group"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Click To Add A " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Particular Race"
        '
        'lblGridText
        '
        Me.lblGridText.AutoSize = True
        Me.lblGridText.Location = New System.Drawing.Point(157, 19)
        Me.lblGridText.Name = "lblGridText"
        Me.lblGridText.Size = New System.Drawing.Size(122, 13)
        Me.lblGridText.TabIndex = 3
        Me.lblGridText.Text = "A table showing Nothing"
        '
        'frmrge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 285)
        Me.Controls.Add(Me.lblGridText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdDp)
        Me.Controls.Add(Me.btnelf)
        Me.Controls.Add(Me.btnElfs)
        Me.Controls.Add(Me.btnorc)
        Me.Controls.Add(Me.btndo)
        Me.Controls.Add(Me.btnhuman)
        Me.Controls.Add(Me.btndh)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmrge"
        Me.Text = "Race Group Evaluator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btndh As System.Windows.Forms.Button
    Friend WithEvents grdDp As UJ.ACSSE.UJGrid
    Friend WithEvents btndo As System.Windows.Forms.Button
    Friend WithEvents btnElfs As System.Windows.Forms.Button
    Friend WithEvents btnhuman As System.Windows.Forms.Button
    Friend WithEvents btnorc As System.Windows.Forms.Button
    Friend WithEvents btnelf As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGridText As System.Windows.Forms.Label

End Class
