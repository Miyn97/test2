namespace TextRPG
{
    public class Statepage
    {
        public static void ShowState() 
        {
            int level = 01;
            int atk = 10;
            int def = 5;
            int hp = 100;
            int gold = 1500;

            Console.WriteLine("[상태 보기]");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine($"Lv. {level}");
                Console.WriteLine("Chad ( 전사 )");
                Console.WriteLine($"공격력 : {atk}");
                Console.WriteLine($"방어력 : {def}");
                Console.WriteLine($"체력 : {hp}");
                Console.WriteLine($"Gold : {gold}G");
                Console.WriteLine("");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("");
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                string input = Console.ReadLine();
                if (input == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.ReadLine();
                }
            }  
        }
    }
}
