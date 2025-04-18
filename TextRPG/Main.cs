namespace TextRPG
{
    public class Mainpage
    {
        static void Main(string[] args)
        {
            MainLoop();
        }

        public static void MainLoop() 
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine("\n1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("\n0. 게임 종료");
                Console.WriteLine("\n원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                string input = Console.ReadLine();
                int selectMenu;

                if (int.TryParse(input, out selectMenu))
                {
                    Console.Clear();

                    switch (selectMenu)
                    {
                        case 1:
                            TextRPG.Statepage.ShowState();
                            break;
                        case 2:
                            TextRPG.InventoryPage.Inventory();
                            break;
                        case 3:
                            Console.WriteLine("상점으로 이동");
                            break;
                        case 0:
                            Console.WriteLine("게임을 종료합니다.");
                            return;
                        default:
                            Console.WriteLine("잘못된 입력입니다.");
                            Pause();
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("숫자를 입력해주세요.");
                    Pause();
                }
            }
        }

        public static void Pause()
        {
            Console.WriteLine("\n엔터 키를 눌러 계속...");
            Console.ReadLine();
        }
    }
}


