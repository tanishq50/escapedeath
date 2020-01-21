using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed = 0.25f;
    public float rotspeed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveright = Vector3.right * h * speed;
        Vector3 moveforward = -Vector3.up * v * speed;
        Vector3 movement = (moveright + moveforward).normalized * speed;

        transform.Translate(movement);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 0.5f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 0.25f;
        }
       /* if (Input.GetButtonDown("S") && Input.GetButtonDown("LeftShift"))
        {
            speed = 0.25f;
        }*/
    }
}
