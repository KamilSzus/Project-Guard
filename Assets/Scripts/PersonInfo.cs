using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonInfo : MonoBehaviour
{
    private int id;
    private string personName;
    private string personSurname;
    private Race race;

    public int Id { get => id; set => id = value; }
    public string PersonName { get => personName; set => personName = value; }
    public string PersonSurname { get => personSurname; set => personSurname = value; }
    public Race Race { get => race; set => race = value; }

    public PersonInfo(int id, string personName, string personSurname, Race race)
    {
        Id = id;
        PersonName = personName;
        PersonSurname = personSurname;
        this.race = race;
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
