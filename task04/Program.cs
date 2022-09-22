// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 1. принимает на вход три числа
// 2. выдаёт максимальное из этих чисел
// 3. Вывод результата

// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("Максимальное число = ");
Console.Write(max);