//Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int GetSum(int Value)
{
    int Sum = 0;
    int Numc;
    int ValueTMP = Value;
    while (ValueTMP > 0)
    {
        Numc = ValueTMP % 10;
        Sum = Sum + Numc;
        ValueTMP = ValueTMP / 10;
    }
    return Sum;
}

int Value = GetIncomingData("Введите число");

Console.WriteLine(GetSum(Value));