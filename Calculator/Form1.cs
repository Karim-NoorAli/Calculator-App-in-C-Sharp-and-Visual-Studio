using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isoperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        { 
            if((textBox_result.Text == "0") || (isoperationPerformed))
            {
                textBox_result.Clear();
            }
            isoperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                     textBox_result.Text = textBox_result.Text + button.Text;

            }
            else
            {
                textBox_result.Text = textBox_result.Text + button.Text;
            }
            
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_result.Text);
            screen1.Text = resultValue + " " + operationPerformed;
            isoperationPerformed = true;
        }

        private void clear_operation(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultValue = 0;
        }

        private void clear_screen(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void equals(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox_result.Text = (resultValue + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultValue - Double.Parse(textBox_result.Text)).ToString();
                    break;

                case "*":
                    textBox_result.Text = (resultValue * Double.Parse(textBox_result.Text)).ToString();
                    break;

                case "/":
                    textBox_result.Text = (resultValue / Double.Parse(textBox_result.Text)).ToString();
                    break;

                default:
                    break;
            }
            screen1.Text = "";
        }
    }
}
