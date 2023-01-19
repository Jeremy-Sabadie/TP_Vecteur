using TP_Vecteur;
//Premier vecteur:
Vecteur2D V1 = new Vecteur2D(1, 2);
Vecteur2D V2 = new Vecteur2D(2, 1);
if (V1.Norme() == V2.Norme())
{
    Console.WriteLine("Les deux vecteurs sont identiques");
}