using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotation : MonoBehaviour
{
    private Quaternion _start, _end;

    [SerializeField, Range(0.0f, 360f)] private float _angle = 90.0f;
    [SerializeField, Range(0.0f, 5.0f)] private float _speed = 2.0f;
    [SerializeField, Range(0.0f, 10.0f)] private float _startTime = 0.0f;

    void Start()
    {
        _start = Cannon(_angle);
        _end = Cannon(-_angle);
    }

    private void FixedUpdate()
    {
        _startTime += Time.deltaTime;
        transform.rotation =
            Quaternion.Lerp(_start, _end, (Mathf.Sin(_startTime * _speed + Mathf.PI / 2) + 1.0f) / 2.0f);
    }

    void ResetTimer()
    {
        _startTime = 0.0f;
    }

    Quaternion Cannon(float angle)
    {
        var cannonRotation = transform.rotation;
        var angleZ = cannonRotation.eulerAngles.z + angle;

        if (angleZ > 180)
            angleZ -= 360;
        else if (angleZ < -180)
            angleZ += 360;
        cannonRotation.eulerAngles = new Vector3(cannonRotation.eulerAngles.x, cannonRotation.eulerAngles.y, angleZ);
        return cannonRotation;
    }
}