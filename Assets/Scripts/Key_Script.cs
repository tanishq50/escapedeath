using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key_Script : MonoBehaviour
{
    private GameObject player;
    public MeshRenderer Key;
    private float distance;
    public float movespeed = 1.0f;
    public Text total_key;
    public Text button;
    public float key;
    

    private void Awake()
    {
        player = GameObject.Find("Player");
    }
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance < 10)
        {
            button.text = "Press E To Pickup The Key";

            if (Input.GetKey(KeyCode.E))
            {
                key = 1;
                Key.enabled = false;
                button.enabled = false;
                total_key.text = "Total Key For Doors collected : " + key;
            }
        }
    }
}
