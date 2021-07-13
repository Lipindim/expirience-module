using UnityEngine;


public class ExperienceCollector : BaseController<IncreaseExperienceView>
{
    private readonly Experience _experience;
    private readonly Transform _placeForUi;
   

    protected override string _viewPath => "Prefabs/UI/IncreaseExperience";

    public ExperienceCollector(Experience experience, Transform placeForUi)
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
        _view.IncreaseExperience.onClick.AddListener(IncreaseExperience);
    }

    private void IncreaseExperience()
    {
        int value = int.Parse(_view.ExperienceValue.text);
        _experience.GainExperience(value);
    }
}

