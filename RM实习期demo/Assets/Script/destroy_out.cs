using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class destroy_out : MonoBehaviour
{
    public float zBound = 500;
    public float xBound = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zBound || transform.position.z < -zBound||
            transform.position.x > xBound || transform.position.x < -xBound)
        {
            Destroy(gameObject);
        }
    
    }
}
