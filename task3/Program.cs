﻿//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void Array ()
{
 int [] NewArray = new int [8];

 for (int i = 0; i < 8; i++)
 {
NewArray[i] = new Random().Next(0,100);
 Console.Write(NewArray[i] + " ");
 }
}
Array ();