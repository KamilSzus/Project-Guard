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

    public PersonInfo(int id, string personName, string personSurname, string raceName, string fractionName)
    {
        this.id = id;
        this.personName = personName;
        this.personSurname = personSurname;
        this.race.setRace(raceName);
        this.fraction.setFraction(fractionName);
    }

    public int getId()
    {
        return id;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public string getPersonName()
    {
        return personName;
    }

    public void setPersonName(string personName)
    {
        this.personName = personName;
    }
    public string getPersonSurname()
    {
        return personSurname;
    }

    public void setPersonSurname(string personSurname)
    {
        this.personSurname = personSurname;
    }

    private bool compareInfo(PersonInfo personInfo)
    {
        if (personInfo.id != id)
            return false;
        else if (personInfo.personName != personName)
            return false;
        else if (personInfo.personSurname != personSurname)
            return false;
        else if (personInfo.race.getRace() != race.getRace())
            return false;
        else if (personInfo.fraction.getFraction() != fraction.getFraction())
            return false;
        return true;
    }

    class Race
    {
        private string raceName;
        public string getRace()
        {
            return raceName;
        }

        public void setRace(string raceName)
        {
            this.raceName = raceName;
        }
    };

    class Fraction
    {
        private string fractionName;

        public string getFraction()
        {
            return fractionName;
        }

        public void setFraction(string fractionName)
        {
            this.fractionName = fractionName;
        }
    };

}
