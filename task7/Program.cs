// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillMas (int[]array)
{
   for (int i = 0; i < array.Length; i++)
    {
        int value = new Random().Next(2);
        array[i] =value;
    }
}

void PrintMas(int [] array)
{
    foreach(int item in array)
    {
        Console.Write(item + ", ");
    }
    Console.WriteLine();
}
    
Console.Write("Введите размерность массива: ");    
int n = int.Parse(Console.ReadLine() ?? "0");
int [] array = new int[n];
FillMas(array);
PrintMas(array);
