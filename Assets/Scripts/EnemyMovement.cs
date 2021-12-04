using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float soldierSpeed = 5.0f;
    [SerializeField] private float Zrange = 25.5f;
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
        
            transform.Translate(Vector3.back * Time.deltaTime * soldierSpeed, Space.World);
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Soldier1") || collision.gameObject.CompareTag("Soldier2") || collision.gameObject.CompareTag("Soldier3") || collision.gameObject.CompareTag("Soldier4")
           || collision.gameObject.CompareTag("Soldier5") || collision.gameObject.CompareTag("Soldier6"))
        {
            Destroy(collision.gameObject, 0.5f);
            
        }
    }
}
