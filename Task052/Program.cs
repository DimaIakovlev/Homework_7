// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] myArray = CreateRandomArray(5, 4);
ShowArray(myArray);
ArithmeticMean(myArray);

int[,] CreateRandomArray(int rows, int columns)
{
    int[,] randomArray = new int[rows, columns];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().Next(1, 10);
        }

    }
    return randomArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }

}

void ArithmeticMean(int[,] array)
{
    double[] summa = new double[array.GetLength(1)];
    for (int i = 0, k = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
        }
        summa[k] = sum / array.GetLength(1);
        Console.WriteLine($"Среднее арифметическое столбца {i + 1} равно: {summa[k]:f2}");
        k++;
    }
}
