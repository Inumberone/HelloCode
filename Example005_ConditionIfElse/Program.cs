Console.Write("Enter name:");
string username = Console.ReadLine();

if(username.ToLower() == "ivan")
{
    Console.WriteLine("Ура, это же Ivan!");
}
else
{
    Console.WriteLine("Hello, ");
    Console.WriteLine(username);
}