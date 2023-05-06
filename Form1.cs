using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kicalculator
{
    public partial class Form1 : Form
    {
        Double ResultValue = 0;
        string operationperformed = "";
        bool isOperationperformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calculation_Click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0")
                textbox_Result.Clear();
            Button button = (Button)sender;
            textbox_Result.Text = textbox_Result.Text + "0";
            isOperationperformed = false;



        }

        private void button_calci_Click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0")
                textbox_Result.Clear();
            Button button = (Button)sender;
            textbox_Result.Text = textbox_Result.Text + "1";
            isOperationperformed = false;


        }



        private void button12_Click(object sender, EventArgs e)


        {
            if ((textbox_Result.Text == "0") || (isOperationperformed)
       )
                textbox_Result.Clear();
            Button button = (Button)sender;
            textbox_Result.Text = textbox_Result.Text + "2";
            isOperationperformed = false;


        }


        private void button13_Click(object sender, EventArgs e)
        {
            if ((textbox_Result.Text == "0") || (isOperationperformed))
                textbox_Result.Clear();
            Button button = (Button)sender;

            textbox_Result.Text = textbox_Result.Text + "3";
            isOperationperformed = false;

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if ((textbox_Result.Text == "0") || (isOperationperformed))
                textbox_Result.Clear();
            Button button = (Button)sender;
            textbox_Result.Text = textbox_Result.Text + "4";
            isOperationperformed = false;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((textbox_Result.Text == "0") || (isOperationperformed))
                textbox_Result.Clear();
            Button button = (Button)sender;
            textbox_Result.Text = textbox_Result.Text + "5";
            isOperationperformed = false;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0")
                textbox_Result.Clear();
            Button button = (Button)sender;
            textbox_Result.Text = textbox_Result.Text + "6";
            isOperationperformed = false;


        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0")
                textbox_Result.Clear();
            Button button = (Button)sender;
            textbox_Result.Text = textbox_Result.Text + "7";
            isOperationperformed = false;

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0")
                textbox_Result.Clear();
            Button button = (Button)sender;
            textbox_Result.Text = textbox_Result.Text + "8";
            isOperationperformed = false; }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0")
                textbox_Result.Clear();
            Button button = (Button)sender;
            textbox_Result.Text = textbox_Result.Text + "9";
            isOperationperformed = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0")
                textbox_Result.Clear();
            Button button = (Button)sender;
            textbox_Result.Text = textbox_Result.Text + ".";
            isOperationperformed = false;
            if (button17.Text == ".")
            {
                if (!textbox_Result.Text.Contains("."))
                    textbox_Result.Text = textbox_Result.Text + button.Text;
            }
            else
                textbox_Result.Text = textbox_Result.Text + button.Text;
        }





        private void button18_Click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0")
                textbox_Result.Clear();
            Button button = (Button)sender;
            operationperformed = button.Text;
            ResultValue = double.Parse(textbox_Result.Text);
            label1.Text = ResultValue + "" + operationperformed;
            isOperationperformed = true;



        }


        private void button5_Click(object sender, EventArgs e)
        {
            textbox_Result.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textbox_Result.Text = "0";
            ResultValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operationperformed)
            {
                case "+":
                    textbox_Result.Text = (ResultValue + double.Parse(textbox_Result.Text)).ToString

();
                    break;
                case "-":
                    textbox_Result.Text = (ResultValue - double.Parse(textbox_Result.Text)).ToString

();
                    break;
                case "*":
                    textbox_Result.Text = (ResultValue * double.Parse(textbox_Result.Text)).ToString

();
                    break;
                case "/":
                    textbox_Result.Text = (ResultValue / double.Parse(textbox_Result.Text)).ToString

();
                    break;
                default:
                    break;
            }
            ResultValue = Double.Parse(textbox_Result.Text);
            label1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0")
                textbox_Result.Clear();
            Button button = (Button)sender;
            operationperformed = button.Text;
            ResultValue = double.Parse(textbox_Result.Text);
            label1.Text = ResultValue + "" + operationperformed;
            isOperationperformed = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0")
                textbox_Result.Clear();
            Button button = (Button)sender;
            operationperformed = button.Text;
            ResultValue = double.Parse(textbox_Result.Text);
            label1.Text = ResultValue + "" + operationperformed;
            isOperationperformed = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0")
                textbox_Result.Clear();
            Button button = (Button)sender;
            operationperformed = button.Text;
            ResultValue = double.Parse(textbox_Result.Text);
            label1.Text = ResultValue + "" + operationperformed;
            isOperationperformed = true;

        }

    } 
}