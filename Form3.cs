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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            double addBill2 = Form1.addBill;
            String addBill3 = "£" + addBill2;
            textBox11.Text = Form1.orderItem1;
            textBox12.Text = Form1.orderItem2;
            textBox14.Text = Form1.orderItem3;
            textBox15.Text = Form1.orderItem4;
            textBox16.Text = Form1.orderItem5;
            textBox17.Text = Form1.orderItem6;
            textBox18.Text = Form1.orderItem7;
            textBox19.Text = Form1.orderItem8;
            textBox20.Text = Form1.orderItem9;
            textBox21.Text = Form1.orderItem10;
            textBox22.Text = Form1.orderItem11;
            textBox23.Text = Form1.orderItem12;
            textBox24.Text = Form2.orderItem1;
            textBox25.Text = Form2.orderItem2;
            textBox26.Text = Form2.orderItem3;
            textBox27.Text = Form2.orderItem4;
            textBox28.Text = Form2.orderItem5;
            textBox29.Text = Form2.orderItem6;
            textBox30.Text = Form2.orderItem7;
            textBox31.Text = Form2.orderItem8;
            textBox32.Text = Form2.orderItem9;
            textBox33.Text = Form2.orderItem10;
            textBox34.Text = Form2.orderItem11;
            //how many?
            textBox35.Text = Form1.numDrinks1.ToString();
            textBox36.Text = Form1.numDrinks2.ToString();
            textBox37.Text = Form1.numDrinks3.ToString();
            textBox38.Text = Form1.numDrinks4.ToString();
            textBox39.Text = Form1.numDrinks5.ToString();
            textBox40.Text = Form1.numDrinks6.ToString();
            textBox41.Text = Form1.numDrinks7.ToString();
            textBox42.Text = Form1.numDrinks8.ToString();
            textBox43.Text = Form1.numDrinks9.ToString();
            textBox44.Text = Form1.numDrinks10.ToString();
            textBox45.Text = Form1.numDrinks11.ToString();
            textBox46.Text = Form1.numDrinks12.ToString();
            textBox47.Text = Form2.numDrinks1.ToString();
            textBox48.Text = Form2.numDrinks2.ToString();
            textBox49.Text = Form2.numDrinks3.ToString();
            textBox50.Text = Form2.numDrinks4.ToString();
            textBox51.Text = Form2.numDrinks5.ToString();
            textBox52.Text = Form2.numDrinks6.ToString();
            textBox53.Text = Form2.numDrinks7.ToString();
            textBox54.Text = Form2.numDrinks8.ToString();
            textBox55.Text = Form2.numDrinks9.ToString();
            textBox56.Text = Form2.numDrinks10.ToString();
            textBox57.Text = Form2.numDrinks11.ToString();
            textBox1.Text = addBill3.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

		private void label18_Click(object sender, EventArgs e)
		{

		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}
	}
}
