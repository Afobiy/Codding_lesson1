 int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
        int minRange = 10;
        int maxRange = 90;
        int i = 0;
        int j = 0;
        
        while(i < array.Length)
      if(array[i] >= minRange & array[i] <= maxRange)
      {
        i = i + 1;
        j = j + 1; 
      }
      else
      {
        i = i + 1;//Введите сюда свое решение
    }
Console.WriteLine(j);