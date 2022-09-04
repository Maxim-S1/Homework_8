// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

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

int IncreasingItemsInRow(int[,] matrix)
{
    int [] sum = new int[matrix.GetLength(1)];
    int Sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum = Sum + matrix[i, j];
            sum[i] = Sum;
            
            
        }
        int min = sum[i];
            if(min > sum[i + 1])
            {
                min = sum[i + 1] ;
            }
        Console.Write(i + 1);
        Console.WriteLine(Sum + " ");
        Sum = 0;        
    }

    // for (int i = 0; i < arr.Length; i++)
    // {
    //     int min = arr[i];
    //     if (arr[i] > arr[i + 1])
    //     {
    //         arr[i + 1] =  min;
    //         Console.WriteLine($"Строка {i} имеет наименьшую сумму элементов {arr[i]}");
    //     }
    // }
    return Sum;
}



int[,] ourMatrix = GetMatrix(3, 4, 0, 9);
PrintMatrix(ourMatrix);
Console.WriteLine();
IncreasingItemsInRow(ourMatrix);
