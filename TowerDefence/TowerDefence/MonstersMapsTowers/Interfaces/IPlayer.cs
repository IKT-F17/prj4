namespace MonstersMapsTowers.Interfaces
{
    public interface IPlayer
    {
        double bank { get; set; }
        int Highscore { get; set; }
        double updateBank(double sum);

    }
}