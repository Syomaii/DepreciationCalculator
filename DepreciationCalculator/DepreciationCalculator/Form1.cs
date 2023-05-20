/*
    Name: Christian Jay Putol
    Date Created: 03/20/2023
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

namespace DepreciationCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lstBoxTable.Items.Clear();
            
            try
            {
                double iniCost = double.Parse(txtBoxInitialCost.Text);
                double salVal = double.Parse(txtBoxSalvageValue.Text);
                int life = int.Parse(cBoxLife.Text);
                int year = 1;
                double depreciation, bookVal;
                lstBoxTable.Items.Add(string.Format("Year\tDepreciation     Book Value"));
                if (rbtnSLN.Checked)
                {
                    depreciation = SLN(iniCost, salVal, life);
                    bookVal = iniCost;
                    lstBoxTable.Items.Add(string.Format($"{year}\t${depreciation:N2}\t         ${bookVal:N2}"));
                    year = 2;
                    do
                    {
                        bookVal -= depreciation;
                        lstBoxTable.Items.Add(string.Format($"{year}\t${depreciation:N2}\t         ${bookVal:N2}"));
                        year++;
                    }while(year <= life);
                }
                else if (rbtnSYD.Checked)
                { 
                    bookVal = iniCost;
                    year = 1;
                    do
                    {
                        depreciation = SYD(iniCost, salVal, life, year);
                        bookVal -= depreciation;
                        lstBoxTable.Items.Add(string.Format($"{year}\t${depreciation:N2}\t         ${bookVal:N2}"));
                        year++;
                    }while (year <= life) ;
                }
                else
                {
                    MessageBox.Show("Please select a depreciation method.");
                }
            }
            catch(FormatException) 
            {
                MessageBox.Show("Invalid input value! The system only accepts number!");
            }
            catch(Exception)
            {
                MessageBox.Show("An error occured try again later!");
            }

        }

        private double SLN(double iniCost, double salVal, int life)
        {
            return (iniCost - salVal) / life;
        }
        private double SYD(double iniCost, double salVal, int life, int year)
        {
            double num = life * (life + 1) / 2.0;
            return (iniCost - salVal) * (life - year + 1) / num;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
