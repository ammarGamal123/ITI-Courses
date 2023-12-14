namespace Day_16
{
    class Program
    {
        public static void Main()
        {
            Ball ball = new Ball();

            Player P11 = new Player()
            {
                Name = "Ammar" , Team = "Al Ahly"
            };
            Player P12 = new Player()
            {
                Name = "Usef" , Team = "Al Ahly"
            };
            Player P21 = new Player()
            {
                Name = "Mido" , Team = "Al Zamalek"
            };
            Player P22 = new Player()
            {
                Name = "Kareem" , Team = "Al Zamalek"
            };

            Refree refree = new Refree() { Name = "Omar" };

            ball.BallLocation = new Location() { X = 20, Y = 20, Z = 20 };

            Console.WriteLine(ball.ToString());
            
            // Registration 
            // Add Pointer to Subsc. Call Back Method to Publisher event Invocation List
            ball.BallLocationChanged += new Action(P11.Run);
            ball.BallLocationChanged += P12.Run;
            ball.BallLocationChanged += P21.Run;
            ball.BallLocationChanged += P22.Run;

            ball.BallLocationChanged += refree.Look;

            ball.BallLocationChanged += () => Console.WriteLine("Adhock Method");

            ball.BallLocation = new Location() {X = 70 , Y = 70 , Z = 70};

            Console.WriteLine(ball);

        }
    }
}