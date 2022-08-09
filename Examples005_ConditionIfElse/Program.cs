Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "оля")
{
    Console.WriteLine("Ура, это же Олечка");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}