// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
// }

// void PrintArray(int[] array)
// {
//     foreach (var el in array)
//         Console.Write($"{el} ");
//     Console.WriteLine();
// }

// void Chetnoe(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count++;
            
//     }
//     Console.WriteLine(count);
// }


// int[] array = new int[5];
// FillArray(array);
// PrintArray(array);
// Chetnoe(array);


// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 100);
// }

// void PrintArray(int[] array)
// {
//     foreach (var el in array)
//         Console.Write($"{el} ");
//     Console.WriteLine();
// }

// void Sum(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1)
//             sum = sum + array[i];
            
//     }
//     Console.WriteLine(sum);
// }


// int[] array = new int[5];
// FillArray(array);
// PrintArray(array);
// Sum(array);



// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// void FillArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-10, 10);
// }

// void PrintArray(double[] array)
// {
//     foreach (var el in array)
//         Console.Write($"{el} ");
//     Console.WriteLine();
// }


// void Diff(double[] array)
// {
//     double min = 0;
//     double max = 0;
//     double diff = 0;
//     for (int i = 0; i < array.Length; i++)
//         if(array[i] < min)
//             min = array[i];
//     for (int i = 0; i < array.Length; i++)
//         if(array[i] > max)
//             max = array[i];
//     diff = max - min; 
//     Console.WriteLine($"Разница равна {diff}");
// }

// double[] array = new double[7];
// FillArray(array);
// PrintArray(array);
// Diff(array);