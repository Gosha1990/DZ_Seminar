//  Задача 10:
//   Напишите программу, которая принимает на вход 
//  трёхзначное число и на выходе показываеn
//   вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = (number / 10) - (number / 100) * 10;

Console.WriteLine( result  );
