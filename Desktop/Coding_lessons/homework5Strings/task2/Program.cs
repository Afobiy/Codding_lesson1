//Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string mixedCaseLettes = "QWerTyuIO";

string GoToLowCase(string mixedCaseLettes)
{
    string newString = "";
    for (int i = 0; i < mixedCaseLettes.Length; i++) ;
    newString = mixedCaseLettes.ToLower();
    return newString;
}

string result = GoToLowCase(mixedCaseLettes);
Console.WriteLine(result);