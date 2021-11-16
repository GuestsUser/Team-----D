using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Sparks : MonoBehaviour
{
    public ParticleSystem spark;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            spark.transform.position = other.transform.position;
            spark.Play();
        }
    }
}
