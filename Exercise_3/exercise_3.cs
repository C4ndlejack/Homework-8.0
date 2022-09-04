// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System;
{
    Console.WriteLine("Укажите число строк первой матрицы: ");
    int rows1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Укажите число столбцов первой матрицы: ");
    int columns1 = int.Parse(Console.ReadLine());
    int[,] matrix1 = FillArray(rows1, columns1);

    Console.WriteLine("Укажите число строк второй матрицы: ");
    int rows2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Укажите число столбцов второй матрицы: ");
    int columns2 = int.Parse(Console.ReadLine());
    int[,] matrix2 = FillArray(rows2, columns2);

    int[,] matrix3 = ProductMatrix(matrix1, matrix2);

    PrintArray(matrix1);
    Console.WriteLine();
    PrintArray(matrix2);
    Console.WriteLine();
    PrintArray(matrix3);

    int[,] FillArray(int n, int m)
    {
        int[,] res = new int[n, m];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                res[i, j] = new Random().Next(10);
            }
        }
        return res;
    }

    void PrintArray(int[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
    {
        if(matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            System.Console.WriteLine("Матрицы невозможно перемножить в таком порядке!");
            return matrix1;
        }
        int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for(int i = 0; i < matrix1.GetLength(0); i++)
        {
            for(int j = 0; j < matrix2.GetLength(1); j++)
            {
                for(int k = 0; k < matrix1.GetLength(1); k++)
                {
                    matrix3[i, j] += matrix1[i, k] * matrix2[k, j];

                }
            }
        }
        return matrix3;
    }
}