Console.WriteLine("введите первую границу интервала m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите вторую границу интервала n:");
int n = Convert.ToInt32(Console.ReadLine());


if (m > n)
{
    Console.WriteLine(" m должна быть меньше n");
    return;
}

void ShowNaturals(int i)
{
    if (i <= n)
    {
        if (i > 0)
        {
            Console.Write(i + " ");
            i++;
        }
        else
        {
            i++;
        }
        ShowNaturals(i);
    }

}
ShowNaturals(m);
