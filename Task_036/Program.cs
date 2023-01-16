// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int start, int end)
{
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(start, end + 1);
    }
    return randomArray;
}
int[] array = CreateRandomArray(10, -10, 10);
Console.WriteLine($" [ {String.Join(", ", array)} ]");

int sum = 0;
for (int i = 1; i < array.Length; i++)
{
    if (i % 2 != 0) sum += array[i];
}

Console.WriteLine($"Сумма элементов заданного массива, стоящих на нечетных позициях равна {sum}");