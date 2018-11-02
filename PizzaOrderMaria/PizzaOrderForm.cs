/*
 * Created by: Maria
 * Created on: 24-10-2018
 * Created for: ICS3U Programming
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderMaria
{
    public partial class frmPizza : Form
    {
        public frmPizza()
        {
            InitializeComponent();
            picHome.Show();
            pic2.Hide();
            pictureBox1.Hide();
        }

        private void radPizza1_CheckedChanged(object sender, EventArgs e)
        {
            double subtotal;
            int total;
            int tax;
            double pizzaSize, Mpizza, Lpizza, XLpizza;

            //set the intitial values
            Mpizza = 7.99;
            Lpizza = 9.99;
            XLpizza = 12.99;
            subtotal = 0;

            // The CheckBox control's Text property is changed each time the   
            // control is clicked, indicating a checked or unchecked state.  
            if (radPizza1.Checked)
            {
                subtotal = subtotal + Mpizza; 
            }
            else
            {
                radPizza1.Text = "Unchecked";
            }


            //pic2.Show();
            //lblTitleSize.Show();
            //nudPizzaSize.Show();
            //declare local variables
            //double subtotal;
            //double total;
            //double HST;
            //int 
            pizzaSize = Convert.ToInt32(this.nudPizzaSize.Value);

        }


        private void radPizza2_CheckedChanged(object sender, EventArgs e)
        {
            //declare constants and variables

        }

        private void radPizza3_CheckedChanged(object sender, EventArgs e)
        {
            //declare constants and variables

        }

        private void nudPizzaSize_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


