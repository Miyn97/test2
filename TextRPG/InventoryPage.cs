namespace TextRPG
{
    public class InventoryPage
    {

        public static void Inventory()
        {  

            while (true)
            {

                Console.Clear();
                Console.WriteLine("[인벤토리]");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
                Console.WriteLine("[아이템 목록]");
                TextRPG.Item.Armor();
                TextRPG.Item.Spear();
                TextRPG.Item.Sword();
                Console.WriteLine("\n1. 장착 관리");
                Console.WriteLine("2. 나가기");
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
                            Equipment();
                            break;
                        case 2:
                            //나가기
                            break;
                        default:
                            Console.WriteLine("잘못된 입력입니다.");
                            TextRPG.Mainpage.Pause();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("숫자를 입력해주세요.");
                    TextRPG.Mainpage.Pause();
                }
            }
        }

        public static void Equipment()
        {

            while (true)
            {

                Console.Clear();
                Console.WriteLine("[인벤토리 - 장착 관리]");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine($"- 1 {"");
                Console.WriteLine($"- 2 {"");
                Console.WriteLine($"- 3 {"");
                Console.WriteLine("\n0. 나가기");
                Console.WriteLine("\n원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                string input = Console.ReadLine();
                int selectMenu;

                if (int.TryParse(input, out selectMenu))
                {
                    Console.Clear();

                    switch (selectMenu)
                    {
                        case 0:
                            Console.WriteLine("나가기를 선택하셨습니다.");
                            return;
                        case 1:
                            Console.WriteLine("1번 장비를 선택하셨습니다.");
                            TextRPG.Mainpage.Pause();
                            break;
                        case 2:
                            Console.WriteLine("2번 장비를 선택하셨습니다.");
                            TextRPG.Mainpage.Pause();
                            break;
                        case 3:
                            Console.WriteLine("3번 장비를 선택하셨습니다.");
                            TextRPG.Mainpage.Pause();
                            break;
                        default:
                            Console.WriteLine("잘못된 입력입니다.");
                            TextRPG.Mainpage.Pause();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("숫자를 입력해주세요.");
                    TextRPG.Mainpage.Pause();
                }
            }

        }

        public static void test() 
        {
            
        }
    }
}
