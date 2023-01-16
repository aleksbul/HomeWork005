// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, int start, int end)
{
    double[] randomArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = Math.Round((new Random().NextDouble() * (end - start) + start), 2);
    }
    return randomArray;
}
double[] array = CreateRandomArray(10, -20, 20);
Console.WriteLine($" [ {String.Join("; ", array)} ]");

double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
double result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элеиентом массива равна {result:f2}");