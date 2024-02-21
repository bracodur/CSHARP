//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29
//A(n, m) = m + 1, если n = 0,
//A(n - 1, 1), если n <> 0, m = 0,
//A(n - 1, A(n, m - 1)), если n> 0, m > 0.
    int n = 3, m = 2; 
    static int A(int n, int m)
    {
        if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
        if (n == 0) return m + 1;
        if (m == 0) return A(n - 1, 1);
        
        return A(n - 1, A(n, m - 1));
    }
    {
         Console.WriteLine(A(n, m));
        
    }