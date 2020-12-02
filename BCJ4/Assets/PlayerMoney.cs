using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{

    public static PlayerMoney Instance;

    public float money;

    public float moneyPerCoin = 10;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectCoin()
    {
        money += (moneyPerCoin * ((float)PlayerExperience.Instance.level / 1.5f));
    }
}
