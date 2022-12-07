/*Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 
*/

Console.WriteLine("Введите число"); 
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if (number>99 && number<1000)
number=number/10;
number=number%10;

Console.WriteLine($"{number}");

