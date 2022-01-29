using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharactersColors
{
    public static Dictionary<string, Color> GetPoorClothesColorsDict()
    {
        Dictionary<string, Color> dict = new Dictionary<string, Color>();

        dict.Add("none", Color.clear);
        dict.Add("light brown", new Color(0.858f, 0.662f, 0.478f));
        dict.Add("brown", new Color(0.615f, 0.423f, 0.262f));
        dict.Add("deep brown", new Color(0.407f, 0.168f, 0.074f));
        dict.Add("light grey", new Color(0.572f, 0.541f, 0.478f));
        dict.Add("grey", new Color(0.513f, 0.478f, 0.423f));
        dict.Add("dirty white", new Color(0.921f, 0.803f, 0.749f));
        dict.Add("grey blue", new Color(0.254f, 0.294f, 0.337f));
        dict.Add("grey pink", new Color(0.407f, 0.168f, 0.074f));

        return dict;
    }

    public static Dictionary<string, Color> GetNobelClothesColorsDict()
    {
        Dictionary<string, Color> dict = new Dictionary<string, Color>();

        dict.Add("none", Color.clear);
        dict.Add("crimson", new Color(0.858f, 0.662f, 0.478f));
        dict.Add("red pink", new Color(0.454f, 0.133f, 0.235f));
        dict.Add("emerald", new Color(0.109f, 0.447f, 0.325f));
        dict.Add("dark red", new Color(0.364f, 0.184f, 0.180f));
        dict.Add("purple", new Color(0.329f, 0.156f, 0.372f));

        return dict;
    }

    public static Dictionary<string, Color> GetHumanHairColorsDict()
    {
        Dictionary<string, Color> dict = new Dictionary<string, Color>();

        dict.Add("none", Color.clear);
        dict.Add("black", new Color(0.145f, 0.133f, 0.133f));
        dict.Add("deep brown", new Color(0.262f, 0.184f, 0.137f));
        dict.Add("Medium brown", new Color(0.478f, 0.290f, 0.180f));
        dict.Add("brown", new Color(0.537f, 0.345f, 0.141f));
        dict.Add("light brown", new Color(0.741f, 0.525f, 0.298f));
        dict.Add("chestnut brown", new Color(0.654f, 0.243f, 0.125f));
        dict.Add("red", new Color(0.976f, 0.741f, 0.203f)); 
        dict.Add("orange red", new Color(0.980f, 0.572f, 0.2f));
        dict.Add("copper", new Color(0.811f, 0.325f, 0.047f));
        dict.Add("titan", new Color(0.745f, 0.360f, 0.015f));
        dict.Add("strawberry blond", new Color(0.968f, 0.682f, 0.031f));
        dict.Add("light blond", new Color(0.988f, 0.941f, 0.694f));
        dict.Add("golden blond", new Color(0.952f, 0.929f, 0.509f));
        dict.Add("medium blond", new Color(0.968f, 0.949f, 0.290f));
        dict.Add("grey", new Color(0.823f, 0.823f, 0.815f));
        dict.Add("white", new Color(0.964f, 0.964f, 0.952f));
        //dict.Add("deep purple", new Color(0.384f, 0.031f, 0.549f));

        return dict;
    }

    internal static Dictionary<string, Color> GetKhajiitSkinColorsDict()
    {
        throw new NotImplementedException();
    }

    internal static Dictionary<string, Color> GetElfSkinColorsDict()
    {
        throw new NotImplementedException();
    }

    internal static Dictionary<string, Color> GetElfHairColorsDict()
    {
        throw new NotImplementedException();
    }

    internal static Dictionary<string, Color> GetKhajiitHairColorsDict()
    {
        throw new NotImplementedException();
    }

    internal static Dictionary<string, Color> GetOrcHairColorsDict()
    {
        Dictionary<string, Color> dict = new Dictionary<string, Color>();

        dict.Add("none", Color.clear);
        dict.Add("black", new Color(0.145f, 0.133f, 0.133f));
        dict.Add("deep brown", new Color(0.262f, 0.184f, 0.137f));
        dict.Add("Medium brown", new Color(0.478f, 0.290f, 0.180f));
        dict.Add("brown", new Color(0.537f, 0.345f, 0.141f));
        dict.Add("light brown", new Color(0.741f, 0.525f, 0.298f));
        dict.Add("chestnut brown", new Color(0.654f, 0.243f, 0.125f));

        return dict;
    }

    public static Dictionary<string, Color> GetHumanSkinColorsDict()
    {
        Dictionary<string, Color> dict = new Dictionary<string, Color>();

        dict.Add("none", Color.clear);
        dict.Add("pale white", new Color(0.992f, 0.976f, 0.909f));
        dict.Add("fair", new Color(0.980f, 0.949f, 0.8f));
        dict.Add("medium white", new Color(0.952f, 0.886f, 0.647f));
        dict.Add("light brown", new Color(0.945f, 0.752f, 0.454f));
        dict.Add("olive", new Color(0.905f, 0.819f, 0.333f));
        dict.Add("moderate brown", new Color(0.878f, 0.572f, 0.043f));
        dict.Add("brown", new Color(0.796f, 0.443f, 0.003f));
        dict.Add("dark brown", new Color(0.568f, 0.286f, 0.011f));
        dict.Add("black", new Color(0.392f, 0.203f, 0.007f));

        return dict;
    }

    public static Dictionary<string, Color> GetOrcSkinColorsDict()
    {
        Dictionary<string, Color> dict = new Dictionary<string, Color>();

        dict.Add("orcish light green", new Color(0.509f, 0.760f, 0.039f));
        dict.Add("orcish green", new Color(0.258f, 0.592f, 0.047f));
        dict.Add("orcish deep green", new Color(0.098f, 0.427f, 0.011f));
        dict.Add("orcish blue", new Color(0.011f, 0.670f, 0.478f));

        return dict;
    }

    public static Dictionary<string, Color> GetPupilColorsDict()
    {
        Dictionary<string, Color> dict = new Dictionary<string, Color>();

        dict.Add("none", Color.clear);
        dict.Add("blue", new Color(0.521f, 0.709f, 0.996f));
        dict.Add("brown", new Color(0.564f, 0.294f, 0.015f));
        dict.Add("green", new Color(0.513f, 0.713f, 0.407f));
        dict.Add("hazel", new Color(0.733f, 0.698f, 0.388f));
        dict.Add("amber", new Color(0.870f, 0.415f, 0.129f));
        dict.Add("grey", new Color(0.650f, 0.650f, 0.650f));
       
        return dict;
    }
}
