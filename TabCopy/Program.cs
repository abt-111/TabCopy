class MainClass
{
    public const int TAB_SIZE = 3;
    public static void Main(string[] args)
    {
        int[] intArray1 = new int[TAB_SIZE],
            intArray2 = new int[TAB_SIZE],
            intArray3 = new int[TAB_SIZE * 2];

        // Affectation des valeurs dans les deux premiers tableaux
        InitializeArray(intArray1);
        InitializeArray(intArray2);

        // Affectation des deux premiers tableaux dans le troisième
        InsertArraysInArray([intArray1, intArray2], intArray3, TAB_SIZE);

        // Préparation de chaînes de caractères pour l'affichage
        DisplayArray(intArray1, 1);
        DisplayArray(intArray2, 2);
        DisplayArray(intArray3, 3);
    }

    public static void InitializeArray(int[] intArray)
    {
        Random random = new Random();

        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = random.Next();
        }
    }

    public static void InsertArraysInArray(int[][] intArrays, int[] intArray, int startIndex)
    {
        for (int i = 0; i < intArrays.Length; i++)
        {
            for(int j = 0; j < intArrays[i].Length; j++)
            {
                intArray[j + (i * startIndex)] = intArrays[i][j];
            }
        }
    }

    public static void DisplayArray(int[] intArray, int number)
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine($"intArray{number}[{i}] = {intArray[i]}");
        }
        Console.WriteLine();
    }
}