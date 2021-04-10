using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Web.UI.DataVisualization.Charting;
using System.Collections;

namespace Black_Scholes_Merton_Model
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            label8.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            label14.Visible = false;
            label22.Visible = false;
            label20.Visible = false;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        //Functions to perform black scholes method
        double d_1(double st,double k, double r, double sd,double t)
        {
            double d=Math.Log(st/k);
            d=d+((r+((sd*sd)/2))*t);
            d=d/(sd*Math.Sqrt(t));

            //d1.Text=Convert.ToString(d);
           return d;
        }

        double d_2(double d1, double sd,double t)
        {
            double d=d1-(sd*Math.Sqrt(t));
            return d;
        }
        

        double call(double spot,double d11,double strike,double interest_rate,double tenor,double d22)
        {
            var chart = new Chart();
            double ND1 = chart.DataManipulator.Statistics.NormalDistribution(d11);
            double ND2 = chart.DataManipulator.Statistics.NormalDistribution(d22);

            double c=spot*ND1;
            c = c - (strike * Math.Exp(-1 * interest_rate * tenor) * ND2);
            return c;
        }

        double put(double strike, double rate, double tenor, double spot, double dd1, double dd2 )
        {
            var chart = new Chart();
            double neg_ND1 = chart.DataManipulator.Statistics.NormalDistribution(-dd1);
            double neg_ND2 = chart.DataManipulator.Statistics.NormalDistribution(-dd2);
            double p = strike * Math.Exp(-1 * rate * tenor) * neg_ND2 - (spot * neg_ND1);
            return p;
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            double sp = Convert.ToDouble(spot.Text);
            double st = Convert.ToDouble(strike.Text);
            double t = Convert.ToDouble(tenor.Text);
            double vol = Convert.ToDouble(volatility.Text);
            double rate = Convert.ToDouble(interest_rates.Text);

            double dd1=d_1(sp,st,rate,vol,t);
           // d1.Text = Convert.ToString(dd1);

            double dd2 = d_2(dd1, vol, t);
           // d2.Text = Convert.ToString(dd2);

            double c = call(sp,dd1,st,rate,t,dd2);
            label8.Text = "Call Option:               " + Convert.ToString(c);

            double p = put(st,rate,t,sp,dd1,dd2);
            label9.Text = "Put Option:                " + Convert.ToString(p);

            label8.Visible = true;
            label9.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        
        private void button2_Click(object sender, EventArgs e)
        {
            double spot = Convert.ToDouble(textBox1.Text);
            double strike = Convert.ToDouble(textBox2.Text);
            double volatility = Convert.ToDouble(textBox4.Text);
            double tenor = Convert.ToDouble(textBox3.Text);
            double rate = Convert.ToDouble(textBox5.Text);
            int iterations = Convert.ToInt32(textBox6.Text);


            ArrayList call_array = new ArrayList();
            ArrayList put_array = new ArrayList();

            
            var chart = new Chart();
            
           
            //MessageBox.Show("" + rand_num);

            for (int i = 0; i < iterations; i++)
            {
                float num = (float)random.NextDouble();
                float rand_num = (float)chart.DataManipulator.Statistics.InverseNormalDistribution(num);

                double a = ((rate * (Math.Pow(volatility,2))) / 2) * tenor;
                double b = volatility * Math.Sqrt(tenor) * rand_num;

                double payoff = spot * Math.Exp(a + b);
                call_array.Add(Math.Max(0, payoff - strike));
                put_array.Add(Math.Max(0, strike - payoff));

            }
            double call_price=0;
            double put_price = 0;
            foreach (double i in call_array)
            {
                call_price+=i;
            }
            foreach (double j in put_array)
            {
                put_price += j;
            }
            call_price = call_price / iterations;
            put_price = put_price / iterations;

            //DISCOUNTING THE PRICE
            call_price *= Math.Exp((-rate)*tenor);
            put_price *= Math.Exp((-rate) * tenor);

            label14.Text = "Call Option:               " + call_price;
            label12.Text = "Put Option:               " + put_price;
            label12.Visible = true;
            label14.Visible = true;
            
        }

        //function to get probability 
        double get_probability(double spot, double rate, double volatility)
        {
            double u = spot * (1 + volatility);
            double d = spot * (1 - volatility);
            double ret = spot * (1 + rate);
            return ((ret-d)/(u-d));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double sp = Convert.ToDouble(textBox7.Text);
            double st = Convert.ToDouble(textBox8.Text);
            double t = Convert.ToDouble(textBox9.Text);
            double vol = Convert.ToDouble(textBox10.Text);
            double rate = Convert.ToDouble(textBox11.Text);
         
            //Remaining Code

            double dd1 = d_1(sp, st, rate, vol, t);
            // d1.Text = Convert.ToString(dd1);

            double dd2 = d_2(dd1, vol, t);
            // d2.Text = Convert.ToString(dd2);

            double c = call(sp, dd1, st, rate, t, dd2);
            label22.Text = "Call Option:               " + Convert.ToString(c);

            double p = put(st, rate, t, sp, dd1, dd2);
            label20.Text = "Put Option:                " + Convert.ToString(p);

            

            
            
            label22.Visible = true;
            label20.Visible = true;
          }   
           
    }
}
