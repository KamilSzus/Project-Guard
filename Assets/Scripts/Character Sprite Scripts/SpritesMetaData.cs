using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesMetaData
{
    public static int spritePixelWidth { get; } = 256;
    public static int spritePixelHeight { get; } = 256;

    public static string spriteAssetsFolderName { get; } = "Character_Assets_Structure";
    public static string XMLLayersFilePath { get; } = spriteAssetsFolderName + "/sprite_layers";
}
