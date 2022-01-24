//60. составить частотный словарь элементов двумерного массива 

int[,] CreateRandomArray(int rowLength, int colLength)
{
    int[,] arrayToReturn = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            arrayToReturn[i, j] = new Random().Next(0, rowLength * colLength);
        }
    }
    return arrayToReturn;
}

void Show2DArray(int[,] arrayToShow)
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


void ShowArray(int[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.WriteLine($"[{i}]:{arrayToShow[i]}");
    }
}



// int FrequenciesOfArrayElements(int[,] arrayOfNums)
// {
//     var colOfFreq = 0;
//     for (int i = 0; i < arrayOfNums.GetLength(0); i++)
//     {
//         var numOfArray = arrayOfNums[i, j];
//         for (int j = 0; j < arrayOfNums.GetLength(1); j++)
//         {
//             if (numOfArray = arrayOfNums[i, j]) colOfFreq+=1;
//         }
//     }
//     return colOfFreq;
// }

int[] CreateFrequencyArray(int[,] arrayOfNumbers)
{
    var frequencyRowArray = new int[arrayOfNumbers.GetLength(0) * arrayOfNumbers.GetLength(1)];
    for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
        {
            frequencyRowArray[arrayOfNumbers[i, j]] += 1;
        }
    }
    return frequencyRowArray;
}

int FindNotNull(int[] array)
{
    var sumOfNotNul = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumOfNotNul += 1;
    }
    return sumOfNotNul;
}

int[,] ClearArrayFromNull(int[] frequencyRowArray)
{
    var frequencyArray = new int[FindNotNull(frequencyRowArray), 2];
    int currentIndex = 0;
    for (int i = 0; i < frequencyRowArray.Length; i++)
    {
        if (frequencyRowArray[i] > 0)
            frequencyArray[currentIndex, 0] = i;
            frequencyArray[currentIndex, 1] = frequencyRowArray[i];
            currentIndex++;

    }

    return frequencyArray;
}


int[,] arrayOfNumbers = CreateRandomArray(5, 6);
Show2DArray(arrayOfNumbers);
Console.WriteLine();
int[] freqArray = CreateFrequencyArray((arrayOfNumbers));
ShowArray(freqArray);
Console.WriteLine();
var numOfNotNull = FindNotNull(freqArray);
Console.WriteLine (numOfNotNull);
Console.WriteLine();
int[,] cleanFreqArray = ClearArrayFromNull(freqArray);
Show2DArray(cleanFreqArray);

