namespace CSharpDay;

class Program
{
    static void Main(string[] args)
    {
        var gameLogic = new GameLogic();
        gameLogic.StartGame();
    }
}

class GameLogic
{
    private Player _player;
    private bool _isGameOver = false;

    public Dictionary<string, ItemData> inventory = new Dictionary<string, ItemData>();


    public void StartGame()
    {

        // Sword 구입 => Inventory 추가
        ItemData buyItem1 = new ItemData();
        buyItem1.name = "양손검";
        buyItem1.itemType = ItemType.Sword;
        buyItem1.sellPrice = 500;
        buyItem1.count = 1;
        inventory.Add("양손검", buyItem1);

        ItemData buyItem2 = new ItemData();
        buyItem2.name = "도끼";
        buyItem2.itemType = ItemType.Axe;
        buyItem2.sellPrice = 200;
        buyItem2.count = 2;
        inventory.Add("도끼", buyItem2);

        foreach (var item in inventory)
        {
            Console.WriteLine($"아이템 명 :{item.Value.name} , 타입 {item.Value.itemType}");
        }

        return; //저한테 설명하신다고 리턴 걸어놨습니다

        Init();

        while (!_isGameOver)
        {
            InputHandler();
        }

        Console.WriteLine("게임이 종료되었습니다.");
    }

    private void InputHandler()
    {
        var input = Console.ReadKey();

        if (input.Key == ConsoleKey.Escape)
        {
            _isGameOver = true;
        }

        // _isGameOver = (input.Key == ConsoleKey.Escape);
    }

    private void Init()
    {
        Console.Clear();
        Console.WriteLine("스파르타 던전에 오신것을 환영합니다.\n이름을 입력하세요.");
        string? playerName = Console.ReadLine();

        if (_isGameOver) return;

        if (string.IsNullOrEmpty(playerName))
        {
            Console.WriteLine("잘못된 이름입니다.");
            Thread.Sleep(1000);
            Init(); // 실제로 이렇 사용하시면 않됨, 재귀호출
        }
        else
        {
            _player = new Player(playerName);
            Console.WriteLine($"{_player.name}님, 입장하셨습니다.");
        }

        // 직업선택
        Console.WriteLine("직업을 선택하세요. [1:전사 | 2:법사 | 3:궁수]");
        int job = int.Parse(Console.ReadLine());

        if (job >= 1 && job <= 3)  // if (job is >=1 and <=3) 패턴매칭 C# 9.0 ?
        {
            _player.job = (Job)job;

            switch (_player.job)
            {
                case Job.Warrior:
                    Console.WriteLine($"{_player.job}를 선택했습니다.");
                    break;
                case Job.Wizzard:
                    Console.WriteLine($"{_player.job}를 선택했습니다.");
                    break;
                case Job.Archor:
                    Console.WriteLine($"{_player.job}를 선택했습니다.");
                    break;
            }
        }
    }
}

class Player
{
    public string name;
    public Job job;

    public Player(string name)
    {
        this.name = name;
    }
}

public enum Job
{
    Warrior = 1,
    Wizzard,
    Archor
}

public enum ItemType
{
    Sword,
    Sphere,
    Axe,
    Ammor
}

// 아이템 정보 구조체
public struct ItemData
{
    public string name;
    public ItemType itemType;
    public float sellPrice;
    public int value;
    public int count;
}



