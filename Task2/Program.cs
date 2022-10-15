/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] RandomArray()
{
    int[] array = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(-10, 10);

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


int GetSumm(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            summ += array[i];
    }
    return summ;
}
int[] array = RandomArray();
PrintArray(array);
int summ = GetSumm(array);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях:{summ} ");

