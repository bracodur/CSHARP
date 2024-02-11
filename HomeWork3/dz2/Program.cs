//Задайте массив заполненный случайными трехзначными числами.
//написать программу которая покажет количество четных чисел в массиве.

Random rnd = new Random();

int size = 1000;
int[] arr_int = new int[size];
int i = 0;
int KolichestvoEven = 0;
while (i < size)
{
    arr_int[i] = rnd.Next(99, 1000);
    i = i + 1;
}

i = 0;
while (i < size)
{
    //Console.Write($"{arr_int[i]} ");

    if (arr_int[i] % 2 == 0)
        KolichestvoEven++;

    i = i + 1;
}
Console.Write($"Количество четных чисел:{KolichestvoEven} ");
