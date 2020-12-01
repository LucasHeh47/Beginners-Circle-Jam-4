using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Weapon equipped;

    public Transform weapon;

    public static PlayerAttack Instance;

    public float damage;
    public float useRate;
    public float range;
    public bool unlocked;

    private float nextTimeToAttack;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextTimeToAttack)
        {
            if (equipped.WeaponType == Weapon.type.Melee)
            {
                weapon.eulerAngles = new Vector3(weapon.eulerAngles.x, weapon.eulerAngles.y, -90);
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (!hit) return;
                if (hit.transform.CompareTag("Enemy") && Vector3.Distance(transform.position, hit.transform.position) <= range)
                {
                    nextTimeToAttack = Time.time + 1f / useRate;
                    hit.transform.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
                }

            } else if(equipped.WeaponType == Weapon.type.Ranged)
            {

            }
        }
        if (Input.GetKeyUp("mouse 0"))
        {
            if (equipped.WeaponType == Weapon.type.Melee)
            {
                weapon.eulerAngles = new Vector3(weapon.eulerAngles.x, weapon.eulerAngles.y, 0);
            }
        }
    }
}
