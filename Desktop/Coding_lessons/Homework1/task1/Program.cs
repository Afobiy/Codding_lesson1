long custom_number1 = Convert.ToInt32(Console.ReadLine());
long checker = 7*23;

long reminder = custom_number1 % checker; 

if(reminder == 0)
{
  Console.WriteLine("Делится на 23 и на 7");  
}
else
{
    Console.WriteLine("Не делится");
}

