// Задача №5
// Написать программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

int N = Convert.ToInt32(Console.ReadLine());
int negatN = N * -1;

while (negatN <= N)
{
    Console.WriteLine(negatN);
    Console.WriteLine(" ");
    negatN ++;
}
Console.WriteLine();