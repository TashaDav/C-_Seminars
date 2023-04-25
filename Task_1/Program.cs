//Задача №1
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> Yes
//a = 2, b = 10 -> No
//a = 9, b = -3 -> Yes
//a = -3, b = 9 -> No

Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (b * b == a)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}