
namespace ModelessDialog
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
            this.btnModal = new System.Windows.Forms.Button();
            this.Modeless = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(271, 26);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(75, 23);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modeless
            // 
            this.Modeless.Location = new System.Drawing.Point(271, 103);
            this.Modeless.Name = "Modeless";
            this.Modeless.Size = new System.Drawing.Size(75, 23);
            this.Modeless.TabIndex = 1;
            this.Modeless.Text = "modeless";
            this.Modeless.UseVisualStyleBackColor = true;
            this.Modeless.Click += new System.EventHandler(this.Modeless_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 154);
            this.Controls.Add(this.Modeless);
            this.Controls.Add(this.btnModal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button Modeless;
    }
}

