//Задача 2:
//Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

using System.ComponentModel.DataAnnotations;

Console.WriteLine("Здравствуй, дорогой друг))");
System.Console.WriteLine("Программа поиска макисмального числа");
Console.WriteLine("Введи перво число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Число: {num1} больше чем: {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"Число: {num2}, больше чем: {num1}");
}
else Console.WriteLine($"Введённые числа равны");

Console.ReadKey();
Console.Clear();


//Задача 4: 
//Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.
System.Console.WriteLine("Программа поиска максимального числа из трёх");
Console.WriteLine("Введите 3 числа!");

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max;
if (number1 > number2)
{
    max = number1;
}
else max = number2;

if (max < number3)
{
    max = number3;
}
Console.WriteLine($"Максимальное число будет: {max}");

Console.ReadKey();
Console.Clear();


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 > 0)
{
    Console.WriteLine("Это нечётное число");
}
else Console.WriteLine("Это чётное число");

Console.ReadKey();
Console.Clear();


//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input N number: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= numberN)
{
    if(current % 2 == 0)
    {
        Console.Write(current + " ");
    }
    current++;
}

Console.ReadKey();
