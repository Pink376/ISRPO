using System;

class Program
{
    static void Main()
    {
        // Вводим размеры матрицы
        Console.Write("Введите количество строк (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов (m): ");
        int m = int.Parse(Console.ReadLine());

        // Создаем матрицу
        double[,] matrix = new double[n, m];

        // Вводим матрицу построчно
        Console.WriteLine("Введите элементы матрицы построчно:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"matrix[{i},{j}] = ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // Выводим матрицу по столбцам
        Console.WriteLine("\nМатрица, выведенная по столбцам:");
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

