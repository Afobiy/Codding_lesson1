//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
char[,] lettets =
{
    {'Q','w','e','r'},
    {'a','s','d','f'},
    {'z','x','c','v'}

};

string GetString(char[,] letters)
{
    string words = "";
    for (int y = 0; y < letters.GetLength(0); y++)
    {
        for (int x = 0; x < letters.GetLength(1); x++)
        {
            words += letters[y, x];
        }
    }return words;
}


string words=GetString(lettets);
Console.Write(words);