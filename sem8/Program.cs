﻿// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());


// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(-30, 31);
//     }
//     return array;
// }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] Revers(int[,] arr)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         int temp = arr[0, j];    
//         arr[0, j] = arr[arr.GetLength(0)-1, j];
//         arr[arr.GetLength(0)-1, j] = temp;
//     }
//     return arr;
// }
//  ДРУГОЙ ВАРИАНТ
// int [,] mas = Fillimageay(m, n);
// Printimageay(mas);
// Console.WriteLine();

// for (int j = 0; j<mas.GetLength(1); j++)
// {
//    int temp = mas[0,j];
//    mas[0,j] = mas[mas.GetLength(0)-1,j];
//    mas[mas.GetLength(0)-1,j] = temp;
// }
// Printimageay(mas);



// int[,] mas = FillArray(m, n);
// PrintArray(mas);
// Console.WriteLine();
// PrintArray(Revers(mas));


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// if (m == n)
// {
//     int[,] Fillimageay(int m, int n)
//     {
//         int[,] mat = new int[m, n];
//         for (int i = 0; i < mat.GetLength(0); i++)
//         {
//             for (int j = 0; j < mat.GetLength(1); j++)
//             {
//                 mat[i, j] = new Random().Next(0, 10);
//             }
//         }
//         Console.WriteLine();
//         return mat;
//     }

//     void Printimageay(int[,] image)
//     {
//         for (int i = 0; i < image.GetLength(0); i++)
//         {
//             for (int j = 0; j < image.GetLength(1); j++)
//             {
//                 Console.Write($"{image[i, j]} \t");
//             }
//             Console.WriteLine();
//         }
//     }

//     int[,] mas = Fillimageay(m, n);
//     Printimageay(mas);
//     Console.WriteLine();

//     int[,] Fillimage(int n, int m)
//     {
//         int[,] mas2 = new int[m, n];
//         for (int i = 0; i < mas2.GetLength(0); i++)
//         {
//             for (int j = 0; j < mas2.GetLength(1); j++)
//             {
//                 mas2[j, i] = mas[i, j];

//             }
//         }
//         Console.WriteLine();
//         return mas2;
//     }
//     int[,] mas2 = Fillimage(n, m);
//     Printimageay(mas2);


// }
// else Console.WriteLine("Невозможно заменить строки на столбцы");

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6

// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] One = new int[10];

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 7);
//     }
//     return array;
// }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// int[] mas2 = new int[10];

// for (int i = 0; i < mas.GetLength(0); i++)
// {
//     for (int j = 0; j < mas.GetLength(1); j++)
//         mas2[mas[i, j]]++;
// }

// for (int i = 0; i < mas2.Length; i++)
// {
//     Console.Write($"Число {i} встречается  {mas2[i]}  раз");

//     Console.WriteLine();
// }

// int[,] mas = FillArray(m, n);
// PrintArray(mas);
// // Console.WriteLine(Finde(One, mas));
// int[] list = Finde(One, mas);
// PrintArray(list);






