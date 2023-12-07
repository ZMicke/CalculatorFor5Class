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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public static string TranslateToRome(int numberInput)
        {
            if (numberInput < 1 || numberInput > 5000)
            {
                throw new ArgumentOutOfRangeException("Число вышло за границы диаппазона (1-5000)!");
            }
            string[] M = { "", "M", "MM", "MMM", "MMMM", "MMMMM" };
            string[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return M[numberInput / 1000] + C[(numberInput % 1000) / 100] + X[(numberInput % 100) / 10] + I[numberInput % 10];
        }
        public static int TranslateFromRome(string rome)
        {
            rome = rome.ToUpper();
            Dictionary<char, int> romeDictionary = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            int number = 0;
            for (int i = 0; i < rome.Length; i++)
            {
                if (i + 1 < rome.Length && romeDictionary[rome[i]] < romeDictionary[rome[i + 1]])
                {
                    number = number - romeDictionary[rome[i]];
                }
                else
                {
                    number = number + romeDictionary[rome[i]];
                }
            }
            return number;
        }

        private void translationRome_Click(object sender, EventArgs e)
        {
            string numberInput = textInput.Text;
            string result = TranslateToRome(int.Parse(numberInput));
            textOutput.Text = result;
        }
    }

}
