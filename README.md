## Description:
A [*Hamming number*](https://en.wikipedia.org/wiki/Regular_number) is a positive integer of the form $2^i3^j5^k$, for some non-negative integers $i$, $j$, and $k$.

Write a function that computes the $nth$ smallest Hamming number.

Specifically:

- The first smallest Hamming number is 1 = $2^03^05^0$.
- The second smallest Hamming number is 2 = $2^13^05^0$.
- The third smallest Hamming number is 3 = $2^03^15^0$.
- The fourth smallest Hamming number is 4 = $2^23^05^0$.
- The fifth smallest Hamming number is 5 = $2^03^05^1$.
- The 20 smallest Hamming numbers are given in the Example test fixture.

Your code should be able to compute the first ```5 000``` ( LC: ```400```, Clojure: ```2 000```, Haskell: ```12 691```, NASM, C, D, C++, Go and Rust: ```13 282``` ) Hamming numbers without timing out.
### My solution
```C#
using System;

public class Hamming
{
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
```
