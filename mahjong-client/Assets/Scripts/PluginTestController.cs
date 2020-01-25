﻿using UnityEngine;

namespace Synapse.Mahjong
{
    public class PluginTestController : MonoBehaviour
    {
        private void Start()
        {
            var tilesetJson = global::Mahjong.GenerateTilesetJson();
            Debug.Log(tilesetJson, this);
            Debug.Log(global::Mahjong.TilesetSize(), this);
            Debug.Log(global::Mahjong.Square(25), this);
        }
    }
}