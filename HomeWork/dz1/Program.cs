//Найти большее из двух чисел
int firstNumber = 7;
int secondNumber = 15;

 if (firstNumber == secondNumber)
{
  Console.Write("Числа равны");
}
      else 
{
   if (firstNumber > secondNumber)
    {
        Console.Write("Первое число больше: ");
        Console.WriteLine(firstNumber);
     }
     else 
    {
        Console.Write("Второе число больше: ");
        Console.WriteLine(secondNumber);
    }
}