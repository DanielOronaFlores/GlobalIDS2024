using Space_Invaders.Creatures;
namespace Space_Invaders.GameManagers;

class Game
{
    private Alien[] aliens;
    private int consoleWidth;
    private int consoleHeigth;
    private int cursorPosition;
    private int movementDirection = 1;

    public Game(int aliensAmount)
    {
        consoleWidth = Console.WindowWidth;
        consoleHeigth = Console.WindowHeight;
        aliens = new Alien[aliensAmount];

        for (int i = 0; i < aliensAmount; i++)
        {
            aliens[i] = new Alien(i * 10); //Numero arbitrario xd
        }

        cursorPosition = 0;
        movementDirection = 1;
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();

            foreach (var alien in aliens)
            {
                alien.Draw(cursorPosition);
            }

            moveAliens();

            if (isConsoleBottom())
            {
                Console.SetCursorPosition(0, consoleHeigth - 1);
                Console.WriteLine("GAME OVER");
                break;
            }

            Thread.Sleep(100);
        }
    }

    private void moveAliens()
    {
        foreach (var alien in aliens)
        {
            alien.Move(movementDirection);
        }

        if (aliens[0].Position <= 0 || aliens[aliens.Length - 1].Position >= consoleWidth - 5)
        {
            movementDirection *= -1;
            cursorPosition++;
        }
    }

    private bool isConsoleBottom()
    {
        return cursorPosition >= consoleHeigth - 2;
    }
}