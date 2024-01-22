using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody RB3D;

    public TextAsset JsonData;
    [System.Serializable]
    public class pulpit_data{
        int min_pulpit_destroy_time;
        int max_pulpit_destroy_time;
        float pulpit_spawn_time;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            RB3D.AddForce(0, 0, 30);
        }

        if (Input.GetKey("a"))
        {
            RB3D.AddForce(-30, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            RB3D.AddForce(30, 0, 0);
        }

         if (Input.GetKey("s"))
        {
            RB3D.AddForce(0, 0, -30);
        }
    }
}
