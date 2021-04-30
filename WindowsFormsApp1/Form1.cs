using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double res;
        public Form1()
        {
            InitializeComponent();
            //double num1 = Convert.ToDouble(textBox1.Text);
            //double num2 = Convert.ToDouble(textBox2.Text);
            //double res = 0; 

            label3.Text = "...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Калькулятор"; 
            //BackColor = Color.Tan;
            label1.Text = "Первое число";
            label2.Text = "Второе число";
            label4.Text = "=";
            label5.Text = "Результат";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "+";
                label6.Text = "cложения";
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                res = num1 + num2;
                textBox3.Text = $"{res}";
            }
            catch
            {
                Block();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "-";
                label6.Text = "вычитания";
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                res = num1 - num2;
                textBox3.Text = $"{res}";
            }
            catch
            {
                Block();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "*";
                label6.Text = "умножения";
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                res = num1 * num2;
                textBox3.Text = $"{res}";
            }
            catch
            {
                Block();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
             
                label6.Text = "Корень из числа";
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                res = Math.Sqrt(num1); 
                textBox3.Text = $"{res}";
            }
            catch
            {
                Block(); 
            }
        }
        private void Block()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Введите первое число", "Число", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = textBox1;
                return;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Введите второе число", "Число", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = textBox2;
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = ""; 
            textBox3.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number1 = e.KeyChar; 
            if (!Char.IsDigit(number1) & number1 !=8)
            {
                e.Handled = true; 
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number2 = e.KeyChar;
            if (!Char.IsDigit(number2) & number2 !=8)
            {
                e.Handled = true; 
            }
        }
    }
 }

