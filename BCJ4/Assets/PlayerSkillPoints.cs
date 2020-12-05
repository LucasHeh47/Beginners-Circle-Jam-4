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

    // Update is called once per frame
    void Update()
    {
        
    }
}
