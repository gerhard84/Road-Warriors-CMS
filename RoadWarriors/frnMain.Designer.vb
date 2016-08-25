<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frnMain))
        Me.btnManEvent = New System.Windows.Forms.Button()
        Me.btnManMembers = New System.Windows.Forms.Button()
        Me.btnResults = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RaceResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageEventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageMembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnManEvent
        '
        Me.btnManEvent.Location = New System.Drawing.Point(245, 21)
        Me.btnManEvent.Name = "btnManEvent"
        Me.btnManEvent.Size = New System.Drawing.Size(126, 88)
        Me.btnManEvent.TabIndex = 0
        Me.btnManEvent.Text = "Manage &Events"
        Me.btnManEvent.UseVisualStyleBackColor = True
        '
        'btnManMembers
        '
        Me.btnManMembers.Location = New System.Drawing.Point(484, 21)
        Me.btnManMembers.Name = "btnManMembers"
        Me.btnManMembers.Size = New System.Drawing.Size(126, 88)
        Me.btnManMembers.TabIndex = 1
        Me.btnManMembers.Text = "Manage &Members"
        Me.btnManMembers.UseVisualStyleBackColor = True
        '
        'btnResults
        '
        Me.btnResults.Location = New System.Drawing.Point(6, 21)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(126, 88)
        Me.btnResults.TabIndex = 2
        Me.btnResults.Text = "&Race Results"
        Me.btnResults.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(723, 21)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 88)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DatabaseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(881, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RaceResultsToolStripMenuItem, Me.ManageEventsToolStripMenuItem, Me.ManageMembersToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateDatabaseToolStripMenuItem, Me.DeleteDBToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.DatabaseToolStripMenuItem.Text = "&Database"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RoadWarriors.My.Resources.Resources.back2_small1
        Me.PictureBox1.InitialImage = Global.RoadWarriors.My.Resources.Resources.back2_small1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(857, 482)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnResults)
        Me.GroupBox1.Controls.Add(Me.btnManEvent)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnManMembers)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 519)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 115)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Club Management"
        '
        'RaceResultsToolStripMenuItem
        '
        Me.RaceResultsToolStripMenuItem.Name = "RaceResultsToolStripMenuItem"
        Me.RaceResultsToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.RaceResultsToolStripMenuItem.Text = "&Race Results"
        '
        'ManageEventsToolStripMenuItem
        '
        Me.ManageEventsToolStripMenuItem.Name = "ManageEventsToolStripMenuItem"
        Me.ManageEventsToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.ManageEventsToolStripMenuItem.Text = "Manage &Events"
        '
        'ManageMembersToolStripMenuItem
        '
        Me.ManageMembersToolStripMenuItem.Name = "ManageMembersToolStripMenuItem"
        Me.ManageMembersToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.ManageMembersToolStripMenuItem.Text = "Manage &Members"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(204, 26)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        '
        'CreateDatabaseToolStripMenuItem
        '
        Me.CreateDatabaseToolStripMenuItem.Name = "CreateDatabaseToolStripMenuItem"
        Me.CreateDatabaseToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.CreateDatabaseToolStripMenuItem.Text = "&Create DB"
        '
        'DeleteDBToolStripMenuItem
        '
        Me.DeleteDBToolStripMenuItem.Name = "DeleteDBToolStripMenuItem"
        Me.DeleteDBToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.DeleteDBToolStripMenuItem.Text = "&Delete DB"
        '
        'frnMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 646)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frnMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Road Warriors - Club Management"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnManEvent As Button
    Friend WithEvents btnManMembers As Button
    Friend WithEvents btnResults As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RaceResultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageEventsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageMembersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CreateDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteDBToolStripMenuItem As ToolStripMenuItem
    Private WithEvents FileToolStripMenuItem As ToolStripMenuItem
End Class
