// Вид 4 - методы, которые что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");

Console.WriteLine(res);