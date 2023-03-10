//Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Math.Pow использовать нельзя
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Getincomingdata(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckPower(int Power)
{
    if (Power > 0)
    {
        return true;
    }
    else
    {
        return false;
    }

}

int GetPowValue(int Value, int Power)
{
    int Sum = 1;
    for (int i = 0; i < Power; i++)
    {
        Sum = Sum * Value;
    }
    return Sum;
}

int Value = Getincomingdata("Введите число");
int Power = Getincomingdata("Введите степень");
if (CheckPower(Power) == true)
{
Console.WriteLine(GetPowValue(Value,Power));
}
else
{
    Console.WriteLine("Степень может быть только положительной");
}