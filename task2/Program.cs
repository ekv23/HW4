//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

int sum (int value)
{
 int result = 0;
 while (value > 9) 
 {
 result = result + value % 10;
 value = value / 10;
 }
 return result + value;
}

Console.WriteLine("Введите целое многозначиное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма чисел в числе равна "+ sum(num));