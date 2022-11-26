//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random numbers = new Random();

for (int i = 0; i < n; i++)
{
    array[i] = numbers.Next(1, 20);
    Console.Write($"{array[i]} ");
}
int min = array[0];
int max = array[0];
foreach (int i in array)
{
    if (min > i)
    {
        min = i;
    }
    if (max < i)
    {
        max = i;
    }
}
int difference = (max - min);
Console.Write($"где max = {max}, min = {min},");
Console.Write($"-> {difference}");

