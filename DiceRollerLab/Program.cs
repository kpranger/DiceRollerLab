//methods will have 2 paramaters
//first method will be for dice combinations (snake eyes, ace deuce, box cars)
//second method will be for totals (win, craps)

bool runProgram = true;
int numOfSides;
int r1;
int r2;

Console.WriteLine("Welcome to the Grand Circus Casino!");
while (true)
{
    Console.WriteLine("How many sides should each die have?");
    if (int.TryParse(Console.ReadLine(), out numOfSides))
    {
        break;
    }
    else
    {
        Console.WriteLine("Please enter a valid whole number");
        continue;
    }
}

while (runProgram)
{
    int totalRoll;

    r1 = new Random().Next(1, numOfSides);
    r2 = new Random().Next(1, numOfSides);
    totalRoll = r1 + r2;
    Console.WriteLine($"You rolled a {r1} and a {r2} ({totalRoll})");
    
    //Exit Strategy
    while (true)
    {
        Console.WriteLine($"\nRoll again? y/n");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y")
        {
            break;
        }
        else if (choice == "n")
        {
            Console.WriteLine("Thanks for playing!");
            runProgram = false;
            break;
        }
    }
}

//Methods
static string diceCombo(int r1, int r2)
{
    string message;

    if (r1 == 1 && r2 == 1)
    {
        message = "Snake Eyes";
    }
    else if (r1 == 1 && r2 == 2 || r1 == 2 && r2 == 1)
    {
        message = "Ace Deuce";
    }
    else if (r1 == 6 && r2 == 6)
    {
        message = "Box Cars";
    }
    else if (r1 + r2 == 12 && r1 == 6)
    {
        message = $"Box Cars\nCraps";
    }
    else
    {
        message = "";
    }
    return message;
}

static string diceTotal(int r1, int r2)
{
    string message1;

    if (r1 + r2 == 7 || r1 + r2 == 11)
    {
        message1 = "Win";
    }
    else if (r1 + r1 == 2 || r1 + r2 == 3 || r1 + r2 == 12)
    {
        message1 = "Craps";
    }
    else
    {
        message1 = "";
    }
    return message1;
}
