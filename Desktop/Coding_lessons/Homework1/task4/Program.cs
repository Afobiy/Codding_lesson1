using System.Diagnostics.Metrics;

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int i;
do
{
    i = num % 10;
    num = num / 10;
    Console.Write(i + ", "); 
}
while(num > 0);