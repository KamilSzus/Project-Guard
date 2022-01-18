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
        Debug.Log(loyalty);
    }

    public void growMorality()
    {
        morality += 1;
        Debug.Log(morality);
    }

    public void growEvil()
    {
        evil += 1;
        Debug.Log(evil);
    }

    public void growGreed()
    {
        greed += 1;
        Debug.Log(greed);
    }


}
