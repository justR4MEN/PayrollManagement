<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.txtEmployeeSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalarySearch = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.btnDeleteEmployee = New System.Windows.Forms.Button()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnLoadRecord = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEmployeeSearch
        '
        Me.txtEmployeeSearch.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmployeeSearch.Location = New System.Drawing.Point(517, 66)
        Me.txtEmployeeSearch.Name = "txtEmployeeSearch"
        Me.txtEmployeeSearch.Size = New System.Drawing.Size(241, 36)
        Me.txtEmployeeSearch.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(326, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee Search:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(776, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Weekly Salary Search:"
        '
        'txtSalarySearch
        '
        Me.txtSalarySearch.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSalarySearch.Location = New System.Drawing.Point(1006, 66)
        Me.txtSalarySearch.Name = "txtSalarySearch"
        Me.txtSalarySearch.Size = New System.Drawing.Size(130, 36)
        Me.txtSalarySearch.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(363, 127)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(773, 386)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddEmployee.Location = New System.Drawing.Point(381, 537)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(168, 38)
        Me.btnAddEmployee.TabIndex = 5
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'btnDeleteEmployee
        '
        Me.btnDeleteEmployee.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDeleteEmployee.Location = New System.Drawing.Point(637, 537)
        Me.btnDeleteEmployee.Name = "btnDeleteEmployee"
        Me.btnDeleteEmployee.Size = New System.Drawing.Size(180, 38)
        Me.btnDeleteEmployee.TabIndex = 6
        Me.btnDeleteEmployee.Text = "Delete Employee"
        Me.btnDeleteEmployee.UseVisualStyleBackColor = True
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGenerateReport.Location = New System.Drawing.Point(882, 537)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(168, 38)
        Me.btnGenerateReport.TabIndex = 7
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReturn.Location = New System.Drawing.Point(381, 673)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(159, 37)
        Me.btnReturn.TabIndex = 8
        Me.btnReturn.Text = "Return To Menu"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnLoadRecord
        '
        Me.btnLoadRecord.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLoadRecord.Location = New System.Drawing.Point(890, 673)
        Me.btnLoadRecord.Name = "btnLoadRecord"
        Me.btnLoadRecord.Size = New System.Drawing.Size(160, 37)
        Me.btnLoadRecord.TabIndex = 9
        Me.btnLoadRecord.Text = "Load Record"
        Me.btnLoadRecord.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1737, 933)
        Me.Controls.Add(Me.btnLoadRecord)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.btnDeleteEmployee)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtSalarySearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmployeeSearch)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmployeeSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSalarySearch As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnDeleteEmployee As Button
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnLoadRecord As Button
End Class
