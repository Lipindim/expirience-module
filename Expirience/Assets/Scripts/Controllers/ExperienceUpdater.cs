using UnityEngine;


public class ExperienceUpdater : BaseController<ExperienceView>
{
    private readonly Experience _experience;
    private readonly Transform _placeForUi;

    protected override string _viewPath => "Prefabs/UI/Experience";

    public ExperienceUpdater(Transform placeForUi, Experience experience)
    {
        _experience = experience;
        _placeForUi = placeForUi;
    }

    public void Activate()
    {
        LoadView(_placeForUi);
        Subscribe();
    }

    private void Subscribe()
    {
        _experience.ExperienceGained += OnExperienceGained;
        _experience.LevelUp += OnLevelUp;
    }

    private void OnLevelUp(int level)
    {
        _view.LevelValue.text = level.ToString();
    }

    private void OnExperienceGained(int experience)
    {
        _view.ExperienceValue.text = experience.ToString();
    }
}

