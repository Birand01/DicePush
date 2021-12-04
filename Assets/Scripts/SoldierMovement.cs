using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float soldierSpeed = 5.0f;
    private float force = 500.0f;
    public GameObject wall;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * soldierSpeed, Space.Self);
       
    }

   
}
