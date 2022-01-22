//60. составить частотный словарь элементов двумерного массива 

int[,] CreateRandomArray(int rowLength, int colLength)
{
    int[,] arrayToReturn = new int[rowLength,colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            arrayToReturn[i, j] = new Random().Next(0, rowLength + colLength);
        }
    }
    return arrayToReturn;
}

void ShowArray(int[,] arrayToShow)
{
    for (int i = 0; i < arrayToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToShow.GetLength(1); j++)
        {
            Console.Write($"{arrayToShow[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] arrayOfNumbers = CreateRandomArray(7, 3);
ShowArray(arrayOfNumbers);


