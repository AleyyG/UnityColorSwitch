using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject item;
    [SerializeField]
    private float changeTime;
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private float distance;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        SpawnCircles();
    }
    void SpawnCircles()
    {
        if((transform.position.y - ball.transform.position.y) < distance)
        {
            if (changeTime > 0)
                changeTime--;
            else
            {
                changeTime = 250;
                transform.position = new Vector2(transform.position.x, transform.position.y + 7f);
                Instantiate(item, transform.position, Quaternion.identity);
            }
        }
    }
}
