using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillPoints : MonoBehaviour
{

    public static PlayerSkillPoints Instance;

    public int skillPoints;

    public int dmg = 1, hp = 1, speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    public void DecrementPoints()
    {
        skillPoints--;
    }

    public void IncrementPoints()
    {
        skillPoints++;
    }

    public void IncrementDmg()
    {
        dmg++;
    }

    public void IncrementHp()
    {
        hp++;
    }

    public void IncrementSpeed()
    {
        speed++;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
