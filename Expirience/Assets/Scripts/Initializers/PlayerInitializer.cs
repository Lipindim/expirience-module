public class PlayerInitializer
{
    private int[] _levelMap = new int[] { 0, 10, 20, 40, 100, 250, 1000 };

    public Player InitializePlayer()
    {
        var experience = new Experience(_levelMap);
        var player = new Player(experience);
        return player;
    }
}

