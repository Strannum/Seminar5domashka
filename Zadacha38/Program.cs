﻿Console.Clear();
double[] CreateRandomArray(int N, int start, int end)
{
    double[] RandomArray = new double[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1) + new Random().NextDouble();
        if (RandomArray[i] > end) RandomArray[i] = end;
    }
    return RandomArray;
}

double ArraysMin(double[] array)

{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double ArraysMax(double[] array)

{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double[] array = CreateRandomArray(6, 100, 1000);
Console.WriteLine($"Разница между максимальным и минимальным числами в вашем массиве: {ArraysMax(array)}-{ArraysMin(array)} = {ArraysMax(array) - ArraysMin(array)} ");

Console.Write($"Ваш массив:{String.Join("| ", array)} ");