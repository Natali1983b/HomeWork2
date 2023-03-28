// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
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
    if(number >= 100) 
    {
        while(number > 999)
        {
            number = number / 10;
        }
        Console.WriteLine(ThirdNumber(number));
    }
    else
    {
        Console.WriteLine("Третьей цыфры нет");
    }
}

int ThirdNumber (int number)
{
    int result = number % 10;
    return result;
}
