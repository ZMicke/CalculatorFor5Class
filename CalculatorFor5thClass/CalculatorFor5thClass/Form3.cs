using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFor5thClass
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Метод для суммы чисел в указанной СС
        public static string SumaXY(string number1, string number2, int targetBase)
        {
            string number_1 = Form1.ConvertToNumber(number1, 10, targetBase);
            string number_2 = Form1.ConvertToNumber(number2, 10, targetBase);
            int result = int.Parse(number_1) + int.Parse(number_2);
            return result.ToString();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            string number1 = firstNumber.Text;
            string number2 = secondNumber.Text;
            int targetBase = int.Parse(sSSum.Text);
            var result = SumaXY(number1, number2, targetBase);
            resultSum.Text = result.ToString();
        }
    }
}
