// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] genRandArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    Random randy = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++) array[i, j] = randy.Next(0, 20);

    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + " \t ");
        Console.WriteLine();
    }
}

void sraInArray(int[,] array)
{
    int colSum = 0;
    double result = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        colSum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            colSum = colSum + array[j, i];
        }
        result = (double)colSum / array.GetLength(0);
        Console.Write(string.Format("{0:f1}", result) + " \t ");
    }
}

int[,] myArray = genRandArray(3, 4);
printArray(myArray);
sraInArray(myArray);
