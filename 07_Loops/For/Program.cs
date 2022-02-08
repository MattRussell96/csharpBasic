int number = 100;

// for (initializer; condition; iterator) {body}
//1     //2     //3         //4  
for (int i = 0; i < number; i++)
{
    //5
    Console.WriteLine(i);
}
//1 - for keyword
//2 - declaration and initialization of iterator
//3 - boolean expression for the loop
//4 - increment the iterator at the end of the loop
//5 - body, runs per iteration if the condition is true.


Console.WriteLine("I will count up from zero to whatever number you choose what number will you choose?");
string userInput = Console.ReadLine();
int target = int.Parse(userInput);
for (int n = 0; n <= target; n++)
{
    Console.WriteLine(n);
}
