//Inga Melkerte
//C00184799
//Sept2015
//Multi Conversion Tool with Menu

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void distanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //If pound to euro menu strip selected then, rename first label - pound, sec - Euro
        private void poundToEuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelInputFrom.Text = "Pound";
            labelInputTo.Text = "Euro";
            txInput.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbConvertTo_Click(object sender, EventArgs e)
        {
          
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            
            double inputValue;
            double total;
          
            //if label name is pound to euro
            if(labelInputFrom.Text =="Pound")
            {
                inputValue = double.Parse(txInput.Text);
                total = inputValue * 0.73;
                lbConvertTo.Text = total.ToString();
            }
            //Pound to Euro
            if (labelInputFrom.Text == "Euro")
            {
                inputValue = double.Parse(txInput.Text);
                total = inputValue * 1.38;
                lbConvertTo.Text = total.ToString();
            }
            //Celsius to Fahrenheit
            if (labelInputFrom.Text == "Celsius")
            {
                inputValue = double.Parse(txInput.Text);
                total = (inputValue * 9.00 / 5.00) + 32;
                lbConvertTo.Text = total.ToString();
            }
            //Fahrenheit to Celsius
            if (labelInputFrom.Text == "Fahrenheit")
            {
                inputValue = double.Parse(txInput.Text);
                total = (5.0 / 9.0) * (inputValue - 32);
                lbConvertTo.Text = total.ToString();
            }
            //Inches to Feet
            if (labelInputFrom.Text == "Inches")
            {
                inputValue = double.Parse(txInput.Text);
                total = inputValue * 12;
                lbConvertTo.Text = total.ToString();
            }
            //Feet to Inches
            if (labelInputFrom.Text == "Feet")
            {
                inputValue = double.Parse(txInput.Text);
                total = inputValue * 0.083;
                lbConvertTo.Text = total.ToString();
            }
        }
        //Euro to Pound
        private void euroToPoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelInputFrom.Text = "Euro";
            labelInputTo.Text = "Pound";
            txInput.Text = "0";
        }
        //Celsius to Fahrenheit
        private void celsiusToFarhenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelInputFrom.Text = "Celsius";
            labelInputTo.Text = "Fahrenheit";
            txInput.Text = "0";
        }
        //Fahrenheit to Celsius
        private void farhenheitToCelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelInputFrom.Text = "Fahrenheit";
            labelInputTo.Text = "Celsius";
            txInput.Text = "0";
        }
        //Inches to Feet
        private void incesToFeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelInputFrom.Text = "Inches";
            labelInputTo.Text = "Feet";
            txInput.Text = "0";
        }
        //Feet to Inches
        private void feetToInchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelInputFrom.Text = "Feet";
            labelInputTo.Text = "Inches";
            txInput.Text = "0";
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbConvertTo.Text = "";//clear the output value(result) every time the menu strip is selected
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all labels and input/output boxes
            labelInputFrom.Text = "";
            labelInputTo.Text = "";
            lbConvertTo.Text = "";
            txInput.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
