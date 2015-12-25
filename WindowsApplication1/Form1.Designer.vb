<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lstbxIntNum = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(437, 111)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(265, 91)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lstbxIntNum
        '
        Me.lstbxIntNum.FormattingEnabled = True
        Me.lstbxIntNum.Location = New System.Drawing.Point(24, 111)
        Me.lstbxIntNum.Name = "lstbxIntNum"
        Me.lstbxIntNum.Size = New System.Drawing.Size(373, 368)
        Me.lstbxIntNum.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(437, 252)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(265, 91)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "DELETE SELECTED"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(18, 18)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(379, 42)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Carlo Nino Mabalatan"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(430, 18)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(165, 42)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "1599017"
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAll.Location = New System.Drawing.Point(437, 388)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(265, 91)
        Me.btnDeleteAll.TabIndex = 5
        Me.btnDeleteAll.Text = "DELETE ALL"
        Me.btnDeleteAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 534)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lstbxIntNum)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lstbxIntNum As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button

End Class
