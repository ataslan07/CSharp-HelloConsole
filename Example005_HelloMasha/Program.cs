Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine ();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Оооо Маш, давно не виделись!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}