class GuessValidator
{
    private bool _validGuess;
    private int _userGuess;


    public GuessValidator(string userInput)
    {
        int.TryParse(userInput, out int guess);
        _validGuess = ValidGuess(userInput);

    }
    public bool ValidGuess(string userInput)
    {
        if (int.TryParse(userInput, out int guess))
        {
            _validGuess = true;
        }
        else
        {
            _validGuess = false;
        }
        return _validGuess;
    }
    public int GetUserGuess(string userInput)
    {
        if (ValidGuess(userInput))
        {
            _userGuess = int.Parse(userInput);
        }
        return _userGuess;
    }
}
