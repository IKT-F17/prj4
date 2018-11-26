namespace MonstersMapsTowers.Interfaces
{
    public interface IOffensiveUnit
    {
        void Path(int startTile, int endTile, int offensiveTiles);
        void Immunites();

        string nameOffensiveUnit { get; set; }//gobil, ponys,cats, Orgs
        int runSpeed { get; set; }//offensive unit speed on map
        int reward { get; set; }//reward for killing an offensive unit
        int hitPoints { get; set; }//attack power
        int startTile { get; set; }
        int offensiveTiles { get; set; }
        int endTile { get; set; }
    }
}