// See https://aka.ms/new-console-template for more information
//Rôle : convertit un nombre de minutes au format H:M
//un paramètre d'entrée:
//- nbMin : nombre de minutes à convertir
//Valeur de retour : un tuple de type (H,M)

(int, int) ConvertMinToHM(int nbMin)
{
		return (nbMin/60,nbMin%60);
}

//Programme Principal

Console.WriteLine("Saisir un nombre de minutes");
(int H, int M) = ConvertMinToHM(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"{H}:{M:D2}");
//D permet de préciser le nombre de chiffres