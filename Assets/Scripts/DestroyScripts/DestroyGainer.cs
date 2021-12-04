using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGainer : MonoBehaviour
{
    private float time = 2.0f;

    void Update()
    {
        time -= Time.deltaTime;
        if(time<=0)
        {
            Destroy(this.gameObject,4.0f);
        }
    }


    
}
