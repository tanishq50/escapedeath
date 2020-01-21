using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rod_script : MonoBehaviour
{
    private GameObject pl;
    private GameObject s;
    public BoxCollider puzzle;
    public MeshRenderer Rod_Fall;
    public MeshRenderer Puzzle;
    private float Rod_Dist;
    private float Switch_Dist;
    public Text button_rod;
    public Text total_rods;
    public Text attach_rod;
    public GameObject Zombie;
    public float rod;
    void Start()
    {
        pl = GameObject.Find("Player");
        s = GameObject.Find("S");
    }

    void Update()
    {
        Rod_Dist = Vector3.Distance(pl.transform.position, transform.position);

        Switch_Dist = Vector3.Distance(pl.transform.position,s.transform.position);

        if (Rod_Dist < 10)
        {
            button_rod.text = "Press E to Pick Rod ";

            Debug.Log("its working");

            if (Input.GetKey(KeyCode.E))
            {
                rod = 1;
                button_rod.enabled = false;
                Rod_Fall.enabled = false;
                total_rods.text = "Total Rods : " + rod;
            }
        }

        if (Switch_Dist < 10)
        {
            
            if (rod == 1)
            {
                attach_rod.text = "Press F To Attach Rod";

                if (Input.GetKeyDown(KeyCode.F))
                {
                    puzzle.enabled = false;

                    Puzzle.enabled = false;

                    attach_rod.enabled = false;

                    Destroy(Zombie, 3f);
                }
            }
        }
        
    }
}
