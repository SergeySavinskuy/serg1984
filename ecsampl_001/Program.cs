// задача 2 программа принимает на вход два числа и выдает какое больше а какое меньше
Console.WriteLine("Введите первое число");
int namberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int namberB = int.Parse(Console.ReadLine());
int min = 0;
int macs = 0;
if (namberA > namberB) 
{
    macs = namberA;
    min=namberB;
}

if (namberB > namberA)
{
    macs = namberB;
    min=namberA;
}

Console.Write("macs = ");
Console.WriteLine(macs);
Console.Write("min =");
Console.WriteLine(min);