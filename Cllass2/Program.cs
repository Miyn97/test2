namespace Cllass2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player gameLogic = new Player();
            gameLogic.ShowState();
        }

    }

    public class Player 
    {
        string name1 = "루피";
        int hp1 = 100;

        string name2 = "조로";
        int hp2 = 80;

        public void ShowState()
        {
        Console.WriteLine($"{name1}의 체력: {hp1}");
        Console.WriteLine($"{name2}의 체력: {hp2}");
        }
    }
}
