//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//Например 
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

// Console.WriteLine("Введите размер строк массива");
// int QuantityLines = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размер колонок массива");
// int QuantityColumns = Convert.ToInt32(Console.ReadLine());

// void FillArrayRandomRealNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-10, 11)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// double[,] numbers = new double[QuantityLines, QuantityColumns];
// FillArrayRandomRealNumbers(numbers);
// PrintArray(numbers);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

// Console.WriteLine("Введите строку позиции элемента");
// int QuantityLines = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите колоноку позиции элемента");
// int QuantityColumns = Convert.ToInt32(Console.ReadLine());

// void FillArrayRandomRealNumbersInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArrayInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }


// int [,] numbers = new int [10,10];
// FillArrayRandomRealNumbersInt(numbers);

// if (QuantityLines > numbers.GetLength(0) || QuantityColumns > numbers.GetLength(1))
// {
//     Console.WriteLine("такого числа в массиве нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента = {numbers[QuantityLines-1,QuantityColumns-1]}");
// }

// PrintArrayInt(numbers);
