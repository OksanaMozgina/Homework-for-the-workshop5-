﻿/*
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + " ");
}

double maxNumber = array[0];
double minNumber = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (maxNumber < array[i])
    {
        maxNumber = array[i];
    }
    if (minNumber > array[i])
    {
        minNumber = array[i];
    }
}

double difference = maxNumber - minNumber;

Console.WriteLine($"разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {difference}");