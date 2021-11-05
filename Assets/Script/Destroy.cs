using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
     public AudioClip clip;
    public GameObject particleObject;

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Ball"))
        {
            Instantiate(particleObject, this.transform.position, Quaternion.identity);
            Destroy(gameObject);
         AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
