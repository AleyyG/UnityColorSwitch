using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
    [SerializeField]
    private float cameraSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }

    void FollowTarget()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(transform.position.x, target.transform.position.y, transform.position.z), cameraSpeed);
    }
}
