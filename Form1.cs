using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float GetSelectedCrustPrice()
        {
            if (rbThink.Checked)
            {
                return Convert.ToSingle(rbThink.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThin.Tag);
            }
        }
        float CalculateToppingsPrice()
        {
            float ToppingTotalPrice = 0;
            if (chkExtarChees.Checked) {
                ToppingTotalPrice += Convert.ToSingle(chkExtarChees.Tag);
            }
            if (chkGreenPeper.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chkGreenPeper.Tag);
            }
            if (chkMushrooms.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkOlives.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkOnion.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkTomatoes.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
            return ToppingTotalPrice;
        }
        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            if (rbMeduim.Checked)
            {
                return Convert.ToSingle(rbMeduim.Tag);
            }
            else
            {
                return Convert.ToSingle(rbLarg.Tag);
            }

            

        }
        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }
        void UpdateTotalPrice()
        {
            labTotalPrice.Text="$"+CalculateTotalPrice().ToString();
        }
        void UpdateToppings()
        {
            UpdateTotalPrice();
            string Toppings = "";
            if (chkExtarChees.Checked)
            {
                Toppings = "Extar Chees";
            }
            if (chkOnion.Checked)
            {
                Toppings += ", Onion ";
            }
            if (chkOlives.Checked)
            {
                Toppings += ", Olives ";
            }
            if (chkMushrooms.Checked)
            {
                Toppings += ", Mushrooms ";
            }
            if (chkGreenPeper.Checked)
            {
                Toppings += ", Green Peper ";
            }
            if (chkTomatoes.Checked)
            {
                Toppings += ", Tomatoes ";
            }
            if (Toppings.StartsWith(","))
            {
                Toppings=Toppings.Substring(1,Toppings.Length-1).Trim();
            }
            if (Toppings == "")
            {
                Toppings = "No Toppings.";
            }
            labToppings.Text = Toppings; 
        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                labSize.Text = "Small";
                return;
            }
            if (rbMeduim.Checked)
            {
                labSize.Text = "Meduim";
                return;
            }
            if (rbLarg.Checked)
            {
                labSize.Text = "Larg";
                return;
            }
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThin.Checked)
            {
                labCrust.Text = rbThin.Text;
                return;
            }
            if(rbThink.Checked)
            {
                labCrust.Text = rbThink.Text;
                return;
            }
        }
        void UpdateWhereEatting()
        {
            UpdateTotalPrice();
            if (rbTakOut.Checked)
            {
                labEat.Text = rbTakOut.Text;
                return;
            }
            if(rbEatIn.Checked)
            {
                labEat.Text =rbEatIn.Text;
                return;
            }
        }
        private void labExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void ResertForm()
        {
            btnOrder.Enabled = true;

            gbCrust.Enabled = true;
            gbEat.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;

            chkExtarChees.Checked=false;
            chkGreenPeper.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;



            rbThin.Checked = true;
            rbEatIn.Checked = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {

            UpdateWhereEatting();
        }

        private void rbTakOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereEatting();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnOrder.Enabled = false;
            gbCrust.Enabled = false;
            gbEat.Enabled = false;
            gbSize.Enabled = false;
            gbToppings.Enabled = false;
        }

        private void chkExtarChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            ResertForm();
        }
        void UpdateSummary()
        {
            UpdateToppings();
            UpdateCrust();
            UpdateSize();
            UpdateSize();
            UpdateTotalPrice();
            UpdateWhereEatting();
        }
        private void gbSummary_Enter(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

