<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallationCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstallationCheck))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bt_Done = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_arma2 = New System.Windows.Forms.TextBox()
        Me.tb_arma2oa = New System.Windows.Forms.TextBox()
        Me.tb_arma3 = New System.Windows.Forms.TextBox()
        Me.tb_arma2oabeta = New System.Windows.Forms.TextBox()
        Me.btn_getdir_a2 = New System.Windows.Forms.Button()
        Me.btn_getdira2oa = New System.Windows.Forms.Button()
        Me.btn_getdira3 = New System.Windows.Forms.Button()
        Me.btn_getdira2oabeta = New System.Windows.Forms.Button()
        Me.fbd_diag = New System.Windows.Forms.FolderBrowserDialog()
        Me.btn_restoredefault = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ArmA2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ArmA2OA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ArmA3 Beta:"
        '
        'bt_Done
        '
        Me.bt_Done.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Done.Location = New System.Drawing.Point(648, 130)
        Me.bt_Done.Name = "bt_Done"
        Me.bt_Done.Size = New System.Drawing.Size(75, 23)
        Me.bt_Done.TabIndex = 3
        Me.bt_Done.Text = "Done"
        Me.bt_Done.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ArmA2OA Beta:"
        '
        'tb_arma2
        '
        Me.tb_arma2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_arma2.Location = New System.Drawing.Point(148, 9)
        Me.tb_arma2.Name = "tb_arma2"
        Me.tb_arma2.ReadOnly = True
        Me.tb_arma2.Size = New System.Drawing.Size(526, 24)
        Me.tb_arma2.TabIndex = 8
        '
        'tb_arma2oa
        '
        Me.tb_arma2oa.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_arma2oa.Location = New System.Drawing.Point(148, 39)
        Me.tb_arma2oa.Name = "tb_arma2oa"
        Me.tb_arma2oa.ReadOnly = True
        Me.tb_arma2oa.Size = New System.Drawing.Size(526, 24)
        Me.tb_arma2oa.TabIndex = 9
        '
        'tb_arma3
        '
        Me.tb_arma3.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_arma3.Location = New System.Drawing.Point(148, 102)
        Me.tb_arma3.Name = "tb_arma3"
        Me.tb_arma3.ReadOnly = True
        Me.tb_arma3.Size = New System.Drawing.Size(526, 24)
        Me.tb_arma3.TabIndex = 10
        '
        'tb_arma2oabeta
        '
        Me.tb_arma2oabeta.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_arma2oabeta.Location = New System.Drawing.Point(148, 71)
        Me.tb_arma2oabeta.Name = "tb_arma2oabeta"
        Me.tb_arma2oabeta.ReadOnly = True
        Me.tb_arma2oabeta.Size = New System.Drawing.Size(526, 24)
        Me.tb_arma2oabeta.TabIndex = 11
        '
        'btn_getdir_a2
        '
        Me.btn_getdir_a2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_getdir_a2.Location = New System.Drawing.Point(680, 9)
        Me.btn_getdir_a2.Name = "btn_getdir_a2"
        Me.btn_getdir_a2.Size = New System.Drawing.Size(43, 23)
        Me.btn_getdir_a2.TabIndex = 12
        Me.btn_getdir_a2.Text = "..."
        Me.btn_getdir_a2.UseVisualStyleBackColor = True
        '
        'btn_getdira2oa
        '
        Me.btn_getdira2oa.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_getdira2oa.Location = New System.Drawing.Point(680, 39)
        Me.btn_getdira2oa.Name = "btn_getdira2oa"
        Me.btn_getdira2oa.Size = New System.Drawing.Size(43, 23)
        Me.btn_getdira2oa.TabIndex = 13
        Me.btn_getdira2oa.Text = "..."
        Me.btn_getdira2oa.UseVisualStyleBackColor = True
        '
        'btn_getdira3
        '
        Me.btn_getdira3.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_getdira3.Location = New System.Drawing.Point(680, 101)
        Me.btn_getdira3.Name = "btn_getdira3"
        Me.btn_getdira3.Size = New System.Drawing.Size(43, 23)
        Me.btn_getdira3.TabIndex = 14
        Me.btn_getdira3.Text = "..."
        Me.btn_getdira3.UseVisualStyleBackColor = True
        '
        'btn_getdira2oabeta
        '
        Me.btn_getdira2oabeta.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_getdira2oabeta.Location = New System.Drawing.Point(680, 72)
        Me.btn_getdira2oabeta.Name = "btn_getdira2oabeta"
        Me.btn_getdira2oabeta.Size = New System.Drawing.Size(43, 23)
        Me.btn_getdira2oabeta.TabIndex = 15
        Me.btn_getdira2oabeta.Text = "..."
        Me.btn_getdira2oabeta.UseVisualStyleBackColor = True
        '
        'btn_restoredefault
        '
        Me.btn_restoredefault.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_restoredefault.Location = New System.Drawing.Point(12, 130)
        Me.btn_restoredefault.Name = "btn_restoredefault"
        Me.btn_restoredefault.Size = New System.Drawing.Size(130, 23)
        Me.btn_restoredefault.TabIndex = 16
        Me.btn_restoredefault.Text = "Restore Values"
        Me.btn_restoredefault.UseVisualStyleBackColor = True
        '
        'InstallationCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 165)
        Me.Controls.Add(Me.btn_restoredefault)
        Me.Controls.Add(Me.btn_getdira2oabeta)
        Me.Controls.Add(Me.btn_getdira3)
        Me.Controls.Add(Me.btn_getdira2oa)
        Me.Controls.Add(Me.btn_getdir_a2)
        Me.Controls.Add(Me.tb_arma2oabeta)
        Me.Controls.Add(Me.tb_arma3)
        Me.Controls.Add(Me.tb_arma2oa)
        Me.Controls.Add(Me.tb_arma2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bt_Done)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "InstallationCheck"
        Me.Text = "Installation Check"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bt_Done As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_arma2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_arma2oa As System.Windows.Forms.TextBox
    Friend WithEvents tb_arma3 As System.Windows.Forms.TextBox
    Friend WithEvents tb_arma2oabeta As System.Windows.Forms.TextBox
    Friend WithEvents btn_getdir_a2 As System.Windows.Forms.Button
    Friend WithEvents btn_getdira2oa As System.Windows.Forms.Button
    Friend WithEvents btn_getdira3 As System.Windows.Forms.Button
    Friend WithEvents btn_getdira2oabeta As System.Windows.Forms.Button
    Friend WithEvents fbd_diag As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btn_restoredefault As System.Windows.Forms.Button
End Class
