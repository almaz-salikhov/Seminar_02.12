// найти большее 
// разделить большее на меньшее и проверить является ли кратным
// если 

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if(a % b == 0)
    {
        Console.WriteLine("Одно число кратно другому");
    }
    else 
    {
        int result = a % b;
        Console.WriteLine("Не кратно и остаток равен " + result);
    }
}
if (b > a)
{
    if(b % a == 0)
    {
        Console.WriteLine("Одно число кратно другому");
    }
    else 
    {
        int result = b % a;
        Console.WriteLine("Не кратно и остаток равен " + result);
    }
}
