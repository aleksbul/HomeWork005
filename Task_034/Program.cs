// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateRandomArray(int size, int start, int end)
{
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(start, end + 1);
    }
    return randomArray;
}
int[] array = CreateRandomArray(10, 100, 999);
Console.WriteLine($" [ {String.Join(", ", array)} ]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count++;
}

Console.WriteLine($"Количество четных чисел в заданном массиве равно {count}");