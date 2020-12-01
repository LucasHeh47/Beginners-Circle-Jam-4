using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{

    public Slider healthbar;
    public TextMeshProUGUI healthText;

    public bool isDead = false;

    public float maxHealth = 25;

    // Start is called before the first frame update
    void Start()
    {
        healthbar.maxValue = maxHealth;
        healthbar.value = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        healthbar.value -= damage;
        healthText.SetText(healthbar.value.ToString());
        if(healthbar.value <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        isDead = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
