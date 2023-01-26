// Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
 int n = int.Parse(Console.ReadLine() ?? "0");

int mod = 0;
int count = 0;
while(n > 0)
{
    mod = mod + n%10;
    n = n/10;
    count +=1;
}
Console. WriteLine(count);



