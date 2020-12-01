using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedWeapon : MonoBehaviour
{

    public SpriteRenderer weaponSprite;

    public static SelectedWeapon Instance;

    public Weapon[] weapons;

    public Weapon equipped;

    void Start()
    {
        Instance = this;
        SetEquipped(weapons[1]);
        Debug.Log(equipped.name + " " + equipped.Damage);
    }

    void Update()
    {
        
    }

    public void SetEquipped(Weapon weapon)
    {
        equipped = weapon;
        SetUpPlayerAttack();
        weaponSprite.sprite = weapon.WeaponImage;
    }

    private Weapon GetByName(string name)
    {
        foreach (Weapon weapon in weapons)
        {
            if (weapon.name.Equals(name)) return weapon;
        }
        return null;
    }

    private void SetUpPlayerAttack()
    {
        PlayerAttack.Instance.equipped = equipped;
        PlayerAttack.Instance.damage = equipped.Damage;
        PlayerAttack.Instance.useRate = equipped.UseRate;
        PlayerAttack.Instance.range = equipped.Range;
        PlayerAttack.Instance.unlocked = equipped.Unlocked;
    }

}
