double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    int max = 10;
    int min = 0;
    double mi = 10.151;
    double math = Math.Round(mi, 2);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
        }
    }
    return array;
}
void PrintArray(double[,] array)
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
Console.WriteLine("Введите размер m x n массива через пробел:");
int[] ArraySize = Console.ReadLine().Split().Select(int.Parse).ToArray();
PrintArray(CreateArray(ArraySize[0], ArraySize[1]));
