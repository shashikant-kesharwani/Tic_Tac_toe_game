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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtnamex = New TextBox()
        txtnameo = New TextBox()
        btnsubmit = New Button()
        btnstart = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(595, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(423, 83)
        Label1.TabIndex = 0
        Label1.Text = "Tic Tac Toe Game"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(595, 165)
        btn1.Name = "btn1"
        btn1.Size = New Size(121, 73)
        btn1.TabIndex = 1
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(747, 165)
        btn2.Name = "btn2"
        btn2.Size = New Size(117, 73)
        btn2.TabIndex = 2
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(897, 165)
        btn3.Name = "btn3"
        btn3.Size = New Size(121, 73)
        btn3.TabIndex = 3
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(595, 280)
        btn4.Name = "btn4"
        btn4.Size = New Size(121, 69)
        btn4.TabIndex = 4
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(747, 280)
        btn5.Name = "btn5"
        btn5.Size = New Size(117, 69)
        btn5.TabIndex = 5
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(897, 280)
        btn6.Name = "btn6"
        btn6.Size = New Size(121, 69)
        btn6.TabIndex = 6
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(595, 386)
        btn7.Name = "btn7"
        btn7.Size = New Size(121, 61)
        btn7.TabIndex = 7
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(747, 386)
        btn8.Name = "btn8"
        btn8.Size = New Size(117, 61)
        btn8.TabIndex = 8
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(897, 386)
        btn9.Name = "btn9"
        btn9.Size = New Size(121, 61)
        btn9.TabIndex = 9
        btn9.UseVisualStyleBackColor = True
        ' 
        ' lbltext
        ' 
        lbltext.Font = New Font("Algerian", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbltext.Location = New Point(721, 484)
        lbltext.Name = "lbltext"
        lbltext.Size = New Size(177, 67)
        lbltext.TabIndex = 10
        lbltext.Text = "X's Terms"
        lbltext.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Red
        btnclear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnclear.Location = New Point(595, 595)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(174, 56)
        btnclear.TabIndex = 11
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btncheck
        ' 
        btncheck.BackColor = Color.Lime
        btncheck.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncheck.Location = New Point(845, 595)
        btncheck.Name = "btncheck"
        btncheck.Size = New Size(173, 56)
        btncheck.TabIndex = 12
        btncheck.Text = "Check Winner"
        btncheck.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label2.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(352, 83)
        Label2.TabIndex = 13
        Label2.Text = "Player's Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(20, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 37)
        Label3.TabIndex = 14
        Label3.Text = "Player X :"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label4.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(20, 280)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 41)
        Label4.TabIndex = 15
        Label4.Text = "Player O :"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtnamex
        ' 
        txtnamex.Location = New Point(139, 188)
        txtnamex.Multiline = True
        txtnamex.Name = "txtnamex"
        txtnamex.Size = New Size(225, 37)
        txtnamex.TabIndex = 16
        ' 
        ' txtnameo
        ' 
        txtnameo.Location = New Point(139, 280)
        txtnameo.Multiline = True
        txtnameo.Name = "txtnameo"
        txtnameo.Size = New Size(225, 41)
        txtnameo.TabIndex = 17
        ' 
        ' btnsubmit
        ' 
        btnsubmit.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnsubmit.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnsubmit.Location = New Point(12, 370)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(352, 77)
        btnsubmit.TabIndex = 18
        btnsubmit.Text = "Submit"
        btnsubmit.UseVisualStyleBackColor = False
        ' 
        ' btnstart
        ' 
        btnstart.BackColor = Color.Fuchsia
        btnstart.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnstart.Location = New Point(12, 483)
        btnstart.Name = "btnstart"
        btnstart.Size = New Size(352, 80)
        btnstart.TabIndex = 19
        btnstart.Text = "Start Again"
        btnstart.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        BackgroundImage = My.Resources.Resources.back_image_Tic_tac_toe
        ClientSize = New Size(1101, 726)
        Controls.Add(btnstart)
        Controls.Add(btnsubmit)
        Controls.Add(txtnameo)
        Controls.Add(txtnamex)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
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
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tic Tac Toe Game Made By Shashikant"
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnamex As TextBox
    Friend WithEvents txtnameo As TextBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btnstart As Button

End Class
