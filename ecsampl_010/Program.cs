// Программа принимает на вход трехзнаное число и на выходе показывает вторую цифру этого числа

int EnterNamber(string message)
{
    Console.Write(message);
   string value = Console.ReadLine();
  int resalt = Convert.ToInt32(value);
    return resalt;
}

int namber = EnterNamber("Введите трехзначное число >");
if (namber < 100 || namber >= 1000)
{
    System.Console.WriteLine("Введено некорректное число");
    return;
}
System.Console.WriteLine($"Введенное число'{namber}'");
int secondNamber = namber / 10 % 10;
System.Console.WriteLine($"Вторая цифра введеного числа'{secondNamber}'");