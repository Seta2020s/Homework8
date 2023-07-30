// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void GenerateUnique3DArray(int[,,] array)
{
    Random random = new Random();

    int sizeX = array.GetLength(0);
    int sizeY = array.GetLength(1);
    int sizeZ = array.GetLength(2);

    for (int i = 0; i < sizeX; i++)
    {
        for (int j = 0; j < sizeY; j++)
        {
            for (int k = 0; k < sizeZ; k++)
            {
                int randomNumber = random.Next(10, 100);
                array[i, j, k] = randomNumber;
            }
        }
    }
}

void Print3DArrayWithIndices(int[,,] array)
{
    int sizeX = array.GetLength(0);
    int sizeY = array.GetLength(1);
    int sizeZ = array.GetLength(2);

    for (int i = 0; i < sizeX; i++)
    {
        for (int j = 0; j < sizeY; j++)
        {
            for (int k = 0; k < sizeZ; k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк (X): ");
int sizeX = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов (Y): ");
int sizeY = int.Parse(Console.ReadLine());

Console.Write("Введите количество глубины (Z): ");
int sizeZ = int.Parse(Console.ReadLine());

int[,,] array = new int[sizeX, sizeY, sizeZ];

GenerateUnique3DArray(array);

Console.WriteLine("Трехмерный массив с индексами элементов:");
Print3DArrayWithIndices(array);