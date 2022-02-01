using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Passage : MonoBehaviour
{
    private PersonInfo info;
    private Image passImage;
    public GameObject button;

    public PersonInfo personInfoObject;
    public Race raceInfoObject;
    public Fraction fractionInfoObject;
    public Passage(PersonInfo info)
    {
        this.info = info;
    }

    public PersonInfo MakePersonInfoObject()
    {
        if(GameObject.Find("PersonInfo") == null)
        {
            GameObject gameObject = new GameObject("PersonInfo");
        }

        PersonInfo personInfo = gameObject.AddComponent<PersonInfo>();

        string gender = RandomGeneratePerson.generateRandomGender();
        Debug.Log(gender);


        if(gender.Equals("Male"))
            personInfo.PersonName = RandomGeneratePerson.generateRandomMaleName();
        else
            personInfo.PersonName = RandomGeneratePerson.generateRandomFemaleName();
        personInfo.PersonSurname = RandomGeneratePerson.generateRandomLastName();


        if(gender.Equals("Male"))
            personInfo.PersonName = RandomGeneratePerson.generateRandomMaleName();
        else
            personInfo.PersonName = RandomGeneratePerson.generateRandomFemaleName();
        personInfo.PersonSurname = RandomGeneratePerson.generateRandomLastName();

        return personInfo;
    }
    public Race MakeRaceInfoObject()
    {
        if(GameObject.Find("Race") == null)
        {
            GameObject gameObject = new GameObject("Race");
        }

        Race raceInfo = gameObject.AddComponent<Race>();

        raceInfo.RaceName = RandomGeneratePerson.generateRandomRace();

        return raceInfo;
    }

    public Fraction MakeFractionInfoObject()
    {
        if(GameObject.Find("Fraction") == null)
        {
            GameObject gameObject = new GameObject("Fraction");
        }
        
        Fraction fractionInfo = gameObject.AddComponent<Fraction>();

        fractionInfo.Faith = RandomGeneratePerson.generateRandomFaith();
        fractionInfo.FractionName = RandomGeneratePerson.generateRandomFraction();

        return fractionInfo;
    }

    public void generateNewInfo()
    {
        personInfoObject = MakePersonInfoObject();
        raceInfoObject = MakeRaceInfoObject();
        fractionInfoObject = MakeFractionInfoObject();
    }

    public void showPassage()
    {
        if(personInfoObject == null && raceInfoObject == null && fractionInfoObject == null)
        {
            personInfoObject = MakePersonInfoObject();
            raceInfoObject = MakeRaceInfoObject();
            fractionInfoObject = MakeFractionInfoObject();
        }

        GameObject stamp = GameObject.FindGameObjectWithTag("stamp");
        passImage = GameObject.Find("Image").GetComponent<Image>();
        passImage.enabled = true;

        if (stamp != null)
        {
            Text textObject = stamp.GetComponent<Text>();
            textObject.enabled = true;
            textObject.text = "Imie: " + personInfoObject.PersonName + '\n' + 
            "Nazwisko: " + personInfoObject.PersonSurname + '\n' +
            "Rasa: " + raceInfoObject.RaceName + '\n' +
            "Frakcja: " + fractionInfoObject.FractionName + '\n' +
            "Frakcja(wiara): " + fractionInfoObject.Faith + '\n';
            button.SetActive(true);
        }
    }
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
