//Задача 2:
//Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello my friend))");

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"maximum number is: {num1}, minimum number is: {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"maximum number is: {num2}, minimum number is: {num1}");
}
else Console.WriteLine($"These umbers are equal");

Console.ReadKey();
Console.Clear();


//Задача 4: 
//Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.

Console.Write("Input 3 numbers!");

Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
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
Console.WriteLine($"maximum number is: {max}");

Console.ReadKey();
Console.Clear();


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 > 0)
{
    Console.WriteLine("It is an odd number");
}
else Console.WriteLine("It is an even number");

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
