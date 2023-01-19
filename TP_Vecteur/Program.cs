using TP_Vecteur;
//Premier vecteur 2D:
Vecteur2D V1 = new Vecteur2D(1, 2);
//Deuxième vecteur 2D:
Vecteur2D V2 = new Vecteur2D(2, 1);
//Comparaison des deux valeurs des Normes de V1 et V2. 
if (V1.Norme() == V2.Norme())
{
    Console.WriteLine("Les deux vecteurs sont identiques");
}
else { Console.WriteLine("Les vecteurs ne sont pas identiques"); }
Console.WriteLine("Vecteur 3D");
//Troisième vecteur de type 3D.1

Vecteur3D vecteur3 = new Vecteur3D(1, 2, 1);