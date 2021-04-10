namespace Black_Scholes_Merton_Model
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.spot = new System.Windows.Forms.TextBox();
            this.strike = new System.Windows.Forms.TextBox();
            this.tenor = new System.Windows.Forms.TextBox();
            this.volatility = new System.Windows.Forms.TextBox();
            this.interest_rates = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calculate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spot Price :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Strike Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tenor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Volatility :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Interest Rate :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Call Option :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Put Option :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // spot
            // 
            this.spot.Location = new System.Drawing.Point(200, 69);
            this.spot.Name = "spot";
            this.spot.Size = new System.Drawing.Size(144, 20);
            this.spot.TabIndex = 9;
            // 
            // strike
            // 
            this.strike.Location = new System.Drawing.Point(200, 135);
            this.strike.Name = "strike";
            this.strike.Size = new System.Drawing.Size(144, 20);
            this.strike.TabIndex = 10;
            // 
            // tenor
            // 
            this.tenor.Location = new System.Drawing.Point(200, 206);
            this.tenor.Name = "tenor";
            this.tenor.Size = new System.Drawing.Size(144, 20);
            this.tenor.TabIndex = 11;
            // 
            // volatility
            // 
            this.volatility.Location = new System.Drawing.Point(200, 276);
            this.volatility.Name = "volatility";
            this.volatility.Size = new System.Drawing.Size(144, 20);
            this.volatility.TabIndex = 12;
            // 
            // interest_rates
            // 
            this.interest_rates.Location = new System.Drawing.Point(198, 355);
            this.interest_rates.Name = "interest_rates";
            this.interest_rates.Size = new System.Drawing.Size(144, 20);
            this.interest_rates.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.spot);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.calculate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.interest_rates);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.volatility);
            this.panel1.Controls.Add(this.strike);
            this.panel1.Controls.Add(this.tenor);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(5, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 648);
            this.panel1.TabIndex = 18;
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.SystemColors.Control;
            this.calculate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(97, 573);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(247, 48);
            this.calculate.TabIndex = 14;
            this.calculate.Text = "CALCULATE";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Location = new System.Drawing.Point(449, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 648);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(901, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 648);
            this.panel3.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(5, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1342, 89);
            this.panel5.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "OPTION PRICING METHODS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "BLACK SCHOLES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(589, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "BINOMIAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1015, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 28);
            this.label11.TabIndex = 3;
            this.label11.Text = "MONTE-CARLO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(63, 523);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "Put Option :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(63, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "Spot Price :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(63, 488);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 18);
            this.label14.TabIndex = 14;
            this.label14.Text = "Call Option :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(63, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 18);
            this.label15.TabIndex = 10;
            this.label15.Text = "Strike Price :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(63, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 18);
            this.label16.TabIndex = 11;
            this.label16.Text = "Tenor :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(63, 276);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 18);
            this.label17.TabIndex = 12;
            this.label17.Text = "Volatility :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(63, 351);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 18);
            this.label18.TabIndex = 13;
            this.label18.Text = "Interest Rate :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(212, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(212, 276);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 20);
            this.textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(212, 352);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 20);
            this.textBox5.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(99, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(112, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 48);
            this.button2.TabIndex = 16;
            this.button2.Text = "CALCULATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(66, 427);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 18);
            this.label19.TabIndex = 20;
            this.label19.Text = "Iterations :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(212, 429);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(144, 20);
            this.textBox6.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(70, 495);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 18);
            this.label20.TabIndex = 21;
            this.label20.Text = "Put Option :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(72, 68);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 18);
            this.label21.TabIndex = 15;
            this.label21.Text = "Spot Price :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(70, 428);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 18);
            this.label22.TabIndex = 20;
            this.label22.Text = "Call Option :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(72, 134);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 18);
            this.label23.TabIndex = 16;
            this.label23.Text = "Strike Price :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(72, 205);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 18);
            this.label24.TabIndex = 17;
            this.label24.Text = "Tenor :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(72, 273);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 18);
            this.label25.TabIndex = 18;
            this.label25.Text = "Volatility :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(70, 351);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 18);
            this.label26.TabIndex = 19;
            this.label26.Text = "Interest Rate :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(221, 71);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(144, 20);
            this.textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(221, 138);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(144, 20);
            this.textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(221, 206);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(144, 20);
            this.textBox9.TabIndex = 23;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(221, 276);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(144, 20);
            this.textBox10.TabIndex = 24;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(221, 355);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(144, 20);
            this.textBox11.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1351, 755);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Option Pricing Methods";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox spot;
        private System.Windows.Forms.TextBox strike;
        private System.Windows.Forms.TextBox tenor;
        private System.Windows.Forms.TextBox volatility;
        private System.Windows.Forms.TextBox interest_rates;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
    }
}

