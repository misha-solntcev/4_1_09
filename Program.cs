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
                { 13, 10, 16, 17, 8, 15 }                
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
            Console.WriteLine("Суммы:");
            foreach (int sum in summ)
                Console.Write($"{sum}, ");
            Console.WriteLine();

            // Поиск минимумов по строкам.
            List<int> indexMin = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int min = arr[i, 0];
                int index = 0;
                for (int j = 1; j < m; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        index = j;
                    }                        
                }
                indexMin.Add(index);
            }
            Console.WriteLine("Индексы минимумов строк:");
            foreach (int index in indexMin)
                Console.Write($"{index}, ");
            Console.WriteLine();

            // Поиск максимумов по столбцам.
            List<int> indexMax = new List<int>();
            for (int j = 0; j < m; j++)                
            {
                int max = arr[0, j];
                int index = 0;
                for (int i = 1; i < n; i++)
                {
                    if (arr[i, j] >= max)
                    {
                        max = arr[i, j];
                        index = i;
                    }
                }
                indexMax.Add(index);
            }
            Console.WriteLine("Индексы максимумов столбцов:");
            foreach (int index in indexMax)
                Console.Write($"{index}, ");
            Console.WriteLine();

            // Номера строк и столбцов всех седловых точек матрицы:
            Console.WriteLine("Индексы седловых точек:");
            for (int i = 0; i < indexMin.Count; i++)            
                if (indexMin[i] == indexMax[i])
                    Console.WriteLine($"i= {indexMin[i]}, j= {indexMax[i]}, " +
                        $"arr[i,j]= {arr[indexMin[i], indexMax[i]]}");                
            
            Console.ReadKey();
        }
    }
}

