//Задача №3
//напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Wodnesday
//5 -> Friday

// string a = Console.ReadLine();
// if (a == "1") Console.WriteLine("Monday");
// else if (a == "2") Console.WriteLine("Tusday");
// else if (a == "3") Console.WriteLine("Wednesday");
// else if (a == "4") Console.WriteLine("Thursday");
// else if (a == "5") Console.WriteLine("Friday");
// else if (a == "6") Console.WriteLine("Saturday");
// else if (a == "7") Console.WriteLine("Sunday");
// else Console.WriteLine("Incorrect value");

// Для решения лучше использовать оператор SWITCH

Console.WriteLine("Введите номер дня недели");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Нет такого номера дня недели");
        break;
}