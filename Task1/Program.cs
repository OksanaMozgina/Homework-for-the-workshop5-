/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] RandomArray()
{
    int[] array = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100, 999);

    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int CheckValues(int[] array)
{

    int counter = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            counter++;

    return counter;

}
int[] array = RandomArray();
PrintArray(array);
int count = CheckValues(array);
Console.WriteLine($"количество чётных чисел в массиве {count}");