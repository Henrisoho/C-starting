
Kata 1

using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
if ((flower1 == flower2) || (flower1 % 2 != 0 && flower2 % 2 != 0 && flower1 != 0 && flower2 != 0) || (flower1 % 1 != 0 && flower2 % 1 != 0))
{
    return false;
}
else
{
    return true;
}
    }
}