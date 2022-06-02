<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRunExisting = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRunExisting
        '
        Me.btnRunExisting.Location = New System.Drawing.Point(191, 85)
        Me.btnRunExisting.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRunExisting.Name = "btnRunExisting"
        Me.btnRunExisting.Size = New System.Drawing.Size(294, 70)
        Me.btnRunExisting.TabIndex = 1
        Me.btnRunExisting.Text = "Run MdiDesigner"
        Me.btnRunExisting.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 249)
        Me.Controls.Add(Me.btnRunExisting)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Name = "Form1"
        Me.Text = "MdiDesigner"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRunExisting As System.Windows.Forms.Button

End Class
