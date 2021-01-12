using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modeless2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DemoDialog dlgDemo;
        private void btnShowDemo_Click(object sender, EventArgs e)
        {
            if (dlgDemo==null)
            {
                dlgDemo = new DemoDialog();
            dlgDemo.Owner = this;
             dlgDemo.FormClosed += DlgDemo_FormClosed;
             dlgDemo.DemoText = txtDemoInForm.Text;
            dlgDemo.Show();
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
    }
}
