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
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.grpResults.Controls.Add(Me.lstResults)
        Me.grpResults.Location = New System.Drawing.Point(9, 31)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(575, 333)
        Me.grpResults.TabIndex = 26
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Results List"
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 16
        Me.lstResults.Location = New System.Drawing.Point(6, 31)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(559, 292)
        Me.lstResults.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 28)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'frmResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 500)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.grpManResult)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Road Warriors - Results"
        Me.grpManResult.ResumeLayout(False)
        Me.grpResults.ResumeLayout(False)
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
End Class
