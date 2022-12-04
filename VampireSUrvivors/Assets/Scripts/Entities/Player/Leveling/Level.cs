using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;

public class Level : MonoBehaviour
{
    int level = 1;
    int experience = 0;
    [SerializeField] ExperienceBar experienceBar;
    [SerializeField] UpgradePanelManager upgradePanel;

    [SerializeField] List<UpgradeData> upgrades;
    int To_Level_Up
    {
        get
        {
            return level * 1000;
        }
    }
    private void Start()
    {
        experienceBar.UpdateExperienceSlider(experience, To_Level_Up);
        experienceBar.SetLevelText(level);
    }

    public void AddExperience(int amount)
    {
        experience += amount;
        CheckLevelUp();
        experienceBar.UpdateExperienceSlider(experience, To_Level_Up);
    }

    public void CheckLevelUp()
    {
        if (experience >= To_Level_Up)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        upgradePanel.OpenPanel(GetUpgrades(4));
        experience -= To_Level_Up;
        level += 1;
        experienceBar.SetLevelText(level);
    }

    public List<UpgradeData> GetUpgrades(int count)
    {
        List<UpgradeData> upgradeList = new List<UpgradeData>();

        if (count > upgrades.Count)
        {
            count = upgrades.Count;
        }

        for (int i = 0; i < count; i++)
        {
            upgradeList.Add(upgrades[Random.Range(0, upgrades.Count)]);
        }
        

        return upgradeList;
    }
}
