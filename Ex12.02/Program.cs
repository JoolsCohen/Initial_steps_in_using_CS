// Вид 3 - методы, которые ничего не принимают, что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();

Console.WriteLine(year);