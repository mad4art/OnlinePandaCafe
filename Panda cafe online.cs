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
    public partial class Form1 : Form
    {

        public static double compBill = 0.0;
		public static double addBill = 0.0;
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
		public static string orderItem12 = "";
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
		public static int numDrinks12 = 0;

		public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
		{
            int numDrinks1 = (int)numericUpDown1.Value;
            int numDrinks2 = (int)numericUpDown2.Value;
            int numDrinks3 = (int)numericUpDown3.Value;
            int numDrinks4 = (int)numericUpDown4.Value;
            int numDrinks5 = (int)numericUpDown5.Value;
            int numDrinks6 = (int)numericUpDown6.Value;
            int numDrinks7 = (int)numericUpDown7.Value;
            int numDrinks8 = (int)numericUpDown8.Value;
            int numDrinks9 = (int)numericUpDown9.Value;
            int numDrinks10 = (int)numericUpDown10.Value;
            int numDrinks11 = (int)numericUpDown11.Value;
            int numDrinks12 = (int)numericUpDown12.Value;
            //The 3 Vanilla Spice Latte drinks 
            double VSLTBill = 3.25 * numDrinks1;
            double VSLGBill = 3.55 * numDrinks2;
            double VSLVBill = 3.75 * numDrinks3;
            //Add how many of the 3 Vanilla Spice Latte drinks that they want
            double VSLBill = VSLTBill + VSLGBill + VSLVBill;
            //The 3 Caffe Latte drinks
            double CLTBill = 2.25 * numDrinks4;
            double CLGBill = 2.60 * numDrinks5;
            double CLVBill = 2.85 * numDrinks6;
            //Add how many of the 3 Caffe Late drinks that they want
            double CLBill = CLTBill + CLGBill + CLVBill;
            //The 3 Cappiccino drinks
            double CTBill = 2.25 * numDrinks7;
            double CGBill = 2.60 * numDrinks8;
            double CVBill = 2.85 * numDrinks9;
            //Add how many of the 3 Cappiccino drinks that they want
            double CBill = CTBill + CGBill + CVBill;
            //The 3 Caffe Americano drinks 
            double CATBill = 3.25 * numDrinks1;
            double CAGBill = 3.55 * numDrinks2;
            double CAVBill = 3.75 * numDrinks3;
            //Add how many of the 3 Caffe Americano drinks that they want
            double CABill = CATBill + CAGBill + CAVBill;
            //Add the total bill of ALL the drinks to create final bill of form1 and add £ sign
            double addBill = VSLBill + CLBill + CBill + CABill;
            string addBill2 = string.Format("{0:N2}", addBill);
            string compBill = "£" + addBill2;
            textBox2.Text = compBill.ToString();
			
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

		private void button3_Click(object sender, EventArgs e)
		{
			Hide();
			Form2 Frm = new Form2();
			Frm.Show();
		}
	}
        }
    

