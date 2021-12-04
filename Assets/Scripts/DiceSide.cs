using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSide : MonoBehaviour
{

    public bool onGround;
    public bool onAddGainGround;
    public int sideValue;

    void OnTriggerStay(Collider other)
    {
        if(other.tag=="Ground")
        {
            onGround = true;
        }
        else if(other.tag=="AddGain")
        {
            onAddGainGround = true;
        }
    }

    void OnTriggerExit(Collider other) 
    {
        if(other.tag=="Ground")
        {
            onGround = false;
        }
        else if (other.tag == "AddGain")
        {
            onAddGainGround = false;
        }
    }

    public bool Onground()
    {
        return onGround;
    }
    public bool OnAddGainGround()
    {
        return onAddGainGround;
    }
}
