<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EvenOddNumbersForm1
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
        Me.evenOddNumbersPanel1 = New System.Windows.Forms.Panel()
        Me.inputNumLabel5 = New System.Windows.Forms.Label()
        Me.inputNumLabel4 = New System.Windows.Forms.Label()
        Me.inputNumLabel3 = New System.Windows.Forms.Label()
        Me.inputNumLabel2 = New System.Windows.Forms.Label()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.calculateBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.inputNumLabel1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.resultTextBox = New System.Windows.Forms.TextBox()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.systemHeadingLabel = New System.Windows.Forms.Label()
        Me.evenOddNumbersPanel1.SuspendLayout()
        Me.sidePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'evenOddNumbersPanel1
        '
        Me.evenOddNumbersPanel1.BackColor = System.Drawing.Color.White
        Me.evenOddNumbersPanel1.Controls.Add(Me.sidePanel)
        Me.evenOddNumbersPanel1.Controls.Add(Me.resultTextBox)
        Me.evenOddNumbersPanel1.Controls.Add(Me.inputNumLabel5)
        Me.evenOddNumbersPanel1.Controls.Add(Me.inputNumLabel4)
        Me.evenOddNumbersPanel1.Controls.Add(Me.inputNumLabel3)
        Me.evenOddNumbersPanel1.Controls.Add(Me.inputNumLabel2)
        Me.evenOddNumbersPanel1.Controls.Add(Me.resetBtn)
        Me.evenOddNumbersPanel1.Controls.Add(Me.calculateBtn)
        Me.evenOddNumbersPanel1.Controls.Add(Me.exitBtn)
        Me.evenOddNumbersPanel1.Controls.Add(Me.TextBox5)
        Me.evenOddNumbersPanel1.Controls.Add(Me.inputNumLabel1)
        Me.evenOddNumbersPanel1.Controls.Add(Me.TextBox4)
        Me.evenOddNumbersPanel1.Controls.Add(Me.TextBox3)
        Me.evenOddNumbersPanel1.Controls.Add(Me.TextBox2)
        Me.evenOddNumbersPanel1.Controls.Add(Me.TextBox1)
        Me.evenOddNumbersPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.evenOddNumbersPanel1.ForeColor = System.Drawing.Color.Black
        Me.evenOddNumbersPanel1.Location = New System.Drawing.Point(0, 0)
        Me.evenOddNumbersPanel1.Name = "evenOddNumbersPanel1"
        Me.evenOddNumbersPanel1.Size = New System.Drawing.Size(600, 360)
        Me.evenOddNumbersPanel1.TabIndex = 0
        '
        'inputNumLabel5
        '
        Me.inputNumLabel5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputNumLabel5.Location = New System.Drawing.Point(201, 186)
        Me.inputNumLabel5.Name = "inputNumLabel5"
        Me.inputNumLabel5.Size = New System.Drawing.Size(157, 29)
        Me.inputNumLabel5.TabIndex = 16
        Me.inputNumLabel5.Text = "INPUT NUMBER:"
        Me.inputNumLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'inputNumLabel4
        '
        Me.inputNumLabel4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputNumLabel4.Location = New System.Drawing.Point(201, 151)
        Me.inputNumLabel4.Name = "inputNumLabel4"
        Me.inputNumLabel4.Size = New System.Drawing.Size(157, 29)
        Me.inputNumLabel4.TabIndex = 15
        Me.inputNumLabel4.Text = "INPUT NUMBER:"
        Me.inputNumLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'inputNumLabel3
        '
        Me.inputNumLabel3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputNumLabel3.Location = New System.Drawing.Point(201, 116)
        Me.inputNumLabel3.Name = "inputNumLabel3"
        Me.inputNumLabel3.Size = New System.Drawing.Size(157, 29)
        Me.inputNumLabel3.TabIndex = 14
        Me.inputNumLabel3.Text = "INPUT NUMBER:"
        Me.inputNumLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'inputNumLabel2
        '
        Me.inputNumLabel2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputNumLabel2.Location = New System.Drawing.Point(201, 81)
        Me.inputNumLabel2.Name = "inputNumLabel2"
        Me.inputNumLabel2.Size = New System.Drawing.Size(157, 29)
        Me.inputNumLabel2.TabIndex = 13
        Me.inputNumLabel2.Text = "INPUT NUMBER:"
        Me.inputNumLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'resetBtn
        '
        Me.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetBtn.Location = New System.Drawing.Point(397, 299)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(100, 30)
        Me.resetBtn.TabIndex = 12
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'calculateBtn
        '
        Me.calculateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calculateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateBtn.Location = New System.Drawing.Point(276, 299)
        Me.calculateBtn.Name = "calculateBtn"
        Me.calculateBtn.Size = New System.Drawing.Size(100, 30)
        Me.calculateBtn.TabIndex = 11
        Me.calculateBtn.Text = "Calculate"
        Me.calculateBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.White
        Me.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.exitBtn.FlatAppearance.BorderSize = 0
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitBtn.ForeColor = System.Drawing.Color.Black
        Me.exitBtn.Image = Global.Identify_Even_and_Odd_numbers.My.Resources.Resources._16_Pixel_Exit_Icon
        Me.exitBtn.Location = New System.Drawing.Point(567, 3)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(30, 30)
        Me.exitBtn.TabIndex = 10
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(364, 186)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(196, 29)
        Me.TextBox5.TabIndex = 5
        '
        'inputNumLabel1
        '
        Me.inputNumLabel1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputNumLabel1.Location = New System.Drawing.Point(201, 46)
        Me.inputNumLabel1.Name = "inputNumLabel1"
        Me.inputNumLabel1.Size = New System.Drawing.Size(157, 29)
        Me.inputNumLabel1.TabIndex = 4
        Me.inputNumLabel1.Text = "INPUT NUMBER:"
        Me.inputNumLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(364, 151)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(196, 29)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(364, 116)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(196, 29)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(364, 81)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(196, 29)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(364, 46)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 29)
        Me.TextBox1.TabIndex = 0
        '
        'resultTextBox
        '
        Me.resultTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultTextBox.Location = New System.Drawing.Point(257, 231)
        Me.resultTextBox.Multiline = True
        Me.resultTextBox.Name = "resultTextBox"
        Me.resultTextBox.Size = New System.Drawing.Size(263, 53)
        Me.resultTextBox.TabIndex = 18
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.Black
        Me.sidePanel.Controls.Add(Me.systemHeadingLabel)
        Me.sidePanel.Location = New System.Drawing.Point(0, 0)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(167, 360)
        Me.sidePanel.TabIndex = 19
        '
        'systemHeadingLabel
        '
        Me.systemHeadingLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.systemHeadingLabel.ForeColor = System.Drawing.Color.White
        Me.systemHeadingLabel.Location = New System.Drawing.Point(12, 9)
        Me.systemHeadingLabel.Name = "systemHeadingLabel"
        Me.systemHeadingLabel.Size = New System.Drawing.Size(155, 320)
        Me.systemHeadingLabel.TabIndex = 20
        Me.systemHeadingLabel.Text = "IDENTIFY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EVEN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ODD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NUMBERS"
        Me.systemHeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EvenOddNumbersForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 360)
        Me.Controls.Add(Me.evenOddNumbersPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EvenOddNumbersForm1"
        Me.Text = "EvenOddNumbersForm1"
        Me.evenOddNumbersPanel1.ResumeLayout(False)
        Me.evenOddNumbersPanel1.PerformLayout()
        Me.sidePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents evenOddNumbersPanel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents inputNumLabel1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents exitBtn As Button
    Friend WithEvents resetBtn As Button
    Friend WithEvents calculateBtn As Button
    Friend WithEvents inputNumLabel5 As Label
    Friend WithEvents inputNumLabel4 As Label
    Friend WithEvents inputNumLabel3 As Label
    Friend WithEvents inputNumLabel2 As Label
    Friend WithEvents resultTextBox As TextBox
    Friend WithEvents sidePanel As Panel
    Friend WithEvents systemHeadingLabel As Label
End Class
