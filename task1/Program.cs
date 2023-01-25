//Найти кубы чисел от 1 до N
Console.Write("Определим случайным образом число N: ");
 int n = new Random().Next(1,10);
 Console.WriteLine(n);
 for (int i = 1;i<=n; i++)
    {
    Console.WriteLine(i + " - " + i * i* i);
    }

