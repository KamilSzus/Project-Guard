using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Race : MonoBehaviour
{
    private string raceName;
    private int raceBonus;//it will be enum determining bonuses from race for example dvarwes heave more gold

    public string RaceName { get => raceName; set => raceName = value; }
    public int RaceBonus { get => raceBonus; set => raceBonus = value; }

    public Race(string raceName) => this.raceName = raceName;

}