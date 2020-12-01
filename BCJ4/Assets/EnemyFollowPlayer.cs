using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{

    public Transform player;

    public Enemy enemy;

    private bool stationary;
    private bool followsPlayer;
    private float followingRange;
    private float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        stationary = enemy.Stationary;
        followsPlayer = enemy.FollowsPlayer;
        followingRange = enemy.FollowingRange;
        movementSpeed = enemy.MovementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
         
        if (Vector3.Distance(player.transform.position, transform.position) <= followingRange && Vector3.Distance(player.transform.position, transform.position) > enemy.AttackRange)
        {
            transform.position += (player.position - transform.position).normalized * movementSpeed * Time.deltaTime;
        }
    }
}
