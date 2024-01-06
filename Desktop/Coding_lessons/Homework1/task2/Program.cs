Console.WriteLine("Ведите координат X, не равный 0 ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координат Y, не равный 0 ");
int Y = Convert.ToInt32(Console.ReadLine());

if(X > 0)
{
    if(Y > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    else
    {
        Console.WriteLine("Четвёртая четверть");
    }
}
else
{
    if(Y > 0)
    {
        Console.WriteLine("Вторая четверть");
    }
    else
    {
        Console.WriteLine("Третья четверть");
    }
}