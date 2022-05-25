/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] CreateArray(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
        arr[i] = rnd.Next(-99, 100);
    return arr;
}
void PrintArray(int[] arr)
{
    foreach (int pos in arr)
        Console.Write($"{pos} ");
}
int GetSumOfNegativePositions(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
        sum += arr[i];
    return sum;
}

Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int[] array = CreateArray(length);
int summ = GetSumOfNegativePositions(array);

Console.WriteLine("Полученный массив: ");
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Сумма элементов на нечетных позициях массива: {summ}");
