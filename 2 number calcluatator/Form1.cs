using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_number_calcluatator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            /* 
             * double.Parse(textBox1.Text);
            double.Parse(textBox2.Text);
            this code for dubble value convent to textbox velue
            */

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            double result = num1 + num2;
            textBox3.Text = ("" + result);
            ActionLB.Text = ("+");
            MessageBox.Show("Result is " + result, "Result" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            double result = num1 - num2;
            textBox3.Text = ("" + result);
            ActionLB.Text = ("-");
            MessageBox.Show("Result is " + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            double result = num1 * num2;
            textBox3.Text = ("" + result);
            ActionLB.Text = ("X");
            MessageBox.Show("Result is " + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1, num2;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            double result = num1 / num2;
            textBox3.Text = ("" + result);
            ActionLB.Text = ("÷");
            MessageBox.Show("Result is " + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pickColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.Color = panel1.BackColor;
            colorDialog.FullOpen = true;
            colorDialog.AnyColor = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog.Color;
            }
            else
            {
                MessageBox.Show("You can not Slect Colour", "Colour naot Slect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
