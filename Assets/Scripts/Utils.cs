using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils
{
    /// <summary>
    /// Selects random boolean true or false.
    /// </summary>
    /// <param name="rarity">The rarity of selecting true.</param>
    /// <returns>The random boolean</returns>
    public static bool RandomBoolean(float rarity)
    {
        if (Random.value >= rarity)
        {
            return true;
        }
        return false;
    }
}
