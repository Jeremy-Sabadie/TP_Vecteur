namespace TP_Vecteur
{
    internal class Vecteur2D
    {
        protected static int instanceCount = 0;

        private int X;
        private int Y;
        private int IdVecteur;
        public Vecteur2D(int x, int y)
        {
            Console.WriteLine("****Vecteur2D****");
            instanceCount++;
            IdVecteur = instanceCount;
            Console.WriteLine($"Vecteur {instanceCount}");
            Console.Write(" Donner X: ");
            x = int.Parse(Console.ReadLine());
            X = x;
            Console.Write(" Donner Y: ");
            y = int.Parse(Console.ReadLine());
            Y = y;
            Console.WriteLine($"X={X} Y={Y}");
            Console.WriteLine($"La norme est: {Norme()}");


        }

        public int X1 { get => X; set => X = value; }
        public int Y1 { get => Y; set => Y = value; }
        public double Norme()
        {

            return Math.Sqrt(Math.Pow(0 - X, 2) + Math.Pow(0 - Y, 2));
        }

    }
}
