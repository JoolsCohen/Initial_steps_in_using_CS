// Вид 2 - методы, которые могут принимать какие-либо аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");


// Вид 2.1
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);
//Method21(msg: "Текст", count: 4); //будет тоже самое
//Method21(count: 4, msg: "Текст");   //будет тоже самое