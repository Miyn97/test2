class TicTacToe
{
    static void Main()
    {
        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int turn = 0; // 짝수는 X, 홀수는 O
        bool gameOver = false;

        while (!gameOver)
        {
            Console.Clear();
            DrawBoard(board);

            char player = (turn % 2 == 0) ? 'X' : 'O';
            Console.WriteLine($"플레이어 {player} 차례입니다.");
            Console.Write("번호를 선택하여 입력하세요 (1 ~ 9): ");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (choice < 0 || choice > 8 || board[choice] == 'X' || board[choice] == 'O')
            {
                Console.WriteLine("잘못된 선택입니다. 아무 키나 누르세요...");
                Console.ReadKey();
                continue;
            }

            board[choice] = player;
            turn++;

            // 승리 조건 확인
            if (CheckWin(board))
            {
                Console.Clear();
                DrawBoard(board);
                Console.WriteLine($"(◑u◑)乃 플레이어 {player} 승리!");
                gameOver = true;
            }
            else if (turn == 9)
            {
                Console.Clear();
                DrawBoard(board);
                Console.WriteLine("(TДT)う 무승부입니다!");
                gameOver = true;
            }
        }
    }

    static void DrawBoard(char[] b)
    {
        Console.WriteLine();
        Console.WriteLine($" {b[0]} | {b[1]} | {b[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {b[3]} | {b[4]} | {b[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {b[6]} | {b[7]} | {b[8]} ");
        Console.WriteLine();
    }

    static bool CheckWin(char[] b)
    {
        int[,] wins = {
            {0,1,2}, {3,4,5}, {6,7,8}, // 가로
            {0,3,6}, {1,4,7}, {2,5,8}, // 세로
            {0,4,8}, {2,4,6}           // 대각선
        };

        for (int i = 0; i < wins.GetLength(0); i++)
        {
            int a = wins[i, 0];
            int b1 = wins[i, 1];
            int c = wins[i, 2];

            if (b[a] == b[b1] && b[b1] == b[c])
                return true;
        }

        return false;
    }
}
