// See https://aka.ms/new-console-template for more information
(int, int) ConvertMinToHM(int nbMin)
{
		return (nbMin/60,nbMin%60);
}

//Programme Principal
(int H, int M) = ConvertMinToHM(130);
Console.WriteLine($"{H}:{M}");