namespace TP_Vecteur
{
    internal class Vecteur3D : Vecteur2D

    {
        private int _Z;
        public int Z { get => _Z; set => _Z = value; }


        public Vecteur3D(int x, int y, int z) : base(x, y)
        {
            int Z = z;
        }

    }
}
