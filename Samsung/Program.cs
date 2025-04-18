namespace Samsung
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 스마트폰 클래스를 생성해서 그 클래스 안에 어플과 시스템, 이미지 클래스까지 호출해보기
            // 최종적으로 메인에 스마트폰 클래스 안에 담겨있는 어플과 시스템, 이미지를 모두 출력
            // 객체 생성과 생성자에 대해서 이해하기
            SmartPhone phone1 = new SmartPhone("phone",app,);
            App app = new App("game","youtube","instagram");
            System system = new System("option");
            Image image = new Image("image","video");
        }
    }

    public class SmartPhone 
    {
        public string phone;

        public void ConsoleWrite() 
        {
            Console.WriteLine("");
        }

        public SmartPhone(string phone, App game, System option, Image image) 
        {
            this.phone = phone;
        }
    }

    public class App 
    {
        public string game;
        public string youtube;
        public string instagram;

        public App(string game,string youtube,string instagram) 
        {
            this.game = game;
            this.youtube = youtube;
            this.instagram = instagram;
        }


    }

    public class System 
    {
        public string option;

        public System(string option) 
        {
            this.option = option;
        }

        
    }

    public class Image 
    {
        public string image;
        public string video;

        public Image(string image,string video)
        {
            this.image = image;
            this.video = video;
        }
        
    }
}
