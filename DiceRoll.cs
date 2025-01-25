
class DiceRoll
{
    public int _number;

    public DiceRoll()
    {
        Random random = new Random();
        _number = random.Next(1, 7);
    }

    public int GetNumber()
    {
        return _number;
    }

}