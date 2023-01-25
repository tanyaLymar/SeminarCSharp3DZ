// Найти сумму чисел от 1 до А
Console.Write("Определим случайным образом число A: ");
 int a = new Random().Next(1,10);
 Console.WriteLine(a);
 int result = 0;
 for (int i = 1;i<=a; i++)
    {
    result = result + i;
    }
Console.WriteLine(result);