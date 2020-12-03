using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySummoner : MonoBehaviour
{
    public Transform player;
    public GameObject enemyObj;
    public Enemy enemy;
    public Vector3[] locations;
    private Dictionary<Vector3, float> nextSummon;
    public float spawnRate;

    // Start is called before the first frame update
    void Start()
    {

        nextSummon = new Dictionary<Vector3, float>();

        foreach (Vector3 loc in locations)
        {
            nextSummon.Add(loc, spawnRate);
        }

    }

    // Update is called once per frame
    void Update()
    {
        foreach (KeyValuePair<Vector3, float> locs in nextSummon)
        {
            if (Vector3.Distance(locs.Key, player.transform.position) <= enemy.FollowingRange * 3 && Time.time >= locs.Value)
            {
                nextSummon[locs.Key] = Time.time + 1f / spawnRate;
                GameObject enemyGO = Instantiate(enemyObj);
                enemyGO.transform.position = locs.Key;
            }
        }
    }
}
