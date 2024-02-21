//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.
//M = 1; N = 5 -> "1, 2, 3, 4, 5" 
//M = 4; N = 8 -> "4, 5, 6, 7, 8"


//Console.WriteLine("введите n:");
//Console.WriteLine("введите m:");

//int n = Console.ReadLine(); 
//int m =  Console.ReadLine();

int M=3, N = 7;
result(M,N);

void result(int M, int N)
{
    if (N == M)
    {
      Console.WriteLine(N); 
      return;
    }
    result(M, N - 1);
    Console.WriteLine(N);
}


 

