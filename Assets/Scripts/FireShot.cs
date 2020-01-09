using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FireShot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject firePrefab;

    public float fireForce = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject fire = Instantiate(firePrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = fire.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.up * fireForce, ForceMode.Impulse);
    }
}