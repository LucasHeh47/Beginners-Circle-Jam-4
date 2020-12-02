using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{

    public TextMeshProUGUI expText;
    public TextMeshProUGUI expNeededText;
    public TextMeshProUGUI totalExpText;
    public TextMeshProUGUI dmgText;
    public TextMeshProUGUI atkRateText;
    public TextMeshProUGUI moneyText;

    void Start()
    {
        
    }

    void Update()
    {
        if (PlayerExperience.Instance != null && PlayerAttack.Instance != null)
        {
            expText.SetText("Exp: " + PlayerExperience.Instance.experience);
            expNeededText.SetText("Exp Needed: " + PlayerExperience.Instance.expNeededToLevelUp);
            totalExpText.SetText("Total Exp: " + PlayerExperience.Instance.totalExp);
            dmgText.SetText("Dmg: " + PlayerAttack.Instance.equipped.Damage);
            atkRateText.SetText("Atk Rate: " + PlayerAttack.Instance.equipped.UseRate);
            moneyText.SetText("Money: " + PlayerMoney.Instance.money.ToString());
        }
    }
}
