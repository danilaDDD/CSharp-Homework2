// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
Console.Write("Введите число:");
int number = Convert.ToInt32(System.Console.ReadLine());

int digit = number % 10;
number /= 10;
System.Console.Write(digit);

while(number > 0)
{
    digit = number % 10;
    number /= 10;
    System.Console.Write("," + digit);
}
