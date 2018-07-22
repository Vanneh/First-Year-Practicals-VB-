<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrip
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
        Me.btnenter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtans = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdirt = New System.Windows.Forms.TextBox()
        Me.btnenter2 = New System.Windows.Forms.Button()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnenter
        '
        Me.btnenter.Location = New System.Drawing.Point(435, 69)
        Me.btnenter.Name = "btnenter"
        Me.btnenter.Size = New System.Drawing.Size(100, 23)
        Me.btnenter.TabIndex = 0
        Me.btnenter.Text = "Enter"
        Me.btnenter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":Enter a word to clean"
        '
        'txtword
        '
        Me.txtword.Location = New System.Drawing.Point(435, 43)
        Me.txtword.Name = "txtword"
        Me.txtword.Size = New System.Drawing.Size(100, 20)
        Me.txtword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(329, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "The Cleaned Word:"
        '
        'txtans
        '
        Me.txtans.Location = New System.Drawing.Point(435, 98)
        Me.txtans.Name = "txtans"
        Me.txtans.Size = New System.Drawing.Size(100, 20)
        Me.txtans.TabIndex = 2
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(561, 168)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.SystemColors.Control
        Me.RectangleShape2.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.RectangleShape2.CornerRadius = 10
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape2.Location = New System.Drawing.Point(4, 32)
        Me.RectangleShape2.Name = "RectangleShape1"
        Me.RectangleShape2.Size = New System.Drawing.Size(233, 101)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.RectangleShape1.CornerRadius = 10
        Me.RectangleShape1.Location = New System.Drawing.Point(312, 32)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(233, 101)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(355, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Recursive Version"
        '
        'txtdirt
        '
        Me.txtdirt.Location = New System.Drawing.Point(12, 43)
        Me.txtdirt.Name = "txtdirt"
        Me.txtdirt.Size = New System.Drawing.Size(100, 20)
        Me.txtdirt.TabIndex = 4
        '
        'btnenter2
        '
        Me.btnenter2.Location = New System.Drawing.Point(12, 69)
        Me.btnenter2.Name = "btnenter2"
        Me.btnenter2.Size = New System.Drawing.Size(100, 23)
        Me.btnenter2.TabIndex = 5
        Me.btnenter2.Text = "Enter"
        Me.btnenter2.UseVisualStyleBackColor = True
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(12, 98)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(100, 20)
        Me.txtanswer.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = ":The Cleaned Word"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Enter a word to clean:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Iterative Version"
        '
        'frmrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 168)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.btnenter2)
        Me.Controls.Add(Me.txtdirt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtans)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnenter)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmrip"
        Me.Text = "Recursion and Iterative practical"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnenter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtans As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdirt As System.Windows.Forms.TextBox
    Friend WithEvents btnenter2 As System.Windows.Forms.Button
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
