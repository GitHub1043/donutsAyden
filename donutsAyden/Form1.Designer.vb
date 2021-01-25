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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDonuts = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblPack = New System.Windows.Forms.Label()
        Me.lblLeftovers = New System.Windows.Forms.Label()
        Me.btnShip = New System.Windows.Forms.Button()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(101, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Donuts"
        '
        'lblDonuts
        '
        Me.lblDonuts.AutoSize = True
        Me.lblDonuts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonuts.Location = New System.Drawing.Point(22, 99)
        Me.lblDonuts.Name = "lblDonuts"
        Me.lblDonuts.Size = New System.Drawing.Size(174, 24)
        Me.lblDonuts.TabIndex = 1
        Me.lblDonuts.Text = "How Many Donuts?"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(202, 104)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 2
        '
        'lblPack
        '
        Me.lblPack.AutoSize = True
        Me.lblPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPack.Location = New System.Drawing.Point(22, 259)
        Me.lblPack.Name = "lblPack"
        Me.lblPack.Size = New System.Drawing.Size(80, 24)
        Me.lblPack.TabIndex = 3
        Me.lblPack.Text = "Packs: 0"
        '
        'lblLeftovers
        '
        Me.lblLeftovers.AutoSize = True
        Me.lblLeftovers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeftovers.Location = New System.Drawing.Point(22, 331)
        Me.lblLeftovers.Name = "lblLeftovers"
        Me.lblLeftovers.Size = New System.Drawing.Size(105, 24)
        Me.lblLeftovers.TabIndex = 4
        Me.lblLeftovers.Text = "Leftovers: 0"
        '
        'btnShip
        '
        Me.btnShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShip.Location = New System.Drawing.Point(26, 191)
        Me.btnShip.Name = "btnShip"
        Me.btnShip.Size = New System.Drawing.Size(85, 32)
        Me.btnShip.TabIndex = 5
        Me.btnShip.Text = "Ship"
        Me.btnShip.UseVisualStyleBackColor = True
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Location = New System.Drawing.Point(23, 427)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(90, 13)
        Me.lblLeft.TabIndex = 6
        Me.lblLeft.Text = "Total Leftovers: 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 449)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.btnShip)
        Me.Controls.Add(Me.lblLeftovers)
        Me.Controls.Add(Me.lblPack)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblDonuts)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDonuts As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblPack As System.Windows.Forms.Label
    Friend WithEvents lblLeftovers As System.Windows.Forms.Label
    Friend WithEvents btnShip As System.Windows.Forms.Button
    Friend WithEvents lblLeft As System.Windows.Forms.Label

End Class
