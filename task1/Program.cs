//Задача 1: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int ResultValue (int numberA, int numberB)
{
 int result = 1;
 for (int i = 1; i <= numberB; i++) 
 {
 result = result * numberA;
 }
 return result;
}

Console.WriteLine("Введите число для возведения в степень: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numB > 0)
{
int value = ResultValue(numA, numB);
Console.Write(value);
}
if (numB == 0)
{
Console.Write("1");
}
