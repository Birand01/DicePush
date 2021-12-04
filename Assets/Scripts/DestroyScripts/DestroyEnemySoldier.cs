using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemySoldier : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy1") || collision.gameObject.CompareTag("Enemy2") || collision.gameObject.CompareTag("Enemy3") || collision.gameObject.CompareTag("Enemy4")
            || collision.gameObject.CompareTag("Enemy5") || collision.gameObject.CompareTag("Enemy6"))
        {
            Destroy(collision.gameObject, 0.5f);
            Destroy(this.gameObject, 0.5f);
        }
    }
}
