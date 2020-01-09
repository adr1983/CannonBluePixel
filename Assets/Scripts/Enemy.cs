using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool moveRight;
    public float moveSpeed;
    public float distance;
    float startX;

    private void Start()
    {
        startX = transform.position.x;
        transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
    }

    private void Update()
    {
        moveSpeed = ScoreManager.score + 1;
        if (transform.position.x >= startX + distance)
        {
            moveRight = false;
        }

        if (transform.position.x <= startX - distance)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            GetComponent<Rigidbody>().velocity =
                new Vector3(moveSpeed, GetComponent<Rigidbody>().velocity.y, transform.position.z);
        }

        if (!moveRight)
        {
            GetComponent<Rigidbody>().velocity =
                new Vector3(-moveSpeed, GetComponent<Rigidbody>().velocity.y, transform.position.z);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FireShot")
        {
            ScoreManager.AddPoints(1);
            Destroy(gameObject);
        }
    }
}