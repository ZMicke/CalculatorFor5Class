using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace CalculatorFor5thClass
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrst";
        public String oprString = "";
        public Double value1 = 0;
        public Double value2 = 0;
        public bool operatorPressed = false;
        public String result = "";


        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Click(object sender, EventArgs e)
        {
            Button Number = (Button)sender;

            if (textBox1.Text == "0" || operatorPressed)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + Number.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + Number.Text;
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            oprString = B.Text;

            value1 = Double.Parse(textBox1.Text);
            textBox1.Text = "0";
            operatorPressed = false;

            number.Text = value1 + " " + oprString;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            int targetBase = int.Parse(textTargetBase.Text);
            value2 = Double.Parse(textBox1.Text);
            number.Text = value1 + " " + oprString + " " + value2;
            operatorPressed = false;

            switch (oprString)
            {
                case "+":
                    string a = AddArbitraryBase(value1.ToString(), value2.ToString(), targetBase);
                    result = a;
                    textBox1.Text = result;
                    textExplanation.Text = GenerateColumnAdditionTable(value1.ToString(), value2.ToString(), targetBase);
                    break;
                case "-":
                    string b = Subtract(value1.ToString(), value2.ToString(), targetBase);
                    result = b;
                    textBox1.Text = result;
                    textExplanation.Text = GenerateColumnSubtractionTable(value1.ToString(), value2.ToString(), targetBase);
                    break;

                case "*":
                    result = Multiply(value1.ToString(), value2.ToString(), targetBase);
                    textBox1.Text = result;
                    textExplanation.Text = Multiply(value1.ToString(), value2.ToString(), targetBase);
                    break;
                case "/":
                    result = (value1 / value2).ToString();
                    textBox1.Text = result;
                    textExplanation.Text = result;
                    break;
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        //Сложение
        public static string AddArbitraryBase(string num1, string num2, int targetBase)
        {
            num1 = ConvertToNumber(num1, 10, targetBase);
            num2 = ConvertToNumber(num2, 10, targetBase);
            int maxLength = Math.Max(num1.Length, num2.Length);
            num1 = num1.PadLeft(maxLength, '0');
            num2 = num2.PadLeft(maxLength, '0');

            StringBuilder table = new StringBuilder();
            StringBuilder sumResult = new StringBuilder();
            int carryOver = 0;
            int[] carries = new int[maxLength];

            for (int i = maxLength - 1; i >= 0; i--)
            {
                int sum = ConvertFromBase(num1[i], targetBase) + ConvertFromBase(num2[i], targetBase) + carryOver;
                carryOver = sum / targetBase;
                int digitResult = sum % targetBase;
                sumResult.Insert(0, ConvertToBase(digitResult, targetBase));
                if (i > 0)
                {
                    carries[i - 1] = carryOver;
                }
            }
            if (carryOver > 0)
            {
                sumResult.Insert(0, ConvertToBase(carryOver, targetBase));
            }
            int resultLength = sumResult.Length;
            return sumResult.ToString();
        }

        // Объяснение сложения
        public static string GenerateColumnAdditionTable(string num1, string num2, int targetBase)
        {

            num1 = ConvertToNumber(num1, 10, targetBase);
            num2 = ConvertToNumber(num2, 10, targetBase);
            int maxLength = Math.Max(num1.Length, num2.Length);
            num1 = num1.PadLeft(maxLength, '0');
            num2 = num2.PadLeft(maxLength, '0');

            StringBuilder table = new StringBuilder();
            StringBuilder sumResult = new StringBuilder();
            int carryOver = 0;
            int[] carries = new int[maxLength];

            for (int i = maxLength - 1; i >= 0; i--)
            {
                int sum = ConvertFromBase(num1[i], targetBase) + ConvertFromBase(num2[i], targetBase) + carryOver;
                carryOver = sum / targetBase;
                int digitResult = sum % targetBase;
                sumResult.Insert(0, ConvertToBase(digitResult, targetBase));
                if (i > 0)
                {
                    carries[i - 1] = carryOver;
                }
            }
            if (carryOver > 0)
            {
                sumResult.Insert(0, ConvertToBase(carryOver, targetBase));
            }
            int resultLength = sumResult.Length;

            table.AppendLine("+ " + string.Join("   ", carries) + "   <-- Перенос  в следующий разряд");
            table.AppendLine("   " + string.Join("   ", num1.ToCharArray()));
            table.AppendLine("+ " + string.Join("   ", num2.ToCharArray()));
            table.AppendLine(new string('-', (maxLength * 3) + 2));

            // Создаем строку с каждым символом в отдельной ячейке
            StringBuilder sumRow = new StringBuilder("   ");
            for (int i = 0; i < resultLength; i++)
            {
                sumRow.Append($"{sumResult[i]}   ");
            }
            table.AppendLine(sumRow.ToString().TrimEnd());

            return table.ToString();
        }


        public static string ConvertToBase(int digit, int targetBase)
        {
            if (digit >= targetBase) throw new ArgumentException("Цифра выходит за пределы разрядов системы счисления.");
            return digit < 10 ? digit.ToString() : CalculatorFor5thClass.Form3.digits[digit].ToString();
        }

        public static int ConvertFromBase(char digit, int baseOfNumbers)
        {
            if (digit >= '0' && digit <= '9')
            {
                int value = digit - '0';
                if (value >= baseOfNumbers) throw new ArgumentException("Цифра выходит за пределы разрядов системы счисления.");
                return value;
            }
            else if (digit >= 'A' && digit <= 'Z')
            {
                int value = digit - 'A' + 10;
                if (value >= baseOfNumbers) throw new ArgumentException("Цифра выходит за пределы разрядов системы счисления.");
                return value;
            }
            else if (digit >= 'a' && digit <= 'z')
            {
                int value = digit - 'a' + 36;
                if (value >= baseOfNumbers) throw new ArgumentException("Цифра выходит за пределы разрядов системы счисления.");
                return value;
            }
            throw new ArgumentException("Недопустимая цифра для преобразования.");
        }
        public static string ConvertToNumber(string number, int sourseBase, int targetBase)
        {
            string result = "";
            var number_0 = MakeDecimal(number, sourseBase);
            while (number_0 > 0)
            {
                result += digits[(int)(number_0 % targetBase)];
                number_0 = number_0 / targetBase;
            }
            return new string(result.ToCharArray().Reverse().ToArray());
        }
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
        //Вычитание
        public static string Subtract(string num1, string num2, int targetBase)
        {
            num1 = ConvertToNumber(num1, 10, targetBase);
            num2 = ConvertToNumber(num2, 10, targetBase);
            int maxLength = Math.Max(num1.Length, num2.Length);
            num1 = num1.PadLeft(maxLength, '0');
            num2 = num2.PadLeft(maxLength, '0');

            StringBuilder table = new StringBuilder();
            StringBuilder diffResult = new StringBuilder();
            int borrow = 0;
            int[] borrows = new int[maxLength];

            for (int i = maxLength - 1; i >= 0; i--)
            {
                int diff = ConvertFromBase(num1[i], targetBase) - ConvertFromBase(num2[i], targetBase) - borrow;
                borrow = diff < 0 ? 1 : 0;
                int digitResult = (diff + targetBase) % targetBase;
                diffResult.Insert(0, ConvertToBase(digitResult, targetBase));
                if (i > 0)
                {
                    borrows[i - 1] = borrow;
                }
            }
            int resultLength = diffResult.Length;
            return diffResult.ToString();
        }
        public static string ConvertFromDecimal(long decimalNumber, int baseTo)
        {
            if (baseTo < 2 || baseTo > digits.Length)
                throw new ArgumentException("Основание должно быть от 2 до " + digits.Length);

            StringBuilder result = new StringBuilder();
            long currentNumber = decimalNumber;

            while (currentNumber > 0)
            {
                result.Insert(0, digits[(int)(currentNumber % baseTo)]);
                currentNumber /= baseTo;
            }

            return result.Length > 0 ? result.ToString() : "0";
        }
        //Вычитание столбиком
        public static string GenerateColumnSubtractionTable(string num1, string num2, int targetBase)
        {
            num1 = ConvertToNumber(num1, 10, targetBase);
            num2 = ConvertToNumber(num2, 10, targetBase);
            int maxLength = Math.Max(num1.Length, num2.Length);
            num1 = num1.PadLeft(maxLength, '0');
            num2 = num2.PadLeft(maxLength, '0');

            StringBuilder table = new StringBuilder();
            StringBuilder diffResult = new StringBuilder();
            int borrow = 0;
            int[] borrows = new int[maxLength];

            for (int i = maxLength - 1; i >= 0; i--)
            {
                int diff = ConvertFromBase(num1[i], targetBase) - ConvertFromBase(num2[i], targetBase) - borrow;
                borrow = diff < 0 ? 1 : 0;
                int digitResult = (diff + targetBase) % targetBase;
                diffResult.Insert(0, ConvertToBase(digitResult, targetBase));
                if (i > 0)
                {
                    borrows[i - 1] = borrow;
                }
            }
            int resultLength = diffResult.Length;

            table.AppendLine("- " + string.Join("   ", borrows) + "   <-- Занимаем у другого разряда");
            table.AppendLine("   " + string.Join("   ", num1.ToCharArray()));
            table.AppendLine("-  " + string.Join("   ", num2.ToCharArray()));
            table.AppendLine(new string('-', (maxLength * 3) + 2));

            // Создаем строку с каждым символом в отдельной ячейке
            StringBuilder diffRow = new StringBuilder("   ");
            for (int i = 0; i < resultLength; i++)
            {
                diffRow.Append($"{diffResult[i]}   ");
            }
            table.AppendLine(diffRow.ToString().TrimEnd());

            return table.ToString();
        }
        //Умножение столбиком (пояснение)
        public static string Multiply(string num1, string num2, int targetBase)
        {
            // Переводим числа в 10-ую систему счисления
            int intNum1 = MakeDecimal(num1, targetBase);
            int intNum2 = MakeDecimal(num2, targetBase);

            // Вычисляем произведение
            int product = intNum1 * intNum2;

            // Переводим результат обратно в указанную систему счисления
            return ConvertFromDecimal(product, targetBase);
        }

        private static int CharToInt(char digit, int baseOfNumbers)
        {
            if (char.IsDigit(digit))
            {
                return int.Parse(digit.ToString());
            }
            else
            {
                return char.ToUpper(digit) - 'A' + 10;
            }
        }

        private static char IntToHexCharWithNumber(int value)
        {
            if (value < 10)
            {
                return (char)(value + '0');
            }
            else
            {
                return (char)(value - 10 + 'A');
            }
        }



    }

}