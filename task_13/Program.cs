// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного семизначного числа или сообщает,
// что третьей цифры нет.

// 78 -> третьей цифры нет

// 3267900 -> 6

// ДОП: цифра третья может быть как с левой стороны, 
//  и с правой


Console.Write("Введите семизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = (number / 10000) - (number / 100000) * 10;
int newresult = (number / 100) - (number / 1000) * 10;
   
Console.WriteLine("Третья цифра с права");
Console.WriteLine(result );
Console.WriteLine("Третья цифра с лева");
Console.WriteLine(newresult);
