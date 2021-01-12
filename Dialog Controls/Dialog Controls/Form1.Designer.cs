
namespace Dialog_Controls
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
            this.ColorTextbox = new System.Windows.Forms.TextBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.FolderButton = new System.Windows.Forms.Button();
            this.FolderTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.OpenTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SaveTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FontButton = new System.Windows.Forms.Button();
            this.FontTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ColorTextbox
            // 
            this.ColorTextbox.Location = new System.Drawing.Point(68, 7);
            this.ColorTextbox.Name = "ColorTextbox";
            this.ColorTextbox.Size = new System.Drawing.Size(100, 20);
            this.ColorTextbox.TabIndex = 1;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(174, 7);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 20);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "Browse";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // FolderButton
            // 
            this.FolderButton.Location = new System.Drawing.Point(174, 33);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(75, 20);
            this.FolderButton.TabIndex = 5;
            this.FolderButton.Text = "Browse";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // FolderTextbox
            // 
            this.FolderTextbox.Location = new System.Drawing.Point(68, 33);
            this.FolderTextbox.Name = "FolderTextbox";
            this.FolderTextbox.Size = new System.Drawing.Size(100, 20);
            this.FolderTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(174, 59);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 20);
            this.OpenButton.TabIndex = 8;
            this.OpenButton.Text = "Browse";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // OpenTextbox
            // 
            this.OpenTextbox.Location = new System.Drawing.Point(68, 59);
            this.OpenTextbox.Name = "OpenTextbox";
            this.OpenTextbox.Size = new System.Drawing.Size(100, 20);
            this.OpenTextbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Open";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(174, 85);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 20);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Browse";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SaveTextbox
            // 
            this.SaveTextbox.Location = new System.Drawing.Point(68, 85);
            this.SaveTextbox.Name = "SaveTextbox";
            this.SaveTextbox.Size = new System.Drawing.Size(100, 20);
            this.SaveTextbox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Save";
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(174, 111);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(75, 20);
            this.FontButton.TabIndex = 14;
            this.FontButton.Text = "Browse";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // FontTextbox
            // 
            this.FontTextbox.Location = new System.Drawing.Point(68, 111);
            this.FontTextbox.Name = "FontTextbox";
            this.FontTextbox.Size = new System.Drawing.Size(100, 20);
            this.FontTextbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Font";
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 141);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.FontTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.SaveTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.OpenTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.FolderTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.ColorTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColorTextbox;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.TextBox FolderTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TextBox OpenTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox SaveTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.TextBox FontTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

