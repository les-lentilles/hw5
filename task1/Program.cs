/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int GetNumberEven(int[]array)
{ 
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;  
    }
    return count;
    }

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
        {
            Console.Write($"{inArray[i]} ");
        }   
            Console.WriteLine(); 
    }

int[] array = GetRandomArray(7, 100, 1000);
Console.WriteLine($"{String.Join(", ", array)}");
Console.WriteLine($"Количество чётных чисел в массиве = {GetNumberEven(array)}");

