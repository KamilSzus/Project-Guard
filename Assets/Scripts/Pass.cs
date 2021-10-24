using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pass : MonoBehaviour
{
    public int age;
    public string gender;
    public string race;
    public string firstName;
    public string lastName;

    public Pass(int age, string gender, string race, string firstName, string lastName)
    {
        this.age = age;
        this.gender = gender;
        this.race = race;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public int getAge()
    {
        return age;
    }

    public string getGender()
    {
        return gender;
    }

    public string getRace()
    {
        return race;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }
}
