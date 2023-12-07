using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFor5thClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string digit = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrst";
        
        private void convertButton_Click(object sender, EventArgs e)
        {
            string numberInput = textInput.Text;
            int sourseBased = Convert.ToInt32(sourseBase.Text);
            int targetBased = Convert.ToInt32(sS.Text);
            string result = ConvertToNumber(numberInput, sourseBased, targetBased);
            textOutput.Text = result;
            string explainConvert = ExplainDivision(int.Parse(numberInput), targetBased);
            textExplain.Text = explainConvert;
            textExplainInWords.Text = ExplainInWords(int.Parse(numberInput), targetBased);
        }
        //Метод для перевода числа в десятичную систему
        public static int MakeDecimal(string numberInput, int sourseBase)
        {
            int decimalValue = 0;
            for (int i = 0; i < numberInput.Length; i++)
            {
                char digit = numberInput[i];
                int digitValue = GetDigitValue(digit);
                //Формула для преобразования в десятичную систему 
                decimalValue = decimalValue * sourseBase + digitValue;
            }
            return decimalValue;
        }
        // Метод для получения числового значения цифры
        public static int GetDigitValue(char digit)
        {
            if (char.IsDigit(digit))
            {
                // Если цифра является числом, возвращаем ее числовое значение
                return digit - '0';
            }
            else
            {
                // Если цифра является буквой, возвращаем ее числовое значение, учитывая 'A' как 10
                return char.ToUpper(digit) - 'A' + 10;
            }
        }
        //Метод для перевода в любую систему счисления
        public static string ConvertToNumber(string number,int sourseBase, int targetBase)
        {
            string result = "";
            var number_0 = MakeDecimal(number, sourseBase);
            while (number_0 > 0)
            {
                result += digit[(int)(number_0 % targetBase)];
                number_0 = number_0 / targetBase;
            }
            return new string(result.ToCharArray().Reverse().ToArray());
        }
        Form2 f2; //Подгружаем второе окно с римской СС

        private void переводВРимскуюСистемуСчисленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }
        //Деление столбиком(пояснение)
        public static string ExplainDivision(int numberInput, int targetBase)
        {
            StringBuilder move = new StringBuilder();
            List<string> divisiondRemainders = new List<string>();
            //Неконечный результат
            int indificator = numberInput;
            int remainder;

            while (indificator != 0)
            {
                remainder = indificator % targetBase;
                divisiondRemainders.Add($"{indificator} | {targetBase}");
                divisiondRemainders.Add($"--- {remainder}");
                indificator /= targetBase;
            }
            //Лево-право
            int offset = 0;
            for (int i = 0; i < divisiondRemainders.Count; i += 2)
            {
                move.AppendLine(new string(' ', offset) + divisiondRemainders[i]);
                if (i + 1 < divisiondRemainders.Count)
                {
                    move.AppendLine(new string(' ', offset) + divisiondRemainders[i + 1]);
                }
                offset += 10; //Отступ
            }
            //Добавляем результат
            move.AppendLine(new string(' ', offset) + "<--- Идем справа налево!");
            move.Append(new string(' ', 1) + "Получаем:");
            move.Append(string.Join("", divisiondRemainders.Where((_, index) => index % 2 != 0).Reverse()));
            move.Append($" для системы счисления {targetBase}");

            return move.ToString();
        }
        Form3 f3;
        private void сложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.Show();
        }
        //Словесное объяснение перевода из одной СС в другую
        public static string ExplainInWords(int decimalNumber, int targetBase)
        {
            StringBuilder move_1 = new StringBuilder();
            move_1.AppendLine("Процесс перевода");
            move_1.AppendLine("Целое число " + decimalNumber + " в систему счисления с основанием " + targetBase + " поэтапным делением на " + targetBase + ":");
            List<string> rest = new List<string>();
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % targetBase;
                int k = decimalNumber / targetBase;
                rest.Add(remainder.ToString());
                move_1.AppendLine($"{decimalNumber} / {targetBase} = {k}, остаток: {remainder}");
                decimalNumber = k;
            }
            rest.Reverse();
            move_1.AppendLine("Соберем все полученные остатки в обратном порядке(снизу вверх): " + string.Join("", rest));
            return move_1.ToString();
        }
    }
}

