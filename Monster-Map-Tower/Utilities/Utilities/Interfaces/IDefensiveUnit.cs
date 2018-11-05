namespace Utilities.Interfaces
{
    public interface IDefensiveUnit//Tower
    {
        
        void upgradUnit();
        void degradUnit();
        void location();

        string nameDefensiveUnit;//
        int defendPower;//How hard can it hit
        int defendType;//What type of deffens
        int range;//How far
        int upgradPrice;//How much
        int degradPrice;
        int defensiveTiles;//where to place?
        
    }
}