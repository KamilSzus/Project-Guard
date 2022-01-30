using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CharacterSpriteRenderer : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public spriteType sprite = spriteType.random;

    public factions faction = factions.all;
    public races race = races.all;
    public genders gender = genders.all;

    public primaryColorType primaryColor = primaryColorType.poorPallet;
    public secondaryColorType secondaryColor = secondaryColorType.poorPallet;

    public bool includeNoneOptions = true;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        switch (sprite)
        {
            case spriteType.random:
                DisplayNewCharacter();
                break;
            case spriteType.wrzod:
                SetSprite(Resources.Load<Texture2D>(SpritesMetaData.spriteAssetsFolderName + "/wrzod"));
                break;
            case spriteType.ghost:
                SetSprite(Resources.Load<Texture2D>(SpritesMetaData.spriteAssetsFolderName + "/ghost"));
                break;
        }

        GameObject button = GameObject.Find("ExitPassButton");
        if (button != null)
            button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisplayNewCharacter()
    {
        CharcterSpriteManager character = new CharcterSpriteManager();

        character.characterFaction = faction.ToString();
        character.characterRace = race.ToString();
        character.characterSex = gender.ToString();
        character.withoutNone = !includeNoneOptions;

        character.GenerateRandomSprite();

        switch (race)
        {
            case races.all:
                character.characterHairColor = RandomValue(CharactersColors.GetHumanHairColorsDict()); //Color.clear;
                character.characterSkinColor = RandomValue(CharactersColors.GetHumanSkinColorsDict()); //Color.clear;
                break;
            case races.human:
                character.characterHairColor = RandomValue(CharactersColors.GetHumanHairColorsDict());
                character.characterSkinColor = RandomValue(CharactersColors.GetHumanSkinColorsDict());
                break;
            case races.orc:
                character.characterHairColor = RandomValue(CharactersColors.GetOrcHairColorsDict());
                character.characterSkinColor = RandomValue(CharactersColors.GetOrcSkinColorsDict());
                break;
            case races.elf:
                character.characterHairColor = RandomValue(CharactersColors.GetElfHairColorsDict());
                character.characterSkinColor = RandomValue(CharactersColors.GetElfSkinColorsDict());
                break;
            case races.khajiit:
                character.characterHairColor = RandomValue(CharactersColors.GetKhajiitHairColorsDict());
                character.characterSkinColor = RandomValue(CharactersColors.GetKhajiitSkinColorsDict());
                break;
        }
 
        character.characterPupilColor = RandomValue(CharactersColors.GetPupilColorsDict());

        switch (primaryColor)
        {
            case primaryColorType.poorPallet:
                character.characterPrimaryColor = RandomValue(CharactersColors.GetPoorClothesColorsDict());
                break;
            case primaryColorType.richPallet:
                character.characterPrimaryColor = RandomValue(CharactersColors.GetNobelClothesColorsDict());
                break;
        }

        switch (secondaryColor)
        {
            case secondaryColorType.poorPallet:
                character.characterSceondaryColor = RandomValue(CharactersColors.GetPoorClothesColorsDict());
                break;
            case secondaryColorType.richPallet:
                character.characterSceondaryColor = RandomValue(CharactersColors.GetNobelClothesColorsDict());
                break;
        }

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

    public enum factions
    {
        all,
        peasants,
        nobility,
        outlaw,
        townsman,
        traveller,
        bandits
    }

    public enum races
    {
        all,
        human,
        orc,
        elf,
        khajiit
    }

    public enum genders
    {
        all,
        male,
        KOBIETAXD
    }

    public enum primaryColorType
    {
        poorPallet,
        richPallet
    }

    public enum secondaryColorType
    {
        poorPallet,
        richPallet
    }

    public enum spriteType
    {
        random,
        wrzod,
        ghost
    }
}
