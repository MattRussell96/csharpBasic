string first = "The cars we sell are";
string second = "BMW, Lexis, and Mercadies";
string concatenatedResult = first + " " + second;
Console.WriteLine(concatenatedResult);

string firstName = "Jenn";
string lastName = "williams";
string compositeResult = string.Format("Her name is {0} {1}", firstName, lastName);
Console.WriteLine(compositeResult);
Console.WriteLine("Her name is {0} {1}", firstName, lastName);

string interpolationResult = $"Her name is still {firstName} {lastName}!";
Console.WriteLine(interpolationResult);