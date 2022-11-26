// : Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
    int size = 4;
    int count = 0;
    int[] numbers = new int[size];
    FillArrayRandomNumbers(numbers, 100, 999);
	WriteArray(numbers);
		
	for(int i = 0; i < numbers.Length; i++)
    {
	    if(numbers[i] % 2 == 0)
	        count++;
	}
    
	Console.WriteLine($"Сумма положительных = {count}");
	
	void FillArrayRandomNumbers(int[] array, int min, int max)
	{
	    for(int i = 0; i < array.Length; i++)
	    {
	        array[i] = new Random().Next(100, 999);
	    }
	}
	
	void WriteArray(int[] array)
	{
	    for(int i = 0; i < array.Length; i++)
	    {
	        Console.Write(array[i] + " ");
	    }
	    Console.Write(" -> ");
	}