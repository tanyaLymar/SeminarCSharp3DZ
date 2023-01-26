/* Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и 
предпоследний и т.д.*/

void FillMas (int[]array)
{
   for (int i = 0; i < array.Length; i++)
    {
        int value = new Random().Next(0,10);
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
int multiplication = 0;

FillMas(array);
PrintMas(array);

for (int i = 0; i < array.Length/2; i++)
{
    int j = array.Length - 1 - i;
    multiplication = array[i] * array[j];
    Console.WriteLine($"Произведение {i+1} пары равно {multiplication}.");
}