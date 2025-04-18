using System;

namespace Newtree
{
    public class Program
    {
        //test
        List<string> ownedItems = new List<string>();

        bool isArmorBought = false;
        bool isIronArmorBought = true;
        bool isSprArmorBought = false;
        bool isSpearBought = true;
        bool isSwordBought = false;
        bool isAxeBought = false;

        bool isEquipArmor = false;
        bool isEquipIronArmor = true;
        bool isEquipSprArmor = false;
        bool isEquipSword = false;
        bool isEquipSpear = true;
        bool isEquipAxe = false;

        string armor = "수련자 갑옷     | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             ";
        string ironArmor = "무쇠갑옷        | 방어력 +5  | 무쇠로 만들어져 튼튼한 갑옷입니다.        ";
        string sprArmor = "스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.        ";
        string spear = "스파르타의 창   | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다.        ";
        string sword = "낡은 검         | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.        ";
        string axe = "청동 도끼       | 공격력 +5  | 어디선가 사용됐던거 같은 도끼입니다.        ";

        string equip = "-[E]";
        int itemNum = 1;
        int gold = 1500; //보유한 골드
        int armorPrice = 1000;
        int ironArmorPrice = 2000;
        int sprArmorPrice = 3500;
        int spearPrice = 2000;
        int swordPrice = 600;
        int axePrice = 1500;

        //isArmorBought == isUnEquipArmor
        static void Main(string[] args)
        {
            Program mainPage = new Program(); 
            mainPage.StartGame(); 
        }

        private bool _isGameOver = false;

        public void StartGame() 
        {

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("\n0. 게임 종료");
                Console.WriteLine("\n원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                string input = Console.ReadLine();
                //int selectMenu; //문자열을 Int로 바꾸기 위해 변수 선언.

                if (int.TryParse(input, out int selectMenu)) 
                {

                    switch (selectMenu) 
                    {
                        case 1: 
                            Status();
                            break;
                        case 2:
                            Inventory();
                            break;
                        case 3:
                            Shop();
                            break;
                        case 0:
                            while (!_isGameOver)
                            {
                                Console.Clear();
                                Console.WriteLine("정말 게임을 종료하시겠습니까?");
                                Console.WriteLine("ESC 키를 입력 시 종료됩니다.");
                                InputHandler();
                            }
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("잘못된 입력입니다.");
                            Pause();
                            break;
                    }
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("숫자를 입력하세요.");
                    Pause();
                }
            }
        }
        private void InputHandler()
        {
            var input = Console.ReadKey();

            if (input.Key == ConsoleKey.Escape)
            {
                _isGameOver = true;
            }
        }
        public void Pause() 
        {
            Console.WriteLine("\n엔터 키를 눌러 계속...");
            Console.Write(">> ");
            Console.ReadLine();
        }

        public void Status()
        {
            string chad = "( 전사 )";
            int level = 1;
            int atk = 10;
            int def = 5;
            int bonusAtk = 0;
            int bonusDef = 0;
            int hp = 100;

            int armorPoint = 5;
            int ironArmorPoint = 9;
            int sprArmorPoint = 15;
            int swordPoint = 2;
            int axePoint = 5;
            int spearPoint = 7;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("[상태 보기]");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");
                Console.WriteLine($"Lv. {level}");
                Console.WriteLine($"Chad {chad}");

                if (isEquipSword) bonusAtk += swordPoint;
                if (isEquipSpear) bonusAtk += spearPoint;
                if (isEquipAxe) bonusAtk += axePoint;

                if (isEquipArmor) bonusDef += armorPoint;
                if (isEquipIronArmor) bonusDef += ironArmorPoint;
                if (isEquipSprArmor) bonusDef += sprArmorPoint;

                Console.WriteLine($"공격력 : {atk} {(bonusAtk > 0 ? $"(+{bonusAtk})" : "")}");
                Console.WriteLine($"방어력 : {def} {(bonusDef > 0 ? $"(+{bonusDef})" : "")}");

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

        public void Inventory()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("[인벤토리]");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
                Console.WriteLine("[아이템 목록]");

                bool hasItem = false;

                ownedItems.Clear();
                itemNum = 1;
                if (isSwordBought)
                {
                    hasItem = true;
                    Console.WriteLine($"{(isEquipSword ? equip : "")}{sword}");
                    ownedItems.Add("sword");
                }
                if (isSpearBought)
                {
                    hasItem = true;
                    Console.WriteLine($"{(isEquipSpear ? equip : "")}{spear}");
                    ownedItems.Add("spear");
                }
                if (isAxeBought)
                {
                    hasItem = true;
                    Console.WriteLine($"{(isEquipAxe ? equip : "")}{axe}");
                    ownedItems.Add("zxe");
                }
                if (isArmorBought)
                {
                    hasItem = true;
                    Console.WriteLine($"{(isEquipArmor ? equip : "")}{armor}");
                    ownedItems.Add("armor");
                }
                if (isIronArmorBought)
                {
                    hasItem = true;
                    Console.WriteLine($"{(isEquipIronArmor ? equip : "")}{ironArmor}");
                    ownedItems.Add("ironArmor");
                }
                if (isSprArmorBought)
                {
                    hasItem = true;
                    Console.WriteLine($"{(isEquipSprArmor ? equip : "")}{sprArmor}");
                    ownedItems.Add("sprArmor");
                }
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
                            return;
                        default:
                            Console.WriteLine("잘못된 입력입니다.");
                            Pause();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("숫자를 입력해주세요.");
                    Pause();
                }
            }
        }
        public void Equipment()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[인벤토리 - 장착 관리]");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
                Console.WriteLine("[아이템 목록]");
                itemNum = 1;
                if (isSwordBought)
                {
                    string display = isEquipSword ? equip + sword : sword;
                    Console.WriteLine($"{itemNum++}. {display}");
                }
                if (isSpearBought)
                {
                    string display = isEquipSpear ? equip + spear : spear;
                    Console.WriteLine($"{itemNum++}. {display}");
                }
                if (isAxeBought)
                {
                    string display = isEquipAxe ? equip + axe : axe;
                    Console.WriteLine($"{itemNum++}. {display}");
                }
                if (isArmorBought)
                {
                    string display = isEquipArmor ? equip + armor : armor;
                    Console.WriteLine($"{itemNum++}. {display}");
                }
                if (isIronArmorBought)
                {
                    string display = isEquipIronArmor ? equip + ironArmor : ironArmor;
                    Console.WriteLine($"{itemNum++}. {display}");
                }
                if (isSprArmorBought)
                {
                    string display = isEquipSprArmor ? equip + sprArmor : sprArmor;
                    Console.WriteLine($"{itemNum++}. {display}");
                }
                Console.WriteLine("\n0. 나가기");
                Console.WriteLine("\n원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                string input = Console.ReadLine();
                int selectMenu;

                if (int.TryParse(input, out selectMenu))
                {
                    Console.Clear();

                    int selectIndex = selectMenu - 1;

                    if (selectIndex >= 0 && selectIndex < ownedItems.Count)
                    {
                        string item = ownedItems[selectIndex];

                        switch (item)
                        {
                            case "sword":
                                isEquipSword = !isEquipSword;
                                Console.WriteLine(isEquipSword ? "낡은 검을 장착 완료했습니다." : "낡은 검을 장착 해제했습니다.");
                                break;

                            case "spear":
                                isEquipSpear = !isEquipSpear;
                                Console.WriteLine(isEquipSpear ? "스파르타의 창을 장착 완료했습니다." : "스파르타의 창을 장착 해제했습니다.");
                                break;

                            case "axe":
                                isEquipAxe = !isEquipAxe;
                                Console.WriteLine(isEquipAxe ? "청동 도끼를 장착 완료했습니다." : "청동 도끼를 장착 해제했습니다.");
                                break;

                            case "armor":
                                isEquipArmor = !isEquipArmor;
                                Console.WriteLine(isEquipArmor ? "수련자 갑옷을 장착 완료했습니다." : "수련자 갑옷을 장착 해제했습니다.");
                                break;

                            case "ironArmor":
                                isEquipIronArmor = !isEquipIronArmor;
                                Console.WriteLine(isEquipIronArmor ? "무쇠 갑옷을 장착 완료했습니다." : "무쇠 갑옷을 장착 해제했습니다.");
                                break;

                            case "sprArmor":
                                isEquipSprArmor = !isEquipSprArmor;
                                Console.WriteLine(isEquipSprArmor ? "스파르타의 갑옷을 장착 완료했습니다." : "스파르타의 갑옷을 장착 해제했습니다.");
                                break;
                            default:
                                Console.WriteLine("잘못된 입력입니다.");
                                Pause();
                                break;

                        }

                        Console.ReadLine();
                    }
                    else if (selectMenu == 0)
                    {
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("숫자를 입력해주세요.");
                        Pause();
                    }
                }
            }
        }
        public void Shop() 
        {
            

            while (true) 
            {
                Console.Clear();

                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine($"{gold} G\n");
                Console.WriteLine("[아이템 목록]");
                string result = (isArmorBought) ? "              |  구매완료" : "              |  1000 G";
                Console.WriteLine($"- {armor + result}");
                string result2 = (isIronArmorBought) ? "               |  구매완료" : "               |  2000 G";
                Console.WriteLine($"- {ironArmor + result2}");
                string result3 = (isSprArmorBought) ? "|  구매완료" : "|  3500 G";
                Console.WriteLine($"- {sprArmor + result3}");
                string result4 = (isSwordBought) ? "                 |  구매완료" : "                  |  600 G";
                Console.WriteLine($"- {sword + result4}");
                string result5 = (isAxeBought) ? "             |  구매완료" : "             |  1500 G";
                Console.WriteLine($"- {axe + result5}");
                string result6 = (isSpearBought) ? "  |  구매완료" : "  |  2000 G";
                Console.WriteLine($"- {spear + result6}\n");
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기\n");
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int selectMenu))
                {

                    switch (selectMenu)
                    {
                        case 1:
                            ItemShop();
                            break;
                        case 0:
                            //나가기
                            return;
                        default:
                            Console.WriteLine("잘못된 입력입니다.");
                            Pause();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("숫자를 입력하세요.");
                    Pause();
                }
            }
        }

        public void ItemShop() 
        {

            while (true)
            {
                Console.Clear();

                Console.WriteLine("상점 - 아이템 구매");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine($"{gold} G\n");
                Console.WriteLine("[아이템 목록]");
                string result = (isArmorBought) ? "              |  구매완료" : "              |  1000 G";
                Console.WriteLine($"- 1 {armor + result}");
                string result2 = (isIronArmorBought) ? "               |  구매완료" : "               |  2000 G";
                Console.WriteLine($"- 2 {ironArmor + result2}");
                string result3 = (isSprArmorBought) ? "|  구매완료" : "|  3500 G";
                Console.WriteLine($"- 3 {sprArmor + result3}");
                string result4 = (isSwordBought) ? "                 |  구매완료" : "                  |  600 G";
                Console.WriteLine($"- 4 {sword + result4}");
                string result5 = (isAxeBought) ? "             |  구매완료" : "             |  1500 G";
                Console.WriteLine($"- 5 {axe + result5}");
                string result6 = (isSpearBought) ? "  |  구매완료" : "  |  2000 G";
                Console.WriteLine($"- 6 {spear + result6}\n");
                Console.WriteLine("0. 나가기\n");
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int selectMenu))
                {
                    switch (selectMenu)
                    {
                        case 1:
                            if (isArmorBought)
                            {
                                Console.Clear();
                                Console.WriteLine("이미 구매한 아이템입니다.");
                                Console.ReadLine();
                            }
                            else if (gold >= armorPrice)
                            {
                                gold -= armorPrice;
                                isArmorBought = true;
                                Console.Clear();
                                Console.WriteLine("구매를 완료했습니다.");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Gold가 부족합니다.");
                                Console.ReadLine();
                            }
                            break;

                        case 2:
                            if (isIronArmorBought)
                            {
                                Console.Clear();
                                Console.WriteLine("이미 구매한 아이템입니다.");
                                Console.ReadLine();
                            }
                            else if (gold >= ironArmorPrice)
                            {
                                gold -= ironArmorPrice;
                                isIronArmorBought = true;
                                Console.Clear();
                                Console.WriteLine("구매를 완료했습니다.");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Gold가 부족합니다.");
                                Console.ReadLine();
                            }
                            break;

                        case 3:
                            if (isSprArmorBought)
                            {
                                Console.Clear();
                                Console.WriteLine("이미 구매한 아이템입니다.");
                                Console.ReadLine();
                            }
                            else if (gold >= sprArmorPrice)
                            {
                                gold -= sprArmorPrice;
                                isSprArmorBought = true;
                                Console.Clear();
                                Console.WriteLine("구매를 완료했습니다.");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Gold가 부족합니다.");
                                Console.ReadLine();
                            }
                            break;

                        case 4:
                            if (isSwordBought)
                            {
                                Console.Clear();
                                Console.WriteLine("이미 구매한 아이템입니다.");
                                Console.ReadLine();
                            }
                            else if (gold >= swordPrice)
                            {
                                gold -= swordPrice;
                                isSwordBought = true;
                                Console.Clear();
                                Console.WriteLine("구매를 완료했습니다.");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Gold가 부족합니다.");
                                Console.ReadLine();
                            }
                            break;

                        case 5:
                            if (isAxeBought)
                            {
                                Console.Clear();
                                Console.WriteLine("이미 구매한 아이템입니다.");
                                Console.ReadLine();
                            }
                            else if (gold >= axePrice)
                            {
                                gold -= axePrice;
                                isAxeBought = true;
                                Console.Clear();
                                Console.WriteLine("구매를 완료했습니다.");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Gold가 부족합니다.");
                                Console.ReadLine();
                            }
                            break;

                        case 6:
                            if (isSpearBought)
                            {
                                Console.Clear();
                                Console.WriteLine("이미 구매한 아이템입니다.");
                                Console.ReadLine();
                            }
                            else if (gold >= spearPrice)
                            {
                                gold -= spearPrice;
                                isSpearBought = true;
                                Console.Clear();
                                Console.WriteLine("구매를 완료했습니다.");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Gold가 부족합니다.");
                                Console.ReadLine();
                            }
                            break;

                        case 0:
                            return;

                        default:
                            Console.WriteLine("잘못된 입력입니다.");
                            Pause();
                            break;
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("숫자를 입력하세요.");
                    Pause();
                }
            }
        }
    }
}
