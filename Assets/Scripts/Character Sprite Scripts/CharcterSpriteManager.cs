using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class CharcterSpriteManager
{
    public Color characterHairColor { get; set; } = Color.clear;
    public Color characterSkinColor { get; set; } = Color.clear;
    public Color characterPupilColor { get; set; } = Color.clear;
    public Color characterPrimaryColor { get; set; } = Color.clear;
    public Color characterSceondaryColor { get; set; } = Color.clear;

    public string characterSex { get; set; } = "all";
    public string characterRace { get; set; } = "all";
    public string characterFaction { get; set; } = "all";
    //private string characterEmotion = "any"; //Not used

    public bool withoutNone { get; set; } = false;

    List<XmlNode> nodes = null;

    public CharcterSpriteManager() { }

    public void GenerateRandomSprite()
    {
        LayersRandomizer layerRandomizer = new LayersRandomizer();

        layerRandomizer.sexFilter = characterSex;
        layerRandomizer.raceFilter = characterRace;
        layerRandomizer.factionFilter = characterFaction;
        layerRandomizer.withoutNone = withoutNone;

        nodes = layerRandomizer.GetRandomParts();
    }

    public Texture2D CreateSpriteTexture()
    {
        if (nodes == null)
            throw new UnityException("No layers were generated to create sprite");

        Texture2D[] layers = MergeAndColorParts(nodes);
        return MergeToOneSprite(layers);
    }

    private Texture2D[] MergeAndColorParts(List<XmlNode> parts)
    {
        List<Texture2D> textureParts = new List<Texture2D>();
        foreach (XmlNode part in parts)
        {
            PartManager partManager = new PartManager(part);

            partManager.skinColor = characterSkinColor;
            partManager.hairColor = characterHairColor;
            partManager.pupilColor = characterPupilColor;
            partManager.primaryColor = characterPrimaryColor;
            partManager.secondaryColor = characterSceondaryColor;

            textureParts.Add(partManager.mergeLayers());
        }
        return textureParts.ToArray();
    }

    private Texture2D MergeToOneSprite(Texture2D[] layers)
    {
        Texture2D finalTexture = new Texture2D(SpritesMetaData.spritePixelWidth, SpritesMetaData.spritePixelHeight);
        Color[] finalImage = new Color[SpritesMetaData.spritePixelWidth * SpritesMetaData.spritePixelHeight];

        foreach (Texture2D layer in layers)
        {
            MergeTexture2DToImage(ref finalImage, PixelsOperations.DuplicateTexture(layer));
        }

        finalTexture.SetPixels(finalImage);
        finalTexture.Apply();

        return finalTexture;
    }

    private void MergeTexture2DToImage(ref Color[] finalImage, Texture2D texture)
    {
        Color[] imageToMerge = texture.GetPixels();

        for (int x = 0; x < texture.width; x++)
        {
            for (int y = 0; y < texture.height; y++)
            {
                int pixelIndex = x + (y * texture.width);

                if (imageToMerge[pixelIndex].a == 1)
                {
                    finalImage[pixelIndex] = imageToMerge[pixelIndex];
                }
                else if (imageToMerge[pixelIndex].a > 0)
                {
                    finalImage[pixelIndex] = PixelsOperations.BlendNormal(finalImage[pixelIndex], imageToMerge[pixelIndex]);
                }
            }
        }
    }
}
