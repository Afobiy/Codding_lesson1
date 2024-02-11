//         n+1,             m=0;
//A(m,n) = A(m-1,1)         m>0,n=0;
//         A(m-1, A(m,n-1)) m>0,n>0

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());



int Acerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    if (n == 0)
    {
        return Acerman(m - 1, 1);
    }
    else
    {
        return Acerman(m - 1, Acerman(m, n - 1));
    }
}



Console.Write("Функция Акермана равно " + Acerman(m, n));