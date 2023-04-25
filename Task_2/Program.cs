//Задача №3
//напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Wodnesday
//5 -> Friday

string a = Console.ReadLine();
if (a == "1") Console.WriteLine("Monday");
else if (a == "2") Console.WriteLine("Tusday");
else if (a == "3") Console.WriteLine("Wednesday");
else if (a == "4") Console.WriteLine("Thursday");
else if (a == "5") Console.WriteLine("Friday");
else if (a == "6") Console.WriteLine("Saturday");
else if (a == "7") Console.WriteLine("Sunday");
else Console.WriteLine("Incorrect value");