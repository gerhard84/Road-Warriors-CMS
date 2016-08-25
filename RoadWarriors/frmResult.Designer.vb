<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResult))
        Me.grpManResult = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnManResult = New System.Windows.Forms.Button()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageEventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageMembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpManResult.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpManResult
        '
        Me.grpManResult.Controls.Add(Me.btnAdd)
        Me.grpManResult.Controls.Add(Me.btnBack)
        Me.grpManResult.Controls.Add(Me.btnDelete)
        Me.grpManResult.Controls.Add(Me.btnExit)
        Me.grpManResult.Controls.Add(Me.btnManResult)
        Me.grpManResult.Location = New System.Drawing.Point(9, 370)
        Me.grpManResult.Name = "grpManResult"
        Me.grpManResult.Size = New System.Drawing.Size(575, 118)
        Me.grpManResult.TabIndex = 25
        Me.grpManResult.TabStop = False
        Me.grpManResult.Text = "Manage Events"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(6, 35)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 57)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add Result"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(347, 35)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 57)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(233, 35)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(107, 57)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete Result"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(461, 35)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 57)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnManResult
        '
        Me.btnManResult.Location = New System.Drawing.Point(119, 35)
        Me.btnManResult.Name = "btnManResult"
        Me.btnManResult.Size = New System.Drawing.Size(107, 57)
        Me.btnManResult.TabIndex = 19
        Me.btnManResult.Text = "Manange Result"
        Me.btnManResult.UseVisualStyleBackColor = True
        '
        'grpResults
        '
        Me.grpResults.Controls.Add(Me.Label7)
        Me.grpResults.Controls.Add(Me.Label6)
        Me.grpResults.Controls.Add(Me.Label5)
        Me.grpResults.Controls.Add(Me.Label4)
        Me.grpResults.Controls.Add(Me.Label3)
        Me.grpResults.Controls.Add(Me.Label2)
        Me.grpResults.Controls.Add(Me.Label1)
        Me.grpResults.Controls.Add(Me.lstResults)
        Me.grpResults.Location = New System.Drawing.Point(9, 31)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(575, 333)
        Me.grpResults.TabIndex = 26
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Results List"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(526, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(417, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Last  Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Memner ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Event"
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 16
        Me.lstResults.Location = New System.Drawing.Point(6, 47)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(559, 276)
        Me.lstResults.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DatabaseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 28)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageEventsToolStripMenuItem, Me.ManageMembersToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ManageEventsToolStripMenuItem
        '
        Me.ManageEventsToolStripMenuItem.Name = "ManageEventsToolStripMenuItem"
        Me.ManageEventsToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.ManageEventsToolStripMenuItem.Text = "Manage Events"
        '
        'ManageMembersToolStripMenuItem
        '
        Me.ManageMembersToolStripMenuItem.Name = "ManageMembersToolStripMenuItem"
        Me.ManageMembersToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.ManageMembersToolStripMenuItem.Text = "Manage Members"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(204, 26)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateDatabaseToolStripMenuItem, Me.DeleteDBToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'CreateDatabaseToolStripMenuItem
        '
        Me.CreateDatabaseToolStripMenuItem.Name = "CreateDatabaseToolStripMenuItem"
        Me.CreateDatabaseToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.CreateDatabaseToolStripMenuItem.Text = "Create DB"
        '
        'DeleteDBToolStripMenuItem
        '
        Me.DeleteDBToolStripMenuItem.Name = "DeleteDBToolStripMenuItem"
        Me.DeleteDBToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.DeleteDBToolStripMenuItem.Text = "Delete DB"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 500)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.grpManResult)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Road Warriors - Results"
        Me.grpManResult.ResumeLayout(False)
        Me.grpResults.ResumeLayout(False)
        Me.grpResults.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpManResult As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnManResult As Button
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents lstResults As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageEventsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageMembersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteDBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
