//23. Показать таблицу квадратов чисел от 1 до N

/*int n = 8;
for (int i = 1; i <= n; i++)
{

    int SquareOfI = i * i;
    Console.WriteLine(i + " " + "*" + " " + i + " " + "=" + SquareOfI);

}*/

//24. Найти кубы чисел от 1 до N

/*int n = 5;
 for (int i = 1; i<=n;i++)
 {
     int CubeOfN = i*i*i;
     Console.WriteLine (CubeOfN);
 }*/

//25. Найти сумму чисел от 1 до А

/*int[] collection = new int[10];
int i = 0;
while (i < collection.Length)
{
    collection[i] = i + 1;
    Console.Write(collection[i] + " ");
    i++;
}
int SumofCol = 0;
for (i = 0; i < collection.Length; i++)
{
    SumofCol = SumofCol + collection[i];
}

Console.WriteLine(SumofCol);*/

//26. Возведите число А в натурльную степень В используя цикл

/*int A = 2;
int B = 4;
int resultOfAB = A;
for (int i = 1; i< B;i++)
{
 resultOfAB = resultOfAB*A;
}

Console.WriteLine(resultOfAB);*/

//27. Определите количество цифр в числе

/*int num = Convert.ToInt32(Console.ReadLine());

int i = 1; 
if (num>10)
{
    while (num/10 >0)
{

   num = num/10;
   i++;

}
Console.WriteLine (i);
}
else Console.WriteLine("Содержит одну цифру");*/

// 28. Посчитать сумму цифр в числе 

/*int num = Convert.ToInt32(Console.ReadLine());

int SumOfNum = 0;

while (num > 0)
{
    SumOfNum = SumOfNum + num % 10;
    num = num / 10;
}

Console.WriteLine(SumOfNum);*/


//29. написать программу вычисления произведения чисел от 1 до N

// int min = 1;
// int max = 23;
// int[] A = new int[5];

// void GetArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
// }

// void ProductOfArray(int[] array)
// {
//     int ProductOfArray = 1;
//     for (int i = 0; i < array.Length; i++)
//     {

//         ProductOfArray = ProductOfArray * array[i];

//     }
//     int resultOfIt = ProductOfArray;
//     Console.WriteLine(resultOfIt);

// }

// GetArray(A);
// PrintArray(A);
// Console.WriteLine();
// ProductOfArray(A);

//29. написать программу вычисления произведения чисел от 1 до N

// int min = 1;
// int max = 5;
// int[] array = new int[5];

// for (int i = 0; i < array.Length; i++)
// {

//     array[i] = new Random().Next(min, max);

//     Console.Write(array[i]);


// }
// Console.WriteLine();
// int result = 1;

// for (int j = 0; j < array.Length; j++)
// {

//     result = result * array[j];

// }
// Console.WriteLine(result);

//30. Показать кубы чисел, заканчивающихся на четную цифру



int ShowCubeMultiple2(int arg)
{
    int i = 1;
    for (i = 1; i <= arg; i++)
    {
        if ((i * i * i) % 2 == 0)
        {
            Console.WriteLine($"{i} - Последняя цифра куба числа {i} - четная");
    
        }
        else Console.WriteLine($"{i} - Не соотвествует заданным параметрам");

    }
    return i*i*i;


}

int Q = 5;
ShowCubeMultiple2(Q);

