using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            ColorTextbox.Text = "(" + cd.Color.R + ", " + cd.Color.G + ", " + cd.Color.B + ")";
            
        }


        private void FolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            FolderTextbox.Text = fbd.SelectedPath;

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            OpenTextbox.Text = ofd.FileName;

            //this.ofd.multiselect = true;
            //foreach (string file in ofd.filenames)
            //{
            //    messagebox.show(file);
            //}

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            
            SaveTextbox.Text = sfd.FileName;
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();

            FontTextbox.Text = fd.Font.Name;
           
        }
    }
}
