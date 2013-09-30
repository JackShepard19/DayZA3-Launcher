<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServerBrowser))
        Me.bt_launch = New System.Windows.Forms.Button()
        Me.bt_getList = New System.Windows.Forms.Button()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.lv_ServerBrowser = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_PlayHostName = New System.Windows.Forms.Label()
        Me.btn_CloseGame = New System.Windows.Forms.Button()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'bt_launch
        '
        Me.bt_launch.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_launch.Location = New System.Drawing.Point(12, 299)
        Me.bt_launch.Name = "bt_launch"
        Me.bt_launch.Size = New System.Drawing.Size(75, 23)
        Me.bt_launch.TabIndex = 1
        Me.bt_launch.Text = "Play"
        Me.bt_launch.UseVisualStyleBackColor = True
        '
        'bt_getList
        '
        Me.bt_getList.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_getList.Location = New System.Drawing.Point(369, 299)
        Me.bt_getList.Name = "bt_getList"
        Me.bt_getList.Size = New System.Drawing.Size(75, 23)
        Me.bt_getList.TabIndex = 2
        Me.bt_getList.Text = "Refresh"
        Me.bt_getList.UseVisualStyleBackColor = True
        '
        'bt_close
        '
        Me.bt_close.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_close.Location = New System.Drawing.Point(717, 299)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(75, 23)
        Me.bt_close.TabIndex = 3
        Me.bt_close.Text = "Close"
        Me.bt_close.UseVisualStyleBackColor = True
        '
        'lv_ServerBrowser
        '
        Me.lv_ServerBrowser.AllowColumnReorder = True
        Me.lv_ServerBrowser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv_ServerBrowser.Dock = System.Windows.Forms.DockStyle.Top
        Me.lv_ServerBrowser.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_ServerBrowser.FullRowSelect = True
        Me.lv_ServerBrowser.GridLines = True
        Me.lv_ServerBrowser.Location = New System.Drawing.Point(0, 0)
        Me.lv_ServerBrowser.MultiSelect = False
        Me.lv_ServerBrowser.Name = "lv_ServerBrowser"
        Me.lv_ServerBrowser.Size = New System.Drawing.Size(804, 293)
        Me.lv_ServerBrowser.TabIndex = 4
        Me.lv_ServerBrowser.UseCompatibleStateImageBehavior = False
        Me.lv_ServerBrowser.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Hostname"
        Me.ColumnHeader1.Width = 620
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Location"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Players"
        '
        'lbl_PlayHostName
        '
        Me.lbl_PlayHostName.AutoSize = True
        Me.lbl_PlayHostName.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PlayHostName.Location = New System.Drawing.Point(9, 336)
        Me.lbl_PlayHostName.Name = "lbl_PlayHostName"
        Me.lbl_PlayHostName.Size = New System.Drawing.Size(68, 15)
        Me.lbl_PlayHostName.TabIndex = 5
        Me.lbl_PlayHostName.Text = "HOSTNAME"
        '
        'btn_CloseGame
        '
        Me.btn_CloseGame.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CloseGame.Location = New System.Drawing.Point(693, 328)
        Me.btn_CloseGame.Name = "btn_CloseGame"
        Me.btn_CloseGame.Size = New System.Drawing.Size(99, 23)
        Me.btn_CloseGame.TabIndex = 6
        Me.btn_CloseGame.Text = "Close Game"
        Me.btn_CloseGame.UseVisualStyleBackColor = True
        Me.btn_CloseGame.Visible = False
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ping"
        '
        'ServerBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 358)
        Me.Controls.Add(Me.btn_CloseGame)
        Me.Controls.Add(Me.lbl_PlayHostName)
        Me.Controls.Add(Me.lv_ServerBrowser)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.bt_getList)
        Me.Controls.Add(Me.bt_launch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ServerBrowser"
        Me.Text = "DayZA3 Server Browser"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_launch As System.Windows.Forms.Button
    Friend WithEvents bt_getList As System.Windows.Forms.Button
    Friend WithEvents bt_close As System.Windows.Forms.Button
    Friend WithEvents lv_ServerBrowser As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_PlayHostName As System.Windows.Forms.Label
    Friend WithEvents btn_CloseGame As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
