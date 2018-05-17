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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSaveTest = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtToString = New System.Windows.Forms.TextBox()
        Me.txtStringBudder = New System.Windows.Forms.TextBox()
        Me.btnToString = New System.Windows.Forms.Button()
        Me.btnStringBudder = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(177, 211)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'btnSaveTest
        '
        Me.btnSaveTest.Location = New System.Drawing.Point(12, 197)
        Me.btnSaveTest.Name = "btnSaveTest"
        Me.btnSaveTest.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveTest.TabIndex = 2
        Me.btnSaveTest.Text = "SaveTest"
        Me.btnSaveTest.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(142, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "testMathRoud"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 171)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'txtToString
        '
        Me.txtToString.Location = New System.Drawing.Point(341, 12)
        Me.txtToString.Multiline = True
        Me.txtToString.Name = "txtToString"
        Me.txtToString.Size = New System.Drawing.Size(138, 118)
        Me.txtToString.TabIndex = 5
        '
        'txtStringBudder
        '
        Me.txtStringBudder.Location = New System.Drawing.Point(485, 12)
        Me.txtStringBudder.Multiline = True
        Me.txtStringBudder.Name = "txtStringBudder"
        Me.txtStringBudder.Size = New System.Drawing.Size(138, 118)
        Me.txtStringBudder.TabIndex = 6
        '
        'btnToString
        '
        Me.btnToString.Location = New System.Drawing.Point(341, 136)
        Me.btnToString.Name = "btnToString"
        Me.btnToString.Size = New System.Drawing.Size(110, 37)
        Me.btnToString.TabIndex = 7
        Me.btnToString.Text = "ToString"
        Me.btnToString.UseVisualStyleBackColor = True
        '
        'btnStringBudder
        '
        Me.btnStringBudder.Location = New System.Drawing.Point(341, 179)
        Me.btnStringBudder.Name = "btnStringBudder"
        Me.btnStringBudder.Size = New System.Drawing.Size(110, 37)
        Me.btnStringBudder.TabIndex = 8
        Me.btnStringBudder.Text = "StringBudder"
        Me.btnStringBudder.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 348)
        Me.Controls.Add(Me.btnStringBudder)
        Me.Controls.Add(Me.btnToString)
        Me.Controls.Add(Me.txtStringBudder)
        Me.Controls.Add(Me.txtToString)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSaveTest)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSaveTest As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtToString As TextBox
    Friend WithEvents txtStringBudder As TextBox
    Friend WithEvents btnToString As Button
    Friend WithEvents btnStringBudder As Button
End Class
