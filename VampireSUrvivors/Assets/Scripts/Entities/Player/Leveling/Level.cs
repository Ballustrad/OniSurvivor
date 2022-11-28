using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    int level = 1;
    int experience = 0;
    [SerializeField] ExperienceBar experienceBar;

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
            experience -= To_Level_Up;
            level += 1;
            experienceBar.SetLevelText(level); 
        }
    }
}
