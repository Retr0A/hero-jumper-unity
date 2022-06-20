using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils
{
    public static bool RandomBoolean()
    {
        if (Random.value >= 0.5)
        {
            return true;
        }
        return false;
    }
}
