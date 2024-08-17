namespace Space_Invaders.Creatures;
class Alien
{
    private int position;

    public int Position { get => position; private set => position = value; }

    public Alien(int initialPosition)
    {
        Position = initialPosition;
    }

    public void Move (int direction)
    {
        Position += direction;
    }

    public void Draw(int cursorPosition)
    {
        Console.SetCursorPosition(Position, cursorPosition);
        Console.Write("* *");

        Console.SetCursorPosition(Position, cursorPosition + 1);
        Console.Write(" * ");
    }
}
