Console.WriteLine("Введите число от 10 до 99");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 10)
{
    Console.WriteLine("Должнобыть число от 10 до 99");
    return;
}

if(num > 99)
{
    Console.WriteLine("Должнобыть число от 10 до 99");
    return;
}

int a = num / 10;
int b = num % 10;


if(a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}
