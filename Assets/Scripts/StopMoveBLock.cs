using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMoveBLock : MonoBehaviour
{

 
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "RedBlock")
        {
            CamShake camShake = FindObjectOfType<CamShake>();
            camShake.Shake();
            transform.parent = other.gameObject.transform;
        }
    }
}

