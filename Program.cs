// See https://aka.ms/new-console-template for more information
(int, int) ConvertMinToHM(int nbMin)
{
		return (nbMin/60,nbMin%60);
}

//Programme Principal

Console.WriteLine("Saisir un nombre de minutes");
(int H, int M) = ConvertMinToHM(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"{H}:{M:D2}");
//D