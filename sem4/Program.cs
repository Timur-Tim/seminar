// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= n; i++) sum = sum + i;
// Console.WriteLine($"Сумма всех чисел от 1 до {n} равна {sum}");

// void SumNumber (int x)
// {
//     int sum = 0;
//     for (int i = 1; i <= x; i++) 
//         sum = sum + i;
//     Console.WriteLine($"Сумма всех чисел от 1 до {x} равна {sum}");
// }

// int SumNumber2 (int x)
// {
//     int sum = 0;
//     for (int i = 1; i <= x; i++) 
//         sum = sum + i;
//     return sum;
// }

// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// SumNumber(n);
// Console.WriteLine(SumNumber2(n));


// Задача 26. Напишите программу которая выдает количество цифр в числе

// Console.WriteLine("Введите целое число");
// int x = Convert.ToInt32(Console.ReadLine());
// int razryad = 0;
// while (x % 10 > 0)
// {
//     razryad ++;
//     x/=10;
// }
// Console.WriteLine(razryad);

//решение функцией

// void SumNumber (int x)
// {
//     int razryad = 0;
//     while (x % 10 > 0)
//     {
//     razryad ++;
//     x/=10;
//     }
//     Console.WriteLine($"Количество цифр в числе {razryad}");
// }

// Console.WriteLine("Введите целое число");
// int x = Convert.ToInt32(Console.ReadLine());
// SumNumber(x);

// решение через логорифм     
// Console.WriteLine("Введите целое число");
// int x = Convert.ToInt32(Console.ReadLine());
// int a = (int)Math.Log10(x) +1;
// Console.WriteLine($"Число символов {a}");



// Задача28: Напишите программу которая принимает на вход число N и выдает произведение чисел от 1 до N.

// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());

// void SumNumber (int x)
// {
//     int a = 1;
//     for (int i = 1; i <= x; i++) 
//         a = a * i;
//     Console.WriteLine($"Произведение всех чисел от 1 до {x} равна {a}");
// }
// SumNumber(n);


// Задача 30: Напишите программу которая выводит массив из 8 элементов заполненный нулями и еденицами в случайном порядке.

// int[] array = new int[8];

// void FullArray(int[] collection)
// {
//     int length = 8;
//     int index = 0;

//     while (index < length)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }
// // FullArry(array);

// void PrintArray(int[] array)
// {
//     int count = 8;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// FullArray(array);
// PrintArray(array);

// int p = 0;
// int count = 8;
// for (int i = 0; i < count; i++)
// {
//     if (array[i] == 1) p = p+1;
// }
// Console.WriteLine($"Количесвло едениц в массиве {p}");
