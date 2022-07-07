#region

// Exercise 1 - Number guessing game

var r = new Random();
    var favNumber = r.Next(1, 1000);
    int userInput = 1001;

    while (userInput != favNumber)
    {
        Console.WriteLine("Guess a number between 1 and 1000: ");
        userInput = int.Parse(Console.ReadLine());

        if (userInput < favNumber)
        {
            Console.WriteLine("too low");
        }
        else if (userInput > favNumber)
        {
            Console.WriteLine("too high");    
        }
        else
    {
        Console.WriteLine($"\n You guessed it! The correct number was: {favNumber}");
    }
}

#endregion

