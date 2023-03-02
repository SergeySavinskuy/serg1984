// программа принимает цифру обозначающую день недели и показывает является ли этот день выходным

int EnterNamber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int resalt = Convert.ToInt32(value);
    return resalt;
}
string[]week={"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
int index=EnterNamber("Введите цифру дня недели  ");
int size=week.Length;
if (index>size )
{
    Console.WriteLine("Не является днем недели!!! Попробуйте еще раз ");
    
}
if(index>size-2 )
{
 Console.WriteLine($"Ура выходной '{week[index-1]}");
}
else Console.WriteLine($"Придется поработать еще только '{week[index-1]}'");