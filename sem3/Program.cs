// void CheckKoord (int number)                                       //этот тип функции не возвращает в основную программу
// {
//     string res;
//     if (number == 1) res =  "x > 0, y > 0";
//     else if (number == 2) res =  "x > 0, y < 0";
//     else if (number == 3) res =  "x < 0, y < 0";
//     else if (number == 4) res =  "x < 0, y < 0";
//     else res = "Нет такой четверти";
//     Console.WriteLine(res);
// }
// try 
// {
//     Console.WriteLine("Введите номер четверти");
//     int number = Convert.ToInt32(Console.ReadLine());
//     CheckKoord(number);
// }
// catch
// {
//     Console.WriteLine("Введены неверные данные");
// }

// Console.WriteLine("Введите номер четверти");
// int num = Convert.ToInt32(Console.ReadLine());
// string res;

// if (num == 1) res =  "x > 0, y > 0";
// else if (num == 2) res =  "x > 0, y < 0";
// else if (num == 3) res =  "x < 0, y < 0";
// else if (num == 4) res =  "x < 0, y < 0";
// else res = "Нет такой четверти";
// Console.WriteLine(res);

//Задача:  Напишите программу которая на врод принимает координаты двух точек и находит расстояние между ними в 2D пространстве


Console.WriteLine("Введите координаты x точки a");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки a");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x точки b");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки b");
int by = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(ay-ax, 2) + Math.Pow(by-bx, 2));
Console.WriteLine($"Расстояние между точками равно {dist}");

//Задача:   Напишите программу которая принимает на вход число (N) и выдает таблицу квадратов чисел

// 5 - > 1 4 9 16 25
// Console.WriteLine("Введите натуральное число");
// int x = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= x; i++)
//     Console.Write($"{i*i}");