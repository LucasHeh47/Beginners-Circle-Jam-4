using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform MainPlayer;

    public float movementSpeed = 5f;
    public PlayerHealth health;

    private bool lookingLeft;

    // Update is called once per frame
    void Update()
    {
        if (!health.isDead)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + movementSpeed * Time.deltaTime, transform.position.z);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - movementSpeed * Time.deltaTime, transform.position.z);
            }
            if (Input.GetKey(KeyCode.A))
            {
                lookingLeft = true;
                transform.position = new Vector3(transform.position.x - movementSpeed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            if (Input.GetKey(KeyCode.D))
            {
                lookingLeft = false;
                transform.position = new Vector3(transform.position.x + movementSpeed * Time.deltaTime, transform.position.y, transform.position.z);
            }

            if (lookingLeft)
            {
                MainPlayer.eulerAngles = new Vector3(0, 180, 0);
            }
            else
            {
                MainPlayer.eulerAngles = new Vector3(0, 0, 0);
            }

        }
    }
}
