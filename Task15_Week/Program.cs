// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
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
    if(number >= 1 && number <= 7) 
    {
        if(number == 1)
        {
            Console.WriteLine("Понедельник, будни");
        }
        else if(number == 2)
        {
            Console.WriteLine("Вторник, будни");
        }
        else if(number == 3)
        {
            Console.WriteLine("Среда, будни");
        }
        else if(number == 4)
        {
            Console.WriteLine("Четверг, будни");
        }
        else if(number == 5)
        {
            Console.WriteLine("Пятница, будни");
        }
        else if(number == 6)
        {
            Console.WriteLine("Суббота, выходной день");
        }
        else if(number == 7)
        {
            Console.WriteLine("Воскресенье, выходной день");
        }
        
    }
    else
    {
        Console.WriteLine("Ошибка, введите число от 1 до 7");
    }
}
