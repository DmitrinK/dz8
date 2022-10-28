/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
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

int[,] search2DArray (int[,] arrayToSearch)
{
    for (int i = 0; i < arrayToSearch.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToSearch.GetLength(1); j++)
        {
            int count = j;
            int temporaryStorage = 0;
            while (count < arrayToSearch.GetLength(1))
            {
                if (arrayToSearch[i,j] < arrayToSearch[i,count])
                {
                    temporaryStorage = arrayToSearch[i,j];
                    arrayToSearch[i,j] = arrayToSearch[i,count];
                    arrayToSearch[i,count] = temporaryStorage;
                }
                count++;
            }
        }
    }
    return arrayToSearch;
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


int[,] generatedArray = generate2DArray(5, 6, 0, 100);
Console.WriteLine("Задан массив:");
print2DArray(generatedArray);
search2DArray (generatedArray);
Console.WriteLine();
Console.WriteLine("В итоге получается вот такой массив:");
print2DArray(generatedArray);