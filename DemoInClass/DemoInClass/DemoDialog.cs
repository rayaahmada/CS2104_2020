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
    public partial class DemoDialog : Form
    {
        public DemoDialog()
        {
            InitializeComponent();
        }

        public string DemoText
        {
            get
            {
                return txtDemoInDialog.Text;
            }
            set
            {
                txtDemoInDialog.Text = value;
            }

        }
    }
}
