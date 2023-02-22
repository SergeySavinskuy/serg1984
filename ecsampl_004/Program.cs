// Программа принимает число N и показывает все четные числа от 1 до N
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int a=1;
while (a<=N)
{
if (a%2==0)
{
    Console.WriteLine(a);
}
a++;
}