/*0. Вывести квадрат числа 
1. По двум заданным числам проверять является ли первое квадратом второго 
2. Даны два числа. Показать большее и меньшее число 

3. По заданному номеру дня недели вывести его название

 4. Найти максимальное из трех чисел 

5. Написать программу вычисления значения функции y=f(a) 

6. Выяснить является ли число чётным 
7. Показать числа от -N до N 8. Показать четные числа от 1 до N 
9. Показать последнюю цифру трёхзначного числа
10. Показать вторую цифру трёхзначного числа
11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
12. Удалить вторую цифру трёхзначного числа
13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
14. Найти третью цифру числа или сообщить, что её нет*/




//0. Вывести квадрат числа
/*int number = 2;
int squereOfNumber = number * number;
Console.WriteLine(squereOfNumber);*/

//1. По двум заданным числам проверять является ли первое квадратом второго 

/*int number = 67;
int number1 = 7;
int squereOfNumber = (number1 * number1);
if (squereOfNumber==number) Console.WriteLine("Yes");
else Console.WriteLine("No");*/


//2. Даны два числа. Показать большее и меньшее число

/*int number = 135;
int number1 = 97;
if (number>number1) Console.WriteLine(number + " " + "больше, чем число "+ " "+ number1);
else Console.WriteLine(number + " "+"меньше, чем число"+" "+ number1);*/

//3. По заданному номеру дня недели вывести его название

/*string[] daysOfTheWeek = { "Mon", "Tue", "Wen", "Thur", "Fri", "Sat", "Sun" };


Console.WriteLine("Write the number of the week");
string weekday = Console.ReadLine();
double WD = Convert.ToDouble(weekday);
int WOD = Convert.ToInt32 (WD);
Console.WriteLine(daysOfTheWeek[WOD-1]);*/


//4. Найти максимальное из трех чисел 

/*int a = 45;
int b = 87;
int c = 45678;
int max = a;
if (b>max) max = b;
if (c>max) max = c;
Console.WriteLine (max + "-"+ "max number of those numbers");*/

//5. Написать программу вычисления значения функции y=f(a)

/*int x = 3;
int y = 4;
int z = ((x + (y+x))/2);
Console.WriteLine (z);*/




//6. Выяснить является ли число чётным 

/*int [] A = {3,4,5,7,8,765,3324,26,65,64,88};

for (int i =0; i< A.Length; i++)
{
    if (A[i]%2 == 0)
    Console.WriteLine (A[i]);
}
*/

//7. Показать числа от -N до N 

/*int count = -8;
while (count<=8)
{
    Console.WriteLine (count);
    count++;
}*/

//8. Показать четные числа от 1 до N 

/*int[] array = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 45, 3, 2, 4, 6, 7, 8, 4, 3 };
int i = 0;
for (i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        Console.WriteLine(array[i]);
    }
}*/


//9. Показать последнюю цифру трёхзначного числа

/*int a = 253;
int result  = 0;
result = a%10;
Console.WriteLine(result);*/


//10. Показать вторую цифру трёхзначного числа

/*int num = 654;
int SecOfNum = num%100;
Console.WriteLine(SecOfNum/10);*/






