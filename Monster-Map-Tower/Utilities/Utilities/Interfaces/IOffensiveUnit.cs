namespace Utilities.Interfaces
{
    public interface IOffensiveUnit
    {
        void Path();
        void Immunites();

        string nameOffensiveUnit;//gobil, ponys,cats, Orgs
        int runSpeed;//offensive unit speed on map
        int reward;//reward for killing an offensive unit
        int hitPoints;//attack power
        int starTile;
        int offensiveTiles;
        int endTile;
    }
}