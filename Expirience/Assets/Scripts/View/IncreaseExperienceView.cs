using UnityEngine;
using UnityEngine.UI;


public class IncreaseExperienceView : MonoBehaviour
{
    [SerializeField] private Button _increaseExperience;
    [SerializeField] private InputField _experienceValue;

    public Button IncreaseExperience => _increaseExperience;
    public InputField ExperienceValue => _experienceValue;
}

