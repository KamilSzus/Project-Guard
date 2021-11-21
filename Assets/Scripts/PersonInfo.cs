using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonInfo : MonoBehaviour
{
    private int id;
    private string personName;
    private string personSurname;
    private Race race;
    private Fraction fraction;

    public int Id { get => id; set => id = value; }
    public string PersonName { get => personName; set => personName = value; }
    public string PersonSurname { get => personSurname; set => personSurname = value; }
    public Race Race { get => race; set => race = value; }
    public Fraction Fraction { get => fraction; set => fraction = value; }

    public PersonInfo(int id, string personName, string personSurname, Race race, Fraction fraction)
    {
        this.Id = id;
        this.PersonName = personName;
        this.PersonSurname = personSurname;
        this.Race = race;
        this.Fraction = fraction;
    }

    public override string ToString()
    {
        return "Person: " + Id + "\n" + PersonName + "\n" + PersonSurname + "\n" + Race.RaceName + "\n" + Fraction.Faith + "\n" + Fraction.FractionName;
    }
    private bool compareInfo(PersonInfo personInfo)
    {
        if (personInfo.Id != Id)
            return false;
        else if (personInfo.PersonName != PersonName)
            return false;
        else if (personInfo.PersonSurname != PersonSurname)
            return false;
        else if (personInfo.Race.RaceName != race.RaceName)
            return false;
        return true;
    }

}
