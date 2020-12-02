using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private Transform target;

    public float speed = 10f;
    private float coinSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = PlayerHealth.Instance.PlayerPosition;

        transform.Rotate(new Vector3(0, speed * 10 * Time.deltaTime, 0));
        transform.position += (target.position - transform.position).normalized * coinSpeed * Time.deltaTime;
        coinSpeed *= 1.013f;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        if (collision.gameObject.CompareTag("player"))
        {
            PlayerMoney.Instance.CollectCoin();
            Destroy(gameObject);
        }
    }

}
