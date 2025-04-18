namespace Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine1 = new Engine("터보엔진");
            Car car1 = new Car("붕붕이",engine1);

            car1.CarName();
        }
    }

    public class Car
    {
        public string name;
        Engine engine;

        public void CarName()
        {
            Console.WriteLine($"제가 보유한 차는 {name}입니다.사용하는 엔진은 {engine.name}입니다.");
        }
        public Car(string name, Engine engine)
        {
            this.name = name;
            this.engine = engine;
        }
    }

    public class Engine
    {
        public string name;
        public Engine(string name) 
        {
            this.name = name;
        }
    }
}
