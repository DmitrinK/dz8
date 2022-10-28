/* 
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

int[,] firstMatrix (int height, int width, int randomStart, int randomEnd)
{
    int[,] firstMatrixArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            firstMatrixArray[i,j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return firstMatrixArray;
}

int[,] secondMatrix (int height, int width, int randomStart, int randomEnd)
{
    int[,] secondMatrixArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            secondMatrixArray[i,j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return secondMatrixArray;
}

void resultMatrixPrint (int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrixArray = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    resultMatrixArray[0,0] = firstMatrix[0,0] * secondMatrix[0,0] + firstMatrix[0,1] * secondMatrix[1,0];
    resultMatrixArray[0,1] = firstMatrix[0,0] * secondMatrix[0,1] + firstMatrix[0,1] * secondMatrix[1,1];
    resultMatrixArray[1,0] = firstMatrix[1,0] * secondMatrix[0,0] + firstMatrix[1,1] * secondMatrix[1,0];
    resultMatrixArray[1,1] = firstMatrix[1,0] * secondMatrix[0,1] + firstMatrix[1,1] * secondMatrix[1,1];
    for (int i = 0; i < resultMatrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrixArray.GetLength(1); j++)
        {
            Console.Write(resultMatrixArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void printMatrix (int[,] firstMatrixToPrint, int[,] secondMatrixToPrint)
{
    for (int i = 0; i < firstMatrixToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrixToPrint.GetLength(1); j++)
        {
            Console.Write(firstMatrixToPrint[i,j] + "\t");
        }
        Console.Write("|" + "\t");
         for (int q = 0; q < firstMatrixToPrint.GetLength(1); q++)
        {
            Console.Write(secondMatrixToPrint[i,q] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] generatedFirstMatrix = firstMatrix(2, 2, 1, 10);
int[,] generatedSecondMatrix = secondMatrix(2, 2, 1, 10);
Console.WriteLine("Даны 2 матрицы:");
printMatrix (generatedFirstMatrix, generatedSecondMatrix);
Console.WriteLine("Результирующая матрица:");
resultMatrixPrint (generatedFirstMatrix, generatedSecondMatrix);