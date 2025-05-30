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
            if (comboBox1.SelectedIndex == 5)
            {
                string numbers_ = numbers.Text;
                if (numbers_ != null)
                {
                    MyFilter summ = new MyFilter();
                    
                    int summ_ = summ.AmountOfArray11(Arrey.StringToArrey(numbers_));
                    label2.Text = summ_.ToString();
                    label1.Text = summ.NumbersOfArray11(Arrey.StringToArrey(numbers_));
                }
            }
        }
    }
}
