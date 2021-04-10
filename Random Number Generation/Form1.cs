using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        //for mid-square
        int n,x,method,x1,x2;
        public Form1()
        {
            InitializeComponent();
            enter4dig.Visible = false;
            textBox1.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            label3.Visible = false;
            label8.Visible = false;
            generate_random.Visible = false;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Midsquare method
            //Linear Congruential Method
            //Combined Linear Congruential Generators
            //Random-Number Streams

            if (method==1)
            {
                //textBox1.Text =Convert.ToString(n+1);
                n = Convert.ToInt32(textBox1.Text);
                n *= n;
                n %= 1000000;
                n /= 100;
                MessageBox.Show("Random Number: " + n, "OUTPUT");
                textBox1.Text = Convert.ToString(n);
                generate_random.Text = "Generate Next Random Number";
            }
            if (method==2)
            {
                int a =Convert.ToInt32(textBox1.Text);
                int b =Convert.ToInt32(textBox2.Text);
                int m = Convert.ToInt32(textBox3.Text);
                x = Convert.ToInt32(textBox4.Text);

                x = ((a * x) + b) % m;
                textBox4.Text =Convert.ToString(x);
                MessageBox.Show("Random Number: " + x, "OUTPUT");     
            }
            if (method == 3)
            {
                label4.Text = "P :";
                label5.Text = "Q :";
                int p = 0, q = 0, x;
                x = Convert.ToInt32(textBox4.Text);
                try
                {
                    p = Convert.ToInt32(textBox2.Text);
                    q = Convert.ToInt32(textBox3.Text);
                    x = Convert.ToInt32(textBox4.Text);
                }
                catch (FormatException e1)
                {
                    MessageBox.Show(""+e1, "ERROR!!!");
                }
                
                if (is_prime(p) == 0)
                {
                    MessageBox.Show("Please enter prime number(P) !", "ERROR!!!");
                }
                if (is_prime(q) == 0)
                {
                    MessageBox.Show("Please enter prime number(Q) !", "ERROR!!!");
                }
                if (x % p == 0 || x % q == 0)            //if x is not co-prime of m
                {
                    MessageBox.Show("Please select X such that it is co-prime to M!", "ERROR!!!");
                }
                int m = p * q;

                x = (x * x) % m;

                textBox4.Text = Convert.ToString(x);
                MessageBox.Show("Random Number: " + x, "OUTPUT");

            }

            if (method == 4)
            {
                String str_x="";
                try
                {
                    str_x = textBox4.Text;
                
                }
                catch(Exception ee)
                {
                    MessageBox.Show(""+ee, "ERROR!!!");
                }

                char[] char_x = str_x.ToCharArray();
                int len=char_x.Length;
                int[] int_x=new int[len];
                for (int i = 0; i < len; i++)
                {
                    int_x[i] =(Convert.ToInt32(char_x[i])-48);

                    //MessageBox.Show(i + ": " + int_x[i]);
                }

                int mod =Convert.ToInt32(textBox1.Text);
                int j = Convert.ToInt32(textBox2.Text);
                int k = Convert.ToInt32(textBox3.Text);
                int sum = (int_x[j - 1] + int_x[k - 1])%mod;
                MessageBox.Show("Random Number:"+sum,"OUTPUT");
                str_x = str_x.Remove(0, 1);
                str_x = str_x + "" + sum;
                textBox4.Text = str_x;
            }

            if (method == 5)
            {
                int a1 = Convert.ToInt32(textBox1.Text);
                int b1 = Convert.ToInt32(textBox2.Text);
                int m1 = Convert.ToInt32(textBox3.Text);
                x1 = Convert.ToInt32(textBox4.Text);

                x1 = ((a1 * x1) + b1) % m1;
                textBox4.Text = Convert.ToString(x1);


                int a2 = Convert.ToInt32(textBox5.Text);
                int b2 = Convert.ToInt32(textBox6.Text);
                int m2 = Convert.ToInt32(textBox7.Text);
                x2 = Convert.ToInt32(textBox8.Text);

                x2 = ((a2 * x2) + b2) % m2;
                
                textBox8.Text = Convert.ToString(x1);


                x = (x1 + x2) % Math.Max(x1, x2);

                MessageBox.Show("Random Number: " + x, "OUTPUT");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            generate_random.Visible = true;
            enter4dig.Visible = true;
            textBox1.Visible = true;
            method = 1;                 //set method to 1 to indicate first method
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enter4dig.Visible = false;
            label6.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label7.Visible = true;
            textBox4.Visible = true;
            method = 2;                 //set method to 2 to indicate second method
        }

        public int is_prime(int n)
        {
            for (int i = 2; i <n; i++)
            {
                if (n % i == 0)
                    return 0;
            }
            return 1;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label7.Visible = true;
            textBox4.Visible = true;
            generate_random.Visible = true;
            method = 3;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enter4dig.Visible = true;
            textBox1.Visible = true;
            enter4dig.Text = "                                   Mod :";
            label4.Visible = true;
            label5.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label7.Visible = true;
            textBox4.Visible = true;
            generate_random.Visible = true;
            label4.Text = "J :";
            label5.Text = "K :";
            method = 4;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            enter4dig.Visible = false;
            label6.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            label7.Visible = true;
            textBox4.Visible = true;
            label3.Visible = true;
            label8.Visible = true;
            
            generate_random.Visible = true;
            method = 5;
        }
    }
}
