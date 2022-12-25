// Программа принимает n, и выдает таблицу кубов чисел от 1 до n.

Console.Clear();

int GetUserNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void getCube(int number)
{
    for (int i = 1; i < number + 1; i++)
    {    
        int temp = i * i * i;
        if (i < number)
        {Console.Write($"{temp}, ");}
        else
        {Console.Write($"{temp}");}
    }
}

int number = GetUserNumber("Введите число:");
getCube(number);