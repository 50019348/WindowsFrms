using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInput
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult Result;

            Result = MessageBox.Show("Are you sure you wish to clear?", "Clear", MessageBoxButtons.YesNo);
        
            if (Result == DialogResult.Yes)
            {
                txtForename.Text = null;
                txtSurename.Text = null;
                txtAge.Text = null;
            }
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strForename = txtForename.Text;
            string strSurname = txtSurename.Text;
            int intAge = Convert.ToInt32(txtAge.Text);

            MessageBox.Show("First Name: " + strForename + " Second Name: " + strSurname + "\nAge", "User Input");



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Result;

            Result = MessageBox.Show("Are you sure you wish to Exit?", "Exit", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }

                
        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }
    }
}
