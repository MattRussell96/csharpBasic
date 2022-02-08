string instructorName = "Brad";
string[] instructors = new string[] { "Michael", "Joshua", instructorName};
foreach (string name in instructors)
{
    Console.WriteLine(name);
}

int[] numbers = new int[] {1, 5, 10, -4, 12, 0 };
foreach (int number in numbers)
{
    string sign = number > 0 ? "positive" : number == 0 ? "neutral" : "negative";
    Console.WriteLine($"{number} is a {sign} number.");
}