// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Clear();
Console.WriteLine("Введите размер массива size");
int size = int.Parse(Console.ReadLine());
//int [] array = CreateArray(size,min,max);
Console.WriteLine("Введите min число массива");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите max число массива");
int max = int.Parse(Console.ReadLine());
int [] array = CreateArray(size,min,max);
int sum = 0;
SumArr (CreateArray(size, min, max));
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечетных индексах =  {sum}");

int [] CreateArray(int size, int min, int max)
{
    int [] arr = new int [size];
    for (int i = 0; i<size; i++)
    {
         arr [i] = new Random().Next(min, max+1);
    }
    return arr;
}

int SumArr (int [] arr)
{
    for ( int i = 0; i<size; i++)
    {
        if ( i%2==1)
        {
            sum = sum + array [i];
            
        }
     
    }
    return sum;
}
