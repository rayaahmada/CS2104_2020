using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string FirstName = txtFName.Text;
            string MiddleName = txtMName.Text;
            string LastName = txtLName.Text;
            var DateOfBirth = dtpDOB.Value;
            var Program = cmbProgram.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(FirstName)|| string.IsNullOrWhiteSpace(MiddleName))
            {
                MessageBox.Show("Please Enter your first Name");
            }

            if(DateOfBirth > DateTime.Now) {
                MessageBox.Show("Invalid Date");
            }
            else
            {
                MessageBox.Show($"First Name: { FirstName}\n\r" +
                    $"Middle Name: { MiddleName}\n\r" +
                    $"Last Name: { LastName}\n\r" +
                    $"Date Of Birth: {DateOfBirth}\n\r" +
                    $"Program: { Program}\n\r"
                   );
            }
        }
    }
}
