using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] intarray1 = new int[3];
        int[] intarray2 = new int[3];
        int[] intarray3 = new int[6];

        intarray1[0] = 123;
        intarray1[1] = 213;
        intarray1[2] = 321;

        intarray2[0] = 456;
        intarray2[1] = 546;
        intarray2[2] = 645;

        intarray3[0] = intarray1[0];
        intarray3[1] = intarray1[1];
        intarray3[2] = intarray1[2];

        intarray3[3] = intarray2[0];
        intarray3[4] = intarray2[2];
        intarray3[5] = intarray2[3];
    }
}