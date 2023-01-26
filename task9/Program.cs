// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void FillMas (int[]array)
{
   for (int i = 0; i < array.Length; i++)
    {
        int value = new Random().Next(100,1000);
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
    
Console.Write("Введите размерность массива: ");    
int n = int.Parse(Console.ReadLine() ?? "0");
int [] array = new int[n];

FillMas(array);
PrintMas(array);

int count1 = 0;
int count2 = 0;

foreach(int item in array)
{
    if(item%2 == 0)
    {
        count1++;
    }
    if(item%2 == 1)
    {
        count2++;
    }
}
Console.WriteLine($"Четные значения встречаются в массиве {count1} раз.");
Console.WriteLine($"Нечетные значения встречаются в массиве {count2} раз.");
