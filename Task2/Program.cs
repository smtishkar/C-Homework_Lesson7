// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> такого числа в массиве нет



Console.Clear();
Console.Write ("Ведите количество строк в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.Write ("Ведите количество столбцов в массиве: ");
int rows = int.Parse(Console.ReadLine()); 
Console.Write ("введите индекс строки в массиве для получения значения этого индекса: ");
int columnsIndex = int.Parse(Console.ReadLine());        
Console.Write ("введите индекс столбца в массиве для получения значения этого индекса: ");
int rowIndex = int.Parse(Console.ReadLine());  
        
int [,] array = GetArray (columns, rows, 0, 10);
PrintArray(array);
Console.WriteLine($"Значение числа на пересечении указанных индексов равно {GetNumber (array)}");
        
int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int [,] arr = new int [m,n];
    for (int i=0 ; i < m; i++)
    {

        for (int j=0; j< n; j++)
        {

            arr[i,j] = new Random().Next(minValue, maxValue);
                    
        }
    }
    return arr;
}

int GetNumber (int [,] array)
{
    int num = 0;

    for (int i =0 ; i<array.GetLength(0); i++)
    {
        if (columnsIndex > array.GetLength(0)) Console.WriteLine("Такого числа в массиве нет");
        for (int j = 0; j <array.GetLength(1); j++)
        {
            if (rowIndex > array.GetLength(1)) Console.WriteLine("Такого числа в массиве нет");
            num = array [columnsIndex,rowIndex];
        }
                
    }
    return num;
}

void PrintArray (int [,] array)
{
    for (int i =0 ; i<array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            Console.Write ($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
            
            
}










