using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Race : MonoBehaviour
{
    private string raceName;
    private int raceBonus;

    public string RaceName { get => raceName; set => raceName = value; }
    public int RaceBonus { get => raceBonus; set => raceBonus = value; }

    public Race(string raceName) => this.raceName = raceName;

}