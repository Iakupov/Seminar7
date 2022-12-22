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
Console.WriteLine("Введите адрес элемента  массива (m, n) массива через пробел:");
int[] ArrayIndex = Console.ReadLine().Split().Select(int.Parse).ToArray();
double[,] array = CreateArray(4, 4);
if (ArrayIndex[0] > array.GetLength(0) || ArrayIndex[1] > array.GetLength(0)
 || ArrayIndex[0] <= 0 || ArrayIndex[1] <= 0)
    Console.WriteLine("Элемента с таким индексом не существует");
else Console.WriteLine(array[ArrayIndex[0] - 1, ArrayIndex[1] - 1]);
