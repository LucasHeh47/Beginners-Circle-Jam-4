using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedWeapon : MonoBehaviour
{

    public SpriteRenderer weaponSprite;


    public Weapon[] weapons;

    public Weapon equipped;

    void Start()
    {
        SetEquipped(weapons[0]);
        Debug.Log(equipped.name + " " + equipped.Damage);
    }

    void Update()
    {
        
    }

    public void SetEquipped(Weapon weapon)
    {
        equipped = weapon;
        weaponSprite.sprite = weapon.WeaponImage;
    }

    private Weapon GetByName(string name)
    {
        foreach (Weapon weapon in weapons)
        {
            if (weapon.name.Equals(name)) return weapon;
        }
        Debug.Log("Weapon not found! SelectedWeapon.cs / GetByName()");
        return null;
    }

}
