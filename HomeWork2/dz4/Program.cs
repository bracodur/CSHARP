// Напишите программу, которая на вход принимает натуральное число N,
//а на выходе показывает его цифры через запятую.


int N =311;
int currentDigit, i;
string digits="";
while (N > 0)
{
    currentDigit = N % 10;
    N /= 10;
    if (N > 0)
    {
        //Console.Write(currentDigit + ",");
        digits=digits+currentDigit.ToString()+",";
    }
    else
    {
        //Console.WriteLine(currentDigit);
        digits+=currentDigit.ToString();
    }
//    i++;
}
//digits+="\n";
//Console.WriteLine(digits);
i=0;
while(i < digits.Length )
{
    Console.Write(digits[digits.Length-i-1]);
    i++;   
}