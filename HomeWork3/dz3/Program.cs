﻿// Написать программу, которая перевернет одномерный массив. 
//Первый элемент станет последним, второй - предпоследним и т.д

int[] numbers = {1, 3, 5, 6, 7, 8}; 
int temp;

for (int i = 0; i < numbers.Length / 2; i++)
{
temp = numbers[i];
numbers[i] = numbers[numbers.Length - 1 - i];
numbers[numbers.Length - 1 - i] = temp;
}
foreach (int number in numbers)
{
Console.Write(number + " ");
}

