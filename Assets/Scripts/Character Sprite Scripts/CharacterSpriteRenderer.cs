using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CharacterSpriteRenderer : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisplayNewCharacter()
    {
        CharcterSpriteManager character = new CharcterSpriteManager();
        character.characterHairColor = RandomValue(CharactersColors.GetHumanHairColorsDict());
        character.characterSkinColor = RandomValue(CharactersColors.GetHumanSkinColorsDict());
        character.characterPupilColor = RandomValue(CharactersColors.GetPupilColorsDict());
        character.characterPrimaryColor = RandomValue(CharactersColors.GetPoorClothesColorsDict());
        character.characterSceondaryColor = RandomValue(CharactersColors.GetPoorClothesColorsDict());
        character.characterFaction = "bandits";

        character.GenerateRandomSprite();
        Texture2D texture = character.CreateSpriteTexture();
        SetSprite(texture);
    }

    public void SetSprite(Texture2D texture)
    {
        texture.wrapMode = TextureWrapMode.Clamp;
        texture.filterMode = FilterMode.Bilinear;

        spriteRenderer.sprite = Sprite.Create(texture, new Rect(0, 0, SpritesMetaData.spritePixelWidth, SpritesMetaData.spritePixelHeight), Vector2.one * 0.5f);
    }

    private Color RandomValue(Dictionary<string, Color> dict)
    {
        List<string> keyList = new List<string>(dict.Keys);
        string randomKey = keyList[UnityEngine.Random.Range(0, keyList.Count)];
        return dict[randomKey];
    }
}
