// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Main();

void Main()
{
    bool Work = true;
    while (Work)
    { 
        System.Console.WriteLine("Решаем задачу? Введите y/n.");
        string a = System.Console.ReadLine();
        switch (a)
        {
            case "y":task1();break;
            case "n": Work = false; break;
        }
    }
}

void task1()
{
    int number = int.Parse(Console.ReadLine());
    if(number >= 100 && number <= 999) 
    {
        Console.WriteLine(SecondNumber(number));
    }
    else
    {
        Console.WriteLine("Ошибка, введите трехзначное число");
    }
}

int SecondNumber (int number)
{
    int FirstNumb = number / 10;
    int result = FirstNumb % 10;
    return result;
}