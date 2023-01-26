// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число: ");
 int n = int.Parse(Console.ReadLine() ?? "0");

 for (int i = 0; i <= n; i+=2)
 {
  Console.WriteLine(i + " - " + i * i* i);  
 }
