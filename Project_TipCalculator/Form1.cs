using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TipCalculator
{
    public partial class Form1 : Form
    {
        double Bill, TipPercent, NoofPeople, TipperPerson, TotalperPerson, TotalTip; // variables to store some value

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)    // method to clear all the entered data in the textbox
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }

        private void btnCalculateBoth_Click(object sender, EventArgs e)  // method to calculate both Tip per person and Total Per Person
        {
            if (textBox1.Text == "" || textBox2.Text == " " || textBox3.Text == "") //text box field cannot be empty 
            {
                MessageBox.Show("Please fill all Required Details ", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bill = Convert.ToDouble(textBox1.Text);
                TipPercent = Convert.ToDouble(textBox2.Text);
                NoofPeople = Convert.ToDouble(textBox3.Text);
                TotalTip = Bill * (TipPercent / 100);
                TipperPerson = TotalTip / NoofPeople;
                textBox4.Text = TipperPerson.ToString();

                Bill = Convert.ToDouble(textBox1.Text);
                TipPercent = Convert.ToDouble(textBox2.Text);
                NoofPeople = Convert.ToDouble(textBox3.Text);
                TotalperPerson = ((Bill + TotalTip) / NoofPeople);
                textBox5.Text = TotalperPerson.ToString();
            }
        }

        private void btnTotalperPerson_Click(object sender, EventArgs e)  // method to calculate total per person
        {
            if (textBox1.Text == "" || textBox2.Text == " " || textBox3.Text == "") //text box field cannot be empty 
            {
                MessageBox.Show("Please fill all Required Details ", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bill = Convert.ToDouble(textBox1.Text);
                TipPercent = Convert.ToDouble(textBox2.Text);
                NoofPeople = Convert.ToDouble(textBox3.Text);
                TotalperPerson = ((Bill + TotalTip) / NoofPeople);
                textBox5.Text = TotalperPerson.ToString();
            }
        }

        private void btnTipperPerson_Click(object sender, EventArgs e)  // method to calculate tip per person
        {
            if (textBox1.Text == "" || textBox2.Text == " " || textBox3.Text == "")  //text box field cannot be empty 
            {
                MessageBox.Show("Please fill all Required Details ", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Bill = Convert.ToDouble(textBox1.Text);
                TipPercent = Convert.ToDouble(textBox2.Text);
                NoofPeople = Convert.ToDouble(textBox3.Text);
                TotalTip = Bill * (TipPercent / 100);
                TipperPerson = TotalTip / NoofPeople;
                textBox4.Text = TipperPerson.ToString();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)  // this method does not allow  user to  entered an alphabet , it always allow numbers to enter in textfield
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox1.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox2.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox3.Text.Contains('.') == true : true))
                e.Handled = true;
        }

    }
}

// Test Cases 
/*
     S.No.                Input                             Otput
               Bill   TipPercent  No.ofPeople      TipperPerson  TotalPerPerson   
 
      1.      500       10           2               25            275
      2.      250       20           4              12.5           75
      3.      1000      30           6              50             216.66
      4.      200       40           7              11.42          40
      5.      5000      12.5         3              208.33         1875
      6.      10000      50          4              1250           3750
      7.      100       100         50               2             4
      8.       50        2           10              0.1           5.1
      9.      700       10           5               14            154  
      10.     150        5           3               2.5           52.5
 
 */

