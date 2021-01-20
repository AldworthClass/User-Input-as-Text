using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Input_as_Text
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            // Declare local variables
            string item;
            int quantity;
            double price, totalPrice;

            // Assign values to Variables
            item = txtItem.Text;
            price = Convert.ToDouble(txtPrice.Text);
            quantity = Convert.ToInt32(txtQuantity.Text);

            // Makes sure negative numbers have not been typed
            if (price < 0 || quantity < 0)
            {
                lblTotalPrice.Text = "Please enter positive values.";
            }
            else
            {
                totalPrice = price * quantity;

                // Output Result
                lblTotalPrice.Text = "Final Price for " + quantity + " " + item + "(s) is: " + totalPrice.ToString("C");
            }
            
        }
    }
}
