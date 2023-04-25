// Задача №7
// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает полсденюю цифру этого числа.

// string input = Console.ReadLine();
// int str_length = input.Length;
// Console.WriteLine(input[str_length - 1]);

//Можно записать короче

// string a = Console.ReadLine();
// int xa = Convert.ToInt32(a);
// int b = xa %10;
// Console.WriteLine(b);

//Ещё короче
// Console.WriteLine(Console.ReadLine().Last());

Console.Write("Введите трехзначное число ");
int a=Convert.ToInt32(Console.ReadLine());
if (a > 99 & a < 1000) {
Console.WriteLine(a % 10);
}
else
{
Console.WriteLine("Вы ввели не трехзначное число");
}

