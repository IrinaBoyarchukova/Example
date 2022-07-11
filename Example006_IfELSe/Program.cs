// Написать программу, которая будет приветствовать пользователя по разному
Console.WriteLine("Введите имя пользователя");
String username=Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}