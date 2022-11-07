// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент
//  будет на первом месте, а первый - на последнем и т.д.)
//  [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] CreateFillArray()
// {
//     int[] arr = new int[14];
//     for (int i=0;i<14;i++) 
//     {
//         arr[i]= new Random().Next(0,100);
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     int count = 14;
//     for ( int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void ReversArray(int[] array)
// {
//     int buf;
//     for ( int i = 0; i < array.Length/2; i++)
//         {
//             // buf=array[i];
//             // array[i]=array[array.Length-1-i];
//             // array[array.Length-1-i] = buf;
//             (array[i], array[array.Length-1-i]) = (array[array.Length-1-i], array[i]);
//         }
//     PrintArray(array);
// }

// int[] mas = CreateFillArray();
// ReversArray(mas);

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите первую длину треугольника");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую длину треугольника");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третью длину треугольника");
// int z = Convert.ToInt32(Console.ReadLine());
// Решение без функии

// if ((x < y+z) && (y < x + z) && ( z < x + y)) Console.WriteLine("Треугольник имеет место быть");
// else Console.WriteLine("Такой треугольник не может существовать");

//Решение функцией

// bool CheckTriangle (int x, int y, int z)
// {
//     bool n = false;
//     if ((x < y+z) && (y < x + z) && ( z < x + y)) n = true;
//     return n;
// }
// Console.WriteLine(CheckTriangle(x, y, z));


// Задача 42: Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите целое число");
// int x = Convert.ToInt32(Console.ReadLine());
// string result = "";
// string y;
// while (x > 0)
// {
//     y = Convert.ToString(x% 2);
//     result = result + y;
//     x = x / 2;
// }
// Console.WriteLine(result);


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1;
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите целое число");
// int N = Convert.ToInt32(Console.ReadLine());
// int x = 0;
// int y = 1;
// Console.Write(x + " ");
// Console.Write(y + " ");
// int n;

// for (int i = 2; i < N; i++)
// {
//     n = x + y;
//     Console.Write(n + " ");
//     x = y;
//     y = n;
// }

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];

// for (int i = 0; i < n; i++)
// {
//     if(i == 0) array[i] = 0;
//     else if(i == 1) array[i] = 1;
//     else array[i] = array[i - 1] + array[i - 2];
// }

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// PrintArray(array);