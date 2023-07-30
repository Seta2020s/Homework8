// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);

    if (columns1 != rows2)
    {
        return null;
    }

    int[,] resultMatrix = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;
            for (int k = 0; k < columns1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}

Console.Write("Введите количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int minValue = -10;
int maxValue = 10;

int[,] matrix1 = new int[rows1, columns1];
int[,] matrix2 = new int[rows2, columns2];

GenerateRandomArray(matrix1, minValue, maxValue);
GenerateRandomArray(matrix2, minValue, maxValue);

Console.WriteLine("\nПервая матрица:");
Print2DMassive(matrix1);

Console.WriteLine("\nВторая матрица:");
Print2DMassive(matrix2);

int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

if (resultMatrix == null)
{
    Console.WriteLine("\nМатрицы несовместимы для умножения.");
}
else
{
    Console.WriteLine("\nРезультирующая матрица:");
    Print2DMassive(resultMatrix);
}
