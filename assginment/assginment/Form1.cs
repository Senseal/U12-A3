using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace assginment
{
    public partial class Form1 : Form
    {// old aray method now unused
        //               Buy    |Sell
        //  Double[] EUR = { 1.1027, 1.2588 };
        // Double[] USD = { 1.3090, 1.4953 };
        //  Double[] TRY = { 9.558, 11.882 };
        // Initalises the arays and sets the values

        // Creates The Tables
        List<Double> EUR = new List<Double>();
        List<Double> USD = new List<Double>();
        List<Double> TRY = new List<Double>();
        List<Double> CUSTOM = new List<Double>();




        public Form1()
        {
            InitializeComponent();
        }
        // Code Ran on form load up
        private void Form1_Load(object sender, EventArgs e)
        {
            //Sets The values for the Table on statrup
            EUR.Add(1.1027);
            EUR.Add(1.2588);
            USD.Add(1.3090);
            USD.Add(1.4953);
            TRY.Add(9.558);
            TRY.Add(11.882);
            CUSTOM.Add(0);
            CUSTOM.Add(0);
            //end

            //sets the values on the Table
            E1.Text = "" + EUR[0];
            E2.Text = "" + EUR[1];
            U1.Text = "" + USD[0];
            U2.Text = "" + USD[1];
            T1.Text = "" + TRY[0];
            T2.Text = "" + TRY[1];
            C1.Text = "0";
            C2.Text = "0";
            //end

        }
        //End
        //Custom Curency input 
        private void Cusstom_imput_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Cus_Buy.Text) && (String.IsNullOrEmpty(Cus_Sell.Text)))
            {
                CUSTOM[0] = 0;
                CUSTOM[1] = 0;
            }
            else if (String.IsNullOrEmpty(Cus_Buy.Text))
            {
                CUSTOM[0] = 0;
                CUSTOM[1] = System.Convert.ToDouble(Cus_Sell.Text);
            }
           else if (String.IsNullOrEmpty(Cus_Sell.Text))
            {
                CUSTOM[0] = System.Convert.ToDouble(Cus_Buy.Text);
                CUSTOM[1] = 0;
            }
            else
            {
                CUSTOM[0] = System.Convert.ToDouble(Cus_Buy.Text);
                CUSTOM[1] = System.Convert.ToDouble(Cus_Sell.Text);

            }

            C1.Text = "" + CUSTOM[0];
            C2.Text = "" + CUSTOM[1];


        }
            
            

        //Conversion Code
        private void EUR_box_Click(object sender, EventArgs e) // Euro Buy
        {

            Double GBP_amount = System.Convert.ToDouble(imput_GBP.Text); // creats a "doulbe" variable, and gives it the value of what the user put into the "GBP_Amount" text box
            Double Output = GBP_amount * EUR[0]; //gets the buy from the table and multiplies GBP_anount by that.
            Output = Math.Round(Output, 2); // rounds the result to 2 decimal places.
            Output_box.Text = "€" + Output; // change the text in Output_box.text to "€(value of "Output")
        }

        private void USD_box_Click(object sender, EventArgs e) // USD Buy
        {
            Double GBP_amount = System.Convert.ToDouble(imput_GBP.Text);  // creats a "doulbe" variable, and gives it the value of what the user put into the "GBP_Amount" text box
            Double Output = GBP_amount * USD[0]; //gets the buy from the table and multiplies GBP_anount by that.
            Output = Math.Round(Output, 2); // rounds the result to 2 decimal places.
            Output_box.Text = "$" + Output; // change the text in Output_box.text to "$(value of "Output")
        }

        private void TRY_box_Click(object sender, EventArgs e) //TRY Buy
        {
            Double GBP_amount = System.Convert.ToDouble(imput_GBP.Text);  // creats a "doulbe" variable, and gives it the value of what the user put into the "GBP_Amount" text box
            Double Output = GBP_amount * TRY[0]; //gets the buy from the Table and multiplies GBP_anount by that.
             Output = Math.Round(Output, 2); // rounds the result to 2 decimal places.
            Output_box.Text = "₺" + Output; // change the text in Output_box.text to "₺(value of "Output")
        }

        private void Custom_Buy_Click(object sender, EventArgs e) // Custom Buy
        {
            Double GBP_amount = System.Convert.ToDouble(imput_GBP.Text);  // creats a "doulbe" variable, and gives it the value of what the user put into the "GBP_Amount" text box
            Double Output = GBP_amount * CUSTOM[0]; //gets the CUSTOM buy from the Table and multiplies GBP_anount by that.
             Output = Math.Round(Output, 2); // rounds the result to 2 decimal places.
            Output_box.Text = "You receive in your currency: " + Output; // change the text in Output_box.text to "You receive in your currency: (value of "Output")
        }

        private void USD_box_sell_Click(object sender, EventArgs e) // USD Sell
        {
            Double USD_amount = System.Convert.ToDouble(Money_imput.Text); // creats a "doulbe" variable, and gives it the value of what the user put into the "USD_Amount" text box
            Double Output = USD_amount / USD[1]; // Divides USD_amount by the 2nd value in the USD table.
             Output = Math.Round(Output, 2); // rounds the result to 2 decimal places.
            Output_box.Text = "£" + Output; // change the text in Output_box.text to "£(value of "Output")
        }

        private void TRY_box_sell_Click(object sender, EventArgs e) // TRY Sell
        {

            Double TRY_amount = System.Convert.ToDouble(Money_imput.Text); // creats a "doulbe" variable, and gives it the value of what the user put into the "TRY_Amount" text box
            Double Output = TRY_amount / TRY[1]; // Divides TRY_amount by the 2nd value in the TRY table.
             Output = Math.Round(Output, 2); // rounds the result to 2 decimal places.
            Output_box.Text = "£" + Output; // change the text in Output_box.text to "£(value of "Output")
        }
        private void EUR_box_sell_Click_1(object sender, EventArgs e) //EUR Sell
        {
            Double EUR_amount = System.Convert.ToDouble(Money_imput.Text); // creats a "doulbe" variable, and gives it the value of what the user put into the "EUR_imput" text box
            Double Output = EUR_amount / EUR[1]; // Divides EUR_Amount by the value in EUR[1]
             Output = Math.Round(Output, 2); // rounds the result to 2 decimal places.
            Output_box.Text = "£" + Output; // change the text in Output_box.text to "£(value of "Output")
        }

        private void Custom_Sell_Click(object sender, EventArgs e)// Custom Sell
        {
            Double CUS_Amount = System.Convert.ToDouble(Money_imput.Text);
            Double Output = CUS_Amount / CUSTOM[1]; // Divides CUS_Amount by the value in CUSTOM[1]
             Output = Math.Round(Output, 2); // rounds the result to 2 decimal places.
            Output_box.Text = "£" + Output; // change the text in Output_box.text to "You receive in your currency: (value of "Output")
        }
        //End


        //Mouse over Info box's
        private void Info_buy_MouseLeave_1(object sender, EventArgs e) // when the mouse is  Not over the I box in the Buy section do,
        {
            Buy_info.BackColor = System.Drawing.Color.Transparent; // Make the text transparent
            Buy_info.ForeColor = System.Drawing.Color.LemonChiffon; // change the background colour to Lemon Chiffon
        }

        private void Sell_Info_MouseLeave(object sender, EventArgs e) // when the mouse is  Not over the I box in the sell section do,
        {
            Sell_text.BackColor = System.Drawing.Color.Transparent; // make the text transparent
            Sell_text.ForeColor = System.Drawing.Color.LemonChiffon; // change the background colour to Lemon Chiffon
        }

        private void Sell_Info_MouseHover(object sender, EventArgs e) // when mouse is over the I box in the Sell section do,
        {
            Sell_text.BackColor = System.Drawing.Color.LightGray; // change the background colour to  LightGray
            Sell_text.ForeColor = System.Drawing.Color.Black; // change the text to black 

        }

        private void Info_buy_MouseHover(object sender, EventArgs e) // when mouse is over the I box in the buy section do,
        {
            Buy_info.BackColor = System.Drawing.Color.LightGray; // change the background colour to  LightGray
            Buy_info.ForeColor = System.Drawing.Color.Black;  // change the background colour to  LightGray
        }
        //End

        //Code that Prevents Text from going in the Input Boxes
        private void Imput_GBP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Money_imput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
        //end
}


