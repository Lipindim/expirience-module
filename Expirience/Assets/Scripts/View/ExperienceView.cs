using UnityEngine;
using UnityEngine.UI;


public class ExperienceView : MonoBehaviour
{
    [SerializeField] private Text _experienceValue;
    [SerializeField] private Text _levelValue;

    public Text ExperienceValue => _experienceValue;
    public Text LevelValue => _levelValue;
}

