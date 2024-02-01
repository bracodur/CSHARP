//Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
//в которой находится эта точка.

int x = 4;
int y = -2;

if ( x > 0 && y > 0)
{
    System.Console.WriteLine("I четверть");
}
else
if ( x < 0 && y > 0)
{
    System.Console.WriteLine("II четверть");
}
if ( x < 0 && y < 0)
{
    System.Console.WriteLine("III четверть");
}
if ( x > 0 && y < 0)
{
    System.Console.WriteLine("IV четверть");
}
