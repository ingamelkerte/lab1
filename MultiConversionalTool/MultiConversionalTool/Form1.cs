//Inga Melkerte
//c00184799
//Multi Conversion Tool
//Sept2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiConversionalTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtInput;//focus on anther txtbox when start the form
        }

        private void rbtnInchesFeet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnPoundEuro_CheckedChanged(object sender, EventArgs e)
        {
       

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double input;
            double result;

            //Pound to Euro
            if(rbtnPoundEuro.Checked)
            {
                input = double.Parse(txtInput.Text);
                result = input * 1.38;//teshkkkhck
                txtOutput.Text = result.ToString();
            }
            //Inch To Foot
            if (rbtnInchesFeet.Checked)
            {
                input = double.Parse(txtInput.Text);
                result = input * 0.083;
                txtOutput.Text = result.ToString();
            }

            //Celsisus to farhenheit
            if (rbtnCelsiusFahrenheit.Checked)
            {
                input = double.Parse(txtInput.Text);
                result = (input * 9.00 / 5.00) + 32 ;
                txtOutput.Text = result.ToString();
            }

            //Farh to Celsius
            if (rbtnFarCelsius.Checked)
            {
                input = double.Parse(txtInput.Text);
                result = (5.0 / 9.0) * (input - 32);
                txtOutput.Text = result.ToString();
            }

            // Foot to Inch
            if (rbtnFootInch.Checked)
            {
                input = double.Parse(txtInput.Text);
                result = input * 12;
                txtOutput.Text = result.ToString();
            }

           //Euro to Pound
            if (rbtnEuroPound.Checked)
            {
                input = double.Parse(txtInput.Text);
                result = input * 0.73;
                txtOutput.Text = result.ToString();
            }
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            txtOutput.Text = "";
            //Pound to Euro
            if (rbtnPoundEuro.Checked)
            {
                txtConvertFrom.Text = "Pound";
                txtConvertTo.Text = "Euro";
                txtInput.Focus();
            }

            //Inch to Foot
            if (rbtnInchesFeet.Checked)
            {
                txtConvertFrom.Text = "Inch";
                txtConvertTo.Text = "Foot";
                txtInput.Focus();
            }

            // Farhenheit to Celsius
            if (rbtnFarCelsius.Checked)
            {
                txtConvertFrom.Text = "Fahrenheit";
                txtConvertTo.Text = "Celsius";
                txtInput.Focus();
            }

            //Celsius to Fahreinheit
            if (rbtnCelsiusFahrenheit.Checked)
            {
                txtConvertFrom.Text = "Celsius";
                txtConvertTo.Text = "Fahrenheit";
                txtInput.Focus();
            }

            //Foot to Inch 
            if (rbtnFootInch.Checked)
            {
                txtConvertFrom.Text = "Foot";
                txtConvertTo.Text = "Inch";
                txtInput.Focus();
            }

            //Euro to Pounds
            if (rbtnEuroPound.Checked)
            {
                txtConvertFrom.Text = "Euro";
                txtConvertTo.Text = "Pound";
                txtInput.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0";
            txtOutput.Text = "";
            txtInput.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}