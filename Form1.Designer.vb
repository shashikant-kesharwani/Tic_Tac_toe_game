<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        lbltext = New Label()
        btnclear = New Button()
        btncheck = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(293, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(423, 83)
        Label1.TabIndex = 0
        Label1.Text = "Tic Tac Toe Game"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(293, 177)
        btn1.Name = "btn1"
        btn1.Size = New Size(121, 73)
        btn1.TabIndex = 1
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(446, 177)
        btn2.Name = "btn2"
        btn2.Size = New Size(117, 73)
        btn2.TabIndex = 2
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(595, 177)
        btn3.Name = "btn3"
        btn3.Size = New Size(121, 73)
        btn3.TabIndex = 3
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(293, 280)
        btn4.Name = "btn4"
        btn4.Size = New Size(121, 69)
        btn4.TabIndex = 4
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(446, 280)
        btn5.Name = "btn5"
        btn5.Size = New Size(117, 69)
        btn5.TabIndex = 5
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(595, 280)
        btn6.Name = "btn6"
        btn6.Size = New Size(121, 69)
        btn6.TabIndex = 6
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(293, 386)
        btn7.Name = "btn7"
        btn7.Size = New Size(121, 61)
        btn7.TabIndex = 7
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(446, 386)
        btn8.Name = "btn8"
        btn8.Size = New Size(117, 61)
        btn8.TabIndex = 8
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(595, 386)
        btn9.Name = "btn9"
        btn9.Size = New Size(121, 61)
        btn9.TabIndex = 9
        btn9.UseVisualStyleBackColor = True
        ' 
        ' lbltext
        ' 
        lbltext.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltext.Location = New Point(432, 492)
        lbltext.Name = "lbltext"
        lbltext.Size = New Size(177, 67)
        lbltext.TabIndex = 10
        lbltext.Text = "X's Terms"
        lbltext.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnclear
        ' 
        btnclear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnclear.Location = New Point(293, 595)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(174, 56)
        btnclear.TabIndex = 11
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = True
        ' 
        ' btncheck
        ' 
        btncheck.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncheck.Location = New Point(543, 595)
        btncheck.Name = "btncheck"
        btncheck.Size = New Size(173, 56)
        btncheck.TabIndex = 12
        btncheck.Text = "Check Winner"
        btncheck.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        ClientSize = New Size(1101, 726)
        Controls.Add(btncheck)
        Controls.Add(btnclear)
        Controls.Add(lbltext)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents lbltext As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents btncheck As Button

End Class
