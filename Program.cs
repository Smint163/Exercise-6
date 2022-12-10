/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/


Console.WriteLine("Введите число");
string number0 = Console.ReadLine();
int num0 = Convert.ToInt32(number0);
if ((num0 % 2) == 0)
{
Console.WriteLine($"{num0} - да");
}
else
{
Console.WriteLine($"{num0} - нет");
}