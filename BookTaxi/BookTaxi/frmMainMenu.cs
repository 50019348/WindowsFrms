using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookTaxi
{
    public partial class frmMainMenu : Form
    {

        string[] strBookingNumber = new string[5];
        string[] strCustomerName = new string[5];
        string[] strStartLocation = new string[5];
        string[] strEndLocation = new string[5];

        int iArrayCounter = 0;



        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Are you sure you wish to exit?", "Exit?", MessageBoxButtons.YesNo);



            if (Exit == DialogResult.Yes)

            {

                Application.Exit();

            }



            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                strBookingNumber[iArrayCounter] = txtBookingNumber.Text;
                strCustomerName[iArrayCounter] = txtBookingNumber.Text;
                strStartLocation[iArrayCounter] = txtStartLocation.Text;
                strEndLocation[iArrayCounter] = txtEndLocation.Text;

                iArrayCounter++;
                MessageBox.Show("Record Saved!");

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Max records saved!");
                btnSave.Visible = false;

            }


        }
        void Clear()
        {
            txtBookingNumber.Text = null;
            txtCustomerName.Text = null;
            txtStartLocation.Text = null;
            txtEndLocation.Text = null;


        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            lstAllBookings.Items.Clear();

            for (int i = 0; i < iArrayCounter; i++)
            {
                lstAllBookings.Items.Add(strBookingNumber[i]);
                lstAllBookings.Items.Add(strCustomerName[i]);
                lstAllBookings.Items.Add(strStartLocation[i]);
                lstAllBookings.Items.Add(strEndLocation[i]);
            }
        }
    }
}
