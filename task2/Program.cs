/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int [] array = GenerateArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GenerateArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i ++)
{
    result[i] = new Random().Next(-10, 10);
}
return result;
}

int[] sumNeg(int[]array)
{
    int[]result = new int[2];
    foreach (int el in array)
    {
        result[0] += el > 0 ? el : 0;
        result[1] += el < 0 ? el : 0;
    }
    return result;
}

int[]r = sumNeg(array);
Console.WriteLine($"NegativeSum = {r[1]}");

