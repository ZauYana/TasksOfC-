/*## **Почувствуй себя лидом*.  (41 - 47)**

1. Выяснить являются ли три числа сторонами треугольника
2. Определить сколько чисел больше 0 введено с клавиатуры
3. Написать программу преобразования десятичного числа в двоичное
4. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
5. Показать числа Фибоначчи
6. Написать программу масштабирования фигуры

```
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

```

1. Написать программу копирования массива*/


// 1. Выяснить являются ли три числа сторонами треугольника

int[] CreateThreeCount(int minVValue, int maxValue)
{
    int[] arrayOfThreeNums = new int[3];
    
    foreach (var item in arrayOfThreeNums)
    {
        arrayOfThreeNums[item] = new Random().Next(minVValue, maxValue);
    }
    return arrayOfThreeNums;
}

void PrintArray(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.WriteLine($"[{i}] - {array[i]} ");
    }
}

Boolean IsCheckTheTriangle(int[] arrayOfThreeNums)
{
    bool isTriangle = true;
    if (arrayOfThreeNums[0] < arrayOfThreeNums[1] + arrayOfThreeNums[2]
    & arrayOfThreeNums[1] < arrayOfThreeNums[0] + arrayOfThreeNums[2]
    & arrayOfThreeNums[2] < arrayOfThreeNums[0] + arrayOfThreeNums[1]) return isTriangle;
    return isTriangle;
}

int [] arrayForTriangle = CreateThreeCount(3, 7);
PrintArray(arrayForTriangle);
IsCheckTheTriangle (arrayForTriangle);


