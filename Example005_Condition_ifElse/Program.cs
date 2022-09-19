Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маргарита")
{
    Console.WriteLine("Ура!!! Это же Маргарита!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}