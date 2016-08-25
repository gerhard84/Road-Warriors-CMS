<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResultAdd))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSurn = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMemSearch = New System.Windows.Forms.TextBox()
        Me.txtMemID = New System.Windows.Forms.Label()
        Me.txtMs = New System.Windows.Forms.TextBox()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtHr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEventSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.btnEvntSearch = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblEvntDate = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSurn)
        Me.GroupBox1.Controls.Add(Me.lblSurname)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMemSearch)
        Me.GroupBox1.Controls.Add(Me.txtMemID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 81)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member Details"
        '
        'lblSurn
        '
        Me.lblSurn.AutoSize = True
        Me.lblSurn.Location = New System.Drawing.Point(517, 36)
        Me.lblSurn.MaximumSize = New System.Drawing.Size(100, 22)
        Me.lblSurn.MinimumSize = New System.Drawing.Size(100, 22)
        Me.lblSurn.Name = "lblSurn"
        Me.lblSurn.Size = New System.Drawing.Size(100, 22)
        Me.lblSurn.TabIndex = 43
        Me.lblSurn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(442, 39)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(69, 17)
        Me.lblSurname.TabIndex = 42
        Me.lblSurname.Text = "Surname:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(200, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 41
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(336, 36)
        Me.lblName.MaximumSize = New System.Drawing.Size(100, 22)
        Me.lblName.MinimumSize = New System.Drawing.Size(100, 22)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 22)
        Me.lblName.TabIndex = 31
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Name:"
        '
        'txtMemSearch
        '
        Me.txtMemSearch.Location = New System.Drawing.Point(94, 36)
        Me.txtMemSearch.Name = "txtMemSearch"
        Me.txtMemSearch.Size = New System.Drawing.Size(100, 22)
        Me.txtMemSearch.TabIndex = 29
        '
        'txtMemID
        '
        Me.txtMemID.AutoSize = True
        Me.txtMemID.Location = New System.Drawing.Point(7, 39)
        Me.txtMemID.Name = "txtMemID"
        Me.txtMemID.Size = New System.Drawing.Size(80, 17)
        Me.txtMemID.TabIndex = 28
        Me.txtMemID.Text = "Member ID:"
        '
        'txtMs
        '
        Me.txtMs.Location = New System.Drawing.Point(364, 82)
        Me.txtMs.Name = "txtMs"
        Me.txtMs.Size = New System.Drawing.Size(40, 22)
        Me.txtMs.TabIndex = 40
        Me.txtMs.Text = "00"
        Me.txtMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSec
        '
        Me.txtSec.Location = New System.Drawing.Point(280, 82)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(40, 22)
        Me.txtSec.TabIndex = 39
        Me.txtSec.Text = "00"
        Me.txtSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(199, 82)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(40, 22)
        Me.txtMin.TabIndex = 38
        Me.txtMin.Text = "00"
        Me.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHr
        '
        Me.txtHr.Location = New System.Drawing.Point(120, 82)
        Me.txtHr.Name = "txtHr"
        Me.txtHr.Size = New System.Drawing.Size(40, 22)
        Me.txtHr.TabIndex = 37
        Me.txtHr.Text = "00"
        Me.txtHr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(328, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 17)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Ms:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(253, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "S:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(170, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 17)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "M:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "H:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Race Time:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(208, 268)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 57)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save Result"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(361, 268)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 57)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(657, 28)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Event Name:"
        '
        'txtEventSearch
        '
        Me.txtEventSearch.Location = New System.Drawing.Point(101, 36)
        Me.txtEventSearch.Name = "txtEventSearch"
        Me.txtEventSearch.Size = New System.Drawing.Size(173, 22)
        Me.txtEventSearch.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(369, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Location:"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(444, 36)
        Me.lblLocation.MaximumSize = New System.Drawing.Size(120, 22)
        Me.lblLocation.MinimumSize = New System.Drawing.Size(120, 22)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(120, 22)
        Me.lblLocation.TabIndex = 47
        Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEvntSearch
        '
        Me.btnEvntSearch.Location = New System.Drawing.Point(283, 36)
        Me.btnEvntSearch.Name = "btnEvntSearch"
        Me.btnEvntSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnEvntSearch.TabIndex = 48
        Me.btnEvntSearch.Text = "Search"
        Me.btnEvntSearch.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblEvntDate)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnEvntSearch)
        Me.GroupBox2.Controls.Add(Me.txtHr)
        Me.GroupBox2.Controls.Add(Me.txtMin)
        Me.GroupBox2.Controls.Add(Me.lblLocation)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtSec)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtMs)
        Me.GroupBox2.Controls.Add(Me.txtEventSearch)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 134)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Race Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(427, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 17)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Date:"
        '
        'lblEvntDate
        '
        Me.lblEvntDate.AutoSize = True
        Me.lblEvntDate.Location = New System.Drawing.Point(475, 80)
        Me.lblEvntDate.MaximumSize = New System.Drawing.Size(100, 22)
        Me.lblEvntDate.MinimumSize = New System.Drawing.Size(100, 22)
        Me.lblEvntDate.Name = "lblEvntDate"
        Me.lblEvntDate.Size = New System.Drawing.Size(100, 22)
        Me.lblEvntDate.TabIndex = 50
        Me.lblEvntDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmResultAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 333)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmResultAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Road Warriors - Result Add"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtMs As TextBox
    Friend WithEvents txtSec As TextBox
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtHr As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMemSearch As TextBox
    Friend WithEvents txtMemID As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSurn As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents btnEvntSearch As Button
    Friend WithEvents lblLocation As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEventSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblEvntDate As Label
    Friend WithEvents Label9 As Label
End Class
