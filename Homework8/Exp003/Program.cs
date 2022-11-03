// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру обозначающую день недели");
int num = int.Parse(Console.ReadLine());
if (num > 7)
{
    Console.WriteLine("в неделе только 7 дней");
}
else
{
    if(num<=5) {Console.WriteLine("Это рабочий день");}
    else {Console.WriteLine("Это выходной день");}
}
