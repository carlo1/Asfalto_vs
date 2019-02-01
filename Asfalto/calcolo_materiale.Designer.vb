<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calcolo_materiale
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calcolo_materiale))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonMat1 = New System.Windows.Forms.Button()
        Me.ButtonMat2 = New System.Windows.Forms.Button()
        Me.ButtonMat3 = New System.Windows.Forms.Button()
        Me.ButtonMat4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox_T = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 36)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Calcolo Materiale"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(569, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 36)
        Me.Label2.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(28, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Materiale"
        '
        'ButtonMat1
        '
        Me.ButtonMat1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMat1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMat1.ForeColor = System.Drawing.Color.DimGray
        Me.ButtonMat1.Location = New System.Drawing.Point(20, 104)
        Me.ButtonMat1.Name = "ButtonMat1"
        Me.ButtonMat1.Size = New System.Drawing.Size(194, 67)
        Me.ButtonMat1.TabIndex = 14
        Me.ButtonMat1.Text = "Tappetino"
        Me.ButtonMat1.UseVisualStyleBackColor = False
        '
        'ButtonMat2
        '
        Me.ButtonMat2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMat2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMat2.ForeColor = System.Drawing.Color.DimGray
        Me.ButtonMat2.Location = New System.Drawing.Point(229, 104)
        Me.ButtonMat2.Name = "ButtonMat2"
        Me.ButtonMat2.Size = New System.Drawing.Size(194, 67)
        Me.ButtonMat2.TabIndex = 13
        Me.ButtonMat2.Text = "Binder"
        Me.ButtonMat2.UseVisualStyleBackColor = False
        '
        'ButtonMat3
        '
        Me.ButtonMat3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMat3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMat3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonMat3.Location = New System.Drawing.Point(440, 104)
        Me.ButtonMat3.Name = "ButtonMat3"
        Me.ButtonMat3.Size = New System.Drawing.Size(194, 67)
        Me.ButtonMat3.TabIndex = 12
        Me.ButtonMat3.Text = "Tout_Venant"
        Me.ButtonMat3.UseVisualStyleBackColor = False
        '
        'ButtonMat4
        '
        Me.ButtonMat4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMat4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMat4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonMat4.Location = New System.Drawing.Point(650, 104)
        Me.ButtonMat4.Name = "ButtonMat4"
        Me.ButtonMat4.Size = New System.Drawing.Size(194, 67)
        Me.ButtonMat4.TabIndex = 11
        Me.ButtonMat4.Text = "Tappeto Modif"
        Me.ButtonMat4.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox1.Location = New System.Drawing.Point(150, 249)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 33)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.Text = "3"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(362, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 57)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "      Modifica"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox2.Location = New System.Drawing.Point(150, 311)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 33)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = "21"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_T
        '
        Me.TextBox_T.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_T.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox_T.Location = New System.Drawing.Point(394, 311)
        Me.TextBox_T.Name = "TextBox_T"
        Me.TextBox_T.Size = New System.Drawing.Size(151, 33)
        Me.TextBox_T.TabIndex = 18
        Me.TextBox_T.Text = "3"
        Me.TextBox_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox3.Location = New System.Drawing.Point(150, 372)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(151, 33)
        Me.TextBox3.TabIndex = 16
        Me.TextBox3.Text = "3"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'calcolo_materiale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBox_T)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonMat4)
        Me.Controls.Add(Me.ButtonMat3)
        Me.Controls.Add(Me.ButtonMat2)
        Me.Controls.Add(Me.ButtonMat1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "calcolo_materiale"
        Me.Size = New System.Drawing.Size(871, 513)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonMat1 As Button
    Friend WithEvents ButtonMat2 As Button
    Friend WithEvents ButtonMat3 As Button
    Friend WithEvents ButtonMat4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox_T As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
