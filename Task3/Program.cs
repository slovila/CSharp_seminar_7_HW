/*Задача 3. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
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

void PrintArray2D(int[,] array)
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

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
}

double[] ArithmeticMean(int[,] array)
{
    double[] result = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(0); j++)
    {
        double averageSum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            averageSum = averageSum + array[i, j];
        }
        result[j] = averageSum / array.GetLength(1);
    }
 return result;
}


int[,] array = GenerateArray(5, 5, 0, 5);
PrintArray2D(array);
System.Console.WriteLine("Среднее арифметическое по столбцам : ");
PrintArray(ArithmeticMean(array));


