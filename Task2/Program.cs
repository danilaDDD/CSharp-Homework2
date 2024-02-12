//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
System.Console.Write("Введите X:");
double x = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите Y:");
double y = Convert.ToDouble(Console.ReadLine());

int quarter = 0;
if(x > 0 && y > 0)
    quarter = 1;
else if(x < 0 && y > 0)
    quarter = 2;
else if(x < 0 && y < 0)
    quarter = 3;
else if(x > 0 && y < 0)
    quarter = 4;

System.Console.WriteLine(quarter);
