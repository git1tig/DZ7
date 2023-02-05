// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] genRandArray(int rows, int cols)
{
    double[,] array = new double[rows, cols];
    Random randy = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++) array[i, j] = randy.NextDouble() * 10;

    return array;
}

void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write(string.Format("{0:f2}", array[i, j]) + "  ");
        Console.WriteLine();
    }
}

double[,] myArray = genRandArray(3, 4);
Console.Clear();
printArray(myArray);
