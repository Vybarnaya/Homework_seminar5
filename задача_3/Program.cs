// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Введите размер массива size :");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите min число массива");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите max  число массива");
int max = int.Parse(Console.ReadLine());
int [] array = CreateArray(size, min, max);
int i = 0;
int MAX = array [i];
int MIN = array [i];
SearchMinMax(CreateArray(size,min,max));
Console.WriteLine($"[{String.Join (", ", array )}]");
Console.WriteLine($"максимальный элемент массива = {MAX}");
Console.WriteLine($"минимальный элемент массива = {MIN}");
Console.WriteLine($"разница между максимальным и минимальным элементом массива = {MAX - MIN}");


int [] CreateArray(int size, int min, int max)
{
    int [] arr = new int [size];
    for (int i = 0; i<size; i++)
    {
        arr [i] = new Random().Next(min, max+1);
    }
    return arr;         
}

void SearchMinMax(int [] arr)
{
    for ( int i = 0; i<size; i++){
        if (array [i]>MAX){
            MAX = array [i];
        }
        else
            if (array [i]< MIN){
                MIN = array [i];
        }
    }
}

