int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    int max = 10;
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
double[] AverageColumns(int[,] array)
{
    double[] AverageCol = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        AverageCol[i] = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            AverageCol[i] += array[j, i];
        }
        AverageCol[i] /= array.GetLength(0);
        Console.Write(Math.Round(AverageCol[i], 2) + "; ");
    }
    return AverageCol;
}
Console.WriteLine("Введите размер m x n массива через пробел:");
int[] ArrayIndex = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[,] array = CreateArray(ArrayIndex[0], ArrayIndex[1]);
PrintArray(array);
AverageColumns(array);
