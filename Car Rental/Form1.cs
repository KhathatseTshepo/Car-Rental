using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            
                const double compact = 328.27;
                const double standard = 410.54;
                const double luxury = 642.82;
                double sum;
                

                if (radioButton1.Checked)
                {
                    if (cmb1.Text == "COMPACT")
                    {
                        sum = compact;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                    else if (cmb1.Text == "STANDARD")
                    {
                        sum = standard;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                    else if (cmb1.Text == "LUXURY")
                    {
                        sum = luxury;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                }
                else if (radioButton2.Checked)
                {
                    if (cmb1.Text == "COMPACT")
                    {
                        sum = compact * 2;
                        
                    lblTotal.Text ="R" + Convert.ToString(sum);
                }
                    else if (cmb1.Text == "STANDARD")
                    {
                        sum = standard * 2;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                    else if (cmb1.Text == "LUXURY")
                    {
                        sum = luxury * 2;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                }
                else if (radioButton3.Checked)
                {
                    if (cmb1.Text == "COMPACT")
                    {
                        sum = compact * 3;
                    lblTotal.Text = "R" + Convert.ToString(sum); 
                }
                    else if (cmb1.Text == "STANDARD")
                    {
                        sum = standard * 3;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                    else if (cmb1.Text == "LUXURY")
                    {
                        sum = luxury * 3;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                }
                else if (radioButton4.Checked)
                {
                    if (cmb1.Text == "COMPACT")
                    {
                        sum = compact * 4;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                    else if (cmb1.Text == "STANDARD")
                    {
                        sum = standard * 4;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                    else if (cmb1.Text == "LUXURY")
                    {
                        sum = luxury * 4;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                }
                else if (radioButton5.Checked)
                {
                    if (cmb1.Text == "COMPACT")
                    {
                        sum = compact * 5;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                    else if (cmb1.Text == "STANDARD")
                    {
                        sum = standard * 5;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                    else if (cmb1.Text == "LUXURY")
                    {
                        sum = luxury * 5;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }

                }
                else if (radioButton6.Checked)
                {
                    if (cmb1.Text == "COMPACT")
                    {
                        sum = compact * 6;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                    else if (cmb1.Text == "STANDARD")
                    {
                        sum = standard * 6;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                    else if (cmb1.Text == "LUXURY")
                    {
                        sum = luxury * 6;
                    lblTotal.Text = "R" + Convert.ToString(sum);
                }
                }

        }
    }
}
