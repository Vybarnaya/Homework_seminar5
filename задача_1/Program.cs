//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите размер массива size :");
int size = int.Parse(Console.ReadLine());
int [] array = CreatArray(size);
int count =0;
CountNum (array);
Console.WriteLine($"[{String.Join(", ", array)}] ");
Console.WriteLine($"Количество четных чисел в массиве = {count}");

int [] CreatArray (int size)
{
    int [] arr = new int [size];
    for (int i = 0; i<size; i++)
    {
        arr [i] = new Random().Next(100, 999);
    }
    return arr;
}

void  CountNum (int [] arr)
{
    for (int i = 0; i<size;i++)
    {
        if (arr [i] %2 == 0)
        {
            count ++;
        }
    }
}
