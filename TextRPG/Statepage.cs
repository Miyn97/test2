namespace TextRPG
{
    public class Statepage
    {
        public static void ShowState()
        {
            int level = 1;
            int atk = 10;
            int def = 5;
            int hp = 100;
            int gold = 1500;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("[상태 보기]");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");
                Console.WriteLine($"Lv. {level}");
                Console.WriteLine("Chad ( 전사 )");
                Console.WriteLine($"공격력 : {atk}");
                Console.WriteLine($"방어력 : {def}");
                Console.WriteLine($"체력 : {hp}");
                Console.WriteLine($"Gold : {gold}G");
                Console.WriteLine("\n0. 나가기");
                Console.WriteLine("\n원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                string input = Console.ReadLine();
                if (input == "0")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.ReadLine();
                }
            }
        }
    }
}
