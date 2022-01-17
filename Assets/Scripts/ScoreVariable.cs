using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreVariable : MonoBehaviour
{
    static public int loyalty = 0;
    static public int morality = 0;
    static public int evil = 0;
    static public int greed = 0;

    public void growLoyalty()
    {
        loyalty += 1;
    }

    public void growMorality()
    {
        morality += 1;
    }

    public void growEvil()
    {
        evil += 1;
    }

    public void growGreed()
    {
        greed += 1;
    }


}
