using System;

class CardGame
{


    //Console.Write("이름을 입력하세요:");
    //string name = Console.ReadLine();

    //Console.Write("나이를 입력하세요:");
    //string age = Console.ReadLine();

    //Console.WriteLine($"안녕하세요 {name}님, 나이는 {age}세 이시군요. 반갑습니다~");

    //Console.Write("계산하실 첫 번째 숫자를 입력하세요: ");
    //string input1 = Console.ReadLine();
    //int num1 = int.Parse(input1);

    //Console.Write("계산하실 두 번째 숫자를 입력하세요: ");
    //string input2 = Console.ReadLine();
    //int num2 = int.Parse(input2);

    //int sum = num1 + num2;
    //Console.WriteLine("덧셈 결과: " + sum);

    //int minus = num1 - num2;
    //Console.WriteLine("뺄셈 결과: " + minus);

    //int mul = num1 * num2;
    //Console.WriteLine("곱셈 결과: " + mul);

    //int div = num1 / num2;
    //Console.WriteLine("나눗셈 결과: " + div);

    //int rem = num1 % num2;
    //Console.WriteLine("나머지 결과: " + rem);

    //Console.Write("섭씨 온도를 입력하세요(숫자만 입력): ");
    //string input = Console.ReadLine();

    //double c = Convert.ToDouble(input);

    //double f = (c * 9 / 5) + 32;

    //Console.WriteLine("화씨 온도는: " + f + "도 입니다.");

    //Console.Write("몸무게를 입력하세요 (kg): ");
    //string w_Input = Console.ReadLine();
    //double w = Convert.ToDouble(w_Input);

    //Console.Write("키를 (미터 단위로) 입력하세요 : ");
    //string h_Input = Console.ReadLine();
    //double h = Convert.ToDouble(h_Input);

    //double bmi = w / (h * h);

    //Console.WriteLine("당신의 BMI는 " + Math.Round(bmi, 2) + " 입니다.");

    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // 1~100 사이 숫자
        int guess = 0;
        int tries = 0;

        Console.WriteLine("◆ 숫자 맞추기 게임! ◆");
        Console.WriteLine("1부터 100 사이 숫자를 맞춰보세요.");

        while (guess != secretNumber)
        {
            Console.Write("숫자 입력: ");
            string input = Console.ReadLine();
            guess = Convert.ToInt32(input); // 숫자로 변환
            tries++;

            if (guess < secretNumber)
            {
                Console.WriteLine("▲ 더 큰 숫자예요!");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("▼ 더 작은 숫자예요!");
            }
            else
            {
                Console.WriteLine("★ 정답입니다!");
                Console.WriteLine("시도한 횟수: " + tries);
            }
        }
    }
}