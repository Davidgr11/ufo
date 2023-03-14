using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    float speed = 1;
    private void Start()
    {
        speed = Random.Range(0.5f, 3f);
    }
    void Update()
    {
        float rotatingSpeed = 45 * speed * Time.deltaTime;
        transform.Rotate(0, 0, rotatingSpeed);
    }
}
