namespace TextRPG
{
    public enum ItemType
    {
        Armor = 1,
        Spear,
        Sword
    }


    internal class Item
    {
        public static ItemType itemType;

        public static void SelectItem() 
        {
            switch (itemType) 
            {
                case ItemType.Armor:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 0:
                    break;
            }
               
        }

        public static void Armor()
        {
            string armor = "무쇠갑옷      ";
            string armorOpt1 = "| 방어력 +5 ";
            string armorOpt2 = "| 무쇠로 만들어져 튼튼한 갑옷입니다.";
            if () 
            {
                Console.WriteLine($"{armor}{armorOpt1}{armorOpt2}");
            }
            else 
            {
                Console.WriteLine($"[E]{armor}{armorOpt1}{armorOpt2}");
            }
              
        }

        public static void Spear()
        {
            string spear = "스파르타의 창 ";
            string spearOpt1 = "| 공격력 +7 ";
            string spearOpt2 = "| 스파르타의 전사들이 사용했다는 전설의 창입니다.";
            Console.WriteLine($"{spear}{spearOpt1}{spearOpt2}");
        }

        public static void Sword()
        {
            string sword = "낡은 검       ";
            string swordOpt1 = "| 공격력 +2 ";
            string swordOpt2 = "| 쉽게 볼 수 있는 낡은 검 입니다.";
            Console.WriteLine($"{sword}{swordOpt1}{swordOpt2}");
        }
    }
