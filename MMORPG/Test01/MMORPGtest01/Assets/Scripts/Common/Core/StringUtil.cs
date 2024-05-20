using UnityEngine;
using System.Collections;
public static class StringUtil
{
    public static int ToInt(this string str)
    {
        int temp = 0;
        int.TryParse(str,out temp);
        return temp;
    }
    public static float ToFloat(this string flt)
    {
        float temp = 0;
        float.TryParse(flt, out temp);
        return temp;
    }
}