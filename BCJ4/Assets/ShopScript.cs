using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopScript : MonoBehaviour
{

    private Weapon[] weapons;

    //Sword
    public Weapon sword;
    private float swordPrice;
    private int swordLevelReq;
    public TextMeshProUGUI swordText;

    //Hatchet
    public Weapon hatchet;
    private float hatchetPrice;
    private int hatchetLevelReq;
    public TextMeshProUGUI hatchetText;

    // Start is called before the first frame update
    void Start()
    {
        swordLevelReq = sword.levelToUnlock;
        swordPrice = sword.Price;

        hatchetLevelReq = hatchet.levelToUnlock;
        hatchetPrice = hatchet.Price;

        if (!sword.Unlocked)
        {
            swordText.SetText("Purchase Sword \n$" + swordPrice.ToString());
        }
        else
        {
            swordText.SetText("Already Purchased!");
        }

        if (!hatchet.Unlocked)
        {
            hatchetText.SetText("Purchase Hatchet \n$" + hatchetPrice.ToString());
        }
        else
        {
            hatchetText.SetText("Already Purchased!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwordPurchase()
    {
        if(PlayerMoney.Instance.money >= swordPrice && PlayerExperience.Instance.level >= swordLevelReq && !sword.Unlocked)
        {
            PlayerMoney.Instance.money -= swordPrice;
            sword.Unlock();
            swordText.SetText("Already Purchased!");
        }
    }

    public void HatchetPurchase()
    {
        if (PlayerMoney.Instance.money >= hatchetPrice && PlayerExperience.Instance.level >= hatchetLevelReq && !hatchet.Unlocked)
        {
            PlayerMoney.Instance.money -= hatchetPrice;
            hatchet.Unlock();
            hatchetText.SetText("Already Purchased!");
        }
    }
}
