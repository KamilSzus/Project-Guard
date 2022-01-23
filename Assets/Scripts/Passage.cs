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
    private Image passImage;
    public GameObject button; // has to be public

    public PersonInfo personInfoObject;
    public Race raceInfoObject;
    public Fraction fractionInfoObject;
    public Passage(PersonInfo info)
    {
        this.info = info;
    }

    public PersonInfo MakePersonInfoObject()
    {
        if(GameObject.Find("PersonInfo") == null) // creating only one GameObject
        {
            GameObject gameObject = new GameObject("PersonInfo");
        }

        //GameObject gameObject = new GameObject("PersonInfo");
        PersonInfo personInfo = gameObject.AddComponent<PersonInfo>();

        string gender = RandomGeneratePerson.generateRandomGender();
        Debug.Log(gender);


        if(gender.Equals("Male"))
            personInfo.PersonName = RandomGeneratePerson.generateRandomMaleName();
        else
            personInfo.PersonName = RandomGeneratePerson.generateRandomFemaleName();
        personInfo.PersonSurname = RandomGeneratePerson.generateRandomLastName();
        //personInfo.Race.RaceName = "Ork";
        //personInfo.Fraction.Faith = "Chrze�cijanin";
        //personInfo.Fraction.FractionName = "Najemnik";


        if(gender.Equals("Male"))
            personInfo.PersonName = RandomGeneratePerson.generateRandomMaleName();
        else
            personInfo.PersonName = RandomGeneratePerson.generateRandomFemaleName();
        personInfo.PersonSurname = RandomGeneratePerson.generateRandomLastName();

        return personInfo;
    }
    public Race MakeRaceInfoObject()
    {
        if(GameObject.Find("Race") == null) // creating only one GameObject
        {
            GameObject gameObject = new GameObject("Race");
        }

        //GameObject gameObject = new GameObject("Race");
        Race raceInfo = gameObject.AddComponent<Race>();

        raceInfo.RaceName = RandomGeneratePerson.generateRandomRace();

        return raceInfo;
    }

    public Fraction MakeFractionInfoObject()
    {
        if(GameObject.Find("Fraction") == null) // creating only one GameObject
        {
            GameObject gameObject = new GameObject("Fraction");
        }
        
        //GameObject gameObject = new GameObject("Fraction");
        Fraction fractionInfo = gameObject.AddComponent<Fraction>();

        fractionInfo.Faith = RandomGeneratePerson.generateRandomFaith();
        fractionInfo.FractionName = RandomGeneratePerson.generateRandomFraction();

        return fractionInfo;
    }

    public void generateNewInfo() // modify this function to generate random values
    {
        personInfoObject = MakePersonInfoObject();
        raceInfoObject = MakeRaceInfoObject();
        fractionInfoObject = MakeFractionInfoObject();
    }

    //AddComponent<> seems to be bugged as they put components to a SampleScene hierarchy
    //every time you hit show passage button
    public void showPassage()
    {
        if(personInfoObject == null && raceInfoObject == null && fractionInfoObject == null) // one time execute
        {
            personInfoObject = MakePersonInfoObject();
            raceInfoObject = MakeRaceInfoObject();
            fractionInfoObject = MakeFractionInfoObject();
        }

        GameObject stamp = GameObject.FindGameObjectWithTag("stamp"); // tag in TextGameObject
        passImage = GameObject.Find("Image").GetComponent<Image>();
        passImage.enabled = true;

        if (stamp != null)
        {
            Text textObject = stamp.GetComponent<Text>(); //get the text component in the gameobject you assigned
            textObject.enabled = true;
            textObject.text = "Imie: " + personInfoObject.PersonName + '\n' + 
            "Nazwisko: " + personInfoObject.PersonSurname + '\n' +
            "Rasa: " + raceInfoObject.RaceName + '\n' +
            "Frakcja: " + fractionInfoObject.FractionName + '\n' +
            "Frakcja(wiara): " + fractionInfoObject.Faith + '\n'; //set the text in the text component
            button.SetActive(true);
        }
    }

    /*public void showButton() {
        GameObject button = GameObject.FindGameObjectWithTag("passageButton");
        Debug.Log(button);
        if (button != null)
            button.SetActive(true);
    }*/

    public void hidePassage() {
        passImage = GameObject.Find("Image").GetComponent<Image>();
        GameObject stamp = GameObject.FindGameObjectWithTag("stamp");
        Text textObject = stamp.GetComponent<Text>();
        if (passImage.enabled == true && textObject.enabled == true)
        {
            button.SetActive(false);
            passImage.enabled = false;
            textObject.enabled = false;
        }
    }
}
