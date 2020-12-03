using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{

    public Slider healthbar;
    public TextMeshProUGUI healthText;

    [HideInInspector]
    public Transform PlayerPosition;

    public static PlayerHealth Instance;

    public bool isDead = false;

    public float maxHealth = 25;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        PlayerPosition = transform;
        healthbar.maxValue = maxHealth;
        healthbar.value = maxHealth;
    }

    public void Heal(float health)
    {
        healthbar.value += health;
        if (healthbar.value >= healthbar.maxValue)
        {
            healthbar.value = healthbar.maxValue;
        }
        healthText.SetText(healthbar.value.ToString());
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
        PlayerPosition = transform;
    }
    
    public void CollectHeart()
    {
        healthbar.value = healthbar.maxValue;
        healthText.SetText(healthbar.value.ToString());
    }

}
