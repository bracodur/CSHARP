//найти максимальное из трех чисел
int a = 27;
int b = 30;
int c = 15;

int max = a;


if (b > max)
{
    max = b;
}
if (c > max)
{
   max = c;
}

System.Console.WriteLine(max);
