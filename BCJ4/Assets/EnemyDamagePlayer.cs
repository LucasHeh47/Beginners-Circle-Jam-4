using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamagePlayer : MonoBehaviour
{
    public static EnemyDamagePlayer Instance;

    public Transform player;
    public PlayerHealth playerHealth;

    public Enemy enemy;

    private float nextTimeToAttack;

    // enemy.WeaponType == Enemy.type.Ranged;
    private float damage;
    private float attackRange;
    private float attackRate;
    private Sprite projectileImage;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        damage = enemy.Damage;
        attackRange = enemy.AttackRange;
        attackRate = enemy.AttackRate;
        projectileImage = enemy.ProjectileImage;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) <= attackRange)
        {
            if (enemy.WeaponType == Enemy.type.Melee)
            {
                if(Time.time >= nextTimeToAttack)
                {
                    nextTimeToAttack = Time.time + 1f / attackRate;
                    playerHealth.TakeDamage(damage);
                }
            } else if(enemy.WeaponType == Enemy.type.Ranged)
            {

            }
        }
    }
}
