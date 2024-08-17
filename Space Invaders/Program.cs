using Space_Invaders.GameManagers;
class Program
{
    static void Main(string[] args)
    {
        Console.SetWindowSize(80, 20);

        Game game = new Game(5); //Numero de aliens
        game.Start();
    }
}
