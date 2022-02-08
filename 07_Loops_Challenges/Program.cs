// Bronze
int bronze = 525;
for(int i = 500; i <= bronze; i++){
Console.WriteLine(i);
}

// Silver
int silver = 100;
for(int i = 0; i <= silver; i++){
    Console.WriteLine(i);
    i = i + 4;

}

// Gold
for(int i = 0; i <= 100; i++){
    if(i % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if(i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if(i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}