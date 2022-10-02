/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10*/

Console.Write("введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0;
int result = 0;
for (int index = 0; index < n; index++)
{
      m = n - n % 10;
      result = result + (n - m);
      n = n / 10;
}
Console.WriteLine("Сумма цифр в числе: " + result);

//задача решена