
int[,] matrix =
{
    {7,85,15,5},
    {91,18,78,7},
    {21,54,98,2}
};

Console.WriteLine("Матрица до:");
ShowMatrix(matrix);

int[] arrayInMemory = new int[matrix.GetLength(1)];

void ReverseMatrixFirtsStringToLast(int[,] matrix1)
{
for (int x = 0; x < matrix.GetLength(1); x++)
{
    int xInMemory = matrix[0, x];
    arrayInMemory[x] = xInMemory;
    matrix[0, x] = matrix[2, x];
    //Console.Write(matrix[0, x] + "\t");
}
}

ReverseMatrixFirtsStringToLast(matrix);

void ReverseMatrixLastStringToFirst(){
for(int l = 0; l < matrix.GetLength(1); l++)
{
    matrix[2,l] = arrayInMemory[l];
}
}
ReverseMatrixLastStringToFirst();

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Матрица после:");
ShowMatrix(matrix);