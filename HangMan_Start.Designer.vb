<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HangMan_Start
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
        Label1 = New Label()
        btnfruits = New Button()
        btnanimal = New Button()
        btnflowers = New Button()
        btnexit = New Button()
        btncolor = New Button()
        cmbfruits = New ComboBox()
        cmbanimals = New ComboBox()
        cmbflowers = New ComboBox()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Yellow
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(261, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(441, 57)
        Label1.TabIndex = 0
        Label1.Text = "Hang Man StartUp Page  "
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnfruits
        ' 
        btnfruits.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnfruits.Font = New Font("Arial", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnfruits.Location = New Point(261, 190)
        btnfruits.Name = "btnfruits"
        btnfruits.Size = New Size(234, 56)
        btnfruits.TabIndex = 1
        btnfruits.Text = "Fruits  Name"
        btnfruits.UseVisualStyleBackColor = False
        ' 
        ' btnanimal
        ' 
        btnanimal.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnanimal.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnanimal.Location = New Point(261, 283)
        btnanimal.Name = "btnanimal"
        btnanimal.Size = New Size(234, 60)
        btnanimal.TabIndex = 2
        btnanimal.Text = "Animals Name"
        btnanimal.UseVisualStyleBackColor = False
        ' 
        ' btnflowers
        ' 
        btnflowers.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        btnflowers.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnflowers.Location = New Point(261, 397)
        btnflowers.Name = "btnflowers"
        btnflowers.Size = New Size(234, 56)
        btnflowers.TabIndex = 3
        btnflowers.Text = "Flowers Name"
        btnflowers.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.Red
        btnexit.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnexit.Location = New Point(337, 595)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(294, 62)
        btnexit.TabIndex = 4
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' btncolor
        ' 
        btncolor.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btncolor.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btncolor.Location = New Point(261, 503)
        btncolor.Name = "btncolor"
        btncolor.Size = New Size(234, 51)
        btncolor.TabIndex = 5
        btncolor.Text = "Colors Name"
        btncolor.UseVisualStyleBackColor = False
        ' 
        ' cmbfruits
        ' 
        cmbfruits.FormattingEnabled = True
        cmbfruits.Items.AddRange(New Object() {"** Fruits Name **", "", "Apple", "Banana", "mango", "orange", "fig", "grapes", "coconut", "pomegrante", "guava", "papaya", "pineapple"})
        cmbfruits.Location = New Point(515, 200)
        cmbfruits.Name = "cmbfruits"
        cmbfruits.Size = New Size(187, 36)
        cmbfruits.TabIndex = 7
        ' 
        ' cmbanimals
        ' 
        cmbanimals.FormattingEnabled = True
        cmbanimals.Items.AddRange(New Object() {"** Animals Name **", "", "Monkey", "Fox ", "Tiger", "Lion", "Dog", "Cat", "Zebra", "Camel", "Horse", "Elephant", "Dear"})
        cmbanimals.Location = New Point(515, 297)
        cmbanimals.Name = "cmbanimals"
        cmbanimals.Size = New Size(187, 36)
        cmbanimals.TabIndex = 8
        ' 
        ' cmbflowers
        ' 
        cmbflowers.FormattingEnabled = True
        cmbflowers.Items.AddRange(New Object() {"** Flowers Name **", "", "Lotus", "Rose", "Lily", "Sunflower", "marygold", "Jasmine", "Waterlily", "Hibiscus", "Bluebell", "Daisy", "Champa"})
        cmbflowers.Location = New Point(515, 409)
        cmbflowers.Name = "cmbflowers"
        cmbflowers.Size = New Size(187, 36)
        cmbflowers.TabIndex = 9
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"** Colors Name **", "", "Blue", "Red", "Green", "Orange", "Pink", "Yellow", "Black", "Brown", "Cyan", "Indigo", "Purple"})
        ComboBox1.Location = New Point(515, 512)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(187, 36)
        ComboBox1.TabIndex = 10
        ' 
        ' HangMan_Start
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.hangman2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1027, 694)
        Controls.Add(ComboBox1)
        Controls.Add(cmbflowers)
        Controls.Add(cmbanimals)
        Controls.Add(cmbfruits)
        Controls.Add(btncolor)
        Controls.Add(btnexit)
        Controls.Add(btnflowers)
        Controls.Add(btnanimal)
        Controls.Add(btnfruits)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "HangMan_Start"
        Text = "HangMan_Start"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnfruits As Button
    Friend WithEvents btnanimal As Button
    Friend WithEvents btnflowers As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btncolor As Button
    Friend WithEvents lstboxfruits As ListBox
    Friend WithEvents cmbfruits As ComboBox
    Friend WithEvents cmbanimals As ComboBox
    Friend WithEvents cmbflowers As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
