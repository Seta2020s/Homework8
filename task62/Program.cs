// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiralArray(int[,] array, int n)
{
    int num = 1;
    int row = 0, col = 0;
    int rowMin = 0, colMin = 0;
    int rowMax = n - 1, colMax = n - 1;

    while (num <= n * n)
    {
        for (col = colMin; col <= colMax; col++)
            array[rowMin, col] = num++;

        rowMin++;

        for (row = rowMin; row <= rowMax; row++)
            array[row, colMax] = num++;

        colMax--;

        for (col = colMax; col >= colMin; col--)
            array[rowMax, col] = num++;

        rowMax--;

        for (row = rowMax; row >= rowMin; row--)
            array[row, colMin] = num++;

        colMin++;
    }
}

void Print2DArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] spiralArray = new int[rows, columns];

FillSpiralArray(spiralArray, Math.Max(rows, columns));

Print2DArray(spiralArray);