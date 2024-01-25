int[,] matrix =
{
     {2,6,4},
     {2,3,8},
     {7,9,8}
};

Console.WriteLine("введите значение строки в матрице: ");
int xPosition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение стольбца в матрице: ");
int yPosition = Convert.ToInt32(Console.ReadLine());

int xPositionTovaliadate = xPosition;
int yPositionTovaliadate = yPosition;

bool validationFlag = ValidatePosition(xPositionTovaliadate, yPositionTovaliadate);


bool ValidatePosition(int xValue, int yValue)
{
  xValue = xPositionTovaliadate;
  yValue = yPositionTovaliadate;
  if (xValue < matrix.GetLength(0) & yValue < matrix.GetLength(1))
  {
    return true;
  }
  else
  {
    return false;
  }
}

int FindElementByPosition(int[,] array, int x, int y)
{
  x = xPosition;
  y = yPosition;
  int matrixValue = array[x, y];
  return matrixValue;

}

if(validationFlag == true)
{
  int result = FindElementByPosition(matrix, xPosition, yPosition);
  Console.WriteLine("Значение в матрице ровно: " + result);

}
else
{
  Console.WriteLine("вы вышли за пределы матрицы!!!");
}