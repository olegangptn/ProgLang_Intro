// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


      Console.WriteLine ("Введите число");
   
        string number = Console.ReadLine();
        if(number.Length < 3) 
        {
            Console.WriteLine("Третьей цифры нет");
          return;
        }

        Console.WriteLine(number[2]);  