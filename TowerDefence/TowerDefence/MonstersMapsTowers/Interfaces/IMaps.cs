﻿using System.Dynamic;
using MonstersMapsTowers.Interfaces;

namespace MonstersMapsTowers.Interfaces
{
    public interface IMaps
    {
        void makeOffensiveUnitPath();
        void wave();
        void callWave();
        void placeDefensiveUnit();

        string nameMap { get; set; }
        int tilesTypes { get; set; }
        int baseTile { get; set; }
        int spawnTile { get; set; }

    }
}