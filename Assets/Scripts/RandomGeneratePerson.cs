using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using System.IO;

static public class RandomGeneratePerson
{
    private static readonly string[] nameMale = new string[] { "Ahmed", "Ahmman", "Alfred", "Ragnar", "Ivar", "Everyman", "Theoden", "Alrik", "Darik", "Gared", "Bezimienny", "Hagen", "Aragorn", "Joshep", "Kamil", "Harry", "Illidan", "Arthas", "Neek", "Geralt", "Vesemir", "Letho", "Lambert", "Eskel" };
    private static readonly string[] nameFemale = new string[] { "Inavera", "Lesha", "Selia", "Olive", "Lagertha", "Veila", "Arwena", "Wonda", "Diana", "Lena", "Sandra", "Sansa", "Arya", "Elune", "Kamila", "Tyrande", "Maiev", "Valera", "Erica", "Lova", "Yen", "Triss", "Monica", "Marcin" };
    private static readonly string[] gender = new string[] { "Male", "Famale" };
    private static readonly string[] race = new string[] { "Ork", "Krasnolud", "Goblin", "Elf", "Cz³owiek", "Gnom", "Pó³-elf", "Pó³-ork", "Hobbit" };
    private static readonly string[] lastName = new string[] { "Praudmoore", "von everec", "van Cleef", "Stormrage", "Kaji", "Majah", "Bloodchin", "Doomtrust", "Baggins", "Arevd", "Akkon", "Amit", "Mahale", "Hama", "Kernel", "Maraara", "Wedrowycz", "Pomidor", "Prostak", "Wiesniak", "Œwiniopas", "Bardak", "Bffadf" };
    private static readonly string[] fraction = new string[] { "Bandyta", "Najemnik", "Kap³an", "Nikt", "Paladyn", "Stra¿nik", "Ch³op", "Wampir", "£owca Smoków", "Kupiec" };
    private static readonly string[] faith = new string[] { "Kult S³oñca", "Kult Ognia", "Kult Œmierci", "Kult Powietrza", "Kult Wody", "Kult Ziemii" };

    static public string generateRandomMaleName()
    {
       return nameMale[UnityEngine.Random.Range(0, nameMale.Length)];
    }
    static public string generateRandomFemaleName()
    {
        return nameFemale[UnityEngine.Random.Range(0, nameFemale.Length)];
    }
    static public string generateRandomGender()
    {
        return gender[UnityEngine.Random.Range(0, gender.Length)];
    }
    static public string generateRandomRace()
    {
        return race[UnityEngine.Random.Range(0, race.Length)];
    }
    static public string generateRandomFraction()
    {
        return fraction[UnityEngine.Random.Range(0, fraction.Length)];
    }
    static public string generateRandomLastName()
    {
        return lastName[UnityEngine.Random.Range(0, lastName.Length)];
    }
    static public string generateRandomFaith()
    {
        return faith[UnityEngine.Random.Range(0, faith.Length)];
    }

}
        
