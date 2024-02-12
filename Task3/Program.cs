// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number % 10;
number = number / 10;
int secondDigit = number % 10;

if(firstDigit > secondDigit)
    System.Console.WriteLine(firstDigit);
else
    System.Console.WriteLine(secondDigit);

