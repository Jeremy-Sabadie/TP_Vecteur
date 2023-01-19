namespace TP_Vecteur
{
    internal class Vecteur3D : Vecteur2D

    {
        private int _Z;
        public int Z { get => _Z; set => _Z = value; }


        public Vecteur3D(int x, int y, int z) : base(x, y)
        {
            Console.WriteLine("****Vecteur3D****");
            instanceCount++;
            Console.WriteLine($"Vecteur {instanceCount}");
            Console.Write(" Donner X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write(" Donner Y:");
            y = int.Parse(Console.ReadLine());
            Console.Write(" Donner Z: ");
            z = int.Parse(Console.ReadLine());
            int Z = z;
            Console.WriteLine($"La norme est: {Norme()}");

        }

    }
}
