// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальный диапозон: ");
int minRange = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальный диапозон: ");
int maxRange = Convert.ToInt32(Console.ReadLine());

double[,] array2D = GetMatrix(rows, columns, minRange, maxRange);

PrintMatrix(array2D);

double[,] GetMatrix(int rows, int columns, int min, int max) // Метод Создания двумерного массива
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() * 100;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix) // Метод печати двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(Math.Round(matrix[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}