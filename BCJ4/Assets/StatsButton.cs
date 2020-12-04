using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsButton : MonoBehaviour
{
    public GameObject stats;

    public GameObject shop;

    public void StatsButtonClick()
    {
        stats.SetActive(!stats.activeSelf);
    }

    public void ShopButtonClick()
    {
        shop.SetActive(!shop.activeSelf);
    }
}
