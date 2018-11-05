namespace Utilities.Interfaces
{
    public interface IMaps
    {
        void makeOffensiveUnitPath();
        void wave();
        void callWave();
        void placeDefensiveUnit();

        string nameMap;
        int tilesTypes;
        IDefensiveUnit IDefensiveUnit;
        IOffensiveUnit IOffensiveUnit;
        int baseTile;
        int spawnTile;

    }
}