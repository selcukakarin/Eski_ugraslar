namespace ThirdAssignment
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
            this.txtx6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mydatagrid = new System.Windows.Forms.DataGridView();
            this.IntegrationResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummationResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtx5 = new System.Windows.Forms.TextBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.txtx4 = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFunction = new System.Windows.Forms.Label();
            this.chck1 = new System.Windows.Forms.CheckBox();
            this.txtx3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chck2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mydatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtx6
            // 
            this.txtx6.Location = new System.Drawing.Point(581, 36);
            this.txtx6.Name = "txtx6";
            this.txtx6.Size = new System.Drawing.Size(100, 20);
            this.txtx6.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "h value";
            // 
            // mydatagrid
            // 
            this.mydatagrid.AllowUserToAddRows = false;
            this.mydatagrid.AllowUserToDeleteRows = false;
            this.mydatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mydatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntegrationResult,
            this.SummationResult});
            this.mydatagrid.Location = new System.Drawing.Point(44, 83);
            this.mydatagrid.Name = "mydatagrid";
            this.mydatagrid.ReadOnly = true;
            this.mydatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mydatagrid.Size = new System.Drawing.Size(416, 241);
            this.mydatagrid.TabIndex = 57;
            // 
            // IntegrationResult
            // 
            this.IntegrationResult.HeaderText = "IntegrationResult";
            this.IntegrationResult.Name = "IntegrationResult";
            this.IntegrationResult.ReadOnly = true;
            // 
            // SummationResult
            // 
            this.SummationResult.HeaderText = "SummationResult";
            this.SummationResult.Name = "SummationResult";
            this.SummationResult.ReadOnly = true;
            // 
            // txtx5
            // 
            this.txtx5.Location = new System.Drawing.Point(542, 203);
            this.txtx5.Name = "txtx5";
            this.txtx5.Size = new System.Drawing.Size(100, 20);
            this.txtx5.TabIndex = 56;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(539, 187);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(63, 13);
            this.lblFinish.TabIndex = 55;
            this.lblFinish.Text = "Finish value";
            // 
            // txtx4
            // 
            this.txtx4.Location = new System.Drawing.Point(542, 145);
            this.txtx4.Name = "txtx4";
            this.txtx4.Size = new System.Drawing.Size(100, 20);
            this.txtx4.TabIndex = 54;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(539, 127);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(58, 13);
            this.lblStart.TabIndex = 53;
            this.lblStart.Text = "Start value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(32, 9);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(48, 13);
            this.lblFunction.TabIndex = 51;
            this.lblFunction.Text = "Function";
            // 
            // chck1
            // 
            this.chck1.AutoSize = true;
            this.chck1.Location = new System.Drawing.Point(162, 38);
            this.chck1.Name = "chck1";
            this.chck1.Size = new System.Drawing.Size(32, 17);
            this.chck1.TabIndex = 49;
            this.chck1.Text = "+";
            this.chck1.UseVisualStyleBackColor = true;
            // 
            // txtx3
            // 
            this.txtx3.Location = new System.Drawing.Point(399, 36);
            this.txtx3.Name = "txtx3";
            this.txtx3.Size = new System.Drawing.Size(100, 20);
            this.txtx3.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "constant";
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(209, 36);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(100, 20);
            this.txtx2.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "x";
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(32, 36);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(100, 20);
            this.txtx1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "x²";
            // 
            // chck2
            // 
            this.chck2.AutoSize = true;
            this.chck2.Location = new System.Drawing.Point(348, 37);
            this.chck2.Name = "chck2";
            this.chck2.Size = new System.Drawing.Size(32, 17);
            this.chck2.TabIndex = 50;
            this.chck2.Text = "+";
            this.chck2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtx6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mydatagrid);
            this.Controls.Add(this.txtx5);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.txtx4);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.chck1);
            this.Controls.Add(this.txtx3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chck2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mydatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtx6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView mydatagrid;
        private System.Windows.Forms.TextBox txtx5;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.TextBox txtx4;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.CheckBox chck1;
        private System.Windows.Forms.TextBox txtx3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chck2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntegrationResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummationResult;
    }
}

