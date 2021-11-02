using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonInfo : MonoBehaviour
{
    private int id;
    private string personName;
    private string personSurname;

    private Race classRace;
    private Fraction classFraction;
    class Race
    {
        private string race;
        public string getRace()
        {
            return race;
        }

        public void setRace(string race)
        {
            this.race = race;
        }
    };
    class Fraction
    {
        private string fraction;

        public string getFraction()
        {
            return fraction;
        }

        public void setFraction(string fraction)
        {
            this.fraction = fraction;
        }
    };

    public PersonInfo(int id, string personName, string personSurname, string race, string fraction)
    {
        this.id = id;
        this.personName = personName;
        this.personSurname = personSurname;
        this.classRace.setRace(race);
        this.classFraction.setFraction(fraction);
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
        else if (personInfo.classRace.getRace() != classRace.getRace())
            return false;
        else if (personInfo.classFraction.getFraction() != classFraction.getFraction())
            return false;
        return true;
    }
}
