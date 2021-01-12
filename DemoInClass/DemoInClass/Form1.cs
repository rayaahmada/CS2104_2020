using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoInClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to Close?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon icons = MessageBoxIcon.Error;

            DialogResult r = MessageBox.Show(message,"CONFIRMATION",
                buttons, icons,MessageBoxDefaultButton.Button3
                );

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Activate(); 
            }



        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        DemoDialog dlgDemo;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(dlgDemo == null)
            {
                dlgDemo = new DemoDialog();
                dlgDemo.Show();
                dlgDemo.FormClosed += DlgDemo_FormClosed;
                dlgDemo.DemoText = txtDemoInForm.Text;
                dlgDemo.Owner = this;
            }
            else
            {
                dlgDemo.Activate();
            }
            
        }

        private void DlgDemo_FormClosed(object sender, FormClosedEventArgs e)
        {
            dlgDemo = null;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog cd = new FolderBrowserDialog();
            cd.ShowDialog();
            txtDemoInForm.Text = cd.SelectedPath;


        }
    }
}
