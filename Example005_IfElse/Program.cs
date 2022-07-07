Console.Write("Pls enter username: ");
string username = Console.ReadLine();

if (username.ToLower() == "sam")
{
    Console.WriteLine("Wow! Sam, its really you?");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
