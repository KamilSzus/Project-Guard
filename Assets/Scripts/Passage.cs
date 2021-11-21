// Mateusz Kapka 21.11.2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Passage : MonoBehaviour
{
    // Passage script add as Component to Canvas and as a Text Game Object set TextGameObject
    // To create TextGameObject create Create Empty in Canvas and set tag stamp
    private PersonInfo info;
    public Passage(PersonInfo info)
    {
        this.info = info;
    }

    public PersonInfo MakePersonInfoObject()
    {
        GameObject gameObject = new GameObject("PersonInfo");
        //gameObject.tag = "PersonInfo";
        PersonInfo personInfo = gameObject.AddComponent<PersonInfo>();
        //Race raceInfo = gameObject.AddComponent<Race>();
        //Fraction fractionInfo = gameObject.AddComponent<Fraction>();

        personInfo.PersonName = "Ala";
        personInfo.PersonSurname = "Kowalska";
        //personInfo.Race.RaceName = "Ork";
        //personInfo.Fraction.Faith = "Chrześcijanin";
        //personInfo.Fraction.FractionName = "Najemnik";

        //Race race = new Race("Ork");
        //PersonInfo personInfo = new PersonInfo(15, "Ala", "Kowalska", race);
        //Passage passage = new Passage(personInfo);

        return personInfo;
    }
    public Race MakeRaceInfoObject()
    {
        GameObject gameObject = new GameObject("Race");
        Race raceInfo = gameObject.AddComponent<Race>();

        raceInfo.RaceName = "Ork";

        return raceInfo;
    }

    public Fraction MakeFractionInfoObject()
    {
        GameObject gameObject = new GameObject("Fraction");
        Fraction fractionInfo = gameObject.AddComponent<Fraction>();

        fractionInfo.Faith = "Chrześcijanka";
        fractionInfo.FractionName = "Najemniczka";

        return fractionInfo;
    }

    void Start()
    {
        PersonInfo personInfoObject = MakePersonInfoObject();
        Race raceInfoObject = MakeRaceInfoObject();
        Fraction fractionInfoObject = MakeFractionInfoObject();

        // Debug.Log(personInfoObject.PersonName);
        // Debug.Log(personInfoObject.PersonSurname);
        // Debug.Log(personInfoObject.Race.RaceName);
        // Debug.Log(personInfoObject.Fraction.Faith);
        // Debug.Log(personInfoObject.Fraction.FractionName);

        GameObject stamp = GameObject.FindGameObjectWithTag("stamp"); // tag in TextGameObject
        if (stamp != null)
        {
            Text textObject = stamp.GetComponent<Text>(); //get the text component in the gameobject you assigned
            
            textObject.text = "Imie: " + personInfoObject.PersonName + '\n' + 
            "Nazwisko: " + personInfoObject.PersonSurname + '\n' +
            "Rasa: " + raceInfoObject.RaceName + '\n' +
            "Frakcja: " + fractionInfoObject.FractionName + '\n' +
            "Frakcja(wiara): " + fractionInfoObject.Faith + '\n'; //set the text in the text component
        }
    }
    void Update()
    {
        
    }
}
