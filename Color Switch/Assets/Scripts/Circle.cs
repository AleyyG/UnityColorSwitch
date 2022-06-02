using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    private float speed;
    private int value = 0;
    private bool direction = false;
    void Start()
    {
        speed = Random.Range(20f, 100f);
        value = Random.Range(0, 1);
    }
    void Update()
    {
        CircleTurn();
    }

    void CircleTurn()
    {
        if (value == 0)
            direction = false;
        else
            direction = true;

        if (!direction)
            transform.Rotate(new Vector3(0f, 0f, speed * Time.deltaTime));
        else
            transform.Rotate(new Vector3(0f, 0f, -speed * Time.deltaTime));
    }
}
