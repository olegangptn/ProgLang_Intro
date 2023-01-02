


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine ("Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
   Console.WriteLine ("number "+number+" is even");
}
else
{
    Console.WriteLine ("number "+number+" is not even");
}

// }
//  Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine ("Enter any number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int evenNumber = 2;

// if(number > 1)
// {
//     while(evenNumber <= number)
//     {
//         Console.Write(evenNumber + " ");
//         evenNumber = evenNumber + 2;
//     }
// }