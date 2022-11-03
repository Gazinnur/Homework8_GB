// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
num = Math.Abs(num);
//int amount = num.ToString().Length;
//if (amount < 3)
if (num < 100)
{
    Console.WriteLine("нет третьей цифры");
}
else
{ while(num>999) {num=num/10;}
    // int c = 1;
    // for (int i = amount; i > 3; i--)
    //{ c = c * 10; }
    int thirdnum = num % 10;
    Console.WriteLine(thirdnum);
}
