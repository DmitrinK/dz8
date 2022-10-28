/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/

int[,] generate2DArray (int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}

void search2DArray (int[,] arrayToSearch)
{
    int answer = 1;
    int count = 1;
    int sum = 0; 
    int smallSum = 0;
    for (int i = 0; i < arrayToSearch.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToSearch.GetLength(1); j++)
        { 
          sum = sum + arrayToSearch[i,j];
          if (i == 0)
          {
            smallSum = sum;
          }
        }
        if (sum < smallSum)
        {
            smallSum = sum;
            answer = count;
        }
        count ++;
        sum = 0;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {answer} строка");
}

void print2DArray (int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int[,] generatedArray = generate2DArray(4, 4, 0, 10);
print2DArray (generatedArray);
search2DArray (generatedArray);

