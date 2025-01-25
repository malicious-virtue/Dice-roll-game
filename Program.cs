var dice = new DiceRoll();
Console.WriteLine("Dice rolled. Guess what number it is in 3 tries.");
int tries = 3;

while (tries > 0)
{
    Console.WriteLine($"You have {tries} tries left. Eneter your guess:");
    var userInput = Console.ReadLine();
    if (userInput == null)
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        return;
    }
    ;
    var guessValidator = new GuessValidator(userInput);
    bool isValid = guessValidator.ValidGuess(userInput);
    int userGuess = guessValidator.GetUserGuess(userInput);

    if (!isValid)
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        continue;
    }
    if(userGuess < 1 || userGuess > 6)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
        continue;
    }
    if (userGuess == dice.GetNumber())
    {
        Console.WriteLine("You guessed correctly!");
        return;
    }
    else if (userGuess != dice.GetNumber())
    {
        Console.WriteLine("You guessed incorrectly. Try again.");
    }
    tries--;

}

EndGameText(dice);
Console.ReadKey();

void EndGameText(DiceRoll dice)
{
    Console.WriteLine("Sorry, you are out of tries.");
    Console.WriteLine($"The number was {dice.GetNumber()}.");
    Console.WriteLine("Game Over! Press any key to exit.");
}