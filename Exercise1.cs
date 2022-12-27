// Урок 1. Знакомство с языком программирования С#

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.WriteLine("Введите первое число: ");
//     int firstNumber = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите второе число: ");
//     int secondNumber = Convert.ToInt32(Console.ReadLine());

//     if (firstNumber > secondNumber) {
//       Console.WriteLine($"max = {firstNumber}, min = {secondNumber}");
//     } else {
//       Console.WriteLine($"max = {secondNumber}, min = {firstNumber}");
//     }



// / Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел


// Console.WriteLine("Введите первое число: ");
//     int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
//     int secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
//     int thirdNumber = Convert.ToInt32(Console.ReadLine());    

//     int max = firstNumber;

//     if (secondNumber > max) max = secondNumber;
    
//     if (thirdNumber > max) max = thirdNumber;

// Console.WriteLine($"Максимальное значение - {+max} ");







// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка)

// Console.WriteLine ("Enter any number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
//    Console.WriteLine ("number "+number+" is even");
// }
// else
// {
//     Console.WriteLine ("number "+number+" is not even");

// }
//  Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine ("Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}