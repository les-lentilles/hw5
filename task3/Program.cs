/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();

double[] array = new double[8];
GetRandomArray(array);
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
Console.WriteLine($"max = {max:f1}, min = {min:f1}");
Console.WriteLine($"Разница между максимальным и минимальным значением массива = {max - min:f1}");

void GetRandomArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(10,100)) / 8;
        }
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]:f1} ");
        }
    Console.WriteLine();
}


