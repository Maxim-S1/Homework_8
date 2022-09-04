// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] GetMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int number = 1;
            matrix[i, j] = number;
            while(number <= i *j)
            {    
                number++;
                if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
                    {
                        j++;
                    }
                else 
                    if (i < j && i + j >= matrix.GetLength(0) - 1)
                    {
                        i++;
                    }
                else 
                    if (i >= j && i + j > matrix.GetLength(1) - 1)
                    {
                        j--;
                    }
                else
                    {
                        i--;
                    }
            }        
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

int[,] ourMatrix = GetMatrix(4, 4);
PrintMatrix(ourMatrix);