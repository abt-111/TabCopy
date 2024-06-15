class MainClass
{
    public const int TAB_SIZE = 3;
    public static void Main(string[] args)
    {
        Random random = new Random();

        long[] intarray1 = new long[TAB_SIZE],
            intarray2 = new long[TAB_SIZE],
            intarray3 = new long[TAB_SIZE * 2];

        string stringForDisplay1 = "",
            stringForDisplay2 = "",
            stringForDisplay3 = "";

        for(int i = 0; i < TAB_SIZE; i++)
        {
            // Affectation des valeurs dans les deux premiers tableaux
            intarray1[i] = random.NextInt64();
            intarray2[i] = random.NextInt64();
        }

        for (int i = 0; i < TAB_SIZE; i++)
        {
            // Affectation des deux premiers tableaux dans le troisième
            intarray3[i] = intarray1[i];
            intarray3[i + TAB_SIZE] = intarray2[i];
        }

        // Préparation de chaînes de caractères pour l'affichage
            for (int i = 0; i < TAB_SIZE; i++)
        {
            // Préparation de chaînes de caractères pour l'affichage
            stringForDisplay1 += $"intarray1[{i}] = {intarray1[i]}\n";
            stringForDisplay2 += $"intarray2[{i}] = {intarray2[i]}\n";
        }

        // Préparation de chaînes de caractères pour l'affichage
        for (int i = 0; i < TAB_SIZE * 2; i++)
        {
            stringForDisplay3 += $"intarray3[{i}] = {intarray3[i]}\n";
        }

        Console.WriteLine(stringForDisplay1 + "\n" + stringForDisplay2 + "\n" + stringForDisplay3);
    }
}