using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pass : MonoBehaviour
{
    private int age;
    private string gender;
    private Race race;
    private string firstName;
    private string lastName;

    public int Age { get => age; set => age = value; }
    public string Gender { get => gender; set => gender = value; }
    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public Race Race { get => race; set => race = value; }

    public Pass(int age, string gender, Race race, string firstName, string lastName)
    {
        this.Age = age;
        this.Gender = gender;
        this.Race = race;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

}
