// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Write("Введите минимальное значение из диапазона значений массива: "); 
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальное значение из диапазона значений массива: "); 
int b = int.Parse(Console.ReadLine() ?? "0");
int n = 123;
int [] array = new int[n];
int count = 0;

void FillMas (int[]array)
{
   for (int i = 0; i < n; i++)
    {
        int value = new Random().Next(a,b + 1);
        array[i] =value;
    }
}
void PrintMas(int [] array)
{
    foreach(int item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
FillMas(array);
PrintMas(array);

foreach (int item in array)
{
    if(item >=10 && item<=99)
    {
        count++;
    }
}
Console.WriteLine($"Количество значений массива, находящихся в диапазоне от 10 до 99 включительно равно {count}");