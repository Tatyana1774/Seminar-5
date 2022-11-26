// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19, [-4, -6, 89, 6] -> 0
    int size = 4;
	int[] numbers = new int[size];
	int sum = 0;
		
	FillArrayRandomNumbers(numbers, 0, 20);
	WriteArray(numbers);
	
	for(int i = 0; i < numbers.Length; i++)
	{
	    if(i % 2 == 1)
	        sum += numbers[i];
	    
	}
	
	Console.Write($"Сумма элементов стоящих на нечетной позиции = {sum}");
	
	
	void FillArrayRandomNumbers(int[] array, int min, int max)
	{
	    for(int i = 0; i < array.Length; i++)
	    {
	        array[i] = new Random().Next(0, 20);
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