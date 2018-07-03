<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.button1 = New System.Windows.Forms.Button()
        Me.btnImportInfo = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLicensePlate = New System.Windows.Forms.TextBox()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblIdentity = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblSchool = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblAvgNote = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentClass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.School = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Average = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupBox1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(351, 472)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 10
        Me.button1.Text = "Go txt form"
        Me.button1.UseVisualStyleBackColor = True
        '
        'btnImportInfo
        '
        Me.btnImportInfo.Location = New System.Drawing.Point(449, 472)
        Me.btnImportInfo.Name = "btnImportInfo"
        Me.btnImportInfo.Size = New System.Drawing.Size(192, 23)
        Me.btnImportInfo.TabIndex = 9
        Me.btnImportInfo.Text = "Import information from xml file"
        Me.btnImportInfo.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(179, 472)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(140, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save as xml file"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.dataGridView1)
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.Controls.Add(Me.btnRemove)
        Me.groupBox1.Controls.Add(Me.btnAdd)
        Me.groupBox1.Controls.Add(Me.btnUpdate)
        Me.groupBox1.Location = New System.Drawing.Point(12, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(776, 450)
        Me.groupBox1.TabIndex = 7
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "StudentSystem"
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.StudentClass, Me.FirstName, Me.LastName, Me.Telephone, Me.Email, Me.School, Me.Average})
        Me.dataGridView1.Location = New System.Drawing.Point(44, 279)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(684, 165)
        Me.dataGridView1.TabIndex = 1
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.TextBox1)
        Me.groupBox2.Controls.Add(Me.lblEmail)
        Me.groupBox2.Controls.Add(Me.TextBox2)
        Me.groupBox2.Controls.Add(Me.lblSchool)
        Me.groupBox2.Controls.Add(Me.TextBox3)
        Me.groupBox2.Controls.Add(Me.TextBox4)
        Me.groupBox2.Controls.Add(Me.lblTelephone)
        Me.groupBox2.Controls.Add(Me.lblAvgNote)
        Me.groupBox2.Controls.Add(Me.txtLicensePlate)
        Me.groupBox2.Controls.Add(Me.lblClass)
        Me.groupBox2.Controls.Add(Me.txtFirstName)
        Me.groupBox2.Controls.Add(Me.lblFirstName)
        Me.groupBox2.Controls.Add(Me.txtLastName)
        Me.groupBox2.Controls.Add(Me.txtID)
        Me.groupBox2.Controls.Add(Me.lblIdentity)
        Me.groupBox2.Controls.Add(Me.lblLastName)
        Me.groupBox2.Location = New System.Drawing.Point(159, 19)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(481, 235)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "StudentRegister"
        '
        'txtLicensePlate
        '
        Me.txtLicensePlate.Location = New System.Drawing.Point(117, 72)
        Me.txtLicensePlate.Name = "txtLicensePlate"
        Me.txtLicensePlate.Size = New System.Drawing.Size(100, 20)
        Me.txtLicensePlate.TabIndex = 10
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(39, 75)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(32, 13)
        Me.lblClass.TabIndex = 9
        Me.lblClass.Text = "Class"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(117, 108)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(39, 111)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(43, 130)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(61, 23)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(44, 84)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(60, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(43, 38)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(61, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(117, 150)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(117, 30)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 3
        '
        'lblIdentity
        '
        Me.lblIdentity.AutoSize = True
        Me.lblIdentity.Location = New System.Drawing.Point(39, 33)
        Me.lblIdentity.Name = "lblIdentity"
        Me.lblIdentity.Size = New System.Drawing.Size(56, 13)
        Me.lblIdentity.TabIndex = 2
        Me.lblIdentity.Text = "Id Number"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(39, 153)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(330, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 18
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(252, 75)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 17
        Me.lblEmail.Text = "Email"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(330, 108)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 15
        '
        'lblSchool
        '
        Me.lblSchool.AutoSize = True
        Me.lblSchool.Location = New System.Drawing.Point(252, 111)
        Me.lblSchool.Name = "lblSchool"
        Me.lblSchool.Size = New System.Drawing.Size(40, 13)
        Me.lblSchool.TabIndex = 11
        Me.lblSchool.Text = "School"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(330, 150)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(330, 30)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 14
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(252, 33)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(58, 13)
        Me.lblTelephone.TabIndex = 13
        Me.lblTelephone.Text = "Telephone"
        '
        'lblAvgNote
        '
        Me.lblAvgNote.AutoSize = True
        Me.lblAvgNote.Location = New System.Drawing.Point(252, 153)
        Me.lblAvgNote.Name = "lblAvgNote"
        Me.lblAvgNote.Size = New System.Drawing.Size(70, 13)
        Me.lblAvgNote.TabIndex = 12
        Me.lblAvgNote.Text = "AverageNote"
        '
        'ID
        '
        Me.ID.HeaderText = "IdNumber"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 80
        '
        'StudentClass
        '
        Me.StudentClass.HeaderText = "Class"
        Me.StudentClass.Name = "StudentClass"
        Me.StudentClass.ReadOnly = True
        Me.StudentClass.Width = 80
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "FirstName"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Width = 80
        '
        'LastName
        '
        Me.LastName.HeaderText = "LastName"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Width = 80
        '
        'Telephone
        '
        Me.Telephone.HeaderText = "Telephone"
        Me.Telephone.Name = "Telephone"
        Me.Telephone.ReadOnly = True
        Me.Telephone.Width = 80
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 80
        '
        'School
        '
        Me.School.HeaderText = "School"
        Me.School.Name = "School"
        Me.School.ReadOnly = True
        Me.School.Width = 80
        '
        'Average
        '
        Me.Average.HeaderText = "Average"
        Me.Average.Name = "Average"
        Me.Average.ReadOnly = True
        Me.Average.Width = 80
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 507)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.btnImportInfo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.groupBox1.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button1 As Button
    Private WithEvents btnImportInfo As Button
    Private WithEvents btnSave As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents txtLicensePlate As TextBox
    Private WithEvents lblClass As Label
    Private WithEvents txtFirstName As TextBox
    Private WithEvents lblFirstName As Label
    Private WithEvents btnRemove As Button
    Private WithEvents btnUpdate As Button
    Private WithEvents btnAdd As Button
    Private WithEvents txtLastName As TextBox
    Private WithEvents txtID As TextBox
    Private WithEvents lblIdentity As Label
    Private WithEvents lblLastName As Label
    Private WithEvents TextBox1 As TextBox
    Private WithEvents lblEmail As Label
    Private WithEvents TextBox2 As TextBox
    Private WithEvents lblSchool As Label
    Private WithEvents TextBox3 As TextBox
    Private WithEvents TextBox4 As TextBox
    Private WithEvents lblTelephone As Label
    Private WithEvents lblAvgNote As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents StudentClass As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents Telephone As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents School As DataGridViewTextBoxColumn
    Friend WithEvents Average As DataGridViewTextBoxColumn
End Class
