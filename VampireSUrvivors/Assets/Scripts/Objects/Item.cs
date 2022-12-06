using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemStats
{
    public int armor;

    internal void Sum(ItemStats stats)
    {
        armor += stats.armor;
    }
}





[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string Name;
    public ItemStats stats;

    public void Equip(Character character)
    {
        character.armor += stats.armor;
    }

    public void UnEquip(Character character)
    {
        character.armor -= stats.armor;   
    }
}
