using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDİce : MonoBehaviour
{
    public bool isDieDestroyed = false;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("AddGain"))
        {
            Destroy(this.gameObject, 4.5f);
            isDieDestroyed = true;
        }
    }
}
