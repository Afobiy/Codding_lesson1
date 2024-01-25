
int[,] matrix = new int[,] {
    {1, 2, 3},//6
    {1, 1, 0},//2
    {7, 8, 2},//17
    {9, 10, 11}//30
};


int[] FinStringSum(int[,] matrix)
{
    int[] columnsSum = new int[matrix.GetLength(0)];
    for (int y = 0; y < matrix.GetLength(0); y++)
    {
        int stringSum = 0;
        for (int x = 0; x < matrix.GetLength(1); x++)
        {
            stringSum = stringSum + matrix[y, x];
        }
        columnsSum[y] = stringSum;
    }
    return columnsSum;
}

int[] columnsSum = FinStringSum(matrix);
{
    for (int i = 0; i < columnsSum.Length; i++)
    {
        Console.Write(columnsSum[i] + "\t");
    }
}


int FindLowestStringIndex()
{
    //int[] colums = { columnOne, columnTwo, columnTree, columnFour }; // 6, 2 , 17 , 30;
    int lowestString = columnsSum[0];
    int lowestStringIndex = 0;
    for (int i = 0; i < columnsSum.Length; i++)
    {
        if (columnsSum[i] < lowestString)
        {
            lowestString = columnsSum[i];
            lowestStringIndex = i;
        }
    }
    return lowestStringIndex;
}

Console.WriteLine();
int result = FindLowestStringIndex();
Console.WriteLine("Индекс строки с наименьшем значением = " + result);
