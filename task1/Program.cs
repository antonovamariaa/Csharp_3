System.Console.Write("input number: ");
string str = Console.ReadLine();

if (str.Length == 5)
{
    if (str[0] == str[4] && str[1] == str[3]) { System.Console.WriteLine("yes"); }
    else { System.Console.WriteLine("no"); }
}
else { System.Console.WriteLine("error"); }
