/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int [] FillArray(int length)
{
    int [] array = new int [length];
    Random rnd = new Random();
    for(int i = 0; i < length; i++)
        array[i] = rnd.Next(100, 1000);
    return array;
}
void PrintArray(int [] arr)
{
    foreach(int item in arr)
        Console.Write($"{item} ");
}
int CountOfEven(int [] col)
{
    int count = 0;
    for(int i = 0; i < col.Length; i++)
        if(col[i] % 2 == 0) count++;
    return count;
}



Console.WriteLine("Ведите размерность массива: ");
int len = int.Parse(Console.ReadLine());
int [] array = FillArray(len);
int count = CountOfEven(array);

Console.WriteLine("Полученный массив: ");
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Количество четных чисел в массиве равно {count}");
