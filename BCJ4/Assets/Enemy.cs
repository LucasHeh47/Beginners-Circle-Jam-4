using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class Enemy : ScriptableObject
{

    public enum type { Melee, Ranged, None };

    public type WeaponType;

    public float Damage;

    public float Health;

    public bool Stationary;

    public bool FollowsPlayer;

    public float FollowingRange;

    public float movementSpeed;

    public float AttackRate;

    public float AttackRange;

    public Sprite EnemyImage;

    public Sprite ProjectileImage;

}
