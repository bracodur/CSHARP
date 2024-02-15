//Задайте произвольную строку. Выясните, является ли она палиндромом.

//char[] array = new char[];
//char[] palindrom = new char[];
//char temp;
string array;
string palindrom="yes";

array = Console.ReadLine();
 
for (int i = 0; i < array.Length/2; i++)
{
    if( array[i] != array[array.Length - 1 - i])
        palindrom="no";
}

Console.Write(palindrom);
