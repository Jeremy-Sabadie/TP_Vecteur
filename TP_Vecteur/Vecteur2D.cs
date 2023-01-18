namespace TP_Vecteur
{
    internal class Vecteur2D
    {
        private int X;
        private int Y;

        public Vecteur2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X1 { get => X; set => X = value; }
        public int Y1 { get => Y; set => Y = value; }
        public double Norme(int x, int y)
        {
            return Math.Sqrt(Math.Pow(0 - X, 2) + Math.Pow(0 - Y, 2));
        }
    }
}
