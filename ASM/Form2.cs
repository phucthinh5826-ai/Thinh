using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class Form2 : Form
    {
        // Default constructor
        public Form2()
        {
            InitializeComponent();
        }

        // Constructor to receive data from Form1
        public Form2(string customerName, string typeOfCustomer, int numberOfPeople, double consumption, double totalAmount)
        {
            InitializeComponent();

            // Assign received data to Labels
            lblCustomerName.Text = customerName;
            lblCustomerType.Text = typeOfCustomer;
            lblConsumption.Text = consumption.ToString("N0") + " m³";
            lblTotalAmount.Text = totalAmount.ToString("N0") + " VNĐ";

            // Only show "Number of people" if it is a household customer
            if (typeOfCustomer == "Household customer")
            {
                lblPeople.Text = numberOfPeople.ToString();
            }
            else
            {
                // If not, hide both the "Number of people:" label and its value
                lblPeople.Visible = false; // Replace "label3" with the REAL NAME of the label "Number of people:"
                lblPeople.Visible = false;
            }
        }
        private void lblPeople_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
