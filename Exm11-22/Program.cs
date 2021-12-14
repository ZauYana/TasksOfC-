/*Почувствуй себя джуном
15. Дано число. Проверить кратно ли оно 7 и 23
16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём
17. По двум заданным числам проверять является ли одно квадратом другого
18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
20. Ввести номер четверти, показать диапазоны для возможных координат
21. Программа проверяет пятизначное число на палиндромом.
22. Найти расстояние между точками в пространстве 2D/3D*/


//15. Дано число. Проверить кратно ли оно 7 и 23


//int a = new Random ().Next (1,10000);
//Console.WriteLine(a);
//int a = 161; /кратно  
//if (a % 7 == 0 && a % 23 == 0) Console.WriteLine("Ok");
//else Console.WriteLine("Fuck");

//16.Дано число обозначающее день недели. Выяснить является номер недели выходным днём

/*string [] DayOfWeek = { "Mon","Tue","Wen","Thur","Fr","Sat","Sun"};


Console.WriteLine("введи номер недели");
string NumOfW = Console.ReadLine();
double NumOfWD = Convert.ToDouble (NumOfW); 
int DOFW = Convert.ToInt32 (NumOfWD);


if (NumOfWD <= 5) Console.WriteLine(DayOfWeek[DOFW- 1] + " " + "Работай, трудяга");
else Console.WriteLine("Гуляй,рванина!"); */


//17. По двум заданным числам проверять является ли одно квадратом другого
/*int a = 36;
int b = 6;
if (b * b == a || a * a == b) Console.WriteLine("Является квадратом числа");
else Console.WriteLine("не является кадратом числа");*/


//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// bool isTrurhofLogic(int x, int y)
// {
//     int c = (x|y);
//     int d = !c;

//     if ((!(x | y)) == (!x ^ !y)) 
//     {
//         return true;
//     }
//     return false;
// }
// Console.WriteLine(isTrurhofLogic(0, 1));

//19. Определите номер четверти плоскости, в которой находится точка с координатами x и y, причем икс и игрек не равны нулю.

// int x = 6;
// int y = -9;
//     if (x != 0 && y != 0)
//     {
//         if (x > 0 && y > 0)
//         {
//             Console.WriteLine("TheFirstPart");

//         }
//         else if (x < 0 && y > 0)
//         {
//             Console.WriteLine("TheSecondPart");

//         }
//         else if (x < 0 && y < 0)
//         {
//             Console.WriteLine("TheThirdPart");
//         }
//         else if (x > 0 && y < 0)
//         {
//             Console.WriteLine("TheFourthPart");
//         }

//     }

//20. Ввести номер четверти , показать диапазоны для возможных координат 



// Console.WriteLine("Write the number of the part");
// int TheNumberOfCoord = Convert.ToInt32(Console.ReadLine());
// if (TheNumberOfCoord < 1 || TheNumberOfCoord > 5)
// {
//     Console.WriteLine("Warning!");
// }




// if (TheNumberOfCoord > 0 && TheNumberOfCoord < 5)

// {
//     if (TheNumberOfCoord == 1)
//     {
//         Console.WriteLine("You can draw from 0 by x and y till 20");
//     }
//     else if (TheNumberOfCoord == 2)
//     {
//         Console.WriteLine("You can draw from 0 by x and y till 20 by y and minus 20 by x");
//     }
//     else if (TheNumberOfCoord == 3)
//     {
//         Console.WriteLine("You can draw from 0 by x and y till -20");
//     }
//     else if (TheNumberOfCoord == 4)
//     {
//         Console.WriteLine("You can draw from 0 by x and y till 20 by x and minus 20 by y");
//     }
// }
// else Console.WriteLine("Warning! Go to school!");


//21. программа проверяет число на палиндром

// Boolean isPal(int x)
// {
//     if (x < 0)
//         return false;
//     int div = 1;
//     while (x / div >= 10)
//     {
//         div *= 10;

//     }
//     while (x!=0)
//     {
//         int l = x/div;
//         int r = x%10;
//         if (l!=r)
//         return false;
//         x = (x%div)/10;
//         div /=100;
//     }
//     return true;
// }
// Console.WriteLine(isPal(65476));


//22. Найти расстояние между точками в 2d/3d

// int FindTheDist(int x1, int y1, int x2, int y2)
// {
//     int DistanceBTW = (Math.Abs(x1 - x2) + Math.Abs(y1 - y2));
//     return DistanceBTW;
// }
// Console.WriteLine(FindTheDist(2,3,7,3));


