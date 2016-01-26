/*
Inga Melkerte
C00184799
Currency Convertor
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

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void cmBoxCurrencyFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmBoxCurrencyFrom.Items.Add("Euro");//Currency I Have stores
            cmBoxCurrencyFrom.Items.Add("Dollars");
            cmBoxCurrencyFrom.Items.Add("Sterling");
            cmBoxToCurency.Items.Add("Euro");//Currency I Want stores
            cmBoxToCurency.Items.Add("Dollars");
            cmBoxToCurency.Items.Add("Sterling");
            txtCurrencyFrom.Select();
        }

        private void cmBoxToCurency_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbCurrencyFrom_Click(object sender, EventArgs e)
        {

        }

        private void txtCurrencyFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCurrencyTo_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double euro;
            double sterling;
            double dollars;
            //from euro
            if (cmBoxCurrencyFrom.Text == "Euro" && cmBoxToCurency.Text == "Sterling")
            {
                euro = double.Parse(txtCurrencyFrom.Text);
                sterling = euro * 0.72;
                txtCurrencyTo.Text = sterling.ToString();
            }
            if (cmBoxCurrencyFrom.Text == "Euro" && cmBoxToCurency.Text == "Dollars")
            {
                euro = double.Parse(txtCurrencyFrom.Text);
                dollars = euro * 1.1;
                txtCurrencyTo.Text = dollars.ToString();
            }
            if (cmBoxCurrencyFrom.Text == "Euro" && cmBoxToCurency.Text == "Euro")
            {
                 euro = double.Parse(txtCurrencyFrom.Text);
                 euro = euro * 1;
                 txtCurrencyTo.Text = euro.ToString();
                
            }

            //from dollars
            if (cmBoxCurrencyFrom.Text == "Dollars" && cmBoxToCurency.Text == "Dollars")
            {
                dollars = double.Parse(txtCurrencyFrom.Text);
                dollars = dollars * 1;
                txtCurrencyTo.Text = dollars.ToString();
            }
            if (cmBoxCurrencyFrom.Text == "Dollars" && cmBoxToCurency.Text == "Euro")
            {
                dollars = double.Parse(txtCurrencyFrom.Text);
                euro = dollars * 0.9;
                txtCurrencyTo.Text = euro.ToString();
            }
            if (cmBoxCurrencyFrom.Text == "Dollars" && cmBoxToCurency.Text == "Sterling")
            {
                dollars = double.Parse(txtCurrencyFrom.Text);
                sterling = dollars * 0.65;
                txtCurrencyTo.Text = sterling.ToString();
            }

            //from Stering
            if (cmBoxCurrencyFrom.Text == "Sterling" && cmBoxToCurency.Text == "Euro")
            {
                sterling= double.Parse(txtCurrencyFrom.Text);
                euro = sterling * 1.35;
                txtCurrencyTo.Text = sterling.ToString();
            }
            if (cmBoxCurrencyFrom.Text == "Sterling" && cmBoxToCurency.Text == "Dollars")
            {
                sterling = double.Parse(txtCurrencyFrom.Text);
                dollars = sterling * 1.54;
                txtCurrencyTo.Text = dollars.ToString();
            }
            if (cmBoxCurrencyFrom.Text == "Sterling" && cmBoxToCurency.Text == "Sterling")
            {
                sterling = double.Parse(txtCurrencyFrom.Text);
                sterling = sterling * 1;
                txtCurrencyTo.Text = sterling.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCurrencyFrom.Clear();
            txtCurrencyTo.Clear();
            txtCurrencyFrom.Focus();

        }

        private void btnUseResult_Click(object sender, EventArgs e)
        {
            double result;

            result = double.Parse(txtCurrencyTo.Text);
            txtCurrencyFrom.Text = result.ToString();
            txtCurrencyTo.Clear();
        }
    }
    }

