Console.WriteLine("Please give us your name!");
string name = Console.ReadLine();

var greeting = name switch
{
    "Matt" => "Hello Matt",
    _ => "Who are you?"
};
Console.WriteLine(greeting);


switch(name)
{
    case "Matt":
    Console.WriteLine("Nice to meet you " + name);
    break;
    default:
    break;
}


Console.WriteLine("How are you feeling today on a scale of 1-5?");
string feelingRating = Console.ReadLine();

switch(feelingRating)
{
    case "5": 
    Console.WriteLine("That is great to hear!");
    break;
    case "4":
    Console.WriteLine("Good Stuff!");
    break;
    case "3":
    Console.WriteLine("Hope things improve!");
    break;
    case "2":
    Console.WriteLine("Oh no, sorry to hear that!");
    break;
    case "1":
    Console.WriteLine("Dang hope everything gets better!");
    break;
}

Console.WriteLine("How were you feeling yesterday on a scale of 1-5?");
string ratingInput = Console.ReadLine();
int yesterdayRating = int.Parse(ratingInput);

string response = yesterdayRating switch
{
    1 => "Dang maybe today will be better",
    2 => "Oh, sorry to hear that",
    3 => "Nice, sounds like a good day",
    4 => "Good stuff",
    5 => "That is wonderful to hear",
    _ => "Man you are off the charts!"
};

Console.WriteLine(response);


int todayRating = int.Parse(feelingRating);
int ratingDifference = todayRating - yesterdayRating;
string output = ratingDifference switch
{
    4 => "Wow a lot of improvement.",
    3 => "Nice improvement overall i'd say.",
    2 => "A bit of an improvement it seems to me.",
    1 => "It's something right.",
    0 => "Same o'l same o'l.",
    -1 => "I guess it could be worse.",
    -2 => "Oh no.",
    -3 => "I am sorry to hear that.",
    -4 => "I am sorry that are not doing good today.",
    _ => "I cant even comprehend that."
};
Console.WriteLine(output);



Console.WriteLine("Please Give us your friends name and we will tell what we think of them");
string aboutFriends = Console.ReadLine();
string lowercaseFriends = aboutFriends.ToLower();

switch(lowercaseFriends)
{
    case "kaleb":
    Console.WriteLine("Kaleb is a weirdo.");
    break;
    case "jared":
    Console.WriteLine("Jared is too smart for his own good.");
    break;
    case "mike":
    Console.WriteLine("Mike is too use to people doing whatever he says.");
    break;
    case "jeremy":
    Console.WriteLine("Jeremy is the real people pleaser he gets along with everyone.");
    break;
    case "justin":
    Console.WriteLine("Justin is strange but in that good way of strange");
    break;
    case "abby":
    Console.WriteLine("Abby is very wholesome and easygoing");
    break;
    default:
    Console.WriteLine($"I don't think I know That one!");
    break;
}

