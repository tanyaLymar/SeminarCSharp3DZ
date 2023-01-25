//Возведите число А в натуральную степень B используя цикл
Console.Write("Определим случайным образом число A: ");
 int a = new Random().Next(1,10);
 Console.WriteLine(a);

 Console.Write("Определим случайным образом степень: ");
 int n = new Random().Next(1,10);
 Console.WriteLine(n); 

int result = 1;

for (int i = 1; i <= n; i++)
{
 result *= a;
}

Console.WriteLine(result);

