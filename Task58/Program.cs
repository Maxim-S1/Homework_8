// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetTMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] tmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < tmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tmatrix.GetLength(1); j++)
        {
            tmatrix[i, j] = matrix[i, j] * matrix2[i, j];
        }
    }
    return tmatrix;
}
int[,] ourMatrix = GetMatrix(3, 4, 0, 9);
PrintMatrix(ourMatrix);
Console.WriteLine();
int[,] ourMatrix2 = GetMatrix(3, 4, 0, 9);
PrintMatrix(ourMatrix2);
Console.WriteLine();
int[,] newMatrix = GetTMatrix(ourMatrix, ourMatrix2);
PrintMatrix(newMatrix);