/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double[] FillArr(int len)
{
    double[] arr = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.NextDouble() * 99;
    return arr;
}
void PrintArr(double[] arr)
{
    foreach (double item in arr)
        Console.Write($"{item} ");
}
double GetDiffOfMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    double dif = max - min;
    return dif;
}

Console.WriteLine("Введите размерность массива вещественных чисел: ");
int length = int.Parse(Console.ReadLine());
double[] array = FillArr(length);

Console.WriteLine("Полученный массив: ");
PrintArr(array);
Console.WriteLine();

double diff = GetDiffOfMaxMin(array);
Console.WriteLine($"Разность максимального и минимального элементов массива: {diff}");
