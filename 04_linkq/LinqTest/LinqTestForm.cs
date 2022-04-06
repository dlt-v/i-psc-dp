using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqTest
{
    public partial class LinqTestForm : Form
    {
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public LinqTestForm()
        {
            InitializeComponent();
        }

        [Description("Posortowane słowa")]
        public static void Test_AB_01(StringBuilder sb)
        {
            digits.OrderBy(word => word).Aggregate(sb, (sb_, word) => sb.Append(word).Append(' '));
        }

        [Description("Cyfry słownie")]
        public static void Test_AB_02(StringBuilder sb)
        {
            numbers.Select(digit => digits[digit]).Aggregate(sb, (sb_, word) => sb.Append(word).Append(' '));
        }

        [Description("Tablica potęg")]
        public static void Test_AB_03(StringBuilder sb)
        {
            var table = from n in numbers orderby n select new { n, n2 = n * n, n3 = n * n * n };
            foreach (var row in table) sb.AppendFormat("{0}\t{1}\t{2}",row.n,row.n2,row.n3).AppendLine();
        }
        /*[Description("Liczby parzyste")]
        public static void Test_TM_04(StringBuilder sb)
        {
            var table = numbers.Where(n => n % 2 == 0);
            foreach (var row in table) sb.Append(row).AppendLine();
        }*/
        [Description("Wartości na poszczególnych indeksach.")]
        public static void Test_TM_05(StringBuilder sb)
        {
            var table = numbers.Select((w, i) => new
            {
                Index = i,
                Value = w
            });
            foreach (var row in table) sb.AppendFormat($"Na indeksie {row.Index} znajduje się: {row.Value}").AppendLine();
        }
        [Description("Połączenie tablic bo czemu nie.")]
        public static void Test_TM_03(StringBuilder sb)
        {
            string[] result = {};
            var table =  result.Concat(digits).Concat(Array.ConvertAll(numbers, num => num.ToString()));
            foreach (var row in table) sb.Append(row).AppendLine();
        }
        [Description("Pobranie mediany z liczb.")]
        public static void Test_TM_04(StringBuilder sb)
        {
            sb.Append($"Mediana tablicy numbers: {numbers.OrderBy(x => x).Skip(numbers.Count() / 2).First()}");

        }

        /*[Description("Połączenie tablic bo czemu nie.")]
        public static void Test_TM_03(StringBuilder sb)
        {
            string[] result = { };
            var table = result.Concat(digits).Concat(Array.ConvertAll(numbers, num => num.ToString()));
            foreach (var row in table) sb.Append(row).AppendLine();
        }*/


        private void BtnExecute_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Test_AB_01(sb);
            sb.AppendLine();
            Test_AB_02(sb);
            sb.AppendLine();
            Test_AB_03(sb);
            sb.AppendLine();
            Test_TM_04(sb);
            sb.AppendLine();
            Test_TM_05(sb);
            sb.AppendLine();
            Test_TM_03(sb);
            sb.AppendLine();
            TbLog.Text = sb.ToString();
        }
    }
}
