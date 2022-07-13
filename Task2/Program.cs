/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
// На мой взгляд пример не корректный, так как не соответствует условию задания.

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(min, max + 1);
        }
    }
    return answer;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}
void FindElementByPosition(int[,] array)
{
    int row = Prompt("Введите номер позиции в строке > ");
    int column = Prompt("Введите номер позиции в столбце > ");
    if (row - 1 > array.GetLength(0) - 1 || column - 1 > array.GetLength(1) - 1|| row <= 0 || column <= 0)
    {
        System.Console.WriteLine($"Элемента с заданной позицией [{row}, {column}], в массиве нет! ");
    }
    else
    {
        System.Console.WriteLine($"Позиции [{row}, {column}], соответствует элемент: {array[row - 1, column - 1]} ");
    }
}

int[,] array = GenerateArray(10, 10, -10, 10);
PrintArray(array);
FindElementByPosition(array);
