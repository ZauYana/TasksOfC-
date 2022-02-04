//31. Задать массив из 8 элементов и вывести их на экран 

// void CreateArray(int minValue, int maxValue)
// {
//     int[] mass = new int[8];
//     int i = 0;
//     while (i < mass.Length)
//     {
//         mass[i] = new Random().Next(minValue, maxValue);
//         Console.WriteLine(mass[i]);
//         i++;
//     }

// }

// CreateArray(-10, 10);

//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

// int [] CreateArray()
// {
//     int[] mass = new int[8];
//     for (int i = 0; i < mass.Length; i++)
//     {
//         mass[i] = new Random().Next(0,2);
//     }

//     return mass;
// }

// void PrintArray (int [] array)
// {

//     for (int i =0; i<array.Length;i++)
//     {
//         Console.WriteLine (array [i]);
//     }
// }

// var N = CreateArray();
// PrintArray (N);

//33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива



// int[] CreateMass(int minValue, int maxValue)
// {
//     int[] mass = new int[12];
//     for (int i = 0; i < mass.Length; i++)
//     {
//         mass[i] = new Random().Next(minValue, maxValue);
//     }
//     return mass;
// }

// void PrintArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
// }


// var massForMe = CreateMass(-9, 9);
// PrintArray(massForMe);

// int FindSumOfNeg(int[] array)
// {
//     int i = 0;
//     int sumOfNegativ = 0;
//     while (i < array.Length)
//     {
//         if (array[i] < 0) sumOfNegativ = sumOfNegativ + array[i];
//         i++;
//     }

//     return sumOfNegativ;
// }

// int FindSumOfPos(int[] array)
// {
//     int i = 0;
//     int sumOfPositive = 0;
//     while (i < array.Length)
//     {
//         if (array[i] > 0) sumOfPositive = sumOfPositive + array[i];
//         i++;
//     }
//     return sumOfPositive;
// }

// Console.WriteLine();

// int negativeSum = FindSumOfNeg(massForMe);
// int positiveSum = FindSumOfPos(massForMe);


// Console.WriteLine($"Сумма отрицательных чисел массива равна {negativeSum}, а сумма положительных - {positiveSum} ");


//34. Написать программу замену элементов массива на противоположные

// int[] MassForFut(int Length, int min, int max)
// {
//     var l = Length;
//     int[] mass = new int[l];
//     for (int i = 0; i < mass.Length; i++)
//     {
//         mass[i] = new Random().Next(min, max);
//     }
//     return mass;
// }

// void PrintMass(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
// }

// var massOrigin = MassForFut(6, -7, 8);
// PrintMass(massOrigin);

// Console.WriteLine ("Gonna be magic");


// int[] ChangeTheSign(int[] array)
// {
//     int l1 = array.Length;
//     int[] arrayWithChanges = new int [l1];
//     for (int i = 0; i < array.Length; i++)
//     {
//         arrayWithChanges[i] = array[i] * -1;
//     }
//     return arrayWithChanges;
// }

// var changedMass = ChangeTheSign (massOrigin);
// PrintMass (changedMass);

//35. Определить, присутствует ли в заданном массиве, некоторое число 

// int[] CreateArray(int Length, int minValue, int maxValue)
// {
//     var len = Length;
//     int[] array = new int[len];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//         array[2] = 7;
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
// }


// int[] myArray = CreateArray(6, -9, 9);
// PrintArray(myArray);
// Console.WriteLine();

// Boolean FindTneNum(int[] array, int Num)
// {
//     bool theSameNum = false;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == Num) theSameNum = true;
//     }

//     return theSameNum;
// }

// var result = FindTneNum(myArray, 7);
// Console.WriteLine(result);

//36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// int[] CreateArray(int Length)
// {
//     int[] array = new int[Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     int l = array.Length;
//     for (int i = 0; i < l; i++)
//     {
//         Console.Write($"{array[i]};");
//     }
// }

// var RandomArray = CreateArray(10);
// PrintArray(RandomArray);


// int QuantityOfOddNum(int[] array)
// {
//     var QuantityOfOddNum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 != 0) QuantityOfOddNum = QuantityOfOddNum + 1;

//     }
//     return QuantityOfOddNum;
// }

// var resultOfOddNumbers = QuantityOfOddNum(RandomArray);
// Console.WriteLine();
// Console.WriteLine($"Quantity of odd numbers are {resultOfOddNumbers}");

// int QuantityOfEvenNumbers(int[] array)
// {
//     var QuantityOfEvenNum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) QuantityOfEvenNum = QuantityOfEvenNum + 1;

//     }
//     return QuantityOfEvenNum;
// }


// var resultOfEvenNum = QuantityOfEvenNumbers(RandomArray);
// Console.WriteLine();
// Console.WriteLine($"Quantity of even numbers are {resultOfEvenNum}");

// ВОТ ТАК НАДО


// int [] CreateArray(int length) 
// { 
//     int[] array = new int[length]; 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         array[i] = new Random().Next(100, 1000); 
//     } 
//     return array; 

// }

// int CountNumbers(int[] array, bool isOdd)
// {
//     var count = 0;

//     foreach (var item in array)
//     {
//         if (item % 2 == (isOdd ? 1 : 0))
//             count++;
//     }

//     return count;
// }

// var array = CreateArray(100);

// var oddCnt = CountNumbers(array, true);

// var evenCnt = CountNumbers(array, false);

// Console.WriteLine("Odd count {0}, Even count {1}", oddCnt, evenCnt);

// Console.ReadLine();


//37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int[] CreateArray()
// {
//     int length = 123;
//     int[] array = new int[length];
//     for (int i = 1; i < array.Length; i++)
//     {
//         array[0] = 0;
//         array[i] = array[i - 1] + 1;
//     }
//     return array;

// }

// // void PrintArray(int[] array)
// // {
// //     int l = array.Length;
// //     for (int i = 0; i < l; i++)
// //     {
// //         Console.Write($"{array[i]};");
// //     }
// // }

// // var array1 = CreateArray();
// // PrintArray(array1);

// int CountNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 10 && array[i] < 99) count = count + 1;

//     }

//     return count;

// }

// var array1 = CreateArray();
// var resultOfCount = CountNumbers(array1);
// Console.WriteLine(resultOfCount);


//38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// int[] CreateArray(int length)
// {

//     int[] array = new int[length];
//     for (int i = 1; i < array.Length; i++)
//     {
//         array[0] = 0;
//         array[i] = array[i - 1] + 1;
//     }
//     return array;
// }

// int FindTheSum(int[] array)
// {
//     var SumOfEven = 0;
//     int i = 0;
//     while (i < array.Length)
//     {
//         if (i % 2 != 0) SumOfEven = SumOfEven + array[i];
//         i++;
//     }

//     return SumOfEven;
// }

// void PrintArray(int[] array)
// {
//     int l = array.Length;
//     for (int i = 0; i < l; i++)
//     {
//         Console.Write($"{array[i]};");
//     }
// }

// var array = CreateArray(15);
// PrintArray(array);
// Console.WriteLine("______");
// var resultOfEvenSum = FindTheSum(array);
// Console.WriteLine(resultOfEvenSum);

//39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int[] CreateArray(int length)

// {

//     int[] array = new int[length];

//     for (int i = 1; i < array.Length; i++)

//     {

//         array[0] = 0;

//         array[i] = array[i - 1] + 1;

//     }

//     return array;

// }

// int[] FindComposition(int[] array)

// {
//     int i = 0;
//     int j = array.Length - 1; 

//     int[] array1 = new int[array.Length / 2];  

//     int ind = 0;

//     while (i <= array.Length / 2 && ind <= array1.Length && j>=array.Length/2)

//     {

//         array1[ind] = array[i] * array[j]; 
//         i++;
//         j--;
//         ind++;

//     }
//     return array1;
// }

// void PrintArray(int[] array)

// {

//     int l = array.Length;

//     for (int i = 0; i < l; i++)

//     {

//         Console.Write($"{array[i]}; ");

//     }

// }

// var arrayForFuture = CreateArray(10);

// PrintArray(arrayForFuture);

// Console.WriteLine("___");

// int[] newArray = FindComposition(arrayForFuture);

// PrintArray(newArray);

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// double [] CreateArray (double minValue, double maxValue, int length)
// {
//     double [] arrayOfDouble = new double [length];
//     for (int i = 0; i<length; i++)
//     {
//         arrayOfDouble [i] = Math.Round ((new Random ().NextDouble ()*(maxValue-minValue)+minValue),2);
//     }
//     return arrayOfDouble;
// }

// double FindMaxDouble ( double [] arrayDoubles)
// {
//     double maxCount = arrayDoubles [0];
//     for (int i = 0; i<arrayDoubles.Length;i++)
//     {
//         if (arrayDoubles [i]> maxCount) maxCount = arrayDoubles [i];
//     }
//     return maxCount;
// }

// double FindMinDouble ( double [] arrayDoubles)
// {
//     double minCount = arrayDoubles [0];
//     for (int i = 0; i<arrayDoubles.Length;i++)
//     {
//         if ( arrayDoubles [i]< minCount) minCount = arrayDoubles [i];
//     }
//     return minCount;
// }

// double FindTheDistBWMaxMin (double maxValue, double minValue)
// {
//     double resultBWMaxMin = maxValue - minValue;
//     return resultBWMaxMin;
// }



// void PrintArray (double [] arrayOfDoub)
// {
//     for (int i = 0; i<arrayOfDoub.Length;i++)
//     {
//         Console.Write ($"[{i}] - {arrayOfDoub [i]} ");
//     }
// }

// double [] arrayCreted = CreateArray (1.5,7.5,10);
// PrintArray (arrayCreted);
// Console.WriteLine ();
// double maxDoubleValue = FindMaxDouble (arrayCreted);
// double minDoubleValue = FindMinDouble (arrayCreted); 
// double distanceBWMaxMin = FindTheDistBWMaxMin (maxDoubleValue,minDoubleValue);
// Console.WriteLine ($"{"Max Value in Array of Doubles"} - {maxDoubleValue}");
// Console.WriteLine ($"{"Min Value in Array of Doubles"} - {minDoubleValue}");
// Console.WriteLine ($"{"The difference between max value and min value " } - {distanceBWMaxMin}");


