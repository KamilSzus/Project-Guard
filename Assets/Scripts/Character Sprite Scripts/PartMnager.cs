using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;


public class PartManager
{
    XmlNode partNode;
    public Color skinColor { get; set; } = Color.clear;
    public Color hairColor { get; set; } = Color.clear;
    public Color pupilColor { get; set; } = Color.clear;
    public Color primaryColor { get; set; } = Color.clear;
    public Color secondaryColor { get; set; } = Color.clear;

    public PartManager(XmlNode partNode)
    {
        this.partNode = partNode;
    }

    public Texture2D mergeLayers()
    {
        Texture2D mergedTexture = new Texture2D(SpritesMetaData.spritePixelWidth, SpritesMetaData.spritePixelHeight);
        Color[] transparentBackground = new Color[SpritesMetaData.spritePixelWidth * SpritesMetaData.spritePixelHeight];
        for (int i = 0; i < transparentBackground.Length; i++)
        {
            transparentBackground[i] = Color.clear;
        }
        mergedTexture.SetPixels(transparentBackground);
        mergedTexture.Apply();

        string resourcePath = GetNodeResourcePath(partNode);

        XmlNodeList layers = partNode.SelectNodes("layers/layer");

        foreach (XmlNode layer in layers)
        {
            string textureLayerPath = "Character_Assets_Structure/" + resourcePath + layer["filename"].InnerText;
            Texture2D textureLayer = Resources.Load<Texture2D>(textureLayerPath);

            Color[] newPixels = mergedTexture == null ? new Color[textureLayer.width * textureLayer.height] : mergedTexture.GetPixels();
            Color[] layerPixels = PixelsOperations.DuplicateTexture(textureLayer).GetPixels();

            Blend blend;

            if (layer.Attributes["colorMode"] != null)
            {
                if (layer.Attributes["colorMode"].Value == "normal")
                    blend = PixelsOperations.BlendNormal;
                else if (layer.Attributes["colorMode"].Value == "multiply")
                    blend = PixelsOperations.BlendMultiply;
                else
                    throw new System.Exception($"There is no {layer.Attributes["colorMode"].Value} colorMode, error catched with layer: {layer}");

                if (skinColor != Color.clear && layer.Attributes["skin"] != null && layer.Attributes["skin"].Value == "True")
                    layerPixels = ColorLayer(layerPixels, skinColor, blend, textureLayer.width, textureLayer.height);

                if (hairColor != Color.clear && layer.Attributes["hair"] != null && layer.Attributes["hair"].Value == "True")
                    layerPixels = ColorLayer(layerPixels, hairColor, blend, textureLayer.width, textureLayer.height);

                if (pupilColor != Color.clear && layer.Attributes["pupil"] != null && layer.Attributes["pupil"].Value == "True")
                    layerPixels = ColorLayer(layerPixels, pupilColor, blend, textureLayer.width, textureLayer.height);

                if (primaryColor != Color.clear && layer.Attributes["primary"] != null && layer.Attributes["primary"].Value == "True")
                    layerPixels = ColorLayer(layerPixels, primaryColor, blend, textureLayer.width, textureLayer.height);

                if (secondaryColor != Color.clear && layer.Attributes["secondary"] != null && layer.Attributes["secondary"].Value == "True")
                    layerPixels = ColorLayer(layerPixels, secondaryColor, blend, textureLayer.width, textureLayer.height);
            }

            if (layer.Attributes["blendMode"].Value == "normal")
                blend = PixelsOperations.BlendNormal;
            else if (layer.Attributes["blendMode"].Value == "multiply")
                blend = PixelsOperations.BlendMultiply;
            else
                throw new System.Exception($"There is no {layer.Attributes["blendMode"].Value} blendMode, error catched with layer: {layer}");

            newPixels = ColorLayer(newPixels, layerPixels, blend, textureLayer.width, textureLayer.height);

            mergedTexture.SetPixels(newPixels);
            mergedTexture.Apply();
        }

        return mergedTexture;
    }

    private Color[] ColorLayer(Color[] layer, Color toColor, Blend blendType, int width, int height)
    {
        Color[] newLayer = (Color[]) layer.Clone();

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                int pixelIndex = x + (y * width);

                if (newLayer[pixelIndex].a > 0)
                    newLayer[pixelIndex] = blendType(layer[pixelIndex], toColor);
            }
        }

        return newLayer;
    }

    private Color[] ColorLayer(Color[] bottomLayer, Color[] layer, Blend blendType, int width, int height)
    {
        Color[] newLayer = (Color[])bottomLayer.Clone();

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                int pixelIndex = x + (y * width);

                if (layer[pixelIndex].a > 0)
                {
                    Color newColor = blendType(bottomLayer[pixelIndex], layer[pixelIndex]);
                    if (bottomLayer[pixelIndex] != Color.clear)
                        newColor.a = 1;
                    newLayer[pixelIndex] = newColor;
                }
                    
            }
        }

        return newLayer;
    }

    private string GetNodeResourcePath(XmlNode element)
    {
        if (element.Name == "characters")
            return element.Attributes["directoryName"].Value + "/";

        XmlNode parentElement = element.ParentNode;

        if (element.Name == "partsParents")
            return GetNodeResourcePath(parentElement);

        string path = element.Attributes["directoryName"].Value + "/";

        if (parentElement != null)
        {
            return GetNodeResourcePath(parentElement) + path;
        }

        return path;
    }

    private delegate Color Blend(Color c1, Color c2);
}

