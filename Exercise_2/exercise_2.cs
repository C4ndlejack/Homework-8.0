// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;
{
    int[,] GenerateArray(int t, int i)
    {
        int[,] table = new int [t, i];
        Random random = new Random();
        for(int a = 0; a < t; a++)
        {
            for(int b = 0; b < i; b++)
            {
                table[a, b] = random.Next(0, 9);
            }
        }
        return table;
    }
    void PrintArray(int[,] array)
    {
        for(int a = 0; a < array.GetLength(0); a++)
        {
            for(int b = 0; b < array.GetLength(1); b++)
            {
             Console.Write(array[a, b] + " ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine("Введите количество столбцов: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество строк: ");
    int row = Convert.ToInt32(Console.ReadLine());
    int[,] arr = GenerateArray(row, column);
    Console.WriteLine("Исходный массив: ");
    PrintArray(arr);

    int result = 1;
    int temp1 = 0; 
    int temp2 = 0;
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            if(i == 0)
            {
                temp2 += arr[i, j];
                temp1 = temp2;
            }
            else
            {
                temp2 += arr[i, j];
            }
        }
        if(temp1 > temp2)
        {
            result = i + 1;
            temp1 = temp2;
            temp2 = 0;
        }
        temp2 = 0;
    }
    Console.WriteLine("");
    Console.WriteLine("Строка с наименьшей суммой элементов: {0}", result);
    Console.WriteLine("");
}
