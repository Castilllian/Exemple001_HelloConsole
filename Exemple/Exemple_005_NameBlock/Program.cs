Console.Write("Print your name, please: ");
string username = Console.ReadLine();

if(username.ToLower() == "Maria")
{
    Console.WriteLine("Yahho, Maria");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}