using System.Globalization;

namespace Exercise4A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetAll();

            // reseting the price of total price to 0
            float price = 0;
            lblTotalPrice.Text = price.ToString("C", new CultureInfo("en-FR"));
        }

        // Reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetAll();

        }

        // Reset all method
        private void resetAll()
        {
            rbPersonal.Checked = true;
            
            // reseting special requirement textbox
            txtSpecialRequirements.Text = " ";

            // reset pizza name
            lstName.SelectedItem = null;

            // reseting extra toppings section
            foreach (Control c in gbExtraToppings.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    float price = 0;
                    if (cb.Checked == true)
                    {
                        cb.Checked = false;
                        lblTotalPrice.Text = price.ToString("C", new CultureInfo("en-FR"));
                    }
                }
            }
        }

        // Calculate Price method
        private void CalculatePrice()
        {
            float price = 0f;
            float pizzaPrice = 2.99f;
            float extraToppings = 0.99f;
            float personal = 4.99f;
            float small = 6.99f;
            float medium = 8.99f;
            float large = 10.99f;

            // pizza name
            foreach(var item in lstName.SelectedItems)
            {
                price = price + pizzaPrice;
            }

            // extra toppings
            foreach (Control c in gbExtraToppings.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if (cb.Checked == true)
                    {
                        price = price + extraToppings;
                        lblTotalPrice.Text = price.ToString("F");
                    }
                }
            }

            // pizza size
            if (rbPersonal.Checked)
            {
                price = price + personal;
            }
            else if (rbSmall.Checked)
            {
                price = price + small;
            }
            else if (rbMedium.Checked)
            {
                price = price + medium;
            }
            else if (rbLarge.Checked)
            {
                price = price + large;
            }
            
            // total price printed on screen
            lblTotalPrice.Text = "€ " + price.ToString("F");
        }

        // Message Box Pop
        private void MessageBoxPop()
        {
            string message = "";

            // selection of pizza size
            if (rbPersonal.Checked)
            {
                message = message + "You have selected Personal ";
            }
            else if (rbSmall.Checked)
            {
                message = message + "You have selected Small ";
            }
            else if (rbMedium.Checked)
            {
                message = message + "You have selected Medium ";
            }

            else if (rbLarge.Checked)
            {
                message = message + "You have selected Large ";
            }

            // selection of pizza name
            string name = string.Empty;
            foreach(var item in lstName.SelectedItems)
            {
                name = name + item + "";
            }

            message = message + " " + name;

            // selection of topping

            string toppings = string.Empty;
            foreach (CheckBox item in gbExtraToppings.Controls)
            {
                if (item.Checked) { 
                    toppings = toppings + ((CheckBox)item).Text + " ";
                }
            }

            message = message + " " + toppings;

            // Adding special requirements

            string text = string.Empty;
             text = txtSpecialRequirements.Text;    

            message = message+ " " + text;

            MessageBox.Show(message, "Your order summary");

            resetAll();
                 
        }

        // Place Order Button
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            CalculatePrice();

            if(lstName.SelectedItem != null)
            {
                MessageBoxPop();
            }
            else
            {
                MessageBox.Show("Please select a pizza name");
            }

        }


        // Extra Topping Event to calculate individual price
        private void ExtraToppingClicked(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        // Pizza size event to calculate individual price
        private void PizzaSizeClicked(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        // List Name event to calculate individual price
        private void lstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
    }
}