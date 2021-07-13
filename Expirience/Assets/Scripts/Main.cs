using UnityEngine;


public class Main : MonoBehaviour
{
    [SerializeField] private Transform _placeForUi;

    private void Start()
    {
        var playerInitializer = new PlayerInitializer();
        var player = playerInitializer.InitializePlayer();
        var experienceCollector = new ExperienceCollector(player.Experience, _placeForUi);
        var experienceUpdater = new ExperienceUpdater(_placeForUi, player.Experience);
        experienceCollector.Activate();
        experienceUpdater.Activate();
    }
}

