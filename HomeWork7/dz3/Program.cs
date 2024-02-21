// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать 
//рекурсию, не использовать циклы.
//[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

int[] Array={1, 2, 5, 0, 10, 34};

//int M=3, N = 7;
//vyvod(M,N);
vyvod(Array,0);//Array.Length-1);

void vyvod(int[] Array, int N)
{
    if (N == Array.Length-1)
    {
      Console.WriteLine(Array[N]); 
      return;
    }
    vyvod(Array, N + 1);
    Console.WriteLine(Array[N]);
}




/*
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
{
  Console.Write (result);
}/**/
//int[] ReversArray1(int[] inArray)
//{
    //int[] result = new int[inArray.Length];
    //for(int i = 0; i < inArray.Length; i++)
    //{
      //  result[i] = inArray[inArray.Length - 1 - i];
   // }
   // return result;
//}

