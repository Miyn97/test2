namespace Test
{
    public class Castingg()
    {
        public static void Main(string[] args)
        {
            Castingg Logic = new Castingg();
            Logic.Casting();

        }

        public void Casting()
        {

            //명시적 형변환
            int num1 = 10;
            long num2 = 10;
            long num3 = num2 + (long)num1;

            Console.WriteLine(num3);

            //암시적 형변환
            int num4 = 10;
            float num5 = 3.14f;
            float result = num4 + num5;

            Console.WriteLine(result);
        }
    }


    class Test()
    {

    }
}