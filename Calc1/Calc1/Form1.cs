/*
Inga Melkerte
C00184799
C# Programming lab1
Sept2015
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1
{
    
    public partial class Form1 : Form
    {
        double num1 = 0;//initialize 1st number 
        double result = 0;//initialize result
        String theOp;//operator is string that will need to bee parse to double

        bool equalsPressed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            equalsPressed = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            if (equalsPressed == true)
            {
                this.txtScreen.Text = "";
                equalsPressed = false;
            }
            this.txtScreen.Text += "0";// or this.txtSreen.Text = btn0.Text;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                this.txtScreen.Text = "";
                equalsPressed = false;
            }
            this.txtScreen.Text += "1";
            equalsPressed = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                this.txtScreen.Text = "";
                equalsPressed = false;
            }
            this.txtScreen.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                this.txtScreen.Text = "";
                equalsPressed = false;
            }
            this.txtScreen.Text += "3";
        }


        private void btn4_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                this.txtScreen.Text = "";
                equalsPressed = false;
            }
            this.txtScreen.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                this.txtScreen.Text = "";
                equalsPressed = false;
            }
            this.txtScreen.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                this.txtScreen.Text = "";
                equalsPressed = false;
            }
            this.txtScreen.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                this.txtScreen.Text = "";
                equalsPressed = false;
            }
            this.txtScreen.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (equalsPressed == true)
            {
                this.txtScreen.Text = "";
                equalsPressed = false;
            }
            this.txtScreen.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (equalsPressed==true)
            {
                this.txtScreen.Text = "";
                equalsPressed = false;
            }
            this.txtScreen.Text += "9";
        }

        private void btnC_Click(object sender, EventArgs e)//cleat button
        {
            this.txtScreen.Clear();
        }
        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 += double.Parse(txtScreen.Text);
            txtScreen.Clear();
            theOp = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 += double.Parse(txtScreen.Text);
            txtScreen.Clear();
            theOp = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            num1 += double.Parse(txtScreen.Text);
            txtScreen.Clear();
            theOp = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 += double.Parse(txtScreen.Text);
            txtScreen.Clear();
            theOp = "/";
        }
        
        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Contains("."))//if in the number there is already dot, cannot input more dots.
            {
                return;
            }
            else
            {
                this.txtScreen.Text += ".";
            }
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            equalsPressed = true;
                switch (theOp)
                {
                    case "+":
                        num1 += double.Parse(txtScreen.Text);
                        break;
                    case "-":
                        num1 -= double.Parse(txtScreen.Text);
                        break;
                    case "*":
                        num1 *= double.Parse(txtScreen.Text);
                        break;
                    case "/":
                        num1 /= double.Parse(txtScreen.Text);
                        break;    
            }
            result = num1;
            txtScreen.Text = result.ToString();//double result convert back to string 
            num1 = 0;            
        }

        private void btnNeg_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
