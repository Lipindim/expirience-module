using System;
using System.Linq;


public class Experience
{
    public int Level { get; private set; }
    public int TotalExperience { get; private set; }

    public event Action<int> LevelUp;
    public event Action<int> ExperienceGained;

    private int[] _levelMap;

    public Experience(int[] levelMap)
    {
        _levelMap = levelMap;

        UpdateLevel();
    }

    public void GainExperience(int experiecne)
    {
        TotalExperience += experiecne;
        ExperienceGained?.Invoke(TotalExperience);
        UpdateLevel();
    }

    private void UpdateLevel()
    {
        while (ReadyNewLevel())
        {
            Level++;
            LevelUp?.Invoke(Level);
        }
    }

    private bool ReadyNewLevel()
    {
        int calculateLevel = _levelMap.Count(x => x <= TotalExperience);
        return calculateLevel > Level;
    }
}
