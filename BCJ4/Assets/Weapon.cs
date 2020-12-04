using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class Weapon : ScriptableObject
{

    public enum type { Melee, Ranged, None };

    public type WeaponType;

    public float Damage;

    public float UseRate;

    public float Range;

    public Sprite WeaponImage;

    public Sprite ProjectileImage;

    public GameObject WeaponObject;

    public bool Unlocked;

    public float Price;

    public int levelToUnlock;

    public void Unlock()
    {
        Unlocked = true;
    }

    public void Lock()
    {
        Unlocked = false;
    }


}
