// 1.)
string favoriteColor = "purple";
Console.WriteLine(favoriteColor);

int favoriteNumber = 28;
Console.WriteLine(favoriteNumber);

var date1 = new DateTime(2022, 2, 3, 15, 08, 01);
Console.WriteLine(date1);

char grades = 'A';
Console.WriteLine(grades);

// 2.)
int hatsLeft = 5 - 3;
Console.WriteLine(hatsLeft);

// 3.)
Console.WriteLine("What is your favorite color?");
string yourColor = Console.ReadLine(); 
Console.WriteLine("Funny that your favorite color is " + yourColor + " mine is as well");

// 4.)
Console.WriteLine("Are you wearing clothes yes or no?");
string wearingClothes = Console.ReadLine();
switch(wearingClothes)
{
    case "yes" :
    Console.WriteLine("Thank you for sparing us!");
    break;
    case "no" :
    Console.WriteLine("Do you want us to all go blind!");
    break;
}

// 5.)
Console.WriteLine("Judge my outfit for the day on a scale of 1-5?");
string outfitRating = Console.ReadLine();

switch(outfitRating)
{
    case "1": 
    Console.WriteLine("What did you crawl out of a dumpster!");
    break;
    case "2":
    Console.WriteLine("At least you figured out where the arm holes are!");
    break;
    case "3":
    Console.WriteLine("Looks like mom still helps you get dressed lol!");
    break;
    case "4":
    Console.WriteLine("Now we are getting somewhere but not quite all the way!");
    break;
    case "5":
    Console.WriteLine("Holy wow someone please pick my jaw up off the floor!");
    break;
}

// 6.)
Console.WriteLine("Do you want to grab a bite to eat yes or no?");
string yourAnswer = Console.ReadLine();

switch(yourAnswer)
{
    case "yes":
    Console.WriteLine("Ok then where from (1) for Mcdonald's, (2) for Burger King,(3) for Steak n' Shake,(4) for Wendy's, or (5) for Chick Fil A?");
    break;
    case "no" :
    Console.WriteLine("That is fine with me I am going to grab something anyways!");
    break;
}

string placeToEat = Console.ReadLine();
int newAnswer = int.Parse(placeToEat);

string response = newAnswer switch
{
    1 => "I can deal with McDonald's!",
    2 => "Burger king doesn't sound too bad either I agree!",
    3 => "I am always down for some Steak n' Shake!",
    4 => "Wendy's is not but bad If thats what you want then lets go!",
    5 => "Mmmmmmmm Chick fil A you are literally speaking my loe language!!",
    _ => "Come on be reasonable what are you thinking!",
};

Console.WriteLine(response);

// 7.)
bool happy = true;
bool sad = false;

if(happy)
Console.WriteLine("Good for you it is always the little things!");
else if (sad)
Console.WriteLine("It is going to be ok there will be better days!");

// 8.)
Console.WriteLine("What is your yearly salary? Don't lie We won't judge... Well maybe ted will!");
string salary = Console.ReadLine();
int yourSalary = int.Parse(salary);
{
if(yourSalary >= 1000 && yourSalary <= 10000)
Console.WriteLine("Hey everyone needs a start just keep going.");
else if(yourSalary >=10001 && yourSalary <= 50000)
Console.WriteLine("Not too bad so your about average in the us.");
else if(yourSalary >= 50001 && yourSalary <= 100000)
Console.WriteLine("Well look at that, many people dream of at least being able to touch that much so good for you!");
else
Console.WriteLine("It is ok no need to be embarrased, either you make too much money and I can't compute or nothing at all and you wont tell the truth!");
}