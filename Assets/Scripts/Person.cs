using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
<<<<<<< HEAD
    
=======
    public int age;
    public string gender;
    public string race;
    public string firstName;
    public string lastName;
    public Pass pass;

    public Person(int age, string gender, string race, string firstName, string lastName, Pass pass)
    {
        this.age = age;
        this.gender = gender;
        this.race = race;
        this.firstName = firstName;
        this.lastName = lastName;
        this.pass = pass;
    }

    //Can be replaced with { get; } at variable names
    public int getAge() {
        return age;
    }

    public string getGender() {
        return gender;
    }

    public string getRace() {
        return race;
    }

    public string getFirstName() {
        return firstName;
    }

    public string getLastName() {
        return lastName;
    }

    public Pass getPass() {
        return pass;
    }

    public bool comparePass(int id) {
        switch (id) {
            case 0:
                return pass.age == age;
            case 1:
                return pass.gender == gender;
            case 2:
                return pass.race == race;
            case 3:
                return pass.firstName == firstName;
            case 4:
                return pass.lastName == lastName;
            default:
                return false;
        }
    }
>>>>>>> 4ed893febee4f68e13dbc0e5932b7a74e58981b2
}
