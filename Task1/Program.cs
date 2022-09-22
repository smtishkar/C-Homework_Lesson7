// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Clear();
Console.Write("Введите количество строк массива: ");
int columns = int.Parse (Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int rows = int.Parse (Console.ReadLine());
Console.Write("Введите минимальную границу массива: ");
int minValue = int.Parse (Console.ReadLine());
Console.Write("Введите максимальную границу массива: ");
int maxValue = int.Parse (Console.ReadLine());


double [,] array = GetArray (columns,rows) ;
PrintArray (array);


double RandomDoubleFigures (int minValue, int maxValue)
{
    double rndnum1 = 0;
    double rndnum2 = 0;
    double result = 0;
    rndnum1 = new Random().Next(minValue, maxValue);
    rndnum2 = new Random().NextDouble();
    result = Math.Round((rndnum1 * rndnum2),2) ;
    return result;
}


double [,] GetArray (int m, int n)
{
    double [,] arr = new double [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = RandomDoubleFigures(minValue, maxValue);
        }
    }
    return arr;
}

void PrintArray ( double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write ($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}





// // Второй вариант без метода по рандомному созданию натуральных чисел


// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int columns = int.Parse (Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int rows = int.Parse (Console.ReadLine());
// Console.Write("Введите минимальную границу массива: ");
// int minValue = int.Parse (Console.ReadLine());
// Console.Write("Введите максимальную границу массива: ");
// int maxValue = int.Parse (Console.ReadLine());


// double [,] array = GetArray (columns,rows, minValue, maxValue) ;
// PrintArray (array);



// double [,] GetArray (int m, int n, int minValue, int maxValue)
// {
//     double rndnum1 = 0;
//     double rndnum2 = 0;
//     double [,] arr = new double [m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             rndnum1 = new Random().Next(minValue, maxValue);
//             rndnum2 = new Random().NextDouble();
//             arr[i,j] = Math.Round((rndnum1 * rndnum2),2) ;
//         }
//     }
//     return arr;
// }

// void PrintArray ( double [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write ($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
    
// }
