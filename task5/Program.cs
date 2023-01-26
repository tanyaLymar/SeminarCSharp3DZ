// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число: ");
 int n = int.Parse(Console.ReadLine() ?? "0");
 int factorial = 1;

 for (int i = 1; i <=n; i++)
 {
    factorial = factorial * i;
 }
Console.WriteLine(factorial);