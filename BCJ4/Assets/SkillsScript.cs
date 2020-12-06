using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillsScript : MonoBehaviour
{

    public GameObject skillsScreen;

    public TextMeshProUGUI pointsCountText;

    public TextMeshProUGUI HPText;
    public TextMeshProUGUI DMGText;
    public TextMeshProUGUI SPDText;


    // Start is called before the first frame update
    void Start()
    {
        FixText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FixText()
    {
        pointsCountText.SetText("Skill Points: \n" + PlayerSkillPoints.Instance.skillPoints);
        Debug.Log("Fix Text");
        HPText.SetText("HP: " + PlayerSkillPoints.Instance.hp);
        DMGText.SetText("Dmg: " + PlayerSkillPoints.Instance.dmg);
        SPDText.SetText("Spd: " + PlayerSkillPoints.Instance.speed);
    }

    public void ToggleSkills()
    {
        skillsScreen.SetActive(!skillsScreen.activeSelf);
    }

    public void PurchaseHP()
    {
        if(PlayerSkillPoints.Instance.skillPoints >= 1)
        {
            PlayerSkillPoints.Instance.DecrementPoints();
            PlayerSkillPoints.Instance.IncrementHp();
            FixText();
        }
    }

    public void PurchaseDmg()
    {
        if (PlayerSkillPoints.Instance.skillPoints >= 1)
        {
            PlayerSkillPoints.Instance.DecrementPoints();
            PlayerSkillPoints.Instance.IncrementDmg();
            FixText();
        }
    }

    public void PurchaseSpeed()
    {
        if (PlayerSkillPoints.Instance.skillPoints >= 1)
        {
            PlayerSkillPoints.Instance.DecrementPoints();
            PlayerSkillPoints.Instance.IncrementSpeed();
            FixText();
        }
    }


}
