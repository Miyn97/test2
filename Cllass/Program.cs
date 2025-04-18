using Microsoft.VisualBasic;

namespace Cllass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.name = "수민";
            player1.hp = 100;

            Player player2 = new Player();
            player2.name = "르탄";
            player2.hp = 80;

            player1.ShowStatus();
            player2.ShowStatus();
        }
    }

    public class Player 
    {
        public string name;
        public int hp;

        public void ShowStatus() 
        {
            Console.WriteLine($"{name}의 체력: {hp}");
        }
    }
    
}
