using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LimitUp" || other.tag == "Enemy")
        {
            Destroy(gameObject);
        }

        if (other.tag == "LimitDown" || other.tag == "Cannon")
        {
            ScoreManager.MinusPoints(1);
            Destroy(gameObject);
        }
    }
}