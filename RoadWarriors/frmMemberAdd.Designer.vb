<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMemberAdd))
        Me.grpNewMem = New System.Windows.Forms.GroupBox()
        Me.lblMemID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dteDob = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpNewMem.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpNewMem
        '
        Me.grpNewMem.Controls.Add(Me.lblMemID)
        Me.grpNewMem.Controls.Add(Me.Label1)
        Me.grpNewMem.Controls.Add(Me.rbtnFemale)
        Me.grpNewMem.Controls.Add(Me.rbtnMale)
        Me.grpNewMem.Controls.Add(Me.Label3)
        Me.grpNewMem.Controls.Add(Me.dteDob)
        Me.grpNewMem.Controls.Add(Me.Label2)
        Me.grpNewMem.Controls.Add(Me.txtSurname)
        Me.grpNewMem.Controls.Add(Me.txtName)
        Me.grpNewMem.Controls.Add(Me.lblSurname)
        Me.grpNewMem.Controls.Add(Me.lblName)
        Me.grpNewMem.Controls.Add(Me.btnSave)
        Me.grpNewMem.Controls.Add(Me.btnBack)
        Me.grpNewMem.Location = New System.Drawing.Point(12, 27)
        Me.grpNewMem.Name = "grpNewMem"
        Me.grpNewMem.Size = New System.Drawing.Size(572, 217)
        Me.grpNewMem.TabIndex = 0
        Me.grpNewMem.TabStop = False
        Me.grpNewMem.Text = "New Member Details"
        '
        'lblMemID
        '
        Me.lblMemID.AutoSize = True
        Me.lblMemID.Location = New System.Drawing.Point(100, 34)
        Me.lblMemID.Name = "lblMemID"
        Me.lblMemID.Size = New System.Drawing.Size(63, 17)
        Me.lblMemID.TabIndex = 42
        Me.lblMemID.Text = "RW0000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Member ID:"
        '
        'rbtnFemale
        '
        Me.rbtnFemale.AutoSize = True
        Me.rbtnFemale.Location = New System.Drawing.Point(456, 78)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(75, 21)
        Me.rbtnFemale.TabIndex = 40
        Me.rbtnFemale.TabStop = True
        Me.rbtnFemale.Text = "Female"
        Me.rbtnFemale.UseVisualStyleBackColor = True
        '
        'rbtnMale
        '
        Me.rbtnMale.AllowDrop = True
        Me.rbtnMale.AutoSize = True
        Me.rbtnMale.Location = New System.Drawing.Point(391, 78)
        Me.rbtnMale.Name = "rbtnMale"
        Me.rbtnMale.Size = New System.Drawing.Size(59, 21)
        Me.rbtnMale.TabIndex = 39
        Me.rbtnMale.TabStop = True
        Me.rbtnMale.Text = "Male"
        Me.rbtnMale.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Gender:"
        '
        'dteDob
        '
        Me.dteDob.Location = New System.Drawing.Point(97, 77)
        Me.dteDob.Name = "dteDob"
        Me.dteDob.Size = New System.Drawing.Size(200, 22)
        Me.dteDob.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Birthday:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(438, 30)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 22)
        Me.txtSurname.TabIndex = 35
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(244, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 34
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(363, 33)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(69, 17)
        Me.lblSurname.TabIndex = 33
        Me.lblSurname.Text = "Surname:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(186, 33)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 32
        Me.lblName.Text = "Name"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(146, 133)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 57)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Add Member"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(299, 133)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 57)
        Me.btnBack.TabIndex = 29
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'frmMemberAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 253)
        Me.Controls.Add(Me.grpNewMem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMemberAdd"
        Me.Text = "Road Warriors - Member Add"
        Me.grpNewMem.ResumeLayout(False)
        Me.grpNewMem.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpNewMem As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblMemID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents dteDob As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
