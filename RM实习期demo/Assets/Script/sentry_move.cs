
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sentry_move : MonoBehaviour
{
    public Vector3 move_right;
    public Vector3 move_left;
    public Vector3[] right_or_left;
    // Start is called before the first frame update
    void Start()
    {/*
        move_right = new Vector3(0.0f, 0.0f, 0.1f);
        move_left = new Vector3(0.0f, 0.0f, -0.1f);
        */
    }

    // Update is called once per frame
    void Update()
    {
        
        int index = Random.Range(0, 2);
        transform.position = transform.position + right_or_left[index];
        if (transform.position.z > 2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 2);
        }
        if (transform.position.z < -3.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -3.5f);
        }
        
    }
}
