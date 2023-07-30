using System;

public class Hamming
{
    public static void Main()
    {
        // Test
        var t = hamming(20);
        // ...should return 36
    }

    public static long hamming(int n)
    {
        long[] sequence = new long[n];
        sequence[0] = 1;
        (long, int) i = (2, 0), j = (3, 0), k = (5, 0);

        for (int l = 1; l < n; l++)
        {
            sequence[l] = Math.Min(i.Item1, Math.Min(j.Item1, k.Item1));

            if (i.Item1 == sequence[l])
                i = (sequence[++i.Item2] * 2, i.Item2);

            if (j.Item1 == sequence[l])
                j = (sequence[++j.Item2] * 3, j.Item2);

            if (k.Item1 == sequence[l])
                k = (sequence[++k.Item2] * 5, k.Item2);
        }

        return sequence[n - 1];
    }
}