// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

// int[,] ReleaseMatrix(int[, ] matrix1, int[, ] matrix2)
// {
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix1.GetLength(1); j++)
//         {
//              result[i, j] = matrix1[i, j] * matrix2[i, j];              
//         }
//     return result;
//     }
// }

int[,] ReleaseMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
            result[i, j] = matrix1[i, j] * matrix2[i, j];
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матриц: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix1 = new int[coord[0], coord[1]];
Console.WriteLine("Начальная матрица 1: ");
InputMatrix(matrix1);
int[,] matrix2 = new int[coord[0], coord[1]];
Console.WriteLine("Начальная матрица 2: ");
InputMatrix(matrix2);
Console.WriteLine("Результат: ");
PrintMatrix(ReleaseMatrix(matrix1, matrix2));

// ReleaseMatrix(result);
// PrintMatrix(matrix);