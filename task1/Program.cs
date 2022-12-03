//1. генерируем число из указанного диапазона 
//2. получаем первую цифру этого числа 
//3. получаем вторую цифру этого числа 
//4. присваиваем max первому для определенности сравниваем цифры между собой, выяв
//

int N = new Random().Next(10, 99);
Console.WriteLine(N);
int firstDigit = N / 10;
int secondDigit = N % 10;

if(firstDigit < secondDigit)
{
    Console.WriteLine(secondDigit);
}
else 
{
    Console.WriteLine(firstDigit);
}
if (firstDigit == secondDigit)
{
    Console.WriteLine("Обе цифры равны");
}
//можно добавить обработку случая когда цифры равны