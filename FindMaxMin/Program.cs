using System;

namespace FindMaxMin
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество городов: ");
            int n = int.Parse(Console.ReadLine());

            // Создаем двумерный массив для хранения расстояний
            int[,] distances = new int[n, n];

            // Вводим расстояния между городами
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Введите расстояние между городами {i + 1} и {j + 1}: ");
                    distances[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Находим минимальное и максимальное расстояния
            int minDistance = int.MaxValue;
            int maxDistance = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j) // Исключаем расстояния между одинаковыми городами
                    {
                        int distance = distances[i, j];
                        minDistance = Math.Min(minDistance, distance);
                        maxDistance = Math.Max(maxDistance, distance);
                    }
                }
            }

            // Выводим результаты
            Console.WriteLine($"Минимальное расстояние: {minDistance}");
            Console.WriteLine($"Максимальное расстояние: {maxDistance}");
        }
    }
}