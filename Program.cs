﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();

Console.WriteLine(numberS.Length > 2 ? $"{number} -> {numberS[2]}" : $"{numberS} -> Отсутствует третья цифра");

/*
if(numberS.Length > 2) {
    Console.WriteLine($"{number} -> {numberS[2]}");
} else {
    Console.WriteLine($"{number} -> Отсутствует третья цифра ");
}
*/
