using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsButton : MonoBehaviour
{
    public GameObject stats;

    public void StatsButtonClick()
    {
        stats.SetActive(!stats.activeSelf);
    }
}
