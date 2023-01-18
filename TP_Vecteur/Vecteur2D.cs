namespace TP_Vecteur
{
    internal class Vecteur2D
    {
        private int X;
        private int Y;
        private int instanceCount=0;   

        public Vecteur2D(int x, int y)
        {
            Console.WriteLine("****Vecteur2D****");
            Console.WriteLine("Donner X:");
            x = int.Parse(Console.ReadLine());
            X = x;
            y = int.Parse(Console.ReadLine());
            Y = y;
            Console.WriteLine($"X={X} Y={Y}");
            Console.WriteLine($"La norme est:{Norme}");
            instanceCount++
        }

        public int X1 { get => X; set => X = value; }
        public int Y1 { get => Y; set => Y = value; }
        public double Norme(int x, int y)
        {
            return Math.Sqrt(Math.Pow(0 - X, 2) + Math.Pow(0 - Y, 2));
        }
        
    }
}
