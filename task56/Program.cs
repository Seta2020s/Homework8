// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
//  и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void GenerateRandomArray(int[,] array, int minValue, int maxValue)
{
    Random random = new Random();

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
}

void Print2DMassive(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int minValue = -10;
int maxValue = 10;

int[,] array = new int[rows, columns];

GenerateRandomArray(array, minValue, maxValue);

Console.WriteLine("Случайный массив:");
Print2DMassive(array);

int minRowSum = int.MaxValue;
int minRowIndex = -1;

for (int i = 0; i < rows; i++)
{
    int rowSum = 0;
    for (int j = 0; j < columns; j++)
    {
        rowSum += array[i, j];
    }

    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        minRowIndex = i;
    }
}

Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minRowIndex + 1} строка");