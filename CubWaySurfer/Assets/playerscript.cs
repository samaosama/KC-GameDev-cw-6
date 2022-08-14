using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public Transform max;
    public Transform min;
    public float inc;
    double speed = 0.1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x+ inc, min.position.x, max.position.x), transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, min.position.x, max.position.x), transform.position.y, transform.position.z);
        }
        else if(Input.GetKeyDown(KeyCode.W));
        {
            transform.position += new Vector3(0, 0, 1*((float)speed));
        }
    }
}
