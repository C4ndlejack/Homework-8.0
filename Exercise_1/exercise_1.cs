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

    void BubbleSort(int[] inArray)
    {
        for(int i = 0; i < inArray.Length; i++)
        {
            for(int j = 0; j < inArray.Length-i-1; j++)
            {
                if(inArray[j] > inArray[j+1])
                {
                    int temp = inArray[j];
                    inArray[j] = inArray[j+1];
                    inArray[j+1] = temp;
                }
            }
        }
    }
    void Insert(bool isRow, int dim, int[] sourse, int[,] dest)
    {
        for(int k = 0; k < sourse.Length; k++)
        {
            if(isRow)
            {
                dest[dim, k] = sourse[k];
            }
            else
            {
                dest[k, dim] = sourse[k];
            }
        }
    }
    int colCount = 6;
    int rowCount = 5;
    int[,] arr = GenerateArray(rowCount, colCount);
    Console.WriteLine("Исходный массив");
    PrintArray(arr);

    Console.WriteLine("Сортировка по столбцам: ");
    int[] col = new int [rowCount];
    for(int i = 0; i < colCount; i++)
    {
        for(int j = 0; j < rowCount; j++)
        {
            col[j] = arr[j, i];
        }
        BubbleSort(col);
        Insert(false, i, col, arr);
    }
    PrintArray(arr);
}
