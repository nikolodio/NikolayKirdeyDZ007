// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Задано поле размеров 4х4");

int[,] GetMatrix(int m, int n, int min, int max) // Метод Создания двумерного массива
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // Метод печати двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Выберите строчку :");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Выберите столбец: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int FindElementInMatrix(int[,] matrix) // Метод поиска элемента в массиве по его позиции
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (rows < matrix.GetLength(0)
                && columns < matrix.GetLength(1))
            {
                matrix[i, j] = matrix[rows, columns];
                Console.WriteLine($"Вы попали в элемент -> {matrix[rows, columns]}");
            }
            else Console.WriteLine("Элемента с такой позицией нет");
        }
    }
    return matrix[rows, columns];
}

int[,] array2D = GetMatrix(4, 4, 0, 100);
PrintMatrix(array2D);
FindElementInMatrix(array2D);

// Я сожалею но не могу разобраться с проблемом вывода количества сообщений в консоль =(