
namespace modeless2
{
    partial class DemoDialog
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
            this.lblDemo = new System.Windows.Forms.Label();
            this.txtDemoInDialog = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDemo
            // 
            this.lblDemo.AutoSize = true;
            this.lblDemo.Location = new System.Drawing.Point(57, 44);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(35, 13);
            this.lblDemo.TabIndex = 0;
            this.lblDemo.Text = "Demo";
            // 
            // txtDemoInDialog
            // 
            this.txtDemoInDialog.Location = new System.Drawing.Point(108, 44);
            this.txtDemoInDialog.Name = "txtDemoInDialog";
            this.txtDemoInDialog.Size = new System.Drawing.Size(268, 20);
            this.txtDemoInDialog.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(93, 102);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(193, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(291, 102);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // DemoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 157);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDemoInDialog);
            this.Controls.Add(this.lblDemo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DemoDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DemoDialog";
            this.Load += new System.EventHandler(this.DemoDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDemo;
        private System.Windows.Forms.TextBox txtDemoInDialog;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
    }
}