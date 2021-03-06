﻿using System;
using System.Xml.Serialization;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "New Tile", menuName = "Game/Tile")]
public class TileInfo : ScriptableObject
{
    public string textureName;

    [XmlIgnore]
    [HideInInspector]
    public Texture texture;

    [HideInInspector]
    public bool moveableTile = false;
    [HideInInspector]
    public Vector2 tileMoveOffset = new Vector2();

    public TileInfo()
    { }

    // TODO Possible support for directional textures?
}
