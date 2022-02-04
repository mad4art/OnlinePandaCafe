using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getting_started_with_forms
{
    
    public partial class Form2 : Form
    {
        public static double addBill4 = 0.0;
        public static string orderItem1 = "";
        public static string orderItem2 = "";
        public static string orderItem3 = "";
        public static string orderItem4 = "";
        public static string orderItem5 = "";
        public static string orderItem6 = "";
        public static string orderItem7 = "";
        public static string orderItem8 = "";
        public static string orderItem9 = "";
        public static string orderItem10 = "";
        public static string orderItem11 = "";
        public static int numDrinks1 = 0;
        public static int numDrinks2 = 0;
        public static int numDrinks3 = 0;
        public static int numDrinks4 = 0;
        public static int numDrinks5 = 0;
        public static int numDrinks6 = 0;
        public static int numDrinks7 = 0;
        public static int numDrinks8 = 0;
        public static int numDrinks9 = 0;
        public static int numDrinks10 = 0;
        public static int numDrinks11 = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numDrinks1 = (int)numericUpDown1.Value;
            numDrinks2 = (int)numericUpDown2.Value;
            numDrinks3 = (int)numericUpDown3.Value;
            numDrinks4 = (int)numericUpDown4.Value;
            numDrinks5 = (int)numericUpDown5.Value;
            numDrinks6 = (int)numericUpDown6.Value;
            numDrinks7 = (int)numericUpDown7.Value;
            numDrinks8 = (int)numericUpDown8.Value;
            numDrinks9 = (int)numericUpDown9.Value;
            numDrinks10 = (int)numericUpDown10.Value;
            numDrinks11 = (int)numericUpDown11.Value;
            double CMPBill = 3.99 * numDrinks1;
            double TMPBill = 3.99 * numDrinks2;
            double BMPBill = 3.99 * numDrinks3;
            double LCMPBill = 3.99 * numDrinks4;
            double SCBPBill = 3.29 * numDrinks5;
            //Add how many of the 4 Paninis that they want
            double PBill = CMPBill + TMPBill + BMPBill + LCMPBill + SCBPBill;
            //The 3 muffins
            double COMBill = 1.59 * numDrinks6;
            double CCMBill = 1.59 * numDrinks7;
            double GCMBill = 1.59 * numDrinks8;
            //Add how many of the 3 muffins that they want
            double MBill = COMBill + CCMBill + GCMBill;
            //The 3 Cakes
            double CoCBill = 1.99 * numDrinks9;
            double CaCBill = 2.55 * numDrinks10;
            double RCCBill = 2.35 * numDrinks11;
            //Add how many of the 3 Cakes that they want
            double CBill = RCCBill + CaCBill + CoCBill;
            //Add the total bill of ALL the drinks to create final bill of form1 and add £ sign
            double addBill4 = PBill + MBill + CBill + Form1.addBill;
            string addBill2 = string.Format("{0:N2}", addBill4);
            string compBill2 = "£" + addBill2;
            textBox1.Text = compBill2;
            Form1.addBill = addBill4;
            //Paninis
            if (numericUpDown1.Value > 0)
            {
                orderItem1 = "Croque Monsieur Panini";
            }
            else
            {
                orderItem1 = "--------";
            }
            if (numericUpDown2.Value > 0)
            {
                orderItem2 = "Thia and Mighty Panini";
            }
            else
            {
                orderItem2 = "--------";
            }
            if (numericUpDown3.Value > 0)
            {
                orderItem3 = "Bella Mozarella Panini";
            }
            else
            {
                orderItem3 = "--------";
            }
            if (numericUpDown4.Value > 0)
            {
                orderItem4 = "Lemon Chicken melt Panini";
            }
            else
            {
                orderItem4 = "--------";
            }
            if (numericUpDown5.Value > 0)
            {
                orderItem5 = "Smokehouse Chicken and Bacon Panini";
            }
            else
            {
                orderItem5 = "--------";
            }
            //Miffins
            if (numericUpDown6.Value > 0)
            {
                orderItem6 = "Cranberry and Orange Muffin";
            }
            else
            {
                orderItem6 = "--------";
            }
            if (numericUpDown7.Value > 0)
            {
                orderItem7 = "Chocolate Cherry Muffin";
            }
            else
            {
                orderItem7 = "--------";
            }
            if (numericUpDown8.Value > 0)
            {
                orderItem8 = "Ginger and Chocolate Muffin";
            }
            else
            {
                orderItem8 = "--------";
            }
            //Cake
            if (numericUpDown9.Value > 0)
            {
                orderItem9 = "Chocolate Cake";
            }
            else
            {
                orderItem9 = "--------";
            }
            if (numericUpDown10.Value > 0)
            {
                orderItem10 = "Carrot Cake";
            }
            else
            {
                orderItem10 = "--------";
            }
            if (numericUpDown11.Value > 0)
            {
                orderItem11 = "Raspberry and Coconut Cake";
            }
            else
            {
                orderItem11 = "--------";
            }
			Hide();
			Form3 Frm = new Form3();
			Frm.Show();
		}

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
