//Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.WriteLine("Введите слово");
string stringForCheck = Console.ReadLine();
//bool palindromeChercker;

bool CheckForPalindrome(string stringForCheck)
{
bool palindromeChercker = true;
for (int i = 0; i < stringForCheck.Length / 2; i++)
{
    if(stringForCheck[i] == stringForCheck[(stringForCheck.Length -1)-i])
    {
        palindromeChercker = true;
    }
    else
    {
        palindromeChercker = false;
        break;
    }
} 
return palindromeChercker;
}

bool palindromeChercker = CheckForPalindrome(stringForCheck);
if(palindromeChercker == true)
{
    Console.WriteLine("Это слово палиндром");
}
else
{
    Console.WriteLine("Это слово не палиндром");

}