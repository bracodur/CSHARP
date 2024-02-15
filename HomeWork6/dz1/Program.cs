// Задайте двумерный массив символов (тип char [,]). Создать строку из символов
// этого массива.

//int[,] matrix = new int[3, 5];
//Ran (dom rnd = new Random();
//forint i = 0; i < matrix.GetLength(0); i++)
//{
    //for (int j = 0; j < matrix.GetLength (1); j++)
    //{
        //matrix[i, j] = rnd.Next(1, 11);
        
    //}
//}
//for (int i = 0; i < matrix.GetLength(1); i++)
//{
    //for (int j = 0; j < matrix.GetLength (0); j++)
    //{
       // System.Console.WriteLine(matrix[i, j]);
        
    //}
//}

//string s1 = "hello";
//                                                          
//string s2 = new string(ch_array);
//string s3 = new string('a', 5); //будет строка "aaaaa"

char[,] array = new char[,]
{
    {'a', 'b', 'c'},
    {'d', 'e', 'f'},
   
};

string result = string.Empty;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result += array[i, j];
    }
}

Console.WriteLine(result);