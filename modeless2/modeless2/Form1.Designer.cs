
namespace modeless2
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
            this.btnShowDemo = new System.Windows.Forms.Button();
            this.txtDemoInForm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowDemo
            // 
            this.btnShowDemo.Location = new System.Drawing.Point(355, 98);
            this.btnShowDemo.Name = "btnShowDemo";
            this.btnShowDemo.Size = new System.Drawing.Size(75, 23);
            this.btnShowDemo.TabIndex = 0;
            this.btnShowDemo.Text = "Show Demo";
            this.btnShowDemo.UseVisualStyleBackColor = true;
            this.btnShowDemo.Click += new System.EventHandler(this.btnShowDemo_Click);
            // 
            // txtDemoInForm
            // 
            this.txtDemoInForm.Location = new System.Drawing.Point(257, 52);
            this.txtDemoInForm.Name = "txtDemoInForm";
            this.txtDemoInForm.Size = new System.Drawing.Size(173, 20);
            this.txtDemoInForm.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 156);
            this.Controls.Add(this.txtDemoInForm);
            this.Controls.Add(this.btnShowDemo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowDemo;
        public System.Windows.Forms.TextBox txtDemoInForm;
    }
}

