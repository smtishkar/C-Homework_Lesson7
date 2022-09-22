// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.Clear();
Console.Write("Введите количество строк массива: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите минимальную границу массива: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите максимальную границу массива: ");
int maxValue = int.Parse(Console.ReadLine());

int[,] array = GetArray(columns, rows, minValue, maxValue);
PrintArray(array);
AvgCalculation(array);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{

    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

void AvgCalculation(int[,] array)
{
    double avg = 0;
    double sum = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];

        }
        avg = Math.Round((sum / columns), 1);
        Console.Write($"{avg}; ");

    }

}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}



