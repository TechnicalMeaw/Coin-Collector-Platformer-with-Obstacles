using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public ParticleSystem Explode;
    public float delayTime = 3;
    private void OnTriggerEnter2D(Collider2D other){


        if (other.gameObject.CompareTag("Player")){
            Explode.Play();
            Destroy(gameObject);
            Destroy(Explode.gameObject, delayTime + 0.2f);
        }

    }
}
