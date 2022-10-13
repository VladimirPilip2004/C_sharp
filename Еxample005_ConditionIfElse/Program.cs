Console.Write ("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Катя")
{
    Console.WriteLine("Ура, это же КАТЯ!");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username);
}