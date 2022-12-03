// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// вопрос: как описать все возможные ситуации с разницей количества знаков, не делая это вручную, вводя каждый кейс до бесконечности? 

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N >= 100)
{
    if(N <= 999)
    {
        int result = N % 10;
        Console.Write("Третья цифра заданного числа: ");
        Console.WriteLine(result);
    }
    else if(N <= 9999)
    {
        int result = N % 100 / 10;
        Console.Write("Третья цифра заданного числа: ");
        Console.WriteLine(result);
    }
    else if(N <= 99999)
    {
        int result = N % 1000 / 100;
        Console.Write("Третья цифра заданного числа: ");
        Console.WriteLine(result);
    }
    else if(N <= 999999)
    {
        int result = N % 10000 / 1000;
        Console.Write("Третья цифра заданного числа: ");
        Console.WriteLine(result);
    }
    else if(N <= 9999999)
    {
        int result = N % 100000 / 10000;
        Console.Write("Третья цифра заданного числа: ");
        Console.WriteLine(result);
    }
    else if(N <= 99999999)
    {
        int result = N % 1000000 / 100000;
        Console.Write("Третья цифра заданного числа: ");
        Console.WriteLine(result);
    }
    else if(N <= 999999999)
    {
        int result = N % 10000000 / 1000000;
        Console.Write("Третья цифра заданного числа: ");
        Console.WriteLine(result);
    }
   
}
else
{
    Console.WriteLine("Третья цифра отсутствует");
}


