using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

    public Enemy enemy;

    public GameObject healthBarObj;
    private Slider healthBar;

    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = healthBarObj.GetComponent<Slider>();
        healthBar.maxValue = enemy.Health;
        healthBar.value = enemy.Health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBarObj.transform.position = Camera.main.WorldToScreenPoint(new Vector3(transform.position.x, transform.position.y+0.75f, transform.position.z));
    }

    public void TakeDamage(float dmg)
    {
        healthBar.value -= dmg;
        if(healthBar.value <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        for (int i = 0; i < enemy.CoinDropAmount; i++)
        {
            GameObject newCoin = Instantiate(coin);
            newCoin.transform.position = gameObject.transform.position;
        }
        Destroy(gameObject);
        PlayerAttack.Instance.EnemyKilled(enemy);
        PlayerHealth.Instance.Heal(enemy.Health/2);
    }

}
