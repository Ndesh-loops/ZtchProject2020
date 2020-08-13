<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pay
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
        Me.Mpesa = New System.Windows.Forms.Label()
        Me.PaymentOptionsComboBox = New System.Windows.Forms.ComboBox()
        Me.GrandTotalTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.VATTextBox = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PayButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Mpesa
        '
        Me.Mpesa.AutoSize = True
        Me.Mpesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mpesa.Location = New System.Drawing.Point(7, 182)
        Me.Mpesa.Name = "Mpesa"
        Me.Mpesa.Size = New System.Drawing.Size(130, 20)
        Me.Mpesa.TabIndex = 82
        Me.Mpesa.Text = "Pay&ment Options"
        '
        'PaymentOptionsComboBox
        '
        Me.PaymentOptionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentOptionsComboBox.FormattingEnabled = True
        Me.PaymentOptionsComboBox.Items.AddRange(New Object() {"MPesa", "Cash"})
        Me.PaymentOptionsComboBox.Location = New System.Drawing.Point(197, 184)
        Me.PaymentOptionsComboBox.Name = "PaymentOptionsComboBox"
        Me.PaymentOptionsComboBox.Size = New System.Drawing.Size(142, 21)
        Me.PaymentOptionsComboBox.TabIndex = 81
        '
        'GrandTotalTextBox
        '
        Me.GrandTotalTextBox.Location = New System.Drawing.Point(197, 134)
        Me.GrandTotalTextBox.Name = "GrandTotalTextBox"
        Me.GrandTotalTextBox.Size = New System.Drawing.Size(142, 20)
        Me.GrandTotalTextBox.TabIndex = 80
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.Location = New System.Drawing.Point(197, 32)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(142, 20)
        Me.SubTotalTextBox.TabIndex = 79
        '
        'VATTextBox
        '
        Me.VATTextBox.Location = New System.Drawing.Point(197, 89)
        Me.VATTextBox.Name = "VATTextBox"
        Me.VATTextBox.Size = New System.Drawing.Size(142, 20)
        Me.VATTextBox.TabIndex = 78
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(44, 141)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(93, 20)
        Me.Label27.TabIndex = 77
        Me.Label27.Text = "Gr&and Total"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(60, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(77, 20)
        Me.Label28.TabIndex = 76
        Me.Label28.Text = "Su&b Total"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(84, 95)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 20)
        Me.Label29.TabIndex = 75
        Me.Label29.Text = "V.A.T"
        '
        'PayButton
        '
        Me.PayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayButton.Location = New System.Drawing.Point(176, 238)
        Me.PayButton.Name = "PayButton"
        Me.PayButton.Size = New System.Drawing.Size(163, 26)
        Me.PayButton.TabIndex = 74
        Me.PayButton.Text = "P&ay"
        Me.PayButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(392, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Label1"
        '
        'Pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 310)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Mpesa)
        Me.Controls.Add(Me.PaymentOptionsComboBox)
        Me.Controls.Add(Me.GrandTotalTextBox)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(Me.VATTextBox)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.PayButton)
        Me.Name = "Pay"
        Me.Text = "Pay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Mpesa As Label
    Friend WithEvents PaymentOptionsComboBox As ComboBox
    Friend WithEvents GrandTotalTextBox As TextBox
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents VATTextBox As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents PayButton As Button
    Friend WithEvents Label1 As Label
End Class
