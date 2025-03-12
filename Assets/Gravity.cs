using System;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Rigidbody rb;
    private const float G = 0.006674f;
    public static List<Gravity> OtherObjectsList;

    //[SerializeField] private bool planet = false;
    //[SerializeField] private int orbitSpeed = 1000;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (OtherObjectsList == null)
        {
            OtherObjectsList = new List<Gravity>();
        }
        OtherObjectsList.Add(this);
        //if (!planet)
        {
            //rb.AddForce(Vector3.left * orbitSpeed);
        }
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
