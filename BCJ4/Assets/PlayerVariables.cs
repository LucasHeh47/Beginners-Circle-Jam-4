using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVariables
{

    public static PlayerVariables Instance;

    public float money;

    void Start()
    {
        Instance = this;
    }

}
