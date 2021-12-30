using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject Particle_System;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            var FallPosition = gameObject.GetComponent<Transform>().position;
            var blow = Instantiate(Particle_System,new Vector3(FallPosition.x, 1, FallPosition.z), Quaternion.identity);

            Destroy(gameObject);
            
        }
    }

}
