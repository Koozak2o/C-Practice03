
Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();

if (number.Length == 5)
{
    Palindrom(number);
}

else
{
    Console.WriteLine("Ошибка! Перезапустите программу и введите пятизначное число: ");
}

void Palindrom(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Поздравляю! Это палиндром!");
    }
    else
        Console.WriteLine("Это не палиндром!");

}

