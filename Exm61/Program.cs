//Найти произведение двух матриц

int[,] CreateMatrix(int rows, int cols)
{

    int[,] matrixWithRandomNum = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrixWithRandomNum[i, j] = new Random().Next(1, rows*cols);
        }
    }
    return matrixWithRandomNum;
}

void PrintMatrix(int[,] matr, string nameOfMatr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"------{nameOfMatr}--------");
}

bool IsMatrixConcerted(int[,] matr1, int[,] matr2)
{
    if (matr1.GetLength(1) == matr2.GetLength(0)) ;
    return true;
}

int[,] MatrixProduct(int[,] matr1, int[,] matr2)
{
    var resultOfBoolIsMatrixConcerted = IsMatrixConcerted(matr1, matr2);
    int[,] productOfMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    if (resultOfBoolIsMatrixConcerted == true)
    {

        
            for (int i = 0; i < matr2.GetLength(1); i++)
            {
                for (int j = 0; j < matr1.GetLength(0); j++)
                {
                    for (int l = 0; l < matr1.GetLength(1); l++)
                    {
                        productOfMatr[i,j] += matr1[i,l] * matr2[l,j];
                        
                    }

                }
                
            }

    }

    return productOfMatr;
}



int[,] matrixOne = CreateMatrix(2, 3);
int[,] matrixTwo = CreateMatrix(3, 3);
PrintMatrix(matrixOne, "Matrix 1");
Console.WriteLine();
PrintMatrix(matrixTwo, "Matrix 2");
IsMatrixConcerted(matrixOne, matrixTwo);
int[,] multiplyOfMatr = MatrixProduct(matrixOne, matrixTwo);
PrintMatrix(multiplyOfMatr, "Matrix Product");
