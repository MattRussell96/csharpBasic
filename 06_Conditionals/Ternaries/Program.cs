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




using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine("Hello there, this will be my submission!");

      int myAge = 25;
      string myName = "Matthew";
      double myGrade = 99.9;

      Console.WriteLine("Hello my name is " + myName + " and I am " + myAge + " years old, I know this is graded so let us hope for a " + myGrade + " or higher!");

      Console.Write("Please enter your age so we know that you are an adult before entering this movie! : "); 
      
      string yourResponse = Console.ReadLine();
      int yourAge = int.Parse(yourResponse);
      
      string response = yourAge >= 17 ? "You May Enter Enjoy the movie!" : "You may not enter the movie! Bring someone older or else this is a no go. Sorry about that!";

      Console.WriteLine(response);
      if(yourAge >= 17)
      {
        response = "You May Enter Enjoy the movie!";
      }
      else if(yourAge < 17)
      {
        response = "You may not enter the movie! Bring someone older or else this is a no go. Sorry about that!";   
      }
      else
      {
        response = "HA HA caught you! Trying to sneak in were ya! CALL SECURITY!";
      }
      
  }
}