using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    private int age;
    private string gender;
    private Race race;
    private string firstName;
    private string lastName;
    private Pass pass;

    public int Age { get => age; set => age = value; }
    public string Gender { get => gender; set => gender = value; }
    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public Pass Pass { get => pass; set => pass = value; }
    public Race Race { get => race; set => race = value; }

    public Person(int age, string gender, Race race, string firstName, string lastName, Pass pass)
    {
        this.Age = age;
        this.Gender = gender;
        this.Race = race;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Pass = pass;
    }

    public bool comparePass(int id)
    {
        switch (id)
        {
            case 0:
                return Pass.Age == Age;
            case 1:
                return Pass.Gender == Gender;
            case 2:
                return Pass.Race.RaceName == Race.RaceName;
            case 3:
                return Pass.FirstName == FirstName;
            case 4:
                return Pass.LastName == LastName;
            default:
                return false;
        }
    }
}