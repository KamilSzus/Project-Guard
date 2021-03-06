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
    public string sexFilter { get; set; }
    public string raceFilter { get; set; }
    public string factionFilter { get; set; }
    public bool withoutNone { get; set; } = false;

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
            XmlNode randomNode = RandomizeType(node);
            if (randomNode != null)
            {
                allSelectedTypes.Add(randomNode);

                RecursiveCharacterPartsAdder(nodePath + "/type[@directoryName='"
                    + randomNode.Attributes["directoryName"].Value + "']/partsParents/partTypes");
            } 
        }
    }

    private XmlNode RandomizeType(XmlNode node)
    {
        string filter = CreateFilterString();
        string stringPath = "type" + filter;
        XmlNodeList xmlNodeList = node.SelectNodes(stringPath);

        if (xmlNodeList.Count > 0)
        {
            int randomNumber = Random.Range(0, xmlNodeList.Count);
            XmlNode randomNode = xmlNodeList[randomNumber];

            Debug.Log($"Selected {randomNode.Attributes["directoryName"].Value}");
            return randomNode;
        } 
        else
        {
            Debug.Log("Didn't find any types for "+ node.Attributes["directoryName"].Value + " with following filters: sex=" + sexFilter + " race=" + raceFilter + " faction=" + factionFilter);
            return null;
        }
    }

    private string CreateFilterString()
    {
        if (sexFilter == "all" && raceFilter == "all" && factionFilter == "all")
            return "";

        string filter = "[";
        if (sexFilter != "all")
            filter += "(@Sex='" + sexFilter + "' " + "or @Sex='any')";
        if (raceFilter != "all")
        {
            if (sexFilter != "all")
                filter += "and ";
            filter += "(@Race='" + raceFilter + "' " + "or @Race='any')";
        }
        if (factionFilter != "all")
        {
            if (raceFilter != "all" || sexFilter != "all")
                filter += "and ";
            filter += "(@Faction='" + factionFilter + "' " + "or @Faction='any')";
        }
        if (withoutNone)
        {
            if (raceFilter != "all" || sexFilter != "all" || factionFilter != "all")
                filter += "and ";
            filter += "not(@None)";
        }
        filter += "]";
        return filter;
    }

}
