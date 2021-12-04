using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayerSoldier : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Soldier1") || collision.gameObject.CompareTag("Soldier2") || collision.gameObject.CompareTag("Soldier3") || collision.gameObject.CompareTag("Soldier4")
            || collision.gameObject.CompareTag("Soldier5") || collision.gameObject.CompareTag("Soldier6"))
        {
            Destroy(collision.gameObject, 0.5f);
            Destroy(this.gameObject, 0.5f);
        }
    }
}
