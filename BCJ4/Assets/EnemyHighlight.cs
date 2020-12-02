using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHighlight : MonoBehaviour
{

    private SpriteRenderer sprite;

    public Sprite normal;
    public Sprite highlighted;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (!hit)
        {
            sprite.sprite = normal;
            return;
        }
        if (hit.transform.CompareTag("Enemy"))
        {
            if (Vector3.Distance(PlayerAttack.Instance.transform.position, hit.transform.position) <= PlayerAttack.Instance.range)
            {
                sprite.sprite = highlighted;
            }
        }
        else
        {
            sprite.sprite = normal;
        }
    }
}
