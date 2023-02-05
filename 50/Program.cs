// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



int[,] genRandArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    Random randy = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++) array[i, j] = randy.Next(0, 20);

    return array;
}

void numInArray(int[,] array, int row, int col)
{
    if (row > array.GetLength(0) || col > array.GetLength(1))
    {
        Console.WriteLine("Такой позиции в массиве нет!");
        return;
    }
    Console.WriteLine($"На позиции ({row},{col}) стоит число {array[row-1, col-1]}");
    return;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + "  ");
Console.WriteLine();
    }
}

int[,] myArray = genRandArray(4, 4);
int myRow = 0;
int myColumn = 0;
Console.Clear();
printArray(myArray);
Console.WriteLine("Введите строку:");
while (!Int32.TryParse(Console.ReadLine(), out myRow) || myRow <= 0)
{
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
}
Console.WriteLine("Введите столбец:");
while (!Int32.TryParse(Console.ReadLine(), out myColumn) || myColumn <= 0)
{
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
}
numInArray(myArray, myRow, myColumn);