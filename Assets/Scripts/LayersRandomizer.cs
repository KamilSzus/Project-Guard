using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;

public class LayersRandomizer
{
    XmlDocument xmlData;
    const string xmlPath = "Character_Assets_Structure/sprite_layers";
    List<XmlNode> allSelectedTypes = new List<XmlNode>();
    string sexFilter { get; set; }
    string raceFilter { get; set; }
    string factionFilter { get; set; }

    public LayersRandomizer(string sexFilter = "any", string raceFilter = "any", string factionFilter = "any")
    {
        TextAsset xmlText = Resources.Load<TextAsset>(xmlPath);
        xmlData = new XmlDocument();
        xmlData.LoadXml(xmlText.text);

        this.sexFilter = sexFilter;
        this.raceFilter = raceFilter;
        this.factionFilter = factionFilter;
    }

    public List<XmlNode> GetRandomParts()
    {
        RecursiveCharacterPartsAdder("/characters/partTypes");

        return allSelectedTypes;
    }

    private void RecursiveCharacterPartsAdder(string nodePath)
    {
        XmlNodeList rootList = xmlData.SelectNodes(nodePath);

        if (rootList == null)
            return;

        foreach (XmlNode node in rootList)
        {
            XmlNode randomNode = randomizeType(node);
            if (randomNode != null)
                allSelectedTypes.Add(randomNode);

            RecursiveCharacterPartsAdder(nodePath + "/type[@directoryName='" 
                + randomNode.Attributes["directoryName"].Value + "']/partsParents/partTypes");
        }
    }

    private XmlNode randomizeType(XmlNode node)
    {
        string stringPath = "type"; //[@Sex='" + sexFilter + "' and @Race='" + raceFilter + "' and @Faction='" + factionFilter + "']";
        XmlNodeList xmlNodeList = node.SelectNodes(stringPath);

        if (xmlNodeList.Count > 0)
        {
            System.Random random = new System.Random();
            int randomNumber = random.Next(0, xmlNodeList.Count - 1);
            XmlNode randomNode = xmlNodeList[randomNumber];

            Debug.Log($"Selected {randomNode.Attributes["directoryName"].Value}");
            return randomNode;
        } 
        else
        {
            Debug.Log("Didn't find any types for " + node.Attributes["ID"].Value + " with following filters: sex=" + sexFilter + "race=" + raceFilter + "faction=" + factionFilter);
            return null;
        }
    }
}
