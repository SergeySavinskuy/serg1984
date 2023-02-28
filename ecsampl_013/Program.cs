// Программа принимает число и показывает третье число или показывает что третьего числа нет

int EnterNamber(string message)
{
    Console.Write(message);
   string value = Console.ReadLine();
  int resalt = Convert.ToInt32(value);
    return resalt;
}
// создание массива
int[]CreateArrai(int size)
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

void FillByNamber(int[] array)
{
int namber=EnterNamber("Ведите число");
int size = array.Length;
int index=0;
while (index<size)
{
    
    array[index]=namber%10;
   index= index+1;
   namber= namber/10;
}

}
int namber=EnterNamber("еше раз повторите введенное число");
double i = Math.Log10(namber);
int size = (int)i+1;
int[] number = CreateArrai(size);
System.Console.WriteLine(Print(number));
 FillByNamber(number);
System.Console.WriteLine(Print(number));