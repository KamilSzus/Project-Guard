using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fraction : MonoBehaviour
{
    private string fractionName;
    private string faith;

    public Fraction(string faith, string fractionName)
    {
        this.faith = faith;
        this.fractionName = fractionName;
    }

    public string FractionName { get => fractionName; set => fractionName = value; }
    public string Faith { get => faith; set => faith = value; }
}
