using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public Enemy enemy;

    public float health;

    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        health = enemy.Health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float dmg)
    {
        health -= dmg;
        if(health <= 0)
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
