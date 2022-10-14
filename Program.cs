using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Вариант 9
Дана целочисленная прямоугольная матрица. Определить:
1.сумму элементов в тех строках, которые содержат хотя бы один отрицательный
элемент;
2.номера строк и столбцов всех седловых точек матрицы.
Примечание. Матрица А имеет седловую точку Аij, если Аij является минимальным
элементом в i-й строке и максимальным в j-м столбце.*/

namespace _4_1_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {
                { 8, 0, 6, -4, 8, 1 },
                { 4, 1, 36, 7, 8, 2 },
                { 7, 8, 9, 0, 2, 3 },
                { 12, 0, 3, -4, 5, 4 },
                { 13, 0, 6, 7, 8, 5 },
                { 14, 8, 9, 0, 2, 3 },
            };
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);

            // Сумма элементов в строках, которые содержат хотя бы один отрицательный элемент.
            List<int> summ = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                bool flag = false;
                for (int j = 0; j < m; j++)
                {
                    sum += arr[i, j];
                    if (arr[i, j] < 0)
                        flag = true;
                }
                if (flag)
                    summ.Add(sum);
            }
            foreach (int sum in summ)
                Console.Write($"{sum}, ");
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}

