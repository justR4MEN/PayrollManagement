<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMngPayroll = New System.Windows.Forms.Button()
        Me.btnDatabase = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnLogoutExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(101, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome , {Username}"
        '
        'btnMngPayroll
        '
        Me.btnMngPayroll.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMngPayroll.Location = New System.Drawing.Point(150, 97)
        Me.btnMngPayroll.Name = "btnMngPayroll"
        Me.btnMngPayroll.Size = New System.Drawing.Size(161, 36)
        Me.btnMngPayroll.TabIndex = 1
        Me.btnMngPayroll.Text = "Manage Payrolls"
        Me.btnMngPayroll.UseVisualStyleBackColor = True
        '
        'btnDatabase
        '
        Me.btnDatabase.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDatabase.Location = New System.Drawing.Point(150, 152)
        Me.btnDatabase.Name = "btnDatabase"
        Me.btnDatabase.Size = New System.Drawing.Size(161, 63)
        Me.btnDatabase.TabIndex = 2
        Me.btnDatabase.Text = "Database Search and Report Generation"
        Me.btnDatabase.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogout.Location = New System.Drawing.Point(114, 245)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(74, 31)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnLogoutExit
        '
        Me.btnLogoutExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogoutExit.Location = New System.Drawing.Point(236, 245)
        Me.btnLogoutExit.Name = "btnLogoutExit"
        Me.btnLogoutExit.Size = New System.Drawing.Size(131, 31)
        Me.btnLogoutExit.TabIndex = 4
        Me.btnLogoutExit.Text = "Logout and Exit"
        Me.btnLogoutExit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 311)
        Me.Controls.Add(Me.btnLogoutExit)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnDatabase)
        Me.Controls.Add(Me.btnMngPayroll)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnMngPayroll As Button
    Friend WithEvents btnDatabase As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnLogoutExit As Button
End Class
