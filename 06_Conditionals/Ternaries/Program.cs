Console.Write("Enter your age:");
string response = System.Console.ReadLine();
int age = int.Parse(response);

string output = age >= 18 ? "You can vote!" : "You are too young to vote";

Console.WriteLine(output);

if(age >= 18)
{
    output = "You can Vote!";
}
else
{
    output = "Your too young to vote.";
}
Console.WriteLine(output);