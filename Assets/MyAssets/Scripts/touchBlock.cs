using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchBlock : MonoBehaviour
{

    [SerializeField] GameObject takenCube;
    [SerializeField] GameObject playerCube;
    [SerializeField] ParticleSystem ParticleSystem;
    private int countCube = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "takenCube")
        {
            ParticleSystem.Play();
            countCube++;
            Vector3 trans = new Vector3(transform.position.x, 0, transform.position.z);
            var cubePlayer = Instantiate(playerCube, trans, Quaternion.identity);
            cubePlayer.transform.parent = transform;
            transform.Translate(transform.position.x, 1, 0);
            
            Destroy(other.gameObject);
        }
            
        
    }

    public int CountCube()
    {
       
        return countCube;
    }
}
