using Filter004;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filter004Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyFilter action = new MyFilter();
            Func<int[], int> delegatSumm;
            Func<int[], string> delegatNumbers;
            if (comboBox1.SelectedIndex == 5)
            {
                string numbers_ = numbers.Text;
                if (numbers_ != null)
                { 
                    delegatNumbers = action.NumbersOfArray11;
                    delegatSumm = action.AmountOfArray11;
                    int summ_ = delegatSumm(Arrey.StringToArrey(numbers_));
                    label2.Text = summ_.ToString();
                    label1.Text = delegatNumbers(Arrey.StringToArrey(numbers_));       
                }
            }
            if (comboBox1.SelectedIndex == 0)
            {
                string numbers_ = numbers.Text;
                if (numbers_ != null)
                {
                    delegatNumbers = action.NumbersOfArray1;
                    delegatSumm = action.AmountOfArray1;
                    int summ_ = delegatSumm(Arrey.StringToArrey(numbers_));
                    label2.Text = summ_.ToString();
                    label1.Text = delegatNumbers(Arrey.StringToArrey(numbers_));
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                string numbers_ = numbers.Text;
                if (numbers_ != null)
                {
                    delegatNumbers = action.NumbersOfArray2;
                    delegatSumm = action.AmountOfArray2;
                    int summ_ = delegatSumm(Arrey.StringToArrey(numbers_));
                    label2.Text = summ_.ToString();
                    label1.Text = delegatNumbers(Arrey.StringToArrey(numbers_));
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                string numbers_ = numbers.Text;
                if (numbers_ != null)
                {
                    delegatNumbers = action.NumbersOfArray3;
                    delegatSumm = action.AmountOfArray3;
                    int summ_ = delegatSumm(Arrey.StringToArrey(numbers_));
                    label2.Text = summ_.ToString();
                    label1.Text = delegatNumbers(Arrey.StringToArrey(numbers_));
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                string numbers_ = numbers.Text;
                if (numbers_ != null)
                {
                    delegatNumbers = action.NumbersOfArray4;
                    delegatSumm = action.AmountOfArray4;
                    int summ_ = delegatSumm(Arrey.StringToArrey(numbers_));
                    label2.Text = summ_.ToString();
                    label1.Text = delegatNumbers(Arrey.StringToArrey(numbers_));
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                string numbers_ = numbers.Text;
                if (numbers_ != null)
                {
                    delegatNumbers = action.NumbersOfArray5;
                    delegatSumm = action.AmountOfArray5;
                    int summ_ = delegatSumm(Arrey.StringToArrey(numbers_));
                    label2.Text = summ_.ToString();
                    label1.Text = delegatNumbers(Arrey.StringToArrey(numbers_));
                }
            }

        }
    }
}
