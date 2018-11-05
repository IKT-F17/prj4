namespace Utilities.Interfaces
{
    public interface IDefensiveUnit//Tower
    {
        
        void upgradUnit();
        void degradUnit();
        void location();

        string nameDefensiveUnit { get; set; } //
        int defendPower { get; set; }//How hard can it hit
        int defendType { get; set; }//What type of deffens
        int range { get; set; }//How far
        int upgradPrice { get; set; }//How much
        int degradPrice { get; set; }
        int defensiveTiles { get; set; }//where to place?
        
    }
}