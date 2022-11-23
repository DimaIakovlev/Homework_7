// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Clear();
int[,] myArray = CreateRandomArray(5, 5);
ShowArray(myArray);
Console.Write("Введите позицию элемента: ");
int number = int.Parse(Console.ReadLine());
ReturnNumber(number, myArray);

int[,] CreateRandomArray(int rows, int columns)
{
    int[,] randomArray = new int[rows, columns];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().Next(1, 50);
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

void ReturnNumber(int number, int[,] array)
{
    int counter = 0;
    string text = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            counter++;
            if (counter == number)
            {
                text = $"{array[i, j]}";
            }
        }
    }
    if (text == "") Console.Write("Числа с такой позицией нет");
    else Console.Write(text);
}