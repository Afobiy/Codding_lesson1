double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; 

int minCounter = 0;
int maxCounter = 0;
double min = array[minCounter];
double max = array[maxCounter];

while(minCounter < array.Length)
{
    if(min >= array[minCounter])
    {
        min = array[minCounter];
        minCounter = minCounter + 1;
    }
    else
    {
        minCounter = minCounter + 1;
    }
}
while(maxCounter < array.Length)
{
    if(max <= array[maxCounter])
    {
        max = array[maxCounter];
        maxCounter = maxCounter + 1;
    }
    else
    {
        maxCounter = maxCounter + 1;
    }
}
double difference = max - min;
Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine(difference);
