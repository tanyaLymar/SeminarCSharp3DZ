// Определить, присутствует ли в заданном массиве, некоторое число

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
        Console.Write(item + ", ");
    }
    Console.WriteLine();
}
    
Console.Write("Введите размерность массива: ");    
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число из диапазона значений массива(от 0 до 9): ");
int number = int.Parse(Console.ReadLine() ?? "0");
int [] array = new int[n];
int count = 0;

FillMas(array);
PrintMas(array);

    while(number < 0 || number >= 10) 
    {   
        Console.WriteLine("Выбранное число выходит за диапазон значений массива, попробуйте еще раз");
        Console.Write("Введите число из диапазона значений массива(от 0 до 9): ");
        number = int.Parse(Console.ReadLine() ?? "0");
    }

foreach( int value in array)
{
    if(value == number) 
        {
            count += 1;
        }
    
}

if(count == 2||count == 3||count == 4) Console.WriteLine($"Значение {number} встречается в массиве {count} разa.");
else if(count == 0) Console.WriteLine($"Значение {number} не встречается в массиве.");
else Console.WriteLine($"Значение {number} встречается в массиве {count} раз.");