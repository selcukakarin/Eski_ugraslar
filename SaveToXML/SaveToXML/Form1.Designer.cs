namespace SaveToXML
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetTheInformations = new System.Windows.Forms.Button();
            this.btnSaveXML = new System.Windows.Forms.Button();
            this.txtDormID = new System.Windows.Forms.TextBox();
            this.lblDormID = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dgRegistiration = new System.Windows.Forms.DataGridView();
            this.StudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDormRoom = new System.Windows.Forms.TextBox();
            this.lblDormRoom = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistiration)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Go to Form2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetTheInformations
            // 
            this.btnGetTheInformations.Location = new System.Drawing.Point(381, 414);
            this.btnGetTheInformations.Name = "btnGetTheInformations";
            this.btnGetTheInformations.Size = new System.Drawing.Size(139, 23);
            this.btnGetTheInformations.TabIndex = 9;
            this.btnGetTheInformations.Text = "Get the informations";
            this.btnGetTheInformations.UseVisualStyleBackColor = true;
            this.btnGetTheInformations.Click += new System.EventHandler(this.btnGetTheInformations_Click);
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.Location = new System.Drawing.Point(220, 414);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(140, 23);
            this.btnSaveXML.TabIndex = 8;
            this.btnSaveXML.Text = "Save XML";
            this.btnSaveXML.UseVisualStyleBackColor = true;
            this.btnSaveXML.Click += new System.EventHandler(this.btnSaveXML_Click);
            // 
            // txtDormID
            // 
            this.txtDormID.Location = new System.Drawing.Point(93, 72);
            this.txtDormID.Name = "txtDormID";
            this.txtDormID.Size = new System.Drawing.Size(100, 20);
            this.txtDormID.TabIndex = 10;
            // 
            // lblDormID
            // 
            this.lblDormID.AutoSize = true;
            this.lblDormID.Location = new System.Drawing.Point(6, 75);
            this.lblDormID.Name = "lblDormID";
            this.lblDormID.Size = new System.Drawing.Size(43, 13);
            this.lblDormID.TabIndex = 9;
            this.lblDormID.Text = "DormID";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(320, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(242, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(365, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(540, 113);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(320, 72);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(93, 30);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStudentNumber.TabIndex = 3;
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(6, 33);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(84, 13);
            this.lblStudentNo.TabIndex = 2;
            this.lblStudentNo.Text = "Student Number";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(242, 75);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // dgRegistiration
            // 
            this.dgRegistiration.AllowUserToAddRows = false;
            this.dgRegistiration.AllowUserToDeleteRows = false;
            this.dgRegistiration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistiration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNumber,
            this.DormID,
            this.FirstName,
            this.LastName,
            this.DormRoom,
            this.StudentTel,
            this.StudentMail,
            this.Age});
            this.dgRegistiration.Location = new System.Drawing.Point(17, 168);
            this.dgRegistiration.Name = "dgRegistiration";
            this.dgRegistiration.ReadOnly = true;
            this.dgRegistiration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRegistiration.Size = new System.Drawing.Size(877, 212);
            this.dgRegistiration.TabIndex = 1;
            this.dgRegistiration.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgRegistiration_MouseClick);
            // 
            // StudentNumber
            // 
            this.StudentNumber.HeaderText = "StudentNumber";
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.ReadOnly = true;
            // 
            // DormID
            // 
            this.DormID.HeaderText = "DormID";
            this.DormID.Name = "DormID";
            this.DormID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // DormRoom
            // 
            this.DormRoom.HeaderText = "DormRoom";
            this.DormRoom.Name = "DormRoom";
            this.DormRoom.ReadOnly = true;
            // 
            // StudentTel
            // 
            this.StudentTel.HeaderText = "StudentTel";
            this.StudentTel.Name = "StudentTel";
            this.StudentTel.ReadOnly = true;
            // 
            // StudentMail
            // 
            this.StudentMail.HeaderText = "StudentMail";
            this.StudentMail.Name = "StudentMail";
            this.StudentMail.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.lblTel);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.lblMail);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.txtDormRoom);
            this.groupBox2.Controls.Add(this.lblDormRoom);
            this.groupBox2.Controls.Add(this.lblAge);
            this.groupBox2.Controls.Add(this.txtDormID);
            this.groupBox2.Controls.Add(this.lblDormID);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.lblFirstName);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.txtStudentNumber);
            this.groupBox2.Controls.Add(this.lblStudentNo);
            this.groupBox2.Controls.Add(this.lblLastName);
            this.groupBox2.Location = new System.Drawing.Point(17, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 142);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Information";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(531, 72);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 18;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(453, 75);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(59, 13);
            this.lblTel.TabIndex = 17;
            this.lblTel.Text = "StudentTel";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(767, 30);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 15;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(689, 33);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(66, 13);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Student Mail";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(767, 72);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 16;
            // 
            // txtDormRoom
            // 
            this.txtDormRoom.Location = new System.Drawing.Point(531, 30);
            this.txtDormRoom.Name = "txtDormRoom";
            this.txtDormRoom.Size = new System.Drawing.Size(100, 20);
            this.txtDormRoom.TabIndex = 14;
            // 
            // lblDormRoom
            // 
            this.lblDormRoom.AutoSize = true;
            this.lblDormRoom.Location = new System.Drawing.Point(453, 33);
            this.lblDormRoom.Name = "lblDormRoom";
            this.lblDormRoom.Size = new System.Drawing.Size(63, 13);
            this.lblDormRoom.TabIndex = 13;
            this.lblDormRoom.Text = "Dorm Room";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(689, 75);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgRegistiration);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 396);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domitory Register";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetTheInformations);
            this.Controls.Add(this.btnSaveXML);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistiration)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGetTheInformations;
        private System.Windows.Forms.Button btnSaveXML;
        private System.Windows.Forms.TextBox txtDormID;
        private System.Windows.Forms.Label lblDormID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DataGridView dgRegistiration;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDormRoom;
        private System.Windows.Forms.Label lblDormRoom;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
    }
}

