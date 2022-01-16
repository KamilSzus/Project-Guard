using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CharacterSpriteRenderer : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public Texture2D[] layersOfSprite;

    private Texture2D finalTexture;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        LayersRandomizer layersRandomizer = new LayersRandomizer();
        List<XmlNode> nodes = layersRandomizer.GetRandomParts();
        List<Texture2D> textureParts = new List<Texture2D>();
        foreach (XmlNode part in nodes)
        {
            PartManager partManager = new PartManager(part);
            textureParts.Add(partManager.mergeLayers());
        }
        layersOfSprite = textureParts.ToArray();

        ApplySprites();
        SetSprite(finalTexture);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ApplySprites()
    {
        Color[] finalImage = new Color[layersOfSprite[0].width * layersOfSprite[0].height];

        foreach (Texture2D layer in layersOfSprite)
        {
            MergeTexture2DToImage(ref finalImage, PixelsOperations.DuplicateTexture(layer));
        }

        this.finalTexture = new Texture2D(layersOfSprite[0].width, layersOfSprite[0].height);
        this.finalTexture.SetPixels(finalImage);

        this.finalTexture.Apply();
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

    public void SetSprite(Texture2D texture)
    {
        texture.wrapMode = TextureWrapMode.Clamp;
        texture.filterMode = FilterMode.Bilinear;

        spriteRenderer.sprite = Sprite.Create(texture, new Rect(0, 0, layersOfSprite[0].width, layersOfSprite[0].height), Vector2.one * 0.5f);
    }
}
