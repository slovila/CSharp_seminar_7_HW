﻿/*Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[,] GenerateArray(int rows, int columns)
{
    double[,] answer = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return answer;
}

void PrintArray(double[,] array)
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

int rows = Prompt("Введите количество строк > ");
int columns = Prompt("Введите количество столбцов > ");
double[,] newArray = GenerateArray(rows, columns);
PrintArray(newArray);
