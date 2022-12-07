/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день вЫХоДНЫм.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите число от 1 до 7");
string numberDay=Console.ReadLine();

if (numberDay== "1")
Console.WriteLine($"{numberDay},Нет");
else if(numberDay== "2")
Console.WriteLine($"{numberDay},Нет");
else if(numberDay=="3")
Console.WriteLine($"{numberDay},Нет");
else if(numberDay=="4")
Console.WriteLine($"{numberDay},Нет");
else if(numberDay=="5")
Console.WriteLine($"{numberDay},Нет");
else if(numberDay=="6")
Console.WriteLine($"{numberDay},Да");
else if(numberDay=="7")
Console.WriteLine($"{numberDay},Да");
else Console.Write("Error");