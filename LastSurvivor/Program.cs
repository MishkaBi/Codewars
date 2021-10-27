using System;

public static class Kata
{
    public static string LastSurvivor(string letters, int[] coords)
    {
        for (int i = 0; i < coords.Length; i++)
        {
            string symbol = letters.Remove(coords[i], 1);
            letters = symbol;
        }
        return letters;
    }
}