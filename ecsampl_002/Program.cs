// программа принимает на вход три числа и выдает максимальное
Console.WriteLine("Введите первое число");
int namberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int namberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int namberC = int.Parse(Console.ReadLine());
int macs = namberA;
if (namberA < namberB)
{
    macs = namberB;
}
if (namberB < namberC)
{
    macs = namberC;
}

Console.Write("Максимальное из трех чисел");
Console.WriteLine(macs);