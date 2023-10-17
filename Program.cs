// Принимает на вход число и определяет является ли число чётным
Console.WriteLine("Введите число");
string anamber = Console.ReadLine();
int namber = Convert.ToInt32(anamber);

a = namber % 2;

if (a == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Ошибка, введите другое число");
}