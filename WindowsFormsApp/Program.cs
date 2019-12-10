using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{

    class Zlist 
    {
        const String PATTERN = @"\s+";

        private double[] numbers;

        private int swapCount = 0;

        public Zlist(String numbersString)
        {
            String[] numberItems = Regex.Split(numbersString, PATTERN);
            if (numberItems.Length != 12)
            {
                throw new ArgumentException("Количество элементов не 12");
            }

            int i = 0;
            this.numbers = new double[numberItems.Length];
            foreach (String strNum in numberItems)
            {
                this.numbers[i] = Convert.ToDouble(strNum);
                i++;
            }

        }

        /// <summary>
        /// http://plssite.ru/csharp/bubble_sort_article.html
        /// </summary>
        public void BubbleSort()
        {
            for (int i = 0; i < this.numbers.Length; i++)
            {
                for (int j = 0; j < this.numbers.Length - 1 - i; j++)
                {
                    if (this.numbers[j] < this.numbers[j+1] )
                    {
                        Swap(ref this.numbers[j], ref this.numbers[j + 1]);
                        this.swapCount++;
                    }
                }
            }
        }
        /// <summary>
        /// Вспомогательная функция перестановки
        /// </summary>
        /// <param name="aFirstArt"></param>
        /// <param name="aSecondArg"></param>
        private static void Swap(ref double aFirstArt, ref double aSecondArg)
        {
            double cache = aFirstArt;
            aFirstArt = aSecondArg;
            aSecondArg = cache;
        }
        
        public String PrintNumbers()
        {
            return String.Join(" ", this.numbers); ;
        }

        public int SwapCount
        {
            get { return swapCount; }
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
