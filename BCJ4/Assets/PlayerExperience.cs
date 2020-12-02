using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerExperience : MonoBehaviour
{
    public static PlayerExperience Instance;

    public float multiplier = 1.2f;
    public float expNeededToLevelUp = 20;

    public Slider slider;
    public TextMeshProUGUI levelText;
    public ParticleSystem particles;

    public int maxLevel = 250;
    public int level = 1;
    public float totalExp = 0;
    public float experience = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        slider.value = experience;
        slider.maxValue = expNeededToLevelUp;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddExperience(int exp)
    {
        experience += exp;
        totalExp += exp;
        slider.value = experience;
        if (experience >= expNeededToLevelUp)
        {
            LevelUp();
        }
    }

    public bool LevelUp()
    {
        if(experience < expNeededToLevelUp || level == maxLevel)
        {
            return false;
        }
        experience -= expNeededToLevelUp;
        expNeededToLevelUp = (expNeededToLevelUp * multiplier);
        particles.Play();
        level++;
        slider.maxValue = expNeededToLevelUp;
        slider.value = experience;
        levelText.SetText(level.ToString());
        return true;
    }
}
