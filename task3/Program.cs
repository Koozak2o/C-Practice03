
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Cube_Number(int number)
{
    int index = 1;
    while (index <= number)
    {
        Console.Write($"{index * index * index}, ");
        index++;
    }
    return 0;
}

Cube_Number(number);


