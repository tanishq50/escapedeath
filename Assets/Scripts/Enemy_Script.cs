using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    public GameObject player;
    private float distance;
    public float movespeed = 2.0f;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }
    void Start()
    {

    }

    void Update()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);

        if (distance < 15)
        {
            transform.LookAt(player.transform);

            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, movespeed * Time.deltaTime);
        }
    }
}
    

