// Вид 1 - не принимают, не возвращают
void Method1()
{
    Console.WriteLine("Author Marina Sudakova");
}
//Method1();

// Вид 2 - принимает, не возвращает
void Method2 (string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст для печати");

void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i += 1;
    }
}
//Method21 (msg: "Текст для печати", count: 3);

// Вид 3 - возвращают, но не принимают
int Method3 ()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);

//Вид 4 - принимает и возвращает + цикл for
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }

    return result;
}

//string res = Method4(10, "Бося");
//Console.Write(res);

// Цикл в цикле пример
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}
