// Найти сумму элементов от M до N


void sumNumbers(int a, int b)
{

    if (a <= b)
    {
        Console.WriteLine(a);
        sumNumbers(a + 1, b);
    }
}

int sumOfNum (int a, int b)
{
    if (a<=b) return a+sumOfNum(a+1,b);
    return 0;

}
int M = 10;
int N = 27;
sumNumbers(M, N);
int result = sumOfNum(M,N);
Console.WriteLine(result);
