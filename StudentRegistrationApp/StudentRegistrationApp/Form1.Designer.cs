
namespace StudentRegistrationApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProgram = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENTS REGISTRATION APLICATION";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(24, 68);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(153, 20);
            this.txtFName.TabIndex = 1;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(20, 45);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(86, 20);
            this.lblStudent.TabIndex = 2;
            this.lblStudent.Text = "First Name";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(24, 137);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 3;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(24, 114);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(97, 20);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date of birth";
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(219, 68);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(153, 20);
            this.txtMName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Middle Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(448, 68);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(153, 20);
            this.txtLName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name";
            // 
            // cmbProgram
            // 
            this.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgram.FormattingEnabled = true;
            this.cmbProgram.Items.AddRange(new object[] {
            "BITAM",
            "BSC",
            "BAGES",
            "BITA",
            "BATMM"});
            this.cmbProgram.Location = new System.Drawing.Point(717, 68);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Size = new System.Drawing.Size(162, 21);
            this.cmbProgram.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(713, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose Your Program";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(636, 170);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(78, 43);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 516);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProgram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProgram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
    }
}

