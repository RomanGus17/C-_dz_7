﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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