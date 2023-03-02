  
// Программа принимает число и показывает третье число или показывает что третьего числа неint EnterNamber(string message)
int EnterNamber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int resalt = Convert.ToInt32(value);
    return resalt;
}
// создание массива
int[] CreateArrai(int size)
{
    return new int[size];
}

string Print(int[] array)
{
    string result = String.Empty;
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        result = result + " " + array[index];
        index++;
    }
    return result;
}

int namber = EnterNamber("Ведите число  ");
double i = Math.Log10(namber);
int size = (int)i + 1;
int[]arrai=CreateArrai(size);
 for (int index = size-1; index>-1; index--)
 {
    arrai[index]=namber%10;
    namber=namber/10;
 }
System.Console.WriteLine(Print(arrai));
int nom=EnterNamber("Введите какую цифру числа показать ");
  if (arrai.Length>nom)
  {
   // Console.WriteLine(arrai[nom-1]); // вариант если считать слева на право
    Console.WriteLine(arrai[size-nom]);
  }
  else Console.Write(" цифры в числе  нет");