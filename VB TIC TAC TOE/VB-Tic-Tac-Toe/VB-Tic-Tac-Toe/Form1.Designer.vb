<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baseForm
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
        Me.leftX = New System.Windows.Forms.Button()
        Me.midX = New System.Windows.Forms.Button()
        Me.rightX = New System.Windows.Forms.Button()
        Me.leftY = New System.Windows.Forms.Button()
        Me.midY = New System.Windows.Forms.Button()
        Me.rightY = New System.Windows.Forms.Button()
        Me.leftZ = New System.Windows.Forms.Button()
        Me.midZ = New System.Windows.Forms.Button()
        Me.rightZ = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'leftX
        '
        Me.leftX.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leftX.Location = New System.Drawing.Point(50, 35)
        Me.leftX.Name = "leftX"
        Me.leftX.Size = New System.Drawing.Size(141, 109)
        Me.leftX.TabIndex = 0
        Me.leftX.UseVisualStyleBackColor = True
        '
        'midX
        '
        Me.midX.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midX.Location = New System.Drawing.Point(197, 35)
        Me.midX.Name = "midX"
        Me.midX.Size = New System.Drawing.Size(141, 109)
        Me.midX.TabIndex = 1
        Me.midX.UseVisualStyleBackColor = True
        '
        'rightX
        '
        Me.rightX.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rightX.Location = New System.Drawing.Point(344, 35)
        Me.rightX.Name = "rightX"
        Me.rightX.Size = New System.Drawing.Size(141, 109)
        Me.rightX.TabIndex = 2
        Me.rightX.UseVisualStyleBackColor = True
        '
        'leftY
        '
        Me.leftY.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leftY.Location = New System.Drawing.Point(50, 150)
        Me.leftY.Name = "leftY"
        Me.leftY.Size = New System.Drawing.Size(141, 109)
        Me.leftY.TabIndex = 3
        Me.leftY.UseVisualStyleBackColor = True
        '
        'midY
        '
        Me.midY.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midY.Location = New System.Drawing.Point(197, 150)
        Me.midY.Name = "midY"
        Me.midY.Size = New System.Drawing.Size(141, 109)
        Me.midY.TabIndex = 4
        Me.midY.UseVisualStyleBackColor = True
        '
        'rightY
        '
        Me.rightY.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rightY.Location = New System.Drawing.Point(344, 150)
        Me.rightY.Name = "rightY"
        Me.rightY.Size = New System.Drawing.Size(141, 109)
        Me.rightY.TabIndex = 5
        Me.rightY.UseVisualStyleBackColor = True
        '
        'leftZ
        '
        Me.leftZ.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leftZ.Location = New System.Drawing.Point(50, 265)
        Me.leftZ.Name = "leftZ"
        Me.leftZ.Size = New System.Drawing.Size(141, 109)
        Me.leftZ.TabIndex = 6
        Me.leftZ.UseVisualStyleBackColor = True
        '
        'midZ
        '
        Me.midZ.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midZ.Location = New System.Drawing.Point(197, 265)
        Me.midZ.Name = "midZ"
        Me.midZ.Size = New System.Drawing.Size(141, 109)
        Me.midZ.TabIndex = 7
        Me.midZ.UseVisualStyleBackColor = True
        '
        'rightZ
        '
        Me.rightZ.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rightZ.Location = New System.Drawing.Point(344, 265)
        Me.rightZ.Name = "rightZ"
        Me.rightZ.Size = New System.Drawing.Size(141, 109)
        Me.rightZ.TabIndex = 8
        Me.rightZ.UseVisualStyleBackColor = True
        '
        'baseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 414)
        Me.Controls.Add(Me.rightZ)
        Me.Controls.Add(Me.midZ)
        Me.Controls.Add(Me.leftZ)
        Me.Controls.Add(Me.rightY)
        Me.Controls.Add(Me.midY)
        Me.Controls.Add(Me.leftY)
        Me.Controls.Add(Me.rightX)
        Me.Controls.Add(Me.midX)
        Me.Controls.Add(Me.leftX)
        Me.MaximizeBox = False
        Me.Name = "baseForm"
        Me.ShowIcon = False
        Me.Text = "VB - TicTacToe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents leftX As Button
    Friend WithEvents midX As Button
    Friend WithEvents rightX As Button
    Friend WithEvents leftY As Button
    Friend WithEvents midY As Button
    Friend WithEvents rightY As Button
    Friend WithEvents leftZ As Button
    Friend WithEvents midZ As Button
    Friend WithEvents rightZ As Button
End Class
