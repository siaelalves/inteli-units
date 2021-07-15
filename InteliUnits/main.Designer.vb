<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.lblTt = New System.Windows.Forms.Label()
        Me.txtEnt = New System.Windows.Forms.ComboBox()
        Me.txtSd = New System.Windows.Forms.ComboBox()
        Me.lblEnt = New System.Windows.Forms.Label()
        Me.lblSd = New System.Windows.Forms.Label()
        Me.txtVlSd = New System.Windows.Forms.TextBox()
        Me.txtVlEnt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTt
        '
        Me.lblTt.AutoSize = True
        Me.lblTt.Location = New System.Drawing.Point(12, 9)
        Me.lblTt.Name = "lblTt"
        Me.lblTt.Size = New System.Drawing.Size(119, 13)
        Me.lblTt.TabIndex = 0
        Me.lblTt.Text = "Conversor de unidades:"
        '
        'txtEnt
        '
        Me.txtEnt.FormattingEnabled = True
        Me.txtEnt.Items.AddRange(New Object() {"B", "KB", "MB", "GB"})
        Me.txtEnt.Location = New System.Drawing.Point(157, 51)
        Me.txtEnt.Name = "txtEnt"
        Me.txtEnt.Size = New System.Drawing.Size(77, 21)
        Me.txtEnt.TabIndex = 1
        Me.txtEnt.Text = "B"
        '
        'txtSd
        '
        Me.txtSd.FormattingEnabled = True
        Me.txtSd.Items.AddRange(New Object() {"B", "KB", "MB", "GB"})
        Me.txtSd.Location = New System.Drawing.Point(382, 51)
        Me.txtSd.Name = "txtSd"
        Me.txtSd.Size = New System.Drawing.Size(77, 21)
        Me.txtSd.TabIndex = 2
        Me.txtSd.Text = "B"
        '
        'lblEnt
        '
        Me.lblEnt.AutoSize = True
        Me.lblEnt.Location = New System.Drawing.Point(12, 33)
        Me.lblEnt.Name = "lblEnt"
        Me.lblEnt.Size = New System.Drawing.Size(47, 13)
        Me.lblEnt.TabIndex = 5
        Me.lblEnt.Text = "Entrada:"
        '
        'lblSd
        '
        Me.lblSd.AutoSize = True
        Me.lblSd.Location = New System.Drawing.Point(237, 33)
        Me.lblSd.Name = "lblSd"
        Me.lblSd.Size = New System.Drawing.Size(39, 13)
        Me.lblSd.TabIndex = 6
        Me.lblSd.Text = "Saída:"
        '
        'txtVlSd
        '
        Me.txtVlSd.Location = New System.Drawing.Point(240, 52)
        Me.txtVlSd.Name = "txtVlSd"
        Me.txtVlSd.ReadOnly = True
        Me.txtVlSd.Size = New System.Drawing.Size(136, 20)
        Me.txtVlSd.TabIndex = 7
        Me.txtVlSd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVlEnt
        '
        Me.txtVlEnt.Location = New System.Drawing.Point(15, 51)
        Me.txtVlEnt.Name = "txtVlEnt"
        Me.txtVlEnt.Size = New System.Drawing.Size(136, 20)
        Me.txtVlEnt.TabIndex = 8
        Me.txtVlEnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 87)
        Me.Controls.Add(Me.txtVlEnt)
        Me.Controls.Add(Me.txtVlSd)
        Me.Controls.Add(Me.lblSd)
        Me.Controls.Add(Me.lblEnt)
        Me.Controls.Add(Me.txtSd)
        Me.Controls.Add(Me.txtEnt)
        Me.Controls.Add(Me.lblTt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "I N T E L I   U N I T S"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTt As System.Windows.Forms.Label
    Friend WithEvents txtEnt As System.Windows.Forms.ComboBox
    Friend WithEvents txtSd As System.Windows.Forms.ComboBox
    Friend WithEvents lblEnt As System.Windows.Forms.Label
    Friend WithEvents lblSd As System.Windows.Forms.Label
    Friend WithEvents txtVlSd As System.Windows.Forms.TextBox
    Friend WithEvents txtVlEnt As System.Windows.Forms.TextBox

End Class
